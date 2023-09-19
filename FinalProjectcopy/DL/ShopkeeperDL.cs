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
    public class ShopkeeperDL
    {


        private ShopkeeperNode root;

        public ShopkeeperNode Root { get => root; set => root = value; }
        public ShopkeeperDL()
        {
            Root = null;
        }

        public void insert(ShopkeeperBL val, ShopkeeperNode p)
        {
            if (p == null)
                return;
            if (val.Id < p.Data.Id)
            {
                if (p.Left == null)
                    p.Left = new ShopkeeperNode(val);
                else
                    insert(val, p.Left);
            }
            else
            {
                if (p.Right == null)
                    p.Right = new ShopkeeperNode(val);
                else
                    insert(val, p.Right);
            }
        }
        public void insert(ShopkeeperBL val)
        {
            if (Root == null)
            {
                Root = new ShopkeeperNode(val);
                return;
            }
            else
                insert(val, Root);
        }
        public ShopkeeperBL search(int id)
        {
            ShopkeeperNode temp = Root;
            if (temp == null)
            {
                return null;
            }
            while (temp != null)
            {
                if (temp.Data.Id == id)
                {
                    return temp.Data;
                }
                if (temp.Data.Id > id)
                {
                    temp = temp.Left;
                }
                else
                {
                    temp = temp.Right;
                }
            }
            return null;
        }
        public ShopkeeperNode Search(ShopkeeperBL emp)
        {
            ShopkeeperNode temp = Root;
            if (temp == null)
            {
                return null;
            }
            while (temp != null)
            {
                if (temp.Data.Id == emp.Id)
                {
                    return temp;
                }
                if (temp.Data.Id > emp.Id)
                {
                    temp = temp.Left;
                }
                else
                {
                    temp = temp.Right;
                }
            }
            return null;
        }
        public bool CheckData(ShopkeeperBL emp)
        {
            ShopkeeperNode temp = Root;
            if (temp == null)
            {
                return false;
            }
            while (temp != null)
            {
                if (temp.Data.Cnic == emp.Cnic)
                {
                    return true;
                }
                if (temp.Data.Id > emp.Id)
                {
                    temp = temp.Left;
                }
                else
                {
                    temp = temp.Right;
                }
            }
            return false;
        }
        /* public bool CheckVisibility(int Id)
         {
             VehicleNode temp = Root;
             if (temp == null)
             {
                 return false;
             }
             while (temp != null)
             {
                 if (temp.Data.Id == Id)
                 {
                     return temp.Data.Status;
                 }
                 if (temp.Data.Id > Id)
                 {
                     temp = temp.Left;
                 }
                 else
                 {
                     temp = temp.Right;
                 }
             }
             return false;
         }*/
        public void Remove(ShopkeeperBL key)
        {
            RemoveHelper(Root, key);
        }
        public ShopkeeperNode RemoveHelper(ShopkeeperNode temp, ShopkeeperBL key)
        {

            if (temp == null)
                return temp;
            //if key is less than the root node,recurse left subtree
            if (key.Id < temp.Data.Id)
                temp.Left = RemoveHelper(temp.Left, key);
            // if key is more than the root node,recurse right subtree
            else if (key.Id > temp.Data.Id)
            {
                temp.Right = RemoveHelper(temp.Right, key);
            }

            //else we found the key
            else
            {
                //case 1: Node to be deleted has no children
                if (temp.Left == null && temp.Right == null)
                {
                    //update root to null
                    temp = null;
                }
                //case 2 : node to be deleted has two children
                else if (temp.Left != null && temp.Right != null)
                {
                    var maxNode = FindMax(temp.Right);
                    //copy the value
                    temp.Data = maxNode.Data;
                    temp.Right = RemoveHelper(temp.Right, maxNode.Data);
                }
                //node to be deleted has one children
                else
                {
                    var child = temp.Left != null ? temp.Left : temp.Right;
                    temp = child;
                }

            }


            return temp;

        }
        public ShopkeeperNode FindMax(ShopkeeperNode node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        public bool Update(ShopkeeperBL emp)
        {
            ShopkeeperNode node = Search(emp);
            if (node == null)
            {
                return false;
            }
            node.Data = emp;
            return true;


        }
        public void ListtoTree(List<ShopkeeperBL> ShopLists)
        {
            foreach (ShopkeeperBL sh in ShopLists)
            {
                insert(sh);

            }
        }

        public List<ShopkeeperBL> Inorder(ShopkeeperNode node, ref List<ShopkeeperBL> list)
        {
            if (node == null)
            {
                return list;
            }
            Inorder(node.Left, ref list);
            list.Add(node.Data);
            Inorder(node.Right, ref list);
            return list;
        }
        public List<ShopkeeperBL> TreetoList()
        {
            List<ShopkeeperBL> ShopLists = new List<ShopkeeperBL>();
            if (Root == null)
            {
                return ShopLists;
            }
            return Inorder(Root, ref ShopLists);

        }

        public bool read(string path)
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
                        string NAME = splittedrecord[0];
                        string CNIC = splittedrecord[1];
                        string AREA = splittedrecord[2];
                        string PHONE = splittedrecord[3];
                        string LOCATION = splittedrecord[4];
                        int Id = int.Parse(splittedrecord[5]);

                        ShopkeeperBL sh = new ShopkeeperBL(NAME, CNIC, AREA, PHONE, LOCATION, Id);
                        insert(sh);
                    }

                    count++;
                }
                file.Close();
                return true;
            }
            return false;

        }
        public void storeInFile(string path, List<ShopkeeperBL> ShopLists)
        {
            var writer = new StreamWriter(path);
            var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);

            csvWriter.WriteField("Name");
            csvWriter.WriteField("Cnic");
            csvWriter.WriteField("Area");
            csvWriter.WriteField("Phone");
            csvWriter.WriteField("Location");
            csvWriter.WriteField("ID");

            csvWriter.NextRecord();

            foreach (var user in ShopLists)
            {
                csvWriter.WriteField(user.Name);
                csvWriter.WriteField(user.Cnic);
                csvWriter.WriteField(user.Area);
                csvWriter.WriteField(user.Phone);
                csvWriter.WriteField(user.Location);
                csvWriter.WriteField(user.Id);
                csvWriter.NextRecord();
            }

            writer.Flush();
            writer.Close();

        }
    }
}
