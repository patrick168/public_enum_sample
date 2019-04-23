using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace public_enum_sample
{
    public partial class Form1 : Form
    {
        int mybet=0;

        enum betmoney { clear,bet1, bet5,bet10,betdouble}

        public Form1()
        {
            InitializeComponent();
        }

        private void BetMoney(betmoney money)
        {
            switch(money)
            {
                case betmoney.bet1:
                    mybet += 1;
                    break;
                case betmoney.bet5:
                    mybet += 5;
                    break;
                case betmoney.bet10:
                    mybet += 10;
                    break;
                case betmoney.clear:
                    mybet = 0;
                    break;
                case betmoney.betdouble:
                    mybet *= 2;
                    break;
            }
          
            lbResult.Text = mybet.ToString();
        }

        private void money1_Click(object sender, EventArgs e)
        {
            BetMoney(betmoney.bet1);
        }

        private void money5_Click(object sender, EventArgs e)
        {
            BetMoney(betmoney.bet5);
        }

        private void money10_Click(object sender, EventArgs e)
        {
            BetMoney(betmoney.bet10);
        }

        private void money0_Click(object sender, EventArgs e)
        {
            BetMoney(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbResult.Text = "0";
        }

        private void moneyDouble_Click(object sender, EventArgs e)
        {
            BetMoney(betmoney.betdouble);
        }
    }
}
