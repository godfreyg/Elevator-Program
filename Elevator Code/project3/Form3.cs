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
namespace project3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        /*
        *this current displayed log details are on the list view when this form loads
        **/
        private void Form3_Load(object sender, EventArgs e)
        {
             string con = null;
            listView2.Items.Clear();
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter;
            DataSet ds = new DataSet();
            int i = 0;
            con = "Provider=Microsoft.ACE.OLEDB.12.0;Data source =Assignment.accdb;";// connection string to my access database
            connection = new OleDbConnection(con);
            try
            {
                connection.Open();
                oledbAdapter = new OleDbDataAdapter("select * from ElevatorLog", connection);//Sql statement to select all from my table and display it to my database
                oledbAdapter.Fill(ds);
                oledbAdapter.Dispose();
                connection.Close();
                
                /**
                *the  lines of code below enables data from my database to be displayed on the listview
                */
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem li = new ListViewItem(row["ID"].ToString());
                    li.SubItems.Add(row["LOCATION"].ToString());
                    li.SubItems.Add(row["DAY"].ToString());
                    li.SubItems.Add(row["TIME"].ToString());
                    listView2.Items.Add(li);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /**
        * this event handler loads the home screen form
        */
        private void homebtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
        /**
        *Refresh button to make my log get updated when ever the button is clicked
        */

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            string con = null;
            listView2.Items.Clear();
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter;
            DataSet ds = new DataSet();
            con = "Provider=Microsoft.ACE.OLEDB.12.0;Data source =Assignment.accdb;";
            connection = new OleDbConnection(con);
            try
            {
                connection.Open();
                oledbAdapter = new OleDbDataAdapter("select * from ElevatorLog", connection);
                oledbAdapter.Fill(ds);
                oledbAdapter.Dispose();
                connection.Close();

                /**
               *the  lines of code below enables data from my database to be displayed on the listview
               */
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem li = new ListViewItem(row["ID"].ToString());
                    li.SubItems.Add(row["LOCATION"].ToString());
                    li.SubItems.Add(row["DAY"].ToString());
                    li.SubItems.Add(row["TIME"].ToString());
                    listView2.Items.Add(li);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /**
        *this event handler loads the lift view form
        */
        private void liftviewbtn2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
