using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace solution_pilkarze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Primera Division");
            comboBox1.Items.Add("Bundesliga");
            comboBox1.Items.Add("Premier League");
            comboBox1.Items.Add("Ligue 1");

            comboBox2.Items.Add("Awans");
            comboBox2.Items.Add("Spadek");
            comboBox2.Items.Add("Różnica");
            comboBox2.Items.Add("Zwycięstwa powyżej średniej");
            comboBox2.Items.Add("Stracone bramki na mecz");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string messageBoxText = "Czy jesteś pewny?";
            string caption = "Zapytajnik";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            DialogResult result = MessageBox.Show(messageBoxText, caption, button, icon);
            switch (result)
            {
                case DialogResult.Yes:

                    break;
                case DialogResult.No:
                    
                    break;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
