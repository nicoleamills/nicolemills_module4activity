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
    public partial class Form1 : Form
    {
        // dorm pricing and meal plan prices in arrays
        int[] dormFees = {1500, 1600, 1800, 2500};
        int[] mealFees = {600, 1200, 1700};

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // combines the selections and adds totals depending on fee cost in array
            int totalCost = dormFees[comboBox1.SelectedIndex] + mealFees[comboBox2.SelectedIndex];
            Form2 f2 = new Form2(totalCost); 
            f2.Show();
        }
    }
}
