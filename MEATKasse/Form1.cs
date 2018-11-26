using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEATKasse
{
    public partial class Meat : Form
    {
        public Meat()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // udregn difference
            try
            {
                lblplus.Text = "";
                ErrorLabel.Text = "";
                kassedif.Text = Convert.ToString(int.Parse(kassebehold.Text)
                    - int.Parse(kassebeholdmor.Text));
                if (Convert.ToInt32(kassedif.Text) > 0)
                {
                    lblplus.Text = "+";
                }
            }
            catch (Exception)
            {
                ErrorLabel.Text = "Der skete en fejl i omsætning, alle felterne skal have en værdi. 0 er default";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }


        private void button2_Click(object sender, EventArgs e)
        {
          
            try
            {
                ErrorLabel.Text = "";
                turnoverTotal.Text = Convert.ToString(int.Parse(turnoverDay1.Text) 
                    + int.Parse(turnoverDay2.Text) + int.Parse(turnoverDay3.Text) 
                    + int.Parse(turnoverDay4.Text) + int.Parse(turnoverDay5.Text) 
                    + int.Parse(turnoverDay6.Text) + int.Parse(turnoverDay7.Text));
            }
            catch (Exception)
            {
                ErrorLabel.Text = "Der skete en fejl i Omsætning, alle felterne skal have en værdi. 0 er default"; 
            }
          
        }

        private void turnoverDay1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void turnoverDay2_TextChanged(object sender, EventArgs e)
        {

        }

        private void turnoverDay3_TextChanged(object sender, EventArgs e)
        {

        }

        private void turnoverDay4_TextChanged(object sender, EventArgs e)
        {

        }

        private void turnoverDay5_TextChanged(object sender, EventArgs e)
        {

        }

        private void turnoverDay6_TextChanged(object sender, EventArgs e)
        {

        }

        private void turnoverDay7_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorLabel.Text = "";
                dkTotal.Text = Convert.ToString(int.Parse(dk1.Text) + 
                    int.Parse(dk2.Text) + int.Parse(dk3.Text) + 
                    int.Parse(dk4.Text) + int.Parse(dk5.Text) + 
                    int.Parse(dk6.Text) + int.Parse(dk7.Text) + 
                    int.Parse(dk8.Text) + int.Parse(dk9.Text) + 
                    int.Parse(dk10.Text) + int.Parse(dk11.Text) + 
                    int.Parse(dk12.Text) + int.Parse(dk13.Text) + 
                    int.Parse(dk14.Text));
            }
            catch (Exception)
            {

                ErrorLabel.Text = "Der skete en fejl i Dankort, alle felterne skal have en værdi. 0 er default";
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorLabel.Text = "";
                gebyrTotal.Text = Convert.ToString(int.Parse(g1.Text)
                                   + int.Parse(g2.Text) + int.Parse(g3.Text)
                                   + int.Parse(g4.Text) + int.Parse(g5.Text)
                                   + int.Parse(g6.Text) + int.Parse(g7.Text));
            }
            catch (Exception)
            {
                ErrorLabel.Text = "Der skete en fejl i gebyr, alle felterne skal have en værdi. 0 er default";
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                
                udTotal.Text = Convert.ToString(int.Parse(u1.Text)
                                   + int.Parse(u2.Text) + int.Parse(u3.Text)
                                   + int.Parse(u4.Text) + int.Parse(u5.Text)
                                   + int.Parse(u6.Text) + int.Parse(u7.Text));
            }
            catch (Exception)
            {
                ErrorLabel.Text = "Der skete en fejl i udlæg fra kassen, alle felterne skal have en værdi. 0 er default";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorLabel.Text = "";
                fakturaTotal.Text = Convert.ToString(int.Parse(f1.Text)
                                   + int.Parse(f2.Text) + int.Parse(f3.Text)
                                   + int.Parse(f4.Text) + int.Parse(f5.Text)
                                   + int.Parse(f6.Text) + int.Parse(f7.Text));
            }
            catch (Exception)
            {
                ErrorLabel.Text = "Der skete en fejl i faktura, alle felterne skal have en værdi. 0 er default";
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorLabel.Text = "";
                sbTotal.Text = Convert.ToString(int.Parse(s1.Text) +
                    int.Parse(s2.Text) + int.Parse(s3.Text) +
                    int.Parse(s4.Text) + int.Parse(s5.Text) +
                    int.Parse(s6.Text) + int.Parse(s7.Text) +
                    int.Parse(s8.Text) + int.Parse(s9.Text) +
                    int.Parse(s10.Text) + int.Parse(s11.Text) +
                    int.Parse(s12.Text) + int.Parse(s13.Text) +
                    int.Parse(s14.Text));
            }
            catch (Exception)
            {

                ErrorLabel.Text = "Der skete en fejl i smartbox, alle felterne skal have en værdi. 0 er default";
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
     
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorLabel.Text = "";
                tilbankTotal.Text = Convert.ToString(int.Parse(turnoverTotal.Text) -
                    int.Parse(dkTotal.Text) + int.Parse(gebyrTotal.Text) -
                    int.Parse(sbTotal.Text) - int.Parse(udTotal.Text) -
                    int.Parse(fakturaTotal.Text));
            }
            catch (Exception)
            {
                ErrorLabel.Text = "Der skete en fejl, alle total felterne skal have en værdi. 0 er default";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorLabel.Text = "";
                double n = UltimateRoundingFunction((int.Parse(tilbankTotal.Text)), 50, 0.5);
           //  double n = Math.Floor((int.Parse(tilbankTotal.Text)) / 50.0) * 50.0;
            bankTotal.Text = Convert.ToString(n);

            }
            catch (Exception)
            {
                ErrorLabel.Text = "Intet at afrunde.";
            }
        }

        double UltimateRoundingFunction(double amountToRound, double nearstOf, double fairness)
        {
            return Math.Floor(amountToRound / nearstOf + fairness) * nearstOf;
        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorLabel.Text = "";
                kassebehold.Text = Convert.ToString(int.Parse(totalKasse.Text) -
                    int.Parse(totalTips.Text) - int.Parse(bankTotal.Text));
            }
            catch (Exception)
            {
                ErrorLabel.Text = "Der skete en fejl, alle felterne skal have en  tal værdi. 0 er default";
            }
        }
    }
}
