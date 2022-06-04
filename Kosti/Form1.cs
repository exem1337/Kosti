using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<double[]> sas = new List<double[]>();
            sas.Add(new double[] { 1, -1, -1, -1, 6, 95, 5.5 });
            sas.Add(new double[] { 1, 1, -1, -1, 14, 95, 5.5 });
            sas.Add(new double[] { 1, -1, 1, -1, 6, 135, 5.5 });
            sas.Add(new double[] { 1, 1, 1, -1, 14, 135, 5.5 });
            sas.Add(new double[] { 1, -1, -1, 1, 6, 95, 9.5 });
            sas.Add(new double[] { 1, 1, -1, 1, 14, 95, 9.5 });
            sas.Add(new double[] { 1, -1, 1, 1, 6, 135, 9.5 });
            sas.Add(new double[] { 1, 1, 1, 1, 14, 135, 9.5 });

            foreach(double[] sass in sas)
            {
                dataGridView1.Rows.Add(sass[0],sass[1],sass[2],sass[3],sass[4],sass[5],sass[6]);
            }

            label6.Visible = false;

            List<double[]> sas1 = new List<double[]>();
            sas1.Add(new double[] { 4993940, 4991120, 4995040, 4993366.5, 4088133.5, 4994535, 4993117 });
            sas1.Add(new double[] { 4999360, 5000000, 5000040, 4999800, 145600, 4997290, 4999550 });
            sas1.Add(new double[] { 4996280, 5000120, 5000360, 4998920, 5241600, 4988260, 5000012 });
            sas1.Add(new double[] { 4983660, 4977180, 4976200, 4979013.5, 16433733, 4991015, 4980105 });
            sas1.Add(new double[] { 4990100, 4971680, 4991280, 4992166.5, 6889733, 4995377, 4992417 });
            sas1.Add(new double[] { 4999960, 4999960, 5000080, 5000000, 4800, 4998132, 5000250 });
            sas1.Add(new double[] { 4984280, 4981840, 4982340, 4982820, 1661200, 4989102, 4981728 });
            sas1.Add(new double[] { 4998400, 5000000, 5000040, 4999480, 875200, 4991857, 4998389 });

            foreach (double[] sass in sas1)
            {
                dataGridView2.Rows.Add(sass[0], sass[1], sass[2], sass[3], sass[4], sass[5], sass[6]);
            }

            dataGridView2.Visible = false;
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text += "0.465017914772034";
            label6.Visible = true;
            dataGridView2.Visible = true;
            groupBox1.Visible = true;
        }
    }
}
