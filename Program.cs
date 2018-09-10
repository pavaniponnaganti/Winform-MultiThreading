using System;
using System.IO; 
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;   

namespace CSharp_Practice 
{
    class Program 
    {
        public enum NUMBER
        { 
         YEK    =1,
         DO     =2,
         SEH    =3,
         CHAHAR =4
        }

        [STAThread]
        static void Main(string[] args)
        {
            //try
            //{
            //    Forms.WorkingWithDelegateForm.Names[] names;
            //    names = new CSharp_Practice.Forms.WorkingWithDelegateForm.Names[] 
            //    {
            //        new Forms.WorkingWithDelegateForm.Names("ALI","Musavi"),
            //        new Forms.WorkingWithDelegateForm.Names("POUYA","Musavi"),
            //        new Forms.WorkingWithDelegateForm.Names("RAHIM","Shaheri"),
            //        new Forms.WorkingWithDelegateForm.Names("AMIR","HajAghaei"),
            //        new Forms.WorkingWithDelegateForm.Names("GHASEM","Musavi"),
            //        new Forms.WorkingWithDelegateForm.Names("AHMAD","Musavi"),
            //    };
           //Application.Run(new Forms.WorkingWithDelegateForm(names));
            Application.Run(new Forms.ProgressBar());
            Application.Exit();
            }

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());  
            //}
        //}

        static void dg_OnDecreaseEvent(int var)
        {
            if(var==0)
             throw new Exception("Value Should not be less than ZERO");
         return;
        }

        static void dg_OnChangeEvent(int var)
        {
            if(var>2)
             throw new Exception("Value should not increment more than 2");
         return;
        }
    }

    #region Class1
    class Class1
    {
        public int value = 0;
        
        static string Name()  //static method
        {
            return "name";
        }

        void WriteSth(string message)   //non-static method
        {
            Console.WriteLine("message is {0}",message);
            Console.Read(); 
        }

        public void DoSth(Class1 c)
        {
            string Default_Name = c.NameMe;//for restoring where we need 
            c.NameMe = "naming nothing.....";
            return;
        }
        
        public string NameMe = "Before";
    }
    #endregion
}










