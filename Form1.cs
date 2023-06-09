using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDBAccess
{
    
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\myFolder\\Database1.mdb;Persist Security Info=False;";

        private OleDbConnection myConnection = null;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string query = "SELECT FirstName FROM [Students] WHERE Id = 1";
            OleDbCommand oleDbCommand = new OleDbCommand(query,myConnection);
            lblShow.Text = oleDbCommand.ExecuteScalar().ToString();
        }
    }
}
