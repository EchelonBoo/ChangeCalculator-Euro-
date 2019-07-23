using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            decimal twoE = (decimal)2.0;
            decimal oneE = (decimal)1.0;
            decimal fiftyC = (decimal)0.5;
            decimal twentyC = (decimal)0.2;
            decimal tenC = (decimal)0.1;
            decimal fiveC = (decimal).05;
            decimal twoC = (decimal).02;
            decimal oneC = (decimal).01;

            decimal money = Convert.ToDecimal(Txt_amount.Text);

            int twoEAmount = (int)(money / twoE);
            decimal change = money % twoE;

            int oneEAmount = (int)(change / oneE);
            change = change % oneE;

            int fiftyCAmount = (int)(change / fiftyC);
            change = change % fiftyC;

            int twentyCAmount = (int)(change / twentyC);
            change = change % twentyC;

            int tenCAmount = (int)(change / tenC);
            change = change % tenC;

            int fiveCAmount = (int)(change / fiveC);
            change = change % fiveC;

            int twoCAmount = (int)(change / twoC);
            change = change % twoC;

            int oneCAmount = (int)(change / oneC);
            change = change % oneC;

            if (twoEAmount != 0)
                TxtTwo.Text = Convert.ToString(twoEAmount);

            if (oneEAmount != 0)
                TxtOne.Text = Convert.ToString(oneEAmount);

            if (fiftyCAmount != 0)
                TxtFifty.Text = Convert.ToString(fiftyCAmount);

            if (twentyCAmount != 0)
                TxtTwent.Text = Convert.ToString(twentyCAmount);

            if (tenCAmount != 0)
                TxtTen.Text = Convert.ToString(tenCAmount);

            if (fiveCAmount != 0)
                TxtFive.Text = Convert.ToString(fiveCAmount);

            if (twoCAmount != 0)
                TxtTwoc.Text = Convert.ToString(twoCAmount);

            if (oneCAmount != 0)
                TxtOnec.Text = Convert.ToString(oneCAmount);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Txt_amount.Text = "";
            TxtTwo.Text = "0";
            TxtOne.Text = "0";
            TxtFifty.Text = "0";
            TxtTwent.Text = "0";
            TxtTen.Text = "0";
            TxtFive.Text = "0";
            TxtTwoc.Text = "0";
            TxtOnec.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
