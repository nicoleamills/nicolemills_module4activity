using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nicolemills_module4activity
{
    public partial class Form2 : Form
    {
        int totalCost;
        public Form2(int totalCost)
        {
            this.totalCost = totalCost;
            InitializeComponent();
            label1.Text = totalCost.ToString("C");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
