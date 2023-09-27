using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001207369_HuynhGiaThuan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

           
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int x;
        public static bool SNT (int n)
        {
            for (int i = n; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        private void btnKtra_Click(object sender, EventArgs e)
        {

            x = Convert.ToInt32(textBox1.Text);
            label4.Text = textBox1.Text;
            if (x != null)
            {
                if (SNT(x))
                {
                    label2.Text = " so nguyen to";
                    lSoNhap.Text = textBox1.Text;
                    lSoNhap.Visible = true;

                    for (int i = 1; i <= x; i++)
                    {
                        
                        if (SNT(i))
                            lKhoan.Text =Convert.ToString(i);
                        lKhoan.Visible = true;
                    }


                }
                else
                {
                    label2.Text = "day la so nguyen to";
                }

            }
            else {
                MessageBox.Show("Khong de trong");
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
