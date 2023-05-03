using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_Adder_Final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
           
        }

        public Form2(double xsum1, double ysum1, double resultangdeg1, double vecxcomp01, double vecxcomp02, double vecxcomp03, double vecxcomp04, double vecxcomp05, double vecycomp01, double vecycomp02, double vecycomp03, double vecycomp04, double vecycomp05)
        {
            InitializeComponent();
            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = -10;
            objChart.AxisX.Maximum = 10;
            objChart.AxisX.Interval = 1;
            objChart.AxisX.Interval = 1;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = -10;
            objChart.AxisY.Maximum = 10;
            objChart.AxisY.Interval = 1;
            /*
             objChart.AxisX.ValueToPosition(vecxcomp1);
             objChart.AxisX.ValueToPosition(vecycomp1);

             foreach (vecxcomp1 && vecycomp1 && vecxcomp2 && vecycomp2 &&
                 vecxcomp3 && vecycomp3 && vecxcomp4 && vecycomp4 &&
                 vecxcomp5 && vecycomp5 && xsum && ysum in private async void enterButton_Click as List<VectorComponents>)
             {

             }

             */

            /*this.chart1.Series["Vector 1"].Points.AddXY(vecxcomp1,vecycomp1);
            this.chart1.Series["Vector 2"].Points.AddXY(vecxcomp2, vecycomp2);
            this.chart1.Series["Vector 3"].Points.AddXY(vecxcomp3, vecycomp3);
            this.chart1.Series["Vector 4"].Points.AddXY(vecxcomp4, vecycomp4);
            this.chart1.Series["Vector 5"].Points.AddXY(vecxcomp5, vecycomp5);*/
            this.chart1.Series["Resultant Vector Graph"].Points.AddXY(xsum1, ysum1);
            this.chart1.Series["Resultant Vector Graph"].Points.AddXY(0, 0);
            this.chart1.Series["OriginX"].Points.AddXY(-10, 0);
            this.chart1.Series["OriginX"].Points.AddXY(10, 0);
            this.chart1.Series["OriginY"].Points.AddXY(0, -10);
            this.chart1.Series["OriginY"].Points.AddXY(0, 10);

            this.chart1.Series["Resultant Vector Graph"].BorderWidth = 5;
            this.chart1.Series["OriginX"].BorderWidth = 5;
            this.chart1.Series["OriginY"].BorderWidth = 5;

            this.chart1.Series["Vector 1"].BorderWidth = 3;
            this.chart1.Series["Vector 2"].BorderWidth = 3;
            this.chart1.Series["Vector 3"].BorderWidth = 3;
            this.chart1.Series["Vector 4"].BorderWidth = 3;
            this.chart1.Series["Vector 5"].BorderWidth = 3;

            this.chart1.Series["OriginX"].Color = Color.Black;
            this.chart1.Series["OriginY"].Color = Color.Black;


            this.chart1.Series["Vector 1"].Points.AddXY(0, 0);
            this.chart1.Series["Vector 1"].Points.AddXY(vecxcomp01, vecycomp01);
            this.chart1.Series["Vector 2"].Points.AddXY(0, 0);
            this.chart1.Series["Vector 2"].Points.AddXY(vecxcomp02, vecycomp02);
            this.chart1.Series["Vector 3"].Points.AddXY(0, 0);
            this.chart1.Series["Vector 3"].Points.AddXY(vecxcomp03, vecycomp03);
            this.chart1.Series["Vector 4"].Points.AddXY(0, 0);
            this.chart1.Series["Vector 4"].Points.AddXY(vecxcomp04, vecycomp04);
            this.chart1.Series["Vector 5"].Points.AddXY(0, 0);
            this.chart1.Series["Vector 5"].Points.AddXY(vecxcomp05, vecycomp05);

            xcompBox.Text = xsum1.ToString();
            ycompBox.Text = ysum1.ToString();
            angleBox.Text = Math.Round(resultangdeg1, 2).ToString() + " degrees" ;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            

        }

        private void xcompBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ycompBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void angleBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

