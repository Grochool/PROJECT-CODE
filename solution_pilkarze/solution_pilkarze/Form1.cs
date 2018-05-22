using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form, Interface // implementacja interfejsu 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string server = "localhost";
        private static string database = "druzyny";
        private static string uid = "root";
        private static string pwd = "root";

        private string connection_string = "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + uid + ";" +
                "PASSWORD=" + pwd + ";";

        public void awans(Form1 liga)   //DONE
        {
            MySqlConnection conn = new MySqlConnection(connection_string);
            MySqlCommand command = new MySqlCommand("SELECT Nazwa_druzyny from drużyny where liga='" + liga.comboBox1.Text + "'" + " limit 3 order by punkty desc");

            command.Connection = conn;

            conn.Open();
            MySqlDataReader read = command.ExecuteReader();
            string nazwy_druzyn = "";
            while (read.Read())
            {
                nazwy_druzyn += read[0] + "\n";
            }
            conn.Close();
            MessageBox.Show(nazwy_druzyn);
        }

        public void iloscbramek(List<Form1> list)
        {
            throw new NotImplementedException();
        }

        public void roznica(Form1 liga)     //DODAJ WYKRES
        {
            MySqlConnection conn = new MySqlConnection(connection_string);

            MySqlCommand command = new MySqlCommand("SELECT Nazwa_druzyny from drużyny where liga='" + liga.comboBox1.Text + "' order by punkty limit 3 ");
            command.Connection = conn;
            conn.Open();
            MySqlDataReader read = command.ExecuteReader();
            int bramki_najlepszych = 0;
            while (read.Read())
            {
                bramki_najlepszych += Convert.ToInt32(read[0]);
            }


            command = new MySqlCommand("SELECT Nazwa_druzyny from drużyny where liga='" + liga.comboBox1.Text + "'" + " limit 3 order by punkty");
            command.Connection = conn;
            read = command.ExecuteReader();
            int bramki_najslabszych = 0;
            while (read.Read())
            {
                bramki_najslabszych += Convert.ToInt32(read[0]);
            }
            conn.Close();

            Chart_slupki chart = new Chart_slupki(bramki_najlepszych, bramki_najslabszych);

        }

        public void spadek(Form1 liga)  //DONE
        {
            MySqlConnection conn = new MySqlConnection(connection_string);
            MySqlCommand command = new MySqlCommand("SELECT Nazwa_druzyny from drużyny where liga='" + liga.comboBox1.Text + "'" + " limit 3 order by punkty");

            command.Connection = conn;

            conn.Open();
            MySqlDataReader read = command.ExecuteReader();
            string nazwy_druzyn = "";
            while (read.Read())
            {
                nazwy_druzyn += read[0] + "\n";
            }
            conn.Close();
            MessageBox.Show(nazwy_druzyn);
        }

        public void straconebramkinamecz(Form1 liga)
        {
            throw new NotImplementedException();
        }

        public void zwyciestwapowsredniej(Form1 liga)
        {
            throw new NotImplementedException();
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
            MessageBox.Show(messageBoxText, caption, button, icon);
            switch (comboBox2.Text)
            {
                case "Awans":
                    MessageBox.Show("SS");
                    awans(this);
                    break;
                case "Spadek":
                    spadek(this);
                    break;
                case "Różnica":
                    roznica(this);
                    break;
                case "Zwycięstwa powyżej średniej":
                    zwyciestwapowsredniej(this);
                    break;
                case "Stracone bramki na mecz":
                    straconebramkinamecz(this);
                    break;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
