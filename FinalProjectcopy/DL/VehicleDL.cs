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
    public class VehicleDL
    {

        private VehicleNode root;

        public VehicleNode Root { get => root; set => root = value; }
        public VehicleDL()
        {
            Root = null;
        }

        public void insert(VehcleBL val, VehicleNode p)
        {
            if (p == null)
                return;
            if (val.Id < p.Data.Id)
            {
                if (p.Left == null)
                    p.Left = new VehicleNode(val);
                else
                    insert(val, p.Left);
            }
            else
            {
                if (p.Right == null)
                    p.Right = new VehicleNode(val);
                else
                    insert(val, p.Right);
            }
        }
        public void insert(VehcleBL val)
        {
            if (Root == null)
            {
                Root = new VehicleNode(val);
                return;
            }
            else
                insert(val, Root);
        }
        public VehcleBL search(int id)
        {
            VehicleNode temp = Root;
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
        public VehicleNode Search(VehcleBL emp)
        {
            VehicleNode temp = Root;
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
        public bool CheckData(VehcleBL emp)
        {
            VehicleNode temp = Root;
            if (temp == null)
            {
                return false;
            }
            while (temp != null)
            {
                if (temp.Data.Number == emp.Number)
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
        public void Remove(VehcleBL key)
        {
            RemoveHelper(Root, key);
        }
        public VehicleNode RemoveHelper(VehicleNode temp, VehcleBL key)
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
        public VehicleNode FindMax(VehicleNode node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        public bool Update(VehcleBL emp)
        {
            VehicleNode node = Search(emp);
            if (node == null)
            {
                return false;
            }
            node.Data = emp;
            return true;


        }
        public void ListtoTree(List<VehcleBL> VehicleLists)
        {
            foreach (VehcleBL vehicle in VehicleLists)
            {
                insert(vehicle);

            }
        }

        public List<VehcleBL> Inorder(VehicleNode node, ref List<VehcleBL> list)
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
        public List<VehcleBL> TreetoList()
        {
            List<VehcleBL> VehicleLists = new List<VehcleBL>();
            if (Root == null)
            {
                return VehicleLists;
            }
            return Inorder(Root, ref VehicleLists);

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
                        string NUMBER = splittedrecord[0];
                        bool STATUS = bool.Parse(splittedrecord[1]);
                        int FUEL = int.Parse(splittedrecord[2]);
                        int Id = int.Parse(splittedrecord[3]);

                        VehcleBL Vehicle = new VehcleBL(NUMBER,STATUS,FUEL,Id);
                        insert(Vehicle);
                    }

                    count++;
                }
                file.Close();
                return true;
            }
            return false;

        }
        public void storeInFile(string path, List<VehcleBL> VehicleLists)
        {
            var writer = new StreamWriter(path);
            var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);

            csvWriter.WriteField("Number");
            csvWriter.WriteField("Status");
            csvWriter.WriteField("Fuel");
            csvWriter.WriteField("ID");
            
            csvWriter.NextRecord();

            foreach (var user in VehicleLists)
            {
                csvWriter.WriteField(user.Number);
                csvWriter.WriteField(user.Status);
                csvWriter.WriteField(user.Fuel);
                csvWriter.WriteField(user.Id);
                csvWriter.NextRecord();
            }

            writer.Flush();
            writer.Close();

        }
    }
}
