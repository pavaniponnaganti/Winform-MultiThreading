namespace CSharp_Practice.Forms
{
    partial class ProgressBar
    {
        private   System.Windows.Forms.Button Btn_Browse;
        private   System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private   System.Windows.Forms.Button Btn_Delete;
        private  System.Windows.Forms.Button Btn_Pause;
        private   System.Windows.Forms.TextBox textBox1;
        private   System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Btn_Stop;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Browse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Pause = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Browse
            // 
            this.Btn_Browse.Location = new System.Drawing.Point(339, 28);
            this.Btn_Browse.Name = "Btn_Browse";
            this.Btn_Browse.Size = new System.Drawing.Size(91, 25);
            this.Btn_Browse.TabIndex = 1;
            this.Btn_Browse.Text = "Browse";
            this.Btn_Browse.UseVisualStyleBackColor = true;
            this.Btn_Browse.Click += new System.EventHandler(this.Btn_Browse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Delete.Location = new System.Drawing.Point(58, 57);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(81, 27);
            this.Btn_Delete.TabIndex = 3;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.Enabled = false;
            this.Btn_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Pause.Location = new System.Drawing.Point(145, 57);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(93, 27);
            this.Btn_Pause.TabIndex = 4;
            this.Btn_Pause.Text = "Pause";
            this.Btn_Pause.UseVisualStyleBackColor = true;
            this.Btn_Pause.Click += new System.EventHandler(this.Btn_Pause_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(61, 116);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(372, 15);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Files :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(58, 146);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(375, 138);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "   Edit Here";
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Enabled = false;
            this.Btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Stop.Location = new System.Drawing.Point(244, 57);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(89, 27);
            this.Btn_Stop.TabIndex = 8;
            this.Btn_Stop.Text = "Stop";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 296);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Btn_Pause);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Browse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProgressBar";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.ProgressBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
          #endregion



    }
}