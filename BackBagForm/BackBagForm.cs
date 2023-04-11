using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class BackBagForm : Form
    {
        public BackBagForm()
        {
            InitializeComponent();
        }

        private void BackBagForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberOfItems = int.Parse(numberOfItemsInput.Text);
            int seedNumber = int.Parse(seedInput.Text);
            int fullWeight = int.Parse(fullWeightInput.Text);
            BackBag backBag = new BackBag(numberOfItems, seedNumber, fullWeight);
            string resultString = backBag.FindBestResult();
            finalFullValue.Text = backBag.GetFullValue().ToString();
            finalFullWeight.Text = backBag.GetFullWeight().ToString();
            result.Text = resultString;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
