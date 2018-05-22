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

        public void awans(Form1 liga)
        {
            MySqlConnection connection = new MySqlConnection(connection_string);
            MySqlCommand command = new MySqlCommand("SELECT")


        }

        public void iloscbramek(List<Form1> list)
        {
            throw new NotImplementedException();
        }

        public void iloscbramek(List<Liga> list)
        {
            throw new NotImplementedException();
        }

        public void roznica(Form1 liga)
        {
            throw new NotImplementedException();
        }

        public void roznica(Liga liga)
        {
            throw new NotImplementedException();
        }

        public void spadek(Form1 liga)
        {
            throw new NotImplementedException();
        }

        public void spadek(Liga liga)
        {
            throw new NotImplementedException();
        }

        public void straconebramkinamecz(Form1 liga)
        {
            throw new NotImplementedException();
        }

        public void straconebramkinamecz(Liga liga)
        {
            throw new NotImplementedException();
        }

        public void zwyciestwapowsredniej(Form1 liga)
        {
            throw new NotImplementedException();
        }

        public void zwyciestwapowsredniej(Liga liga)
        {
            throw new NotImplementedException();
        }
    }
}
