using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (this.door.GetItemText(this.door.SelectedItem) == "")
                return;

            string left_str = this.left.GetItemText(this.left.SelectedItem);
            if (left_str == "")
                left_str = "false";
            string right_str = this.left.GetItemText(this.right.SelectedItem);
            if (right_str == "")
                right_str = "false";

            this.label.Text = left_str + " ";
            this.label.Text += this.door.GetItemText(this.door.SelectedItem) + " ";
            if (this.door.GetItemText(this.door.SelectedItem) != "no")
                this.label.Text += right_str;
            this.label.Text += " : ";

            if (Fixme.Test(left_str, this.door.GetItemText(this.door.SelectedItem), right_str))
                this.label.Text += "true";
            else
                this.label.Text += "false";
        }
    }
}
