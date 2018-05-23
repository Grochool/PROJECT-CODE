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

        public void awans(Form1 liga)                   //DONE
        {
            MySqlConnection conn = new MySqlConnection(connection_string);
            MySqlCommand command = new MySqlCommand("SELECT Nazwa_druzyny from drużyny where liga='" + liga.comboBox1.Text + "' order by punkty desc limit 3");

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
        }   //Cokolwiek ma robic...

        public void roznica(Form1 liga)                 //DONE
        {
            MySqlConnection conn = new MySqlConnection(connection_string);

            MySqlCommand command = new MySqlCommand("SELECT bramki from drużyny where liga='" + liga.comboBox1.Text + "' order by punkty limit 3 ");
            command.Connection = conn;
            conn.Open();
            MySqlDataReader read = command.ExecuteReader();
            int bramki_najlepszych = 0;
            while (read.Read())
            {
                bramki_najlepszych += Convert.ToInt32(read[0]);
            }
            conn.Close();

            conn.Open();
            command = new MySqlCommand("SELECT bramki from drużyny where liga='" + liga.comboBox1.Text + "' order by punkty limit 3");
            command.Connection = conn;
            read = command.ExecuteReader();
            int bramki_najslabszych = 0;
            while (read.Read())
            {
                bramki_najslabszych += Convert.ToInt32(read[0]);
            }
            conn.Close();

            Chart_slupki chart = new Chart_slupki(bramki_najlepszych, bramki_najslabszych);
            chart.Show();
        }

        public void spadek(Form1 liga)                  //DONE
        {
            MySqlConnection conn = new MySqlConnection(connection_string);
            MySqlCommand command = new MySqlCommand("SELECT Nazwa_druzyny from drużyny where liga='" + liga.comboBox1.Text + "' order by punkty limit 3");

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

        public void straconebramkinamecz(Form1 liga)    //DONE
        {
            //FUNKCJONALNOSC NIEMOZLIWA, BRAK DANYCH NA TEMAT STRACONYCH BRAMEK
            throw new NotImplementedException();
        }

        public void zwyciestwapowsredniej(Form1 liga)
        {
            MySqlConnection conn = new MySqlConnection(connection_string);
            MySqlCommand command = new MySqlCommand("select Nazwa_druzyny from drużyny where (zwyciestwa / Rozegrane_mecze) > (select avg(zwyciestwa / Rozegrane_mecze) from drużyny)");
            command.Connection = conn;

            conn.Open();
            MySqlDataReader read = command.ExecuteReader();
            int team_above = 0;
            while (read.Read())
            {
                team_above += 1;
            }
            conn.Close();

            command = new MySqlCommand("select Nazwa_druzyny from drużyny where (zwyciestwa / Rozegrane_mecze) > (select avg(zwyciestwa / Rozegrane_mecze) from drużyny) AND liga='" + comboBox1.Text +"';");
            command.Connection = conn;

            conn.Open();
            read = command.ExecuteReader();
            int team_below = 0;
            while (read.Read())
            {
                team_below += 1;
            }
            conn.Close();

            Chart_kolowy chart = new Chart_kolowy(team_above, team_below);
            chart.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lista od Liga
            comboBox1.Items.Add("Primera Division");
            comboBox1.Items.Add("Bundesliga");
            comboBox1.Items.Add("Premier League");
            comboBox1.Items.Add("Ligue 1");
            //lista od Opcje
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

            if (DialogResult.Yes == result)
            {
                option();   //W wyborze opcji są przekierowania do odpowiednich akcji
            }
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void option()
        {
            switch (comboBox2.Text)
            {
                case "Awans":
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

        private void ilosc_bramek_Click(object sender, EventArgs e) //DONE
        {
            MySqlConnection conn = new MySqlConnection(connection_string);
            MySqlCommand command = new MySqlCommand("SELECT liga, sum(bramki) from drużyny group by liga");

            command.Connection = conn;

            conn.Open();
            MySqlDataReader read = command.ExecuteReader();
            string[] ligi = { "", "", "", "", "" };
            int[] bramki = { 0, 0, 0, 0, 0 };
            int i = 0;
            while (read.Read())
            {
                ligi[i] = read[0].ToString();
                bramki[i] = Convert.ToInt32(read[1]);
                i++;
            }
            conn.Close();

            Chart_bramki chart = new Chart_bramki(ligi, bramki);
            chart.Show();
            //generowanie wykrsów do pdf
        }
    }
}
