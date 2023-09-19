using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using FinalProject.BL;
using System.Globalization;
using System.Xml.Linq;

namespace FinalProject.DL
{

    public class EmployeeDL
    {
        private EmployeeNode root;

        public EmployeeNode Root { get => root; set => root = value; }
        public EmployeeDL()
        {
            Root = null;
        }

        public void insert(EmployeeBL val, EmployeeNode p)
        {
            if (p == null)
                return;
            if (val.Id < p.Data.Id)
            {
                if (p.Left == null)
                    p.Left = new EmployeeNode(val);
                else
                    insert(val, p.Left);
            }
            else
            {
                if (p.Right == null)
                    p.Right = new EmployeeNode(val);
                else
                    insert(val, p.Right);
            }
        }
        public void insert(EmployeeBL val)
        {
            if (Root == null)
            {
                Root = new EmployeeNode(val);
                return;
            }
            else
                insert(val, Root);
        }
        public EmployeeBL search(int id)
        {
            EmployeeNode temp = Root;
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
        public EmployeeNode Search(EmployeeBL emp)
        {
            EmployeeNode temp = Root;
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
        public bool CheckData(EmployeeBL emp)
        {
            EmployeeNode temp = Root;
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
        public void Remove(EmployeeBL key)
        {
            RemoveHelper(Root, key);
        }

        public EmployeeNode RemoveHelper(EmployeeNode root, EmployeeBL key)
        {

            if (root == null)
                return root;
            if (key.Id < root.Data.Id)
                root.Left = RemoveHelper(root.Left, key);
            else if (key.Id > root.Data.Id)
            {
                root.Right = RemoveHelper(root.Right, key);
            }
            else
            {
                if (root.Left == null && root.Right == null)
                {
                    root = null;
                }
                else if (root.Left != null && root.Right != null)
                {
                    var maxNode = FindMax(root.Right);
                    root.Data = maxNode.Data;
                    root.Right = RemoveHelper(root.Right, maxNode.Data);
                }
                else
                {
                    var child = root.Left != null ? root.Left : root.Right;
                    root = child;
                }

            }
            return root;
        }
        public EmployeeNode FindMax(EmployeeNode node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        public bool Update(EmployeeBL emp)
        {
            EmployeeNode node = Search(emp);
            if (node == null)
            {
                return false;
            }
            node.Data = emp;
            return true;


        }

       
        public void ListtoTree(List<EmployeeBL> EmployeeLists)
        {
            foreach (EmployeeBL emp in EmployeeLists)
            {
                insert(emp);

            }
        }

        public List<EmployeeBL> Inorder(EmployeeNode node, ref List<EmployeeBL> list)
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
        public List<EmployeeBL> TreetoList()
        {
            List<EmployeeBL> EmployeeLists = new List<EmployeeBL>();
            if (Root == null)
            {
                return EmployeeLists;
            }
            return Inorder(Root, ref EmployeeLists);

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
                        EmployeeBL emp = new EmployeeBL(Name, cnic, email, salary, dob, phone, password, role, Id);
                        insert(emp);
                    }

                    count++;
                }
                file.Close();
                return true;
            }
            return false;

        }
        public void storeInFile(string path, List<EmployeeBL> EmployeeLists)
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
            csvWriter.NextRecord();

            foreach (var user in EmployeeLists)
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
                csvWriter.NextRecord();
            }

            writer.Flush();
            writer.Close();
        }
    }
}
