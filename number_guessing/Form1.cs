using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace number_guessing
{
    public partial class Form1 : Form
    {
       
           Random number = new Random();
            int n = number.Next(1, 10);
        public Form1()
        {
            
            


            InitializeComponent();
        }
       
        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Verify(txt2.Text);
            
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Verify(string f)
        {
            
           
            int num = int.Parse(f);

            if(n == num)
            {
                txt.Text = "Felicitari ai ghicit numarul!";

            }
            if(n>num)
            {
                txt.Text = "Mai mare!";
               

            }
            if(n>num)
            {
                txt.Text = "Mai mic!";

            }
           

        }
        
    } 
}
