using CsvHelper;
using FinalProject.BL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DL
{
    public class SupplierDL
    {

        private SupplierNode root;

        public SupplierNode Root { get => root; set => root = value; }
        public SupplierDL()
        {
            Root = null;
        }

        public void insert(SupplierBL val, SupplierNode p)
        {
            if (p == null)
                return;
            if (val.Id < p.Data.Id)
            {
                if (p.Left == null)
                    p.Left = new SupplierNode(val);
                else
                    insert(val, p.Left);
            }
            else
            {
                if (p.Right == null)
                    p.Right = new SupplierNode(val);
                else
                    insert(val, p.Right);
            }
        }
        public void insert(SupplierBL val)
        {
            if (Root == null)
            {
                Root = new SupplierNode(val);
                return;
            }
            else
                insert(val, Root);
        }
        public SupplierBL search(int id)
        {
            SupplierNode temp = Root;
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
        public SupplierNode Search(SupplierBL emp)
        {
            SupplierNode temp = Root;
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
        public bool CheckData(SupplierBL emp)
        {
            SupplierNode temp = Root;
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
       
        public void Remove(SupplierBL key)
        {
            RemoveHelper(Root, key);
        }
        public SupplierNode RemoveHelper(SupplierNode temp, SupplierBL key)
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
        public SupplierNode FindMax(SupplierNode node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        public bool Update(SupplierBL emp)
        {
            SupplierNode node = Search(emp);
            if (node == null)
            {
                return false;
            }
            node.Data = emp;
            return true;


        }
        public void ListtoTree(List<SupplierBL> SupplierLists)
        {
            foreach (SupplierBL sup in SupplierLists)
            {
                insert(sup);

            }
        }

        public List<SupplierBL> Inorder(SupplierNode node, ref List<SupplierBL> list)
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
        public List<SupplierBL> TreetoList()
        {
            List<SupplierBL> SupplierLists = new List<SupplierBL>();
            if (Root == null)
            {
                return SupplierLists;
            }
            return Inorder(Root, ref SupplierLists);

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
                        string PHONE = splittedrecord[2];
                        int Id = int.Parse(splittedrecord[3]);

                        SupplierBL sh = new SupplierBL(NAME, CNIC, PHONE, Id);
                        insert(sh);
                    }

                    count++;
                }
                file.Close();
                return true;
            }
            return false;

        }
        public void storeInFile(string path, List<SupplierBL> SupplierLists)
        {
            var writer = new StreamWriter(path);
            var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);

            csvWriter.WriteField("Name");
            csvWriter.WriteField("Cnic");
            csvWriter.WriteField("Phone");
            csvWriter.WriteField("ID");

            csvWriter.NextRecord();

            foreach (var user in SupplierLists)
            {
                csvWriter.WriteField(user.Name);
                csvWriter.WriteField(user.Cnic);
                csvWriter.WriteField(user.Phone);
                csvWriter.WriteField(user.Id);
                csvWriter.NextRecord();
            }

            writer.Flush();
            writer.Close();

        }
    }
}
