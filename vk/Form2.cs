using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet.Model;

namespace vk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sex_TextChanged(object sender, EventArgs e)
        {

        }

        private void Birthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hometown_TextChanged(object sender, EventArgs e)
        {

        }

        private void Status_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Photo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Video_TextChanged(object sender, EventArgs e)
        {

        }

        private void Friends_TextChanged(object sender, EventArgs e)
        {

        }

        public void ID_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string friendsId = listBox1.SelectedItem.ToString();
                textBox1.Text = friendsId;
        }
    }
}
