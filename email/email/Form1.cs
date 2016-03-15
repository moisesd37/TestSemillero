using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace email
{
    public partial class Form1 : Form
    {
        Stack<string> Orders = new Stack<string>();
        Dictionary<string, string> Customers = new Dictionary<string, string>();
        string line;
        string[] pairs = new string[2];
        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                Cursor.Current = Cursors.WaitCursor; //Not necessary
                foreach (KeyValuePair<string, string> customer in Customers)
                {
                    i++;
                    SendMail(customer.Key, i, Orders.Pop());
                    textBox1.Text += customer.Key + " ✓\r\n"; //Not necessary
                }
                pictureBox3.Visible = true; //Not necessary
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                pictureBox3.Visible = false; //Not necessary
            }
        }
        private void SendMail(string email, int deadline,string item)
        {
            var sender = new MailAddress("YOUR_GOOGLE_ACCOUNT");
            var recipient = new MailAddress(email);
            string password = "YOUR_PASSWORD"; // You have to allow unsafe devices connection
            string subject = "Your order has been placed";
            string body = "Hi, we have successfully received your "+item+" order, it will be delivered in "+deadline+" day(s).";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(sender.Address, password)
            };
            using (var message = new MailMessage(sender, recipient)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
            smtp.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Customers.Clear();
                StreamReader file = new StreamReader(@"e:\customers.txt");
                while ((line = file.ReadLine()) != null)
                {
                    pairs = line.Split(',');
                    Customers.Add(pairs[0], pairs[1]);
                }
                file.Close();
                pictureBox1.Visible = true; //Not necessary
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                pictureBox1.Visible = false; //Not necessary
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader file = new StreamReader(@"e:\orders.txt");
                while ((line = file.ReadLine()) != null)
                {
                    pairs = line.Split(',');
                    Orders.Push(pairs[1]);
                }
                file.Close();
                pictureBox2.Visible = true; //Not necessary
            }
            catch (Exception exc) 
            { 
                MessageBox.Show(exc.Message); 
                pictureBox2.Visible = false; //Not necessary
            }
        }
    }
}