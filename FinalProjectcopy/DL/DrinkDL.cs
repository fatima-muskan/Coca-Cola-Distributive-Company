using CsvHelper;
using FinalProject.BL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DL
{
    public class DrinkDL
    {
        public static List<Drink> DrinkList = new List<Drink>();

        public static void addDrinktolist(Drink or)
        {
          DrinkList.Add(or);
        }

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
                        int quantity = int.Parse(splittedrecord[2]);
                        Drink d = new Drink(type,size,quantity);
                        addDrinktolist(d);
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
            csvWriter.WriteField("Quantity");
            csvWriter.NextRecord();

            foreach (var user in DrinkList)
            {
                csvWriter.WriteField(user.Type);
                csvWriter.WriteField(user.Size);
                csvWriter.WriteField(user.Quantity);
                csvWriter.NextRecord();
            }

            writer.Flush();
            writer.Close();
        }
        public static Drink Search(string type,int size)
        {
            foreach(Drink d in DrinkList)
            {
                if(d.Type==type && d.Size==size)
                {
                    return d;
                }
               
            }
            return null;
        }
        public static void deletedata(Drink d)
        {
            for (int index = 0; index < DrinkList.Count; index++)
            {
                if (DrinkList[index].Type == d.Type && DrinkList[index].Size == d.Size)
                {
                    DrinkList.RemoveAt(index);
                }
            }
        }
        public static void ADDInstock(Drink d)
        {
            Drink drink = Search(d.Type, d.Size);
            if (drink != null)
            {
                d.Quantity = drink.Quantity+d.Quantity;
                Drink de = new Drink(d.Type, d.Size, d.Quantity);
                deletedata(d);
                DrinkList.Add(de);
            }
            if(drink==null)
            {
                DrinkList.Add(d);
            }
            storeInFile("Stock.csv");
        }
        public static bool ExtractItem(Drink d)
        {
            foreach (Drink dr in DrinkList)
            {
                if (dr.Type == d.Type && dr.Size == d.Size && dr.Quantity>=d.Quantity )

                {
                    dr.Type = d.Type;
                    dr.Size = d.Size;
                    dr.Quantity = dr.Quantity - d.Quantity;
                    storeInFile("Stock.csv");
                    return true;
                }

            }
            return false;
        }
        public static bool ADDItem(Drink d)
        {
            foreach (Drink dr in DrinkList)
            {
                if (dr.Type == d.Type && dr.Size == d.Size)

                {
                    dr.Type = d.Type;
                    dr.Size = d.Size;
                    dr.Quantity = dr.Quantity + d.Quantity;
                    storeInFile("Stock.csv");
                    return true;
                }

            }
            return false;
        }
    }
}
