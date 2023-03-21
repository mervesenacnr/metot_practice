using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Yazdir()
        {
            textBox1.Text = "Merve Sena";
            textBox2.Text = "Çınar";
            textBox3.Text = "İzmir";
        }

        void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yazdir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
