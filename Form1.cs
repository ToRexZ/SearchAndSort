using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SøgningOgSortering
{
    public partial class Form1 : Form
    {
        List<int> lstRandom = new List<int>();
        List<int> lstSort = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lstRandom.Clear();
            Random randomNumber = new Random();
            ClearOut();
            ClearInp();

            for (int i = 0; i < 100; i++)
            {
                lstRandom.Add(randomNumber.Next(0, 100));
            }
            lsbInput.DataSource = lstRandom;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            var stopWatch = System.Diagnostics.Stopwatch.StartNew();
            lsbOutput.DataSource = BubbleSort();
            stopWatch.Stop();
            lblTime.Text = "Time: " + stopWatch.ElapsedMilliseconds.ToString() + " ms";
        }

        public List<int> BubbleSort()
        {
            int cycles = 0;
            lstSort = lstRandom;
            for (int i = 0; i < lstSort.Count-1; i++)
            {
                for (int j = 0; j < lstSort.Count-1-i; j++)
                {
                    cycles++;
                    if (lstSort[j] > lstSort[j+1])
                    {
                        int temp = lstSort[j+1];
                        lstSort[j+1] = lstSort[j];
                        lstSort[j] = temp;
                    }
                }
            }
            lblCycles.Text = "Cycles: " + cycles.ToString();
            return lstSort;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOut();
        }

        public void ClearOut()
        {
            lstSort = null;
            lsbOutput.DataSource = null;
            lblCycles.Text = "Cycles: ";
            lblTime.Text = "Time: ";
        }

        public void ClearInp()
        {
            lsbInput.DataSource = null;
        }
    }
}
