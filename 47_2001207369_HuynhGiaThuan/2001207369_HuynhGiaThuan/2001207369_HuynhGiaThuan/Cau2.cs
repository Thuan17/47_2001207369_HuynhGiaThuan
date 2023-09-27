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
    public partial class Cau2 : Form
    {
        public Cau2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
      

        private void Kie_Click(object sender, EventArgs e)
        {

        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
             int a, b, c;
            a = Convert.ToInt32(txta.Text);
            b = Convert.ToInt32(txtb.Text);
            c = Convert.ToInt32(txtc.Text);
            double denta = b * b - 4 * a * c;

           
          
            if(denta < 0)
            {
                lbPTVONGHIEM.Visible = true;
            }
            else if (denta == 0)
            {
                x2kep.Visible = true;
                double nghiemkep = -(b / 2 * a);
                x2kep.Text = Convert.ToString(nghiemkep);

            }
            else 
            {

                double x1 = (-b + (double)Math.Sqrt(denta)) / (2 * a);
                double x2 = (-b - (double)Math.Sqrt(denta)) / (2 * a);
                X1PB.Text = Convert.ToString(x1);
                X1PB.Text = Convert.ToString(x2);
                X1PB.Visible = true;
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            txta.Text="";
            txtb.Text = "";
            txtc.Text = "";
        }
    }
}
