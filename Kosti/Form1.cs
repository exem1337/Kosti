using CodenameShctangencircle;
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
            #region
            List<double[]> sas = new List<double[]>();
            sas.Add(new double[] { 1, -1, -1, -1, 6, 95, 5.5 });
            sas.Add(new double[] { 1, 1, -1, -1, 14, 95, 5.5 });
            sas.Add(new double[] { 1, -1, 1, -1, 6, 135, 5.5 });
            sas.Add(new double[] { 1, 1, 1, -1, 14, 135, 5.5 });
            sas.Add(new double[] { 1, -1, -1, 1, 6, 95, 9.5 });
            sas.Add(new double[] { 1, 1, -1, 1, 14, 95, 9.5 });
            sas.Add(new double[] { 1, -1, 1, 1, 6, 135, 9.5 });
            sas.Add(new double[] { 1, 1, 1, 1, 14, 135, 9.5 });

            foreach (double[] sass in sas)
            {
                dataGridView1.Rows.Add(sass[0], sass[1], sass[2], sass[3], sass[4], sass[5], sass[6]);
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
        #endregion
    }

    namespace CodenameShctangencircle
    {
        public class Cycles
        {
            public List<string> Combinations = new List<string>();
            public List<string> Combination2 = new List<string>();

            int Count = 1;
            public int o, o1, o2, o3, o4, p1, p2, p3, p4, p5, GridCount;

            void k1Cycle(int n)
            {
                double n1;

                for (int k1 = 100; k1 <= 200; k1++)
                {
                    n1 = k1 - _a11 / _koef1 + 1;
                    //if (n1 > 0 && n1 % 1 == 0)
                    //{
                    k2Cycle(n, k1, n1);
                    //} 
                }
            }

            void k2Cycle(int n, int k1, double n1)
            {
                double n2;
                for (int k2 = 12; k2 <= 62; k2++)
                {
                    n2 = Convert.ToDouble(k2 - k1 * _koef1 / _koef2);
                    if (n2 > 0 && n2 % 1 == 0)
                    {
                        k3Cycle(n, k1, k2, n1, n2);
                    }
                }
            }

            void k3Cycle(int n, int k1, int k2, double n1, double n2)
            {
                double n3;
                for (int k3 = 7; k3 <= 57; k3++)
                {
                    n3 = Convert.ToDouble(k3 - k2 * _koef2 / _koef3);
                    if (n3 > 0 && n3 % 1 == 0)
                    {
                        k4Cycle(n, k1, k2, k3, n1, n2, n3);
                    }
                }
            }

            void k4Cycle(int n, int k1, int k2, int k3, double n1, double n2, double n3)
            {
                double n4;
                for (int k4 = 2; k4 <= 52; k4++)
                {
                    n4 = Convert.ToDouble(k4 - k3 * _koef3 / _koef4);
                    if (n4 > 0 && n4 % 1 == 0)
                    {
                        k5Cycle(n, k1, k2, k3, k4, n1, n2, n3, n4);
                    }
                }
            }

            void k5Cycle(int n, int k1, int k2, int k3, int k4, double n1, double n2, double n3, double n4)
            {
                double n5;
                for (int k5 = 1; k5 <= 10; k5++)
                {
                    n5 = Convert.ToDouble(k5 - k4 * _koef4 / _koef5);
                    if (n5 > 0 && n5 % 1 == 0)
                    {
                        if (n == n1 + n2 + n3 + n4 + n5) //условие суммы
                        {
                            this.gotResult = true;
                            Combinations.Add($"{n},{k1},{k2},{k3},{k4},{k5},{n1},{n2},{n3},{n4},{n5};"); //добавление результата в базу удачных комбинаций
                            Combination2.Add($"({Count}) {n},{k1},{k2},{k3},{k4},{k5},{n1},{n2},{n3},{n4},{n5};");
                            Database.o.Add(n); Database.p1.Add(n1);
                            Database.o1.Add(k1); Database.p2.Add(n2);
                            Database.o2.Add(k2); Database.p3.Add(n3);
                            Database.o3.Add(k3); Database.p4.Add(n4);
                            Database.o4.Add(k4); Database.p5.Add(n5);
                            Database.o5.Add(k5); Database.GridCount.Add(Count);
                            Count++;
                        }
                    }
                }
            }

            private bool gotResult = false;

            public void nCycle(ref List<string> VisualOutput, ref List<string> Output, int higher, int lower, double koef1, double koef2, double koef3, double koef4, double koef5, double a11)
            {
                _koef1 = koef1; _koef2 = koef2; _koef3 = koef3; _koef4 = koef4; _koef5 = koef5; _a11 = a11;
                for (int n = higher; n <= lower; n++)
                {
                    k1Cycle(n);
                }
                if (!gotResult) Database.noResultList.Add((_koef1 + " " + koef2 + " " + koef3 + " " + koef4 + " " + koef5).ToString());
                System.IO.File.WriteAllLines("file.txt", Combinations);
                Output = Combinations;
                VisualOutput = Combination2;
            }

            double _koef1, _koef2, _koef3, _koef4, _koef5, _a11;

        }
    }

}

