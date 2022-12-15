using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MathGraf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xmax = double.Parse(textBoxX.Text);
            double constA = double.Parse(textBoxConstA.Text);
            double step = double.Parse(textBoxStep.Text.Replace(".", ","));

            this.chart1.Series[0].Points.Clear();
            for (double x = 0; x<=xmax; x+=step)
            {
                double y = Math.Sqrt(0.5 * x * constA);
                this.chart1.Series[0].Points.AddXY(x, y);
            }
        }
    }
}
