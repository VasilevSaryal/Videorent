﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videorent
{
    public partial class Autoresation : Form
    {
        string name="SuperNastya", passw="qwe123_";
        public Autoresation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check credentials
            if (textBox1.Text == name && textBox2.Text == passw)
            {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
            else Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
            //Application.Exit();
        }

        private void Autoresation_Load(object sender, EventArgs e)
        {

        }
    }
}
