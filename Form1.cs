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
        public int cycles = 0;

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
            if (!string.IsNullOrWhiteSpace(txtRange.Text) && txtRange.Text.Contains("-") && !string.IsNullOrWhiteSpace(txtInput.Text))
            {
                string[] subStrings = txtRange.Text.Split('-');
                for (int i = 0; i < int.Parse(txtInput.Text); i++)
                {
                    lstRandom.Add(randomNumber.Next(int.Parse(subStrings[0]), int.Parse(subStrings[1])));
                }
                lsbInput.DataSource = lstRandom;
            }
            else
            {
                MessageBox.Show("Enter numberspecifications. Range of numbers is seperated by a '-'");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cmbMethod.SelectedIndex != -1) 
            {
                var stopWatch = System.Diagnostics.Stopwatch.StartNew();
                switch (cmbMethod.SelectedIndex)
                {
                    case 0:
                        lsbOutput.DataSource = BubbleSort();
                        break;
                    case 1:
                        lsbOutput.DataSource = Divide(lstRandom);
                        lblCycles.Text = "Cycles: " + cycles.ToString();
                        cycles = 0;
                        break;
                }
                stopWatch.Stop();
                lblTime.Text = "Time: " + stopWatch.ElapsedMilliseconds.ToString() + " ms";
            }
            else
            {
                MessageBox.Show("Choose a sorting algorithm");
            }

        }

        private List<int> Divide(List <int> lstRandom)
        {
            if (lstRandom.Count <= 1) return lstRandom;

            List<int> right = new List<int>();
            List<int> left = new List<int>();

            int middle = lstRandom.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(lstRandom[i]);
            }

            for (int i = middle; i < lstRandom.Count; i++)
            {
                right.Add(lstRandom[i]);
            }

            left = Divide(left);
            right = Divide(right);

            return Merge(left,right);
        }

        public List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            
            while (left.Any() || right.Any())
            {
                if (left.Any() && right.Any())
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }

                else if (left.Any())
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }

                else if (right.Any())
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
                cycles++;
            }
            
            return result;
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
