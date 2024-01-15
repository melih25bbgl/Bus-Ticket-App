using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobus_bileti_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Nerden :";
            label2.Text = "Nereye :";
            label3.Text = "Tarih :";
            label4.Text = "Cinsiyet :";
            label5.Text = "ERZURUM";
            label6.Text = "TURİZM";
            label7.Text = "ONLINE BİLET SATIŞ";
            label8.Text = "Saat :";
            label9.Text = "Dolu";
            label10.Text = "Boş";
            listBox1.Visible = false;
            radioButton1.Text = "Erkek";
            radioButton2.Text = "Kadın";
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "10";
            button11.Text = "11";
            button12.Text = "12";
            button13.Text = "13";
            button14.Text = "14";
            button15.Text = "15";
            button16.Text = "16";
            button17.Text = "17";
            button18.Text = "18";
            button19.Text = "19";
            button20.Text = "20";
            button21.Text = "21";
            button22.Text = "22";
            button23.Text = "23";
            button24.Text = "24";
            button25.Text = "25";
            button26.Text = "26";
            button27.Text = "27";
            button28.Text = "28";
            button29.Text = "29";
            button30.Text = "30";
            button31.Text = "31";
            button32.Text = "32";
            button33.Text = "33";
            button34.Text = "34";
            button35.Text = "35";
            button36.Text = "36";
            button37.Text = "37";
            button38.Text = "38";
            button39.Text = "Kaydet";
            button40.Text = "";
            button41.Text = "";
            panel1.BackColor = Color.Gray;
            label5.ForeColor = Color.Blue;
            label6.ForeColor = Color.White;
            button40.BackColor = Color.Black;
            button40.Enabled = false;
            button41.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                button1.BackColor = Color.Blue;
            }
            else if(radioButton2.Checked==true)
            {
                button1.BackColor = Color.Red;
            }
            else if(button1.BackColor == Color.Blue || button1.BackColor == Color.Red)
            {
                button1.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button2.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button2.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button3.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button3.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button4.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button4.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button5.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button5.BackColor = Color.Red;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button6.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button6.BackColor = Color.Red;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button7.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button7.BackColor = Color.Red;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button8.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button8.BackColor = Color.Red;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button9.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button9.BackColor = Color.Red;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button10.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button10.BackColor = Color.Red;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button11.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button11.BackColor = Color.Red;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button12.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button12.BackColor = Color.Red;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button13.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button13.BackColor = Color.Red;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button14.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button14.BackColor = Color.Red;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button15.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button15.BackColor = Color.Red;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button16.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button16.BackColor = Color.Red;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button17.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button17.BackColor = Color.Red;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button18.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button18.BackColor = Color.Red;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button19.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button19.BackColor = Color.Red;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button20.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button20.BackColor = Color.Red;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button21.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button21.BackColor = Color.Red;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button22.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button22.BackColor = Color.Red;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button23.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button23.BackColor = Color.Red;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button24.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button24.BackColor = Color.Red;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button25.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button25.BackColor = Color.Red;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button26.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button26.BackColor = Color.Red;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button27.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button27.BackColor = Color.Red;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button28.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button28.BackColor = Color.Red;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button29.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button29.BackColor = Color.Red;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button30.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button30.BackColor = Color.Red;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button31.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button31.BackColor = Color.Red;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button32.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button32.BackColor = Color.Red;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button33.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button33.BackColor = Color.Red;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button34.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button34.BackColor = Color.Red;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button35.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button35.BackColor = Color.Red;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button36.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button36.BackColor = Color.Red;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button37.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button37.BackColor = Color.Red;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button38.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                button38.BackColor = Color.Red;
            }
        }
        private void button39_Click(object sender, EventArgs e)
        {
            if (button1.BackColor==Color.Blue || button1.BackColor == Color.Red)
            {
                button1.Enabled = false;
                button1.BackColor = Color.Black;
                
            }
            if(button2.BackColor == Color.Blue || button2.BackColor == Color.Red)
            {
                button2.Enabled = false;
                button2.BackColor = Color.Black;
            }
            if (button3.BackColor == Color.Blue || button3.BackColor == Color.Red)
            {
                button3.Enabled = false;
                button3.BackColor = Color.Black;
            }
            if (button4.BackColor == Color.Blue || button4.BackColor == Color.Red)
            {
                button4.Enabled = false;
                button4.BackColor = Color.Black;
            }
            if (button5.BackColor == Color.Blue || button5.BackColor == Color.Red)
            {
                button5.Enabled = false;
                button5.BackColor = Color.Black;
            }
            if (button6.BackColor == Color.Blue || button6.BackColor == Color.Red)
            {
                button6.Enabled = false;
                button6.BackColor = Color.Black;
            }
            if (button7.BackColor == Color.Blue || button7.BackColor == Color.Red)
            {
                button7.Enabled = false;
                button7.BackColor = Color.Black;
            }
            if (button8.BackColor == Color.Blue || button8.BackColor == Color.Red)
            {
                button8.Enabled = false;
                button8.BackColor = Color.Black;
            }
            if (button9.BackColor == Color.Blue || button9.BackColor == Color.Red)
            {
                button9.Enabled = false;
                button9.BackColor = Color.Black;
            }
            if (button10.BackColor == Color.Blue || button10.BackColor == Color.Red)
            {
                button10.Enabled = false;
                button10.BackColor = Color.Black;

            }
            if (button11.BackColor == Color.Blue || button11.BackColor == Color.Red)
            {
                button11.Enabled = false;
                button11.BackColor = Color.Black;

            }
            if (button12.BackColor == Color.Blue || button12.BackColor == Color.Red)
            {
                button12.Enabled = false;
                button12.BackColor = Color.Black;

            }
            if (button13.BackColor == Color.Blue || button13.BackColor == Color.Red)
            {
                button13.Enabled = false;
                button13.BackColor = Color.Black;

            }
            if (button14.BackColor == Color.Blue || button14.BackColor == Color.Red)
            {
                button14.Enabled = false;
                button14.BackColor = Color.Black;

            }
            if (button15.BackColor == Color.Blue || button15.BackColor == Color.Red)
            {
                button15.Enabled = false;
                button15.BackColor = Color.Black;

            }
            if (button16.BackColor == Color.Blue || button16.BackColor == Color.Red)
            {
                button16.Enabled = false;
                button16.BackColor = Color.Black;

            }
            if (button17.BackColor == Color.Blue || button17.BackColor == Color.Red)
            {
                button17.Enabled = false;
                button17.BackColor = Color.Black;

            }
            if (button18.BackColor == Color.Blue || button18.BackColor == Color.Red)
            {
                button18.Enabled = false;
                button18.BackColor = Color.Black;

            }
            if (button19.BackColor == Color.Blue || button19.BackColor == Color.Red)
            {
                button19.Enabled = false;
                button19.BackColor = Color.Black;

            }
            if (button20.BackColor == Color.Blue || button20.BackColor == Color.Red)
            {
                button20.Enabled = false;
                button20.BackColor = Color.Black;
            }
            if (button21.BackColor == Color.Blue || button21.BackColor == Color.Red)
            {
                button21.Enabled = false;
                button21.BackColor = Color.Black;
            }
            if (button22.BackColor == Color.Blue || button22.BackColor == Color.Red)
            {
                button22.Enabled = false;
                button22.BackColor = Color.Black;
            }
            if (button23.BackColor == Color.Blue || button23.BackColor == Color.Red)
            {
                button23.Enabled = false;
                button23.BackColor = Color.Black;
            }
            if (button24.BackColor == Color.Blue || button24.BackColor == Color.Red)
            {
                button24.Enabled = false;
                button24.BackColor = Color.Black;
            }
            if (button25.BackColor == Color.Blue || button25.BackColor == Color.Red)
            {
                button25.Enabled = false;
                button25.BackColor = Color.Black;
            }
            if (button26.BackColor == Color.Blue || button26.BackColor == Color.Red)
            {
                button26.Enabled = false;
                button26.BackColor = Color.Black;
            }
            if (button27.BackColor == Color.Blue || button27.BackColor == Color.Red)
            {
                button27.Enabled = false;
                button27.BackColor = Color.Black;
            }
            if (button28.BackColor == Color.Blue || button28.BackColor == Color.Red)
            {
                button28.Enabled = false;
                button28.BackColor = Color.Black;
            }
            if (button29.BackColor == Color.Blue || button29.BackColor == Color.Red)
            {
                button29.Enabled = false;
                button29.BackColor = Color.Black;
            }
            if (button30.BackColor == Color.Blue || button30.BackColor == Color.Red)
            {
                button30.Enabled = false;
                button30.BackColor = Color.Black;
            }
            if (button31.BackColor == Color.Blue || button31.BackColor == Color.Red)
            {
                button31.Enabled = false;
                button31.BackColor = Color.Black;
            }
            if (button32.BackColor == Color.Blue || button32.BackColor == Color.Red)
            {
                button32.Enabled = false;
                button32.BackColor = Color.Black;
            }
            if (button33.BackColor == Color.Blue || button33.BackColor == Color.Red)
            {
                button33.Enabled = false;
                button33.BackColor = Color.Black;
            }
            if (button34.BackColor == Color.Blue || button34.BackColor == Color.Red)
            {
                button34.Enabled = false;
                button34.BackColor = Color.Black;
            }
            if (button35.BackColor == Color.Blue || button35.BackColor == Color.Red)
            {
                button35.Enabled = false;
                button35.BackColor = Color.Black;
            }
            if (button36.BackColor == Color.Blue || button36.BackColor == Color.Red)
            {
                button36.Enabled = false;
                button36.BackColor = Color.Black;
            }
            if (button37.BackColor == Color.Blue || button37.BackColor == Color.Red)
            {
                button37.Enabled = false;
                button37.BackColor = Color.Black;
            }
            if (button38.BackColor == Color.Blue || button38.BackColor == Color.Red)
            {
                button38.Enabled = false;
                button38.BackColor = Color.Black;
            }
            listBox1.Visible = true;
            MessageBox.Show("Kayıt Başarılı !");
            listBox1.Items.Add("Kayıt Bilgileri");
            listBox1.Items.Add("---------------------------");
            listBox1.Items.Add(comboBox1.Text+"-"+comboBox2.Text+" Tarih :"+dateTimePicker1.Text+" Saat :"+comboBox3.Text);
        }
    }
}
