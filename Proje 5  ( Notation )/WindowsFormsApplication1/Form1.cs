using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notations;

namespace WindowsFormsApplication1
{
    public partial class Polish : Form
    {
        public Polish()
        {
            InitializeComponent();
        }
        
        Notations.Polish p = new Notations.Polish();
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (InFixTB.Text == "") { List.Items.Add("Enter Your InFix Expression First"); }
            else if (p.CheckInFix(InFixTB.Text)) { List.Items.Add("PostFix\t" + p.PostFix(InFixTB.Text)); }
            else { List.Items.Add("Your InFix Expression Is Not Fully Parenthesized"); }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (InFixTB.Text == "") { List.Items.Add("Enter Your InFix Expression First"); }
            else if (p.CheckInFix(InFixTB.Text)) { List.Items.Add("PreFix\t" + p.PreFix(InFixTB.Text)); }
            else { List.Items.Add("Your InFix Expression Is Not Fully Parenthesized"); }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            List.Items.Add("Result\t" + p.EvaluatePostFix(p.PostFix(InFixTB.Text)));
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            List.Items.Add("Result\t" + p.EvaluatePreFix(p.PreFix(InFixTB.Text)));
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (PostFixTB.Text == "") { List.Items.Add("Enter Your PostFix Expression First"); }
            else { List.Items.Add("Result\t" + p.EvaluatePostFix(PostFixTB.Text)); }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (PreFixTB.Text == "") { List.Items.Add("Enter Your PreFix Expression First"); }
            else { List.Items.Add("Result\t" + p.EvaluatePreFix(PreFixTB.Text)); }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            InFixTB.Text = "";
            PostFixTB.Text = "";
            PreFixTB.Text = "";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            foreach (string item in List.Items)
            {
                comboBox1.Items.Add(item);
            }
            List.Items.Clear();
        }

        private void AddInfix_Click(object sender, EventArgs e)
        {
            if (InFixTB.Text == "") { List.Items.Add("Enter Your InFix Expression First"); }
            else { List.Items.Add("InFix\t" + InFixTB.Text); }
        }

        private void AddPostfix_Click(object sender, EventArgs e)
        {
            if (PostFixTB.Text == "") { List.Items.Add("Enter Your PostFix Expression First"); }
            else { List.Items.Add("PostFix\t" + PostFixTB.Text); }
        }

        private void AddPrefix_Click(object sender, EventArgs e)
        {
            if (PreFixTB.Text == "") { List.Items.Add("Enter Your PreFix Expression First"); }
            else { List.Items.Add("PreFix\t" + PreFixTB.Text); }
        }

        private void PostFixTB_Enter(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void PostFixTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
