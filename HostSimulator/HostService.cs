using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;
using System.IO;


namespace HostSimulator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HostService" in both code and config file together.
    public class HostService : IHostService
    {
        char[] delimiterChars = { ',' };
        public string DoWork(string indata)
        {
            // Invoke the delegate here.
            string databack = "Error";
            try
            {

                UpdateTextDelegate handler = TextUpdater;
                if (handler != null)
                {
                    handler(this, new UpdateTextEventArgs(indata));
                }
                
                //now wait for file to be created
                string curFile = @"MyTest.txt";
                while (!File.Exists(curFile))
                {
                    Thread.Sleep(10);
                }
                //read file data - answer of service
                try
                {
                 
                    // Open the stream and read it back.
                    using (StreamReader sr = File.OpenText(curFile))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            //Console.WriteLine(s);
                            databack = s;
                        }
                    }

                    File.Delete(curFile);
                }

                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                }
                 
            }
            catch
            {
            }
            return databack;
        }


        public AuthResult GetAuth(string card, string stationcode)
        {
                AuthResult res = new AuthResult(); // { Allowed = true, DriverName = "Ofer" };
                res.Allowed = false;
                res.ErrorDesc = "Exception";

                UpdateTextDelegate handler = TextUpdater;
                if (handler != null)
                {
                    handler(this, new UpdateTextEventArgs("AUTH:,"+card+","+stationcode));
                }
                
                //now wait for file to be created
                string curFile = @"MyTest.txt";
                while (!File.Exists(curFile))
                {
                    Thread.Sleep(10);
                }
                //read file data - answer of service
                try
                {
                 
                    // Open the stream and read it back.
                    using (StreamReader sr = File.OpenText(curFile))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            //Console.WriteLine(s);
                            //break the line to tokens
                            string[] words = s.Split(delimiterChars);

                            if (words[0] == "false")
                            {
                                res.Allowed = false;
                                res.ErrorDesc = words[1];
                                res.Reference = words[2];
                            }
                            else
                            {
                                res.Allowed = true;
                                res.ErrorDesc = words[1];
                                res.Reference = words[2];

                                res.DriverName = words[3];

                                res.Limit = double.Parse(words[4]);
                                res.LimitType = words[4];
                               
                                res.ProductsList.Add(new ProductItem());

                                res.ProductsList[0].Code = 103;
                                res.ProductsList[0].Discount = 5;
                                res.ProductsList[0].DiscountType = "Abs";

                                res.ProductsList.Add(new ProductItem());

                                res.ProductsList[1].Code = 101;
                                res.ProductsList[1].Discount = 5;
                                res.ProductsList[1].DiscountType = "%";
                            }
                        }
                    }

                    File.Delete(curFile);
                    return res;
                }

                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                    res.ErrorDesc = ex.Message;
                    return res;
                }
                 
            }
            
        
        public TransactionCompleteResult TransactionComplete(string referece, double amount, double volume, int ProductCode, DateTime datetime)
        {
            TransactionCompleteResult res = new TransactionCompleteResult();

            res.Recived = true;
            res.ErrorDesc = "OK";

            UpdateTextDelegate handler = TextUpdater;
            if (handler != null)
            {
                handler(this, new UpdateTextEventArgs("TRX:,"+referece+","+amount.ToString()+","+volume.ToString()+","+ProductCode.ToString()+","));
            }

            return res;
        }


        public static UpdateTextDelegate TextUpdater { get; set; }

        
    }

    public delegate void UpdateTextDelegate(object sender, UpdateTextEventArgs e);

    public class UpdateTextEventArgs
    {
        public string Text { get; set; }
        public UpdateTextEventArgs(string text)
        {
            Text = text;
        }
    }

    

    
}
