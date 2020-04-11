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
        public Gameboard()
        {
            InitializeComponent();
            lblDice.Text = "THROW";
        }

        private void buttk4_Click(object sender, EventArgs e)
        {
            k_switcher(4);
        }

        private void buttk6_Click(object sender, EventArgs e)
        {
            k_switcher(6);
        }

        private void buttk8_Click(object sender, EventArgs e)
        {
            k_switcher(8);
        }

        private void buttk10_Click(object sender, EventArgs e)
        {
            k_switcher(10);
        }

        private void buttk12_Click(object sender, EventArgs e)
        {
            k_switcher(12);
        }

        private void buttk20_Click(object sender, EventArgs e)
        {
            k_switcher(20);
        }

        private void buttkperc_Click(object sender, EventArgs e)
        {
            k_switcher(0);
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
    }
}
