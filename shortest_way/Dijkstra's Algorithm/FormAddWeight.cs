using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dijkstra_s_Algorithm
{
    public partial class FormAddWeight : Form
    {
        public int value = -1;

        public FormAddWeight()
        {
            InitializeComponent();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox1.Text) < 1)
                {
                    //MessageBox.Show("Вес должен быть неотрицательным", "Ошибка", MessageBoxButtons.OK);
                    // Bellman
                    Algoritm.alg = 2; // Если хоть есть хоть один отрицательный вес - Беллман
                    value = int.Parse(textBox1.Text);
                    //textBox1.Text = "1";
                }
                else
                {
                    // Dijkstra's
                    value = int.Parse(textBox1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                textBox1.Text = "1";
            }
            this.Close();
        }

        private void FormAddWeight_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
                //if (value == -1)
                    //e.Cancel = true;
        }
    }
}
