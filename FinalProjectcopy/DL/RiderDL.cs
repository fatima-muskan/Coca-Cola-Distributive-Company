using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CsvHelper;
using FinalProject.BL;

namespace FinalProject.DL
{
    public class RiderDL
    {
        private RiderNode root;

        public RiderNode Root { get => root; set => root = value; }
        public RiderDL()
        {
            Root = null;
        }

        public void insert(RiderBL val, RiderNode p)
        {
            if (p == null)
                return;
            if (val.Id < p.Data.Id)
            {
                if (p.Left == null)
                    p.Left = new RiderNode(val);
                else
                    insert(val, p.Left);
            }
            else
            {
                if (p.Right == null)
                    p.Right = new RiderNode(val);
                else
                    insert(val, p.Right);
            }
        }
        public void insert(RiderBL val)
        {
            if (Root == null)
            {
                Root = new RiderNode(val);
                return;
            }
            else
                insert(val, Root);
        }
        public RiderBL search(int id)
        {
            RiderNode temp = Root;
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
        public RiderNode Search(RiderBL emp)
        {
            RiderNode temp = Root;
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
        public bool CheckData(RiderBL emp)
        {
            RiderNode temp = Root;
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
        public void Remove(RiderBL key)
        {
            RemoveHelper(Root, key);
        }
        public RiderNode RemoveHelper(RiderNode temp, RiderBL key)
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
        public RiderNode FindMax(RiderNode node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        public bool Update(RiderBL emp)
        {
            RiderNode node = Search(emp);
            if (node == null)
            {
                return false;
            }
            node.Data = emp;
            return true;


        }
        public void ListtoTree(List<RiderBL> RiderLists)
        {
            foreach (RiderBL rider in RiderLists)
            {
                insert(rider);

            }
        }

        public List<RiderBL> Inorder(RiderNode node, ref List<RiderBL> list)
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
        public List<RiderBL> TreetoList()
        {
            List<RiderBL> RiderLists = new List<RiderBL>();
            if (Root == null)
            {
                return RiderLists;
            }
            return Inorder(Root, ref RiderLists);

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
                        string Name = splittedrecord[0];
                        string cnic = splittedrecord[1];
                        string email = splittedrecord[2];
                        int salary = int.Parse(splittedrecord[3]);

                        string dob = splittedrecord[4];
                        string phone = splittedrecord[5];

                        string password = splittedrecord[6];
                        string role = splittedrecord[7];
                        int Id = int.Parse(splittedrecord[8]);
                        string Area = splittedrecord[9];
                        int VehicleId = int.Parse(splittedrecord[10]);
                        RiderBL rider = new RiderBL(Name, cnic, email, salary, dob, phone, password, role, Id, VehicleId, Area);
                        insert(rider);
                    }

                    count++;
                }
                file.Close();
                return true;
            }
            return false;

        }
        public void storeInFile(string path, List<RiderBL> RiderLists)
        {
            var writer = new StreamWriter(path);
            var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);

            csvWriter.WriteField("Name");
            csvWriter.WriteField("Cnic");
            csvWriter.WriteField("Email");
            csvWriter.WriteField("Salary");
            csvWriter.WriteField("DOB");
            csvWriter.WriteField("Phone");
            csvWriter.WriteField("Password");
            csvWriter.WriteField("Role");
            csvWriter.WriteField("Id");
            csvWriter.WriteField("Area");
            csvWriter.WriteField("VehicleId");
            csvWriter.NextRecord();

            foreach (var user in RiderLists)
            {
                csvWriter.WriteField(user.Name);
                csvWriter.WriteField(user.Cnic);
                csvWriter.WriteField(user.Email);
                csvWriter.WriteField(user.Salary);
                csvWriter.WriteField(user.DOB);
                csvWriter.WriteField(user.Phone);
                csvWriter.WriteField(user.Password);
                csvWriter.WriteField(user.Role);
                csvWriter.WriteField(user.Id);
                csvWriter.WriteField(user.Area);
                csvWriter.WriteField(user.VehicleID);
                csvWriter.NextRecord();
            }

            writer.Flush();
            writer.Close();

        }

    }
}    
