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
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lstRandom.Clear();
            Random randomNumber = new Random();
            lsbInput.DataSource = null;

            for (int i = 0; i < 100; i++)
            {
                lstRandom.Add(randomNumber.Next(0, 100));
            }
            lsbInput.DataSource = lstRandom;
            //hejsa dette er en tilfælidg kommentar
        }
    }
}
