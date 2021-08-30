using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataBasePractice
{
    
    public partial class Form1 : Form
    {
        string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\saes0\Desktop\IIEBooks.accdb";
        public Form1()
        {
            InitializeComponent();

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = conStr;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Books";
            con.Open();
            OleDbDataReader rd =  cmd.ExecuteReader();
            while (rd.Read())
            {
                for(int c = 0; c < rd.FieldCount; c++)
                {
                    richTextBox1.AppendText(rd[c].ToString() + "\t");
                }
            richTextBox1.AppendText("\n");
            }
            con.Close();



            OleDbDataAdapter adp = new OleDbDataAdapter();
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            int num = adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
