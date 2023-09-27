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
    public partial class Cau3 : Form
    {
        public Cau3()
        {
            InitializeComponent();
        }
        
        private void btnFind_Click(object sender, EventArgs e)
        {
            String code = txtCode.Text;
            if (code != null)
            {

            }
            else {
                MessageBox.Show("Khong de trong");
            
            }
        }
    }
}
