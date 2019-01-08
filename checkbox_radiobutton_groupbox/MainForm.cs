﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox_radiobutton_groupbox
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            string orderInfo = "";
            if (chFloorMats.Checked)
                orderInfo += "Ви хочете замовити коврики.\n";
            if (radioRed.Checked)
                orderInfo += "Ви обрали червоний колір.\n";
            if (radioGreen.Checked)
                orderInfo += "Ви обрали зелений колір.\n";
            if (radioYellow.Checked)
                orderInfo += "Ви обрали жовтий колір.\n";
            if (radioPink.Checked)
                orderInfo += "А чому рожевий?\n";

            lbDetails.Text = orderInfo;
        }
    }
}