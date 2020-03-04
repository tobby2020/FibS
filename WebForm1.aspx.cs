using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Fibs
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private System.DirectoryServices.DirectorySearcher directorySearcher1;


        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int an = 0;

            try
            {
                 a = int.Parse(TextBox1.Text);

                for (int i = 0; i < a; i++)

                {

                    Console.Write(foo(a).ToString() + ",");
                    an = foo(a);
                }

                Label2.Text = "第" + a + "數字為: " + Convert.ToString(an);
            }
            catch (Exception)
            {
                MessageBox.Show("请输入数字");
                Label2.Text = "請輸入數字";
                TextBox1.Text = "";
                a = 0;
            }         
            
            
        }

        static int foo(int i)
        {
             if (i == 0 || i == 1)
                return i;
              else
                return foo(i - 1) + foo(i - 2);
        }

       
    }
}
