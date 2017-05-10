

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project3
{
    public partial class Form2 : Form
    {
        /**
        *global variables for lift location day and time
        **/
        string a = "This lift is going down";
        string b = DateTime.Now.ToString("dd/MM/yyyy");
        string c = DateTime.Now.ToString("HH:mm:ss");

        public Form2()
        {
            InitializeComponent();
            DirectionP1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + "direction1.png");//this displays the position of the lift when the form is loaded
            DirectionP2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + "direction1.png");
            statuspanel.BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + "LIFT STATUS1.png");
        }
        /*
        *method for database connection
        **/
        public void dataconnection(string a, string b)
        {
            string con = null;
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter;
            DataSet ds = new DataSet();
            con = "Provider=Microsoft.ACE.OLEDB.12.0;Data source =Assignment.accdb;";// database connection string.... this connects to the database
            connection = new OleDbConnection(con);
            try
            {
                connection.Open();
                oledbAdapter = new OleDbDataAdapter("Insert INTO  ElevatorLog([LOCATION],[DAY],[TIME]) VALUES ('" + a + "', '" + b + "','" + c + "')", connection);//this inserts details in to the database
               oledbAdapter.Fill(ds);
                statuspanel.BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + "LIFT STATUS2.png");
                oledbAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /*
         * This timer moves the lift to the ground floor
         * */
        private void goingdowntimer_Tick(object sender, EventArgs e)
        {
            DirectionP1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + "direction4.png");
            DirectionP2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + "direction4.png");

            lift1.Top = lift1.Top + 3; //makes the lift go down to the groung floor
            if (lift1.Top == 400) //This if statement checks if the lift has reached the ground floor....if so the lift stops moving
            {
                DirectionP1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + "direction2.png");
                DirectionP2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + "direction2.png");

                goingdowntimer.Stop(); //stops the going down timer 
                grounddoortimer.Start();// starts the timer which opens the door on the ground floor
            }
        }
        /*
        * This timer moves the lift to the first floor
        * */
        private void goinguptimer_Tick(object sender, EventArgs e)
        {
            DirectionP1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + "direction3.png");
            DirectionP2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + "direction3.png");

            lift1.Top = lift1.Top - 3; //makes the lift go up to the firstfloor

            if (lift1.Top == 49) // an if statement to check if the lift has reached the first floor....if so the lift stops moving
            {
                DirectionP1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + "direction1.png");//this command displays the location of the lift
                DirectionP2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + "direction1.png");
                goinguptimer.Stop(); // stops the lift from going up
                doorsopentimer.Start();// starts the timer which opens the door on the first floor
            }
        }
        //calls the lift from the ground floor to the firstfloor
        private void goingdownbtn_Click(object sender, EventArgs e)
        {
            if (lift1.Top == 49)//location of the lift on the firstfloor
                doorsopentimer.Start();
            else if (upleftdoor.Left < 3)//this checksif the doors are closed
            {
                return;
            }
            else if (lift1.Top == 400)//location of the lift on the groundfloor
            {
                goinguptimer.Start();
                dataconnection(a, b);
            }
        }
        private void goingupbtn_Click(object sender, EventArgs e)
        {
            if (lift1.Top == 400)// this IF statement starts when the lift is on the ground floor
                grounddoortimer.Start();

            else if (upleftdoor.Left < 3)//this checks if the doors are closed
            {
                return;
            }
            else if (lift1.Top == 49)//an IF statement to start a timer for the lift to go to the first floor
            {
                goingdowntimer.Start();
               
            }
        }
        private void doorsopentimer_Tick(object sender, EventArgs e)
        {
            if (uprightdoor.Left <= 275)//this opems the door on the first floor
            {
                Console.WriteLine(upleftdoor.Left);
                uprightdoor.Left = uprightdoor.Left + 5;
                upleftdoor.Left = upleftdoor.Left - 5;
                uprightdoor2.Left = uprightdoor2.Left + 5;
                upleftdoor2.Left = upleftdoor2.Left - 5;
                Console.WriteLine(upleftdoor.Left);
            }
            else
            {
                Thread.Sleep(2000);//this is a 2 second timer which starts after the door of the lift has been opened in order to close the doors
                doorsopentimer.Stop();
                doorsclosetimer.Start();
                string a = "This lift is on the first floor";
                dataconnection(a, b);
            }
        }

        private void doorsclosetimer_Tick(object sender, EventArgs e)
        {
            if (uprightdoor.Left > 143)//this closes the door
            {
                doorsopentimer.Stop();
                Console.WriteLine("running");
                uprightdoor.Left = uprightdoor.Left - 5;
                upleftdoor.Left = upleftdoor.Left + 5;
                uprightdoor2.Left = uprightdoor2.Left - 5;
                upleftdoor2.Left = upleftdoor2.Left + 5;
            }
            else
            {
                doorsclosetimer.Stop();
            }
        }
        /**
         * Event handler for the lift to go to the ground floor
         * */
        private void groundfloor_Click(object sender, EventArgs e)
        {
            if (upleftdoor.Left < 3)//This if statement checks if the door is close before the life starts going up
            {
                return;
            }
            else if ((lift1.Top == 49))//this if ststement moves the lift to the  ground floor...if the lift is on the first floor
            {
                goingdowntimer.Start();
                string a = "This lift is going down"; //this is whats is upgated into the database
                dataconnection(a, b);
            }
        }
        /*
         * a timer to open the doors on the ground floor
         * */
        private void grounddoortimer_Tick(object sender, EventArgs e)
        {

            if (uprightdoor.Left < 275)
            {
                Console.WriteLine(upleftdoor.Left);
                uprightdoor.Left = uprightdoor.Left + 5;
                upleftdoor.Left = upleftdoor.Left - 5;
                downleftdoor2.Left = downleftdoor2.Left - 5;
                downrightdoor2.Left = downrightdoor2.Left + 5;

                Console.WriteLine(upleftdoor.Left);
            }
            else
            {
                Thread.Sleep(2000);//this is a 2second timer which starts after the door of the lift has been opened in order to close the doors
                grounddoortimer.Stop();
                closegrounddoorstimer.Start();
                string a = "This lift is on the ground floor";
                dataconnection(a, b);//calls the method to save details to the database

            }
        }
        /*
         * a timer to close the doors on the ground floor
         * */
        private void closegrounddoorstimer_Tick(object sender, EventArgs e)
        {

            if (uprightdoor.Left > 143)//this closes the door
            {
                grounddoortimer.Stop();
                Console.WriteLine("running");
                /*
                *the lines of code below the speed at which the doors close 
                */
                uprightdoor.Left = uprightdoor.Left - 5;
                upleftdoor.Left = upleftdoor.Left + 5;
                downleftdoor2.Left = downleftdoor2.Left + 5;
                downrightdoor2.Left = downrightdoor2.Left - 5;
            }
            else
            {
                closegrounddoorstimer.Stop();
            }
        }
        /*
         * Event handler for the lift to get to the first floor
         * */
        private void goingfirstfloorbtn_Click(object sender, EventArgs e)
        {
            if (upleftdoor.Left < 3) //This IF statement checks if the door is close before the life starts going down
            {
                return;
            }
            else if ((lift1.Top == 400)) //this if statement moves the lift to the first floor...if the lift is on the ground floor
            {
                goinguptimer.Start();
                string a = "This lift is going up";
                dataconnection(a, b);
            }
        }
        /**
        *this event handler loads the log form
        */
        private void logbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();

        }
        /**
        *this event handler loads the home screen form
        */
        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

    }
}
