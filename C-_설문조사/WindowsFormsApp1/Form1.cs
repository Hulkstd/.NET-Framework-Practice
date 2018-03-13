﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPoll_Click(object sender, EventArgs e)
        {
            if(this.chb01.Checked != false || this.chb02.Checked != false)
            {
                foreach (RadioButton c in this.gbHobby.Controls)
                {
                    if (c.Checked == true)
                        this.lblHobbyBox.Text = c.Text;
                }
                this.lblSportsBox.Text = "";
                foreach(CheckBox c in this.gbSports.Controls)
                {
                    if(c.Checked == true)
                    {
                        this.lblSportsBox.Text += c.Text + " ";
                    }
                }
            }
        }
    }
}
