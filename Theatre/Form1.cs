using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Theatre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theathreDataSet.ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter1.Fill(this.theathreDataSet.ticket);
            SUM.ForeColor = System.Drawing.Color.Blue;
            SUM.BackColor = System.Drawing.Color.White;
            tabPage1.Text = "Спектакли";
            tabPage2.Text = "Билеты";
            
            SqlConnection con =new SqlConnection(@"Data Source = DESKTOP-G2L34UC\SQLEXPRESS; Initial Catalog = theathre; Integrated Security = True"); 
            con.Open();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = Data.Text;
            string specid = spec.Text;
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-G2L34UC\SQLEXPRESS; Initial Catalog = theathre; Integrated Security = True");
            con.Open();
            SqlCommand thisCommand = con.CreateCommand();
            thisCommand.CommandText = "SELECT SUM(price) as TOTALPRICE FROM ticket where id_Spectacle ='" + specid + "'and [date]='"+date+"'GROUP BY(date)";
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            string res = string.Empty;
            while (thisReader.Read())
            {
                res += thisReader["TOTALPRICE"];
            }
            SUM.Text = "Сумма выручки " + res + " Рублей";

            thisReader.Close();
            con.Close();

        }

  
    }
}
