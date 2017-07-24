using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String callerName = "Caller Name: ";
        String cname = "";
        String callbackNumber = "Call Back #: ";
        String cnum = "";
        String npiNumber = "NPI #: ";
        String npinum = "";
        //String callNote = ""; // cname + Environment.NewLine + cnum;
        //String demo = cname + cnum;

        private void callerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            cname = callerName + callerNameTextBox.Text + Environment.NewLine;
            //callNoteRTBox.Text = demo;
            callNoteRTBox.Text = cname + cnum + npinum;
        }

        private void callbackNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            cnum = callbackNumber + callbackNumberTextBox.Text + Environment.NewLine;
            //callNoteRTBox.Text = demo;
            callNoteRTBox.Text = cname + cnum + npinum;
            
        }

        private void npiTextBox_TextChanged(object sender, EventArgs e)
        {
            npinum = npiNumber + npiTextBox.Text + Environment.NewLine;
            //callNoteRTBox.Text = demo;
            callNoteRTBox.Text = cname + cnum + npinum;

        }
    }
}
