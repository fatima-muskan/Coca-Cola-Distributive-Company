using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using FinalProject.BL;

namespace FinalProject.DL
{
    public class StockDL
    {
        public static List<Stock> stocklist = new List<Stock>();
        public static bool read(string path)
        {
            StreamReader file = new StreamReader(path);

            if (File.Exists(path))
            {
                int count = 0;
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    if (count != 0)
                    {
                        string[] splittedrecord = record.Split(',');
                        string type = splittedrecord[0];
                        int size = int.Parse(splittedrecord[1]);
                        int quantitytotal = int.Parse(splittedrecord[2]);
                        int quantity = int.Parse(splittedrecord[3]);
                        int quantityextract = int.Parse(splittedrecord[4]);
                        Stock s = new Stock(type, size,quantitytotal, quantity,quantityextract);
                        stocklist.Add(s);
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
            var writer = new StreamWriter(path);
            var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);

            csvWriter.WriteField("Type");
            csvWriter.WriteField("Size");
            csvWriter.WriteField("Total");
            csvWriter.WriteField("Update");
            csvWriter.WriteField("Remove");
            csvWriter.NextRecord();

            foreach (var user in stocklist)
            {
                csvWriter.WriteField(user.Type);
                csvWriter.WriteField(user.Size);
                csvWriter.WriteField(user.TotalQuantity);
                csvWriter.WriteField(user.QuantityUpdate);
                csvWriter.WriteField(user.QuantityRemove);
                csvWriter.NextRecord();
            }

            writer.Flush();
            writer.Close();
        }

        public static void add(Stock s)
        {

        }
        public static int search(string type,int size)
        {
            foreach(Stock s in stocklist)
            {
                if(s.Type==type && s.Size==size)
                {
                    return s.QuantityUpdate;
                }

            }
            return 0;
        }

        public static int Total(string type, int size)
        {
            foreach (Stock s in stocklist)
            {
                if (s.Type == type && s.Size == size)
                {
                    return s.TotalQuantity;
                }

            }
            return 0;
        }

    
    public static bool extract(Stock st)
        {
            foreach (Stock s in stocklist)
            {
                if (s.Type == st.Type && s.Size == st.Size)
                {
                    st.QuantityUpdate = s.QuantityUpdate - st.QuantityRemove;

                    st.QuantityRemove=s.QuantityRemove+st.QuantityRemove;
                    return true;
                }

            }
            return false;
        }
        public static void update(Stock st)
        {
            foreach (Stock s in stocklist)
            {
                if (s.Type == st.Type && s.Size == st.Size)
                {
                    s.TotalQuantity = st.TotalQuantity;
                    s.QuantityRemove = st.QuantityRemove;
                    s.QuantityUpdate = st.QuantityUpdate;
                    
                }

            }
            storeInFile("Stock.csv");
        }
    }
}
