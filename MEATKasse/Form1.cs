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
            // multiplies values from turnover
            try
            {
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

                udTotal.Text = Convert.ToString(int.Parse(f1.Text)
                                   + int.Parse(f2.Text) + int.Parse(f3.Text)
                                   + int.Parse(f4.Text) + int.Parse(f5.Text)
                                   + int.Parse(f6.Text) + int.Parse(f7.Text));
            }
            catch (Exception)
            {
                ErrorLabel.Text = "Der skete en fejl i faktura, alle felterne skal have en værdi. 0 er default";
            }
        }
    }
}
