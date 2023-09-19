using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using FinalProject.BL;

namespace FinalProject.DL
{
    public class OrderDL
    {
        public static List<Orders> OrderList = new List<Orders>();

        public static void addOrdertolist(Orders or)
        {
            OrderList.Add(or);
        }
        public static bool read(string path)
        {
            StreamReader file = new StreamReader(path);

            if (File.Exists(path))
            {
                int count = 0;
                int st=0;
                string record;
                List<Drink> list = new List<Drink>();
                while ((record = file.ReadLine()) != null)
                {
                    if (count != 0)
                    {
                        string[] splittedrecord = record.Split(',');
                        
                        bool Payment = bool.Parse(splittedrecord[0]);
                        int Idorder = int.Parse(splittedrecord[1]);
                        int Iddeliver = int.Parse(splittedrecord[2]);
                        string[] Drinks = (splittedrecord[3]).Split(';');
                        
                        for(int i=0;i<Drinks.Length;i=i+3)
                        {
                            Drink n = new Drink(Drinks[i], int.Parse(Drinks[i + 1]), int.Parse(Drinks[i + 2]));
                            list.Add(n);
                        
                        }
                        Orders or = new Orders(list,Payment,Idorder,Iddeliver);
                        addOrdertolist(or);
                    }

                    count++;
                }
                file.Close();
                return true;
            }
            return false;

        }
        public static void storeInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Orders or in OrderList)
            {
                string temp = "";
                foreach (Drink d in or.Dinks) 
                {
                    temp = temp + (";" + d.Type + ";" + d.Size + ";" + d.Quantity).ToString();
                }
                file.WriteLine(or.Payment + "," + or.IDOrder1 + "," + or.IDDeliver1+temp);

            }

            file.Flush();
            file.Close();

        }
      /*  public static void storeInFile(string path)
        {
            var writer = new StreamWriter(path);
            var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);

            csvWriter.WriteField("Payment");
            csvWriter.WriteField("Id order");
            csvWriter.WriteField("Id Deliver");
            csvWriter.WriteField("Order");
            csvWriter.NextRecord();

            foreach (var user in OrderList)
            {
                csvWriter.WriteField(user.Payment);
                csvWriter.WriteField(user.IDOrder1);
                csvWriter.WriteField(user.IDDeliver1);
                string temp = "";
                foreach (Drink item in user.Dinks)
                {                    
                    temp=temp+(";"+item.Type + ";" + item.Size + ";" + item.Quantity ).ToString();
                }
                csvWriter.WriteField(temp);


                csvWriter.NextRecord();
            }

            writer.Flush();
            writer.Close();

        }*/
    }
}
