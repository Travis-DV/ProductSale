using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductSale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputTB_TextChanged(object sender, EventArgs e)
        {
            ArrayList inputint = Turnintoint(inputTB.Text);
            if ((bool)inputint[0])
            {
                int totalcost = (int)inputint[1] * 99;
                //Your discount is: 0%
                //
                if ((int)inputint[1] < 10)
                {
                    discountLB.Text = "Your discount is: 0%";
                }
                else if ((int)inputint[1] >= 10 && (int)inputint[1] < 20)
                {
                    discountLB.Text = "Your discount is: 20%!";
                    totalcost = (totalcost / 5) * 4;
                }
                else if ((int)inputint[1] >= 20 && (int)inputint[1] < 50)
                {
                    discountLB.Text = "Your discount is: 30%!!";
                    totalcost = (totalcost / 10) * 7;
                }
                else if ((int)inputint[1] >= 50 && (int)inputint[1] < 100)
                {
                    discountLB.Text = "Your discount is: 40%!!!";
                    totalcost = (totalcost / 10) * 6;
                }
                else
                {
                    discountLB.Text = "Your discount is: 50%!!!!";
                    totalcost = totalcost / 2;
                }
                totalcostLB.Text = $"Your total cost is: {totalcost}";
            }


        }

        private ArrayList Turnintoint(string inputstring)
        {
            try
            {
                int inputnumb = int.Parse(inputstring);
                if (inputnumb < 0)
                {
                    Isempty(inputstring);
                    ArrayList outputfails = new ArrayList();
                    outputfails.Add(false);
                    return outputfails;
                }
                ArrayList outputwork = new ArrayList();
                outputwork.Add(true);
                outputwork.Add(int.Parse(inputstring));
                return outputwork;
            }
            catch (FormatException)
            {
                Isempty(inputstring);
                ArrayList outputfails = new ArrayList();
                outputfails.Add(false);
                return outputfails;
            }


        }

        private void Isempty(string inputstr)
        {
            if (inputstr == "")
            {
                totalcostLB.Text = "";
            }
            else
            {
                totalcostLB.Text = "Please input a number!";
            }
        }
    }
}
