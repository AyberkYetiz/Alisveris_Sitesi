using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alışveriş_Sitesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(comboBox2.Text);
            listBox1.Items.Add(comboBox3.Text);
            listBox1.Items.Add(comboBox4.Text);
            listBox1.Items.Add(comboBox5.Text);
            listBox1.Items.Add(comboBox6.Text);
            listBox1.Items.Add(comboBox7.Text);
            listBox1.Items.Add(comboBox8.Text);
            listBox1.Items.Add(comboBox9.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            MessageBox.Show("Giriş Başarılı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buyrun Size Nasıl Yardımcı Olabilirim");
        }
    }
}
