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
       
        //public double denta(){
        //    int a,b,c;
        //    a = Convert.ToInt32(txta.Text);
        //    b = Convert.ToInt32(txta.Text);
        //    c = Convert.ToInt32(txta.Text);
        //    return(b*b)-4*a*c;
        //}
        //public double nghiemkep()
        //{
        //    int a, b, c;
        //    a = Convert.ToInt32(txta.Text);
        //    b = Convert.ToInt32(txta.Text);
        //    c = Convert.ToInt32(txta.Text);
        //    return -(b/2*a);
        //}

        private void Kie_Click(object sender, EventArgs e)
        {

        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
             int a, b, c;
            a = Convert.ToInt32(txta.Text);
            b = Convert.ToInt32(txta.Text);
            c = Convert.ToInt32(txta.Text);
            double denta = b * b - 4 * a * c;

           
            label9.Text = Convert.ToString(denta);
            if(denta < 0)
            {
                lbPTVONGHIEM.Visible = true;
            }
            else if (denta == 0)
            {
                double nghiemkep = -(b / 2 * a);
                x2kep.Text = Convert.ToString(nghiemkep);

            }
            else 
            {
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
