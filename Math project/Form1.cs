using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Math_project
{
    public partial class Form1 : Form
    {

        float w0, x0, y0, z0, w1, x1, y1, z1, w2, x2, y2, z2;



        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("MeowMixSong.wav");

            simpleSound.Play();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add

            w2 = w0 + w1;
            x2 = x0 + x1;
            y2 = y0 + y1;
            z2 = z0 + z1;


            textBox9.Text = Convert.ToString(w2);
            textBox10.Text = Convert.ToString(x2);
            textBox11.Text = Convert.ToString(y2);
            textBox12.Text = Convert.ToString(z2);

           SoundPlayer simpleSound = new SoundPlayer("cat.wav");

          simpleSound.Play();



            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //subtract

            w2 = w0 - w1;
            x2 = x0 - x1;
            y2 = y0 - y1;
            z2 = z0 - z1;


            textBox9.Text = Convert.ToString(w2);
            textBox10.Text = Convert.ToString(x2);
            textBox11.Text = Convert.ToString(y2);
            textBox12.Text = Convert.ToString(z2);

            SoundPlayer simpleSound = new SoundPlayer("cat.wav");

            simpleSound.Play();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //multiply

            w2 = (w0 * w1) - (x0 * x1) - (y0 * y1) - (z0 * z1);
            x2 = (w0 * x1) + (x0 * w1) + (y0 * z1) - (z0 * y1);
            y2 = (w0 * y1) - (x0 * z1) + (y0 * w1) + (z0 * x1);
            z2 = (w0 * z1) + (x0 * y1) - (y0 * x1) + (z0 * w1);


            textBox9.Text = Convert.ToString(w2);
            textBox10.Text = Convert.ToString(x2);
            textBox11.Text = Convert.ToString(y2);
            textBox12.Text = Convert.ToString(z2);

            SoundPlayer simpleSound = new SoundPlayer("cat.wav");

            simpleSound.Play();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            w0 = float.Parse(this.textBox1.Text);
            x0 = float.Parse(this.textBox2.Text);
            y0 = float.Parse(this.textBox3.Text);
            z0 = float.Parse(this.textBox4.Text);
            w1 = float.Parse(this.textBox5.Text);
            x1 = float.Parse(this.textBox6.Text);
            y1 = float.Parse(this.textBox7.Text);
            z1 = float.Parse(this.textBox8.Text);
            w2 = float.Parse(this.textBox9.Text);
            x2 = float.Parse(this.textBox10.Text);
            y2 = float.Parse(this.textBox11.Text);
            z2 = float.Parse(this.textBox12.Text);


            SoundPlayer simpleSound = new SoundPlayer("cat.wav");

            simpleSound.Play();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }






    }
}
