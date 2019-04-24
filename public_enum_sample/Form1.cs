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
        //現在下注的金額
        int mybet =0;

        //列舉不同的賭注金額
        enum betmoney { clear, bet1, bet5, bet10, betdouble }

        public Form1()
        {
            InitializeComponent();
        }

        //賭注金額增減
        private void BetMoney(betmoney money)
        {
            //依照不同的狀況，增加玩家的下注金額
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
            //結果顯示於textbox
            lbResult.Text = mybet.ToString();
        }

        //按下1元
        private void money1_Click(object sender, EventArgs e)
        {
            BetMoney(betmoney.bet1);
        }

        //按下5元
        private void money5_Click(object sender, EventArgs e)
        {
            BetMoney(betmoney.bet5);
        }

        //按下10元
        private void money10_Click(object sender, EventArgs e)
        {
            BetMoney(betmoney.bet10);
        }

        //按下reset
        private void money0_Click(object sender, EventArgs e)
        {
            BetMoney(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //剛開始下注金額顯示為0
            lbResult.Text = "0";
        }

        //按下double
        private void moneyDouble_Click(object sender, EventArgs e)
        {
            BetMoney(betmoney.betdouble);
        }
    }
}