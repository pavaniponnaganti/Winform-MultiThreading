using System;
using System.Threading; 
using System.IO; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSharp_Practice.Forms
{
    public partial class ProgressBar : Form
    {

        #region Private Area
        public List<string> files;
        public Thread thread = null;
        public static int TotalSize = 0;
        public static int CurrentSize = 0;
        public static string Path = "";
        private delegate void ShowMessageDelegateCallBack();
        public delegate void setRichBoxTextCallBack();
        //public delegate void setRichBoxTextCallBackByText(string text);
        #endregion

        #region public ProgressBar()
        public ProgressBar()
        {
            InitializeComponent();
        }
        #endregion

        #region private void Btn_Browse_Click(object sender, EventArgs e)
        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            label2.Text = String.Empty;
            Btn_Delete.Enabled = true;
            Btn_Pause.Text = "Pause";
            Btn_Pause.Enabled = false;
            Btn_Stop.Enabled = false;
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
            if (textBox1.Text.Length >= 248)
                throw new Exception("Directory illigal");
        }
        #endregion

        #region private void Btn_Delete_Click(object sender, EventArgs e)
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Please specify a path");
                return;
            }
            Btn_Pause.Enabled = true;
            Btn_Stop.Enabled = true;
            Btn_Delete.Enabled = false;
            InitializeMyObjects();
            GetAllFiles();   //this saves all files in the directory with their path to files generics.

            thread = new Thread(delegate()
            {
                //Part 1      //Divide thread into several  parts .Numerous code you want to execute you can implement as below:

                //for (int i = 0; i < files.Count; Interlocked.Increment(ref i)) 
                for (int i = 0; i < files.Count; i++)
                {
                    this.BeginInvoke((ThreadStart)delegate()
                    {
                        this.Text = files[i].ToString().Substring(files[i].LastIndexOf('\\') + 1);
                        this.label2.Text = Convert.ToString(i + 1);
                        progressBar1.PerformStep();
                    });
                    Thread.Sleep(6);
                }
                //Part 2
                this.BeginInvoke((ThreadStart)delegate()    
                {
                    this.Btn_Pause.Enabled = false;
                    this.Btn_Stop.Enabled = false;
                });
                //Part 3
                this.BeginInvoke((ThreadStart)delegate()
                {
                    this.ShowMessageDelegate("100% (Process Compeletd)");
                });
            });//.Start();
            thread.Start();
            
            //Implement the other codes here for performing them at the time the progressbar is being processes.
        }

        #endregion

        #region private void Btn_Pause_Click(object sender, EventArgs e)
        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            if (thread == null || !thread.IsAlive)
            {
                MessageBox.Show("Process has not been started or just being already finished");
                return;
            }
            if (Btn_Pause.Text.ToUpper() == "pause".ToUpper())
            {
                Btn_Pause.Text = "Continue";
                thread.Suspend();
            }
            else
            {
                Btn_Pause.Text = "Pause";
                thread.Resume();
            }
        }
        #endregion

        #region private void Btn_Stop_Click(object sender, EventArgs e)
        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            if (thread.IsAlive)
            {
                if (thread.ThreadState == ThreadState.Suspended)
                {
                    thread.Resume();
                }

                thread.Abort();
                label2.Text = "THIS PROCESS OF DELETING HAS BEEN ABORTED";
                label2.Refresh();

                new Thread(delegate()
                {
                    int val = this.progressBar1.Value;
                    for (int i = 1; i <= val; Interlocked.Increment(ref i))
                    {
                        progressBar1.Increment(-1);
                        this.BeginInvoke((ThreadStart)delegate()
                        {
                            progressBar1.Increment(-1);
                        });
                        Thread.Sleep(10);
                    }
                }).Start();
            }
            else
                label2.Text = "PROCESS HAS BEEN ABORETD";

            Btn_Pause.Enabled = false;
            Btn_Delete.Enabled = false;
            Btn_Pause.Text = "Pause";
            Btn_Stop.Enabled = false;
            return;
        }
        #endregion

        #region static void  InitializeMyObjects()
        public void InitializeMyObjects()
        {
            try
            {
                files = new List<string>();
                Path = textBox1.Text;
                progressBar1.Value = 0;
                progressBar1.Maximum = 0;
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region public void GetAllFiles(string path)
        public void GetAllFiles(string path)
        {
            foreach (string f in Directory.GetFiles(path))
            {
                files.Add(f);
            }
            foreach (string directory in Directory.GetDirectories(path))
            {
                GetAllFiles(directory);
            }
            progressBar1.Maximum = files.Count;
            progressBar1.Step = 1;
            return;
        }
        #endregion

        #region public void GetAllFiles()
        public void GetAllFiles()
        {
            GetAllFiles(Path);
        }
        #endregion

        #region public  void Delete(string path)
        public void Delete(string path)
        {
            try
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    string name = file.Substring(file.LastIndexOf('\\') + 1);
                    this.Text = name;
                    //progressBar1.PerformStep();
                    CurrentSize = progressBar1.Value;
                    System.Threading.Thread.Sleep(9);
                }

                foreach (string directory in Directory.GetDirectories(path))
                {
                    Delete(directory);
                }
            }
            catch (Exception ioex)
            {
                MessageBox.Show(ioex.ToString());
            }

            return;
        }
        #endregion

        #region public void Delete()
        public void Delete()
        {
            InitializeMyObjects();
            GetAllFiles(Path);
            //Delete(Path);
            return;
        }
        #endregion

        private void ShowMessageDelegate()
        {
            //MessageBox.Show("Deleting Completed"); 
            this.Text = "Deleting Completed";
            return;
        }

        private void ShowMessageDelegate(string text)
        {
            //MessageBox.Show("Deleting Completed"); 
            this.Text = text;
            return;
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {

        }
    }
}

