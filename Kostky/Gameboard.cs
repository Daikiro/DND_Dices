using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostky
{
    public partial class Gameboard : Form
    {
        Point valueOneCif = new Point(248, 236);
        Point valueTwoCif = new Point(238, 236);
        Point percZeroCif = new Point(221, 236);
        Point percOneCif = new Point(205, 236);
        Point percTwoCif = new Point (199, 236);

        public Gameboard()
        {
            InitializeComponent();
            lblDice.Text = "THROW";
        }

        private void buttk4_Click(object sender, EventArgs e)
        {
            k_switcher(4);
            k_value(1,5,4);
        }

        private void buttk6_Click(object sender, EventArgs e)
        {
            k_switcher(6);
            k_value(1,7,6);
        }

        private void buttk8_Click(object sender, EventArgs e)
        {
            k_switcher(8);
            k_value(1,9,8);
        }

        private void buttk10_Click(object sender, EventArgs e)
        {
            k_switcher(10);
            k_value(1,11,10);
        }

        private void buttk12_Click(object sender, EventArgs e)
        {
            k_switcher(12);
            k_value(1,13,12);
        }

        private void buttk20_Click(object sender, EventArgs e)
        {
            k_switcher(20);
            k_value(1,21,20);
        }

        private void buttkperc_Click(object sender, EventArgs e)
        {
            k_switcher(0);
            k_value(0,110,0);
        }

        private void k_switcher(int value)
        {
            String baseValue = "You throwed:\n";
            switch (value)
            {
                case 4:
                    lblDice.Text = baseValue + "k4";
                    break;
                case 6:
                    lblDice.Text = baseValue + "k6";
                    break;
                case 8:
                    lblDice.Text = baseValue + "k8";
                    break;
                case 10:
                    lblDice.Text = baseValue + "k10";
                    break;
                case 12:
                    lblDice.Text = baseValue + "k12";
                    break;
                case 20:
                    lblDice.Text = baseValue + "k20";
                    break;
                case 0:
                    lblDice.Text = baseValue + "k perc";
                    break;
                default:
                    break;
            }
        }

        private void k_value (int minValue, int maxValue, int k)
        {
            Random random = new Random();
            int value = -1;

            switch (k)
            {
                case 4:
                    value = (random.Next(minValue, maxValue));
                    lbl_prefix(value, 4);
                    lblNumber.Text = Convert.ToString(random.Next(minValue, maxValue));
                    break;
                case 6:
                    value = (random.Next(minValue, maxValue));
                    lbl_prefix(value, 6);
                    lblNumber.Text = Convert.ToString(random.Next(minValue, maxValue));
                    break;
                case 8:
                    value = (random.Next(minValue, maxValue));
                    lbl_prefix(value, 8);
                    lblNumber.Text = Convert.ToString(random.Next(minValue, maxValue));
                    break;
                case 10:
                    value = (random.Next(minValue, maxValue));
                    lbl_prefix(value, 10);
                    lblNumber.Text = Convert.ToString(random.Next(minValue, maxValue));
                    break;
                case 12:
                    value = (random.Next(minValue, maxValue));
                    lbl_prefix(value, 12);
                    lblNumber.Text = Convert.ToString(random.Next(minValue, maxValue));
                    break;
                case 20:
                    value = (random.Next(minValue, maxValue));
                    lbl_prefix(value,20);
                    lblNumber.Text = Convert.ToString(value);
                    break;
                case 0:
                    value = (random.Next(minValue, maxValue)/10)*10;
                    lbl_prefix(value,0);
                    lblNumber.Text = Convert.ToString(value + " %");
                    break;
                default:
                    break;
            }
        }

        private void lbl_prefix(int value, int dice)
        {
            switch (dice)
            {
                case 4:
                    lblNumber.Location = valueOneCif;
                    break;
                case 6:
                    lblNumber.Location = valueOneCif;
                    break;
                case 8:
                    lblNumber.Location = valueOneCif;
                    break;
                case 10:
                    if (value != 10)
                    lblNumber.Location = valueOneCif;
                    else
                    lblNumber.Location = valueTwoCif;
                    break;
                case 12:
                    if (value < 10)
                        lblNumber.Location = valueOneCif;
                    if (value >= 10)
                        lblNumber.Location = valueTwoCif;
                    break;
                case 20:
                    if (value < 10)
                        lblNumber.Location = valueOneCif;
                    if (value >= 10)
                        lblNumber.Location = valueTwoCif;
                    break;
                case 0:
                    if (value < 10)
                        lblNumber.Location = percZeroCif;
                    if (value < 100)
                        lblNumber.Location = percOneCif;
                    if (value >= 100)
                        lblNumber.Location = percTwoCif;
                    break;
                default:
                    break;
            }
        }
    }
}
