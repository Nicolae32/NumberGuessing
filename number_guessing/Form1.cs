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
            int n;
        public Form1()
        {
            
            

            
            InitializeComponent();
            generate();

        }
        private void generate()
        {
            n = number.Next(1,10);

        }
       
        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Verify();
            
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Verify()
        {
            
           
            int num = Convert.ToInt32(txt.Text);

            if(num == n)
            {
                MessageBox.Show("Felicitari ai ghicit numarul");
                generate();
                txt.Text = "";

            }
            else if(num>n)
            {

                MessageBox.Show("Mai mic");
                txt.Text = "";

            }
           else if(num<n)
            {
                MessageBox.Show("Mai mare");
                txt.Text = "";

            }
           

        }
        
    } 
}
