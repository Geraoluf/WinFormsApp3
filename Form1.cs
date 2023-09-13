using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public string[] arr = new string[3];
        public int tæller = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tæller < arr.Length)
            {
                string inputText = textBox1.Text;
                arr[tæller] = inputText;
                tæller++;

                listBox1.Items.Clear(); // Ryd ListBox

                // Opdater listBox1 med alle elementer fra arr
                foreach (string item in arr)
                {
                    if (item != null)
                    {
                        listBox1.Items.Add(item);
                    }
                }

            }
            else
            {
                MessageBox.Show("Arr er fuldt. Du kan ikke tilføje flere elementer.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string item in arr)
            {
                textBox2.Text = item;
            }
        }
    }
}
