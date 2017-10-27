using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.IO;
using System.Threading;

namespace HostSimulator
{
    public partial class ErrLimit : Form
    {
        ServiceHost host;
        //ServiceHost.TextUpdater = ShowMessageBox;
        public ErrLimit()
        {
            InitializeComponent();

            HostService.TextUpdater = ShowMessageBox;
            
            string path = @"MyTest.txt";
            try
            {

                // Delete the file if it exists.
                if (File.Exists(path))
                {
                    // Note that no lock is put on the
                    // file and the possibility exists
                    // that another process could do
                    // something with it between
                    // the calls to Exists and Delete.
                    File.Delete(path);
                }
            }
            catch (Exception ex)
            {

            }

            TransactionsList.EnableHeadersVisualStyles = false;
            TransactionsList.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;


            MyUpdater up = new MyUpdater();
            up.indata = "indata";

            Thread t1 = new Thread(new ThreadStart(up.Worker));
            t1.IsBackground = true;
            t1.Start();

        }

        public void ShowMessageBox(object sender, UpdateTextEventArgs e)
        {
            char[] delimiterChars = { ','};
            // Use Invoke() to make sure the UI interaction happens
            // on the UI thread...just in case this delegate is
            // invoked on another thread.
            Invoke((MethodInvoker)delegate
            {
                if (e.Text.Contains("TRX:"))
                {
                    string[] words = e.Text.Split(delimiterChars);
                    //find the correct line
                    String searchValue = words[1];
                    int rowIndex = -1;
                    foreach (DataGridViewRow row in TransactionsList.Rows)
                    {
                        if (row.Cells[4].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }
                    if (rowIndex != -1)
                    {
                        //update the row with additional data
                        TransactionsList.Rows[rowIndex].Cells[5].Value = "Completed";
                        TransactionsList.Rows[rowIndex].Cells[6].Value = words[2];
                        TransactionsList.Rows[rowIndex].Cells[7].Value = words[3];
                        TransactionsList.Rows[rowIndex].Cells[8].Value = words[4];
                    }
                }
                else
                if (e.Text.Contains("AUTH:"))
                {
                    string[] words = e.Text.Split(delimiterChars);
                    //fill the GUI
                    CardNumber.Text = words[1];
                    StationCode.Text = words[2];
                    Message.Text = "Got autorization request...";
                }
                else
                    CardNumber.Text = e.Text;
                //MessageBox.Show(e.Text);
            });
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            TransactionsList.Rows.Clear();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string path = @"MyTest.txt";
            try
            {

                // Delete the file if it exists.
                if (File.Exists(path))
                {
                    // Note that no lock is put on the
                    // file and the possibility exists
                    // that another process could do
                    // something with it between
                    // the calls to Exists and Delete.
                    File.Delete(path);
                }

                // Create the file.
                string Ref = GenReference();
                using (FileStream fs = File.Create(path))
                {

                    if (OK.Checked)
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes("true");
                        fs.Write(info, 0, info.Length);
                        info = new UTF8Encoding(true).GetBytes(",");
                        fs.Write(info, 0, info.Length);

                        info = new UTF8Encoding(true).GetBytes(GetErrorDesc());
                        fs.Write(info, 0, info.Length);
                        info = new UTF8Encoding(true).GetBytes(",");
                        fs.Write(info, 0, info.Length);

                        info = new UTF8Encoding(true).GetBytes(Ref);
                        fs.Write(info, 0, info.Length);
                        info = new UTF8Encoding(true).GetBytes(",");
                        fs.Write(info, 0, info.Length);

                        info = new UTF8Encoding(true).GetBytes(DriverName.Text);
                        fs.Write(info, 0, info.Length);
                        info = new UTF8Encoding(true).GetBytes(",");
                        fs.Write(info, 0, info.Length);

                        info = new UTF8Encoding(true).GetBytes(Limit.Text);
                        fs.Write(info, 0, info.Length);
                        info = new UTF8Encoding(true).GetBytes(",");
                        fs.Write(info, 0, info.Length);

                        string LimitType = "Volume";
                        if (Money.Checked)
                            LimitType = "Money";


                        info = new UTF8Encoding(true).GetBytes(LimitType);
                        fs.Write(info, 0, info.Length);
                        info = new UTF8Encoding(true).GetBytes(",");
                        fs.Write(info, 0, info.Length);
                    }
                    else
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes("false");
                        fs.Write(info, 0, info.Length);
                        info = new UTF8Encoding(true).GetBytes(",");
                        fs.Write(info, 0, info.Length);

                        info = new UTF8Encoding(true).GetBytes(GetErrorDesc());
                        fs.Write(info, 0, info.Length);
                        info = new UTF8Encoding(true).GetBytes(",");
                        fs.Write(info, 0, info.Length);

                        info = new UTF8Encoding(true).GetBytes(Ref);
                        fs.Write(info, 0, info.Length);
                    }
                }
                TransactionsList.Rows.Add(DateTime.Now,CardNumber.Text,DriverName.Text,StationCode.Text,Ref,GetErrorDesc());

                Message.Text = "Waiting for authorization request...";
                
                CardNumber.Text = "";
                StationCode.Text = "";
                


            }

            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
            }
        }

        public string GetErrorDesc()
        {
            string err = "";

            if (OK.Checked) err = "OK";
            if (ErrStation.Checked) err = "Not allowed in this station";
            if (ErrLim.Checked) err = "Out of limit";
            if  (ErrUnknown.Checked) err = "Unknown card";
            if (ErrTime.Checked) err = "Not allowed at this time";
            if (ErrProduct.Checked) err = "Product not allowed";

            return err;
        }

        public String GenReference()
        {            
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return finalString;

        }
    }
}
