using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        Boolean checker;
        int plusone;
        void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        void score()
        {
            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
            {
                button1.BackColor = System.Drawing.Color.CadetBlue;
                button2.BackColor = System.Drawing.Color.CadetBlue;
                button3.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("The winner is player X", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            {
                button4.BackColor = System.Drawing.Color.CadetBlue;
                button5.BackColor = System.Drawing.Color.CadetBlue;
                button6.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("The winner is player X", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (button7.Text == "x" && button8.Text == "x" && button9.Text == "x")
            {
                button7.BackColor = System.Drawing.Color.CadetBlue;
                button8.BackColor = System.Drawing.Color.CadetBlue;
                button9.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("The winner is player X", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (button1.Text == "x" && button4.Text == "x" && button7.Text == "x")
            {
                button1.BackColor = System.Drawing.Color.CadetBlue;
                button4.BackColor = System.Drawing.Color.CadetBlue;
                button7.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("The winner is player X", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
            {
                button2.BackColor = System.Drawing.Color.CadetBlue;
                button5.BackColor = System.Drawing.Color.CadetBlue;
                button8.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("The winner is player X", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
            {
                button3.BackColor = System.Drawing.Color.CadetBlue;
                button6.BackColor = System.Drawing.Color.CadetBlue;
                button9.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("The winner is player X", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
            {
                button1.BackColor = System.Drawing.Color.CadetBlue;
                button5.BackColor = System.Drawing.Color.CadetBlue;
                button9.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("The winner is player X", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            {
                button3.BackColor = System.Drawing.Color.CadetBlue;
                button5.BackColor = System.Drawing.Color.CadetBlue;
                button7.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("The winner is player X", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            //=============================================================================================================
            if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
            {
                button1.BackColor = System.Drawing.Color.Pink;
                button2.BackColor = System.Drawing.Color.Pink;
                button3.BackColor = System.Drawing.Color.Pink;
                MessageBox.Show("The winner is player O", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            {
                button4.BackColor = System.Drawing.Color.Pink;
                button5.BackColor = System.Drawing.Color.Pink;
                button6.BackColor = System.Drawing.Color.Pink;
                MessageBox.Show("The winner is player O", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (button7.Text == "o" && button8.Text == "o" && button9.Text == "o")
            {
                button7.BackColor = System.Drawing.Color.Pink;
                button8.BackColor = System.Drawing.Color.Pink;
                button9.BackColor = System.Drawing.Color.Pink;
                MessageBox.Show("The winner is player O", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                 label5.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (button1.Text == "o" && button4.Text == "o" && button7.Text == "o")
            {
                button1.BackColor = System.Drawing.Color.Pink;
                button4.BackColor = System.Drawing.Color.Pink;
                button7.BackColor = System.Drawing.Color.Pink;
                MessageBox.Show("The winner is player O", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (button2.Text == "o" && button5.Text == "o" && button8.Text == "o")
            {
                button2.BackColor = System.Drawing.Color.Pink;
                button5.BackColor = System.Drawing.Color.Pink;
                button8.BackColor = System.Drawing.Color.Pink;
                MessageBox.Show("The winner is player O", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
            {
                button3.BackColor = System.Drawing.Color.Pink;
                button6.BackColor = System.Drawing.Color.Pink;
                button9.BackColor = System.Drawing.Color.Pink;
                MessageBox.Show("The winner is player O", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
            {
                button1.BackColor = System.Drawing.Color.Pink;
                button5.BackColor = System.Drawing.Color.Pink;
                button9.BackColor = System.Drawing.Color.Pink;
                MessageBox.Show("The winner is player O", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
            {
                button3.BackColor = System.Drawing.Color.Pink;
                button5.BackColor = System.Drawing.Color.Pink;
                button7.BackColor = System.Drawing.Color.Pink;
                MessageBox.Show("The winner is player O", "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                button1.Text = "x";
                checker = true;
            }
            else
            {

                button1.Text = "o";
                checker = false;
            }
            score();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "x";
                checker = true;
            }
            else
            {

                button2.Text = "o";
                checker = false;
            }
            score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "x";
                checker = true;
            }
            else
            {

                button3.Text = "o";
                checker = false;
            }
            score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "x";
                checker = true;
            }
            else
            {

                button4.Text = "o";
                checker = false;
            }
            score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "x";
                checker = true;
            }
            else
            {

                button5.Text = "o";
                checker = false;
            }
            score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "x";
                checker = true;
            }
            else
            {

                button6.Text = "o";
                checker = false;
            }
            score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "x";
                checker = true;
            }
            else
            {

                button7.Text = "o";
                checker = false;
            }
            score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "x";
                checker = true;
            }
            else
            {

                button8.Text = "o";
                checker = false;
            }
            score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "x";
                checker = true;
            }
            else
            {

                button9.Text = "o";
                checker = false;
            }
            score();
            button9.Enabled = false;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                label4.Text = "0";
                label5.Text = "0";

                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.WhiteSmoke;
                button7.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "X,O.Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                button11.Enabled = true;

                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.WhiteSmoke;
                button7.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "X,O Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
          
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Do You really want to Exit", 
                    "X,O Game", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "X,O Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
