/* Nathan Mayer         EGR111            Professor Brownlowe
 * 
 * This program will take 5 inputed vectors and csum them by means of:
 * 
 * - Converting inputed angle to radians via : (inputed angle)(Pi/180) = (inputed angle in radians)
 * - Sepparating inputed values into their x and y components using cos and sin
 * - Summing the x and y components
 * - Converting the summed x and y's back to one angle in via : arctan(ysum/xsum) = (resultant angle in radians)
 * - Converting resultant radians back to degrees via : 180/pi
 * - Converting x and y sums to a magnitude via : sqrt(x^2 + y^2) 
 * 
 * The program will then output the resultant angle to the resultant angle box and the resultant magnitude to the resultant magnitude box
 * The program will also contain error traps:
 * - 0 inputted magnitude
 * - Negative inputted magnitude
 * - Negative inputted angle
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.IO;

namespace Vector_Adder_Final
{
    public partial class Form1 : Form
    {
        // Declare public variables
        double vecxcomp1 = 0;
        double vecycomp1 = 0;
        double vecxcomp2 = 0;
        double vecycomp2 = 0;
        double vecxcomp3 = 0;
        double vecycomp3 = 0;
        double vecxcomp4 = 0;
        double vecycomp4 = 0;
        double vecxcomp5 = 0;
        double vecycomp5 = 0;

        double vecnum = 1;

        double resultmag;
        double resultangrad;
        double resultangdeg;
        double xsum = 0;
        double ysum = 0;
        double vecmag = 0;
        double vecang = 0;

        double radianconverter = Math.PI / 180;
        double radianundo = 180 / Math.PI;
        double hidegraph = 0;
        

        
              
            
    public Form1()
        {
            InitializeComponent();
            vecnumBox.Text = vecnum.ToString();     //Display initial vector number
            chart1.Visible = false;
        }

        private void vecmagBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vecangBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vecnumBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultmagBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultangBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void enterButton_Click(object sender, EventArgs e)
        {
            // Play sound on button press
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\media\Windows Menu Command.wav");
            player.Play();

            
            // Error trap for null values in mag/ang boxes
            try
            {
                double doitfuckinwork = Convert.ToDouble(vecmagBox.Text);
                double itdontfuckinwork = Convert.ToDouble(vecangBox.Text);
            }
            catch
            {
                MessageBox.Show("You are missing one or more values");
                vecmagBox.Text = "Error";
                vecangBox.Text = "Error";
                await Task.Delay(3000);
                vecmagBox.Clear();
                vecangBox.Clear();
                return;
            }

            double vecmag = Convert.ToDouble(vecmagBox.Text);
            double vecang = Convert.ToDouble(vecangBox.Text);

            // Error trap for negative inputted values (or 0 magnitude)
            if (vecmag <= 0 || vecang < 0)
            {
                MessageBox.Show("You entered a value that is less than or equal to zero");
                vecmagBox.Text = "Error";
                vecangBox.Text = "Error";
                vecmagBox.Clear();
                vecangBox.Clear();
                await Task.Delay(3000);
                return;
            }

            vecnum = vecnum + 1;
            vecnumBox.Text = vecnum.ToString();


            // The program knows which variables to use based on the number of inputted vectors
            // Based on the vector number, the program assigns values to each one of the 5 sets of x and y comp. variables

            if (vecnum == 2)
            {
                vecxcomp1 = vecmag * Math.Cos(vecang * radianconverter);
                vecycomp1 = vecmag * Math.Sin(vecang * radianconverter);
                vecmagBox.Clear();
                vecangBox.Clear();
            }
            else
            {
                if (vecnum == 3)
                {
                    vecxcomp2 = vecmag * Math.Cos(vecang * radianconverter);
                    vecycomp2 = vecmag * Math.Sin(vecang * radianconverter);
                    vecmagBox.Clear();
                    vecangBox.Clear();
                }

                else
                {
                    if (vecnum == 4)
                    {
                        vecxcomp3 = vecmag * Math.Cos(vecang * radianconverter);
                        vecycomp3 = vecmag * Math.Sin(vecang * radianconverter);
                        vecmagBox.Clear();
                        vecangBox.Clear();
                    }
                    else
                    {
                        if (vecnum == 5)
                        {
                            vecxcomp4 = vecmag * Math.Cos(vecang * radianconverter);
                            vecycomp4 = vecmag * Math.Sin(vecang * radianconverter);
                            vecmagBox.Clear();
                            vecangBox.Clear();
                        }
                        else
                        {
                            if (vecnum == 6)
                            {
                                vecxcomp5 = vecmag * Math.Cos(vecang * radianconverter);
                                vecycomp5 = vecmag * Math.Sin(vecang * radianconverter);
                                vecmagBox.Clear();
                                vecangBox.Clear();
                                vecnumBox.Text = "5 Vectors entered.";
                            }
                        
                        else {

                                vecnumBox.Text = "5 Vectors entered.";
                                MessageBox.Show("You have entered too many vectors for the program to handle. System exiting!");
                                System.Environment.Exit(0);
                        }

                        }
                    }
                }

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear button code sets every value back to its initial condition
            
            vecmagBox.Clear();
            vecangBox.Clear();
            vecnumBox.Text = "1";
            resultmagBox.Clear();
            resultangBox.Clear();
            vecnum = 1;
            vecxcomp1 = 0;
            vecycomp1 = 0;
            vecxcomp2 = 0;
            vecycomp2 = 0;
            vecxcomp3 = 0;
            vecycomp3 = 0;
            vecxcomp4 = 0;
            vecycomp4 = 0;
            vecxcomp5 = 0;
            vecycomp5 = 0;
            xsum = 0;
            ysum = 0;
            vecmag = 0;
            vecang = 0;

            // Play sound on button press
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\media\Windows Message Nudge.wav");
            player.Play();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            // Play sound on button press
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\media\Ring02.wav");
            player.Play();

            // Sum all x and y components 
            xsum = (vecxcomp1) + (vecxcomp2) + (vecxcomp3) + (vecxcomp4) + (vecxcomp5);
            ysum = (vecycomp1) + (vecycomp2) + (vecycomp3) + (vecycomp4) + (vecycomp5);

            
            // Calculate each result magnitude and angle based on where the x and y components land on the cartesian plane
            // Some of the formulas contain addition, which accounts for a resultant angle out of 360 degrees

            if(xsum > 0 && ysum >= 0)                                            // +x and +y result
            {
                resultangrad = Math.Atan(ysum / xsum);
                resultangdeg = resultangrad * radianundo;
                resultangBox.Text = resultangdeg.ToString();

                resultmag = Math.Sqrt(Math.Pow(xsum, 2) + Math.Pow(ysum, 2));
            }

            if (xsum < 0 && ysum <= 0)                                           // -x and -y result
            {
                resultangrad = Math.Atan(ysum / xsum) + Math.PI;
                resultangdeg = resultangrad * radianundo;
                resultangBox.Text = resultangdeg.ToString();

                resultmag = Math.Sqrt(Math.Pow(xsum, 2) + Math.Pow(ysum, 2));
            }

            if (xsum > 0 && ysum < 0)                                            // +x and -y result
            {
                resultangrad = Math.Atan(ysum / xsum) + 2 * Math.PI;
                resultangdeg = resultangrad * radianundo;
                resultangBox.Text = resultangdeg.ToString();

                resultmag = Math.Sqrt(Math.Pow(xsum, 2) + Math.Pow(ysum, 2));
            }

            if (xsum < 0 && ysum > 0)                                            // -x and +y result
            {
                resultangrad = Math.Atan(ysum / xsum) + Math.PI;
                resultangdeg = resultangrad * radianundo;
                resultangBox.Text = resultangdeg.ToString();

                resultmag = Math.Sqrt(Math.Pow(xsum, 2) + Math.Pow(ysum, 2));
            }

            if (xsum == 0 && ysum > 0)                                                        // x = 0 and +y result
            {
                resultangdeg = 90;

                resultmag = ysum;
            }

            if (xsum == 0 && ysum < 0)                                                        // x = 0 and -y result
            {
                resultangdeg = 270;

                resultmag = Math.Abs(ysum);
            }

            if (xsum + ysum <= 0.00001 && xsum +ysum >= -0.00001)                                                        // x = 0 and y = 0 result
            {
                resultangdeg = 0;

                resultmag = 0;
            }

            if (ysum == 0 && xsum < 0)                                                        // y = 0 and -x result
            {
                resultangdeg = 180;

                resultmag = Math.Abs(xsum);
            }

            if (ysum == 0 && xsum >= 0)                                                        // y = 0 and +x result
            {
                resultangdeg = 0;

                resultmag = xsum;
            }

            // Test code to observe results and verify
            //resultangBox.Text = vecnum.ToString();*/
            resultangBox.Text = xsum.ToString();
            resultmagBox.Text = ysum.ToString();

            //resultangBox.Text = xsum.ToString();
            //resultmagBox.Text = ysum.ToString();

            // Output resultant magnitude and angle

            resultangBox.Text = Math.Round(resultangdeg, 4).ToString() + " degrees";
            resultmagBox.Text = Math.Round(resultmag, 4).ToString() + " units";
            
        }

        private void quitButton_Click(object sender, EventArgs e)
        {

            // Close program on button press
            // Play sound on button press
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\media\Windows Notify Email.wav");
            player.Play();
            Thread.Sleep(2000);
            System.Environment.Exit(0);
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            computeButton_Click(sender, e);
            double vecxcomp01 = Math.Round(vecxcomp1, 3);
            double vecycomp01 = Math.Round(vecycomp1, 3);
            double vecxcomp02 = Math.Round(vecxcomp2, 3);
            double vecycomp02 = Math.Round(vecycomp2, 3);
            double vecxcomp03 = Math.Round(vecxcomp3, 3);
            double vecycomp03 = Math.Round(vecycomp3, 3);
            double vecxcomp04 = Math.Round(vecxcomp4, 3);
            double vecycomp04 = Math.Round(vecycomp4, 3);
            double vecxcomp05 = Math.Round(vecxcomp5, 3);
            double vecycomp05 = Math.Round(vecycomp5, 3);
            double xsum1 = Math.Round(xsum, 3);
            double ysum1 = Math.Round(ysum, 3);
            double resultangdeg1 = resultangdeg;
            Form2 newFrm = new Form2(xsum1, ysum1, resultangdeg1, vecxcomp01, vecxcomp02, vecxcomp03, vecxcomp04, vecxcomp05, vecycomp01, vecycomp02, vecycomp03, vecycomp04, vecycomp05);
            newFrm.Show();
                
        }
        }
    }

