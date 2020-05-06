using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuneSource
{
    public partial class Form1 : Form
    {
        private readonly object OpenFileDiaglog;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Form2 registration = new Form2();
            registration.Show();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Form3 registration = new Form3();
            registration.Show();
        }

        private void labelNewrelease_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
            String msg = "";
            msg = msg + "BackGround Color Form:" + this.BackColor.ToString() + "\n";
            msg = msg + "Button Click:" + labelNewrelease.Text;
            Text = msg;
        }
    }
}
