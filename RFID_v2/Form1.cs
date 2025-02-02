﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RFID_v2
{

    public partial class Form1 : Form
    {
        SerialPort serialPort = null;
        const int BAUDRATE= 4800;
        DataTable dt;
        List<string> listTag;
        List<Student> listStudent;
        string rxData = "";
        public Form1()
        {
            InitializeComponent();
            listTag = new List<string>();
            dt = new DataTable();
            listStudent = new List<Student>();
            dt.Columns.Add("RFID Tag");
            dt.Columns.Add("Student ID");
            dt.Columns.Add("Name");
            dgvLog.DataSource = dt;
            string[] listPort = SerialPort.GetPortNames();
            if (listPort != null)
            {
                cbCom.Items.AddRange(listPort);
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            serialPort = new SerialPort();
            serialPort.PortName = cbCom.Text;
            serialPort.BaudRate =BAUDRATE;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.Parity = Parity.None;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            serialPort.Open();
            btStart.Enabled = false;
          //  serialPort.Write("abc");
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            rxData += sp.ReadExisting();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            serialPort.Write("a");
        }

        private void btShow_Click(object sender, EventArgs e)
        {
#if DEBUG
            rxData = "1234123411\n1234123412\n1234123413\n1234123414\n";
#endif
            Console.WriteLine(rxData);
            Console.WriteLine("size:" + rxData.Length);
            for(int i = 0; i < rxData.Length; i++)
            {
                if (rxData[i] == '\n')
                {
                    string x = rxData.Substring(i-10,10);
                    if (!x.Contains("FFFFF")) listTag.Add(x);
                }
            }
            Console.WriteLine("size:" + listTag.Count());
            readFileDB(tbPath.Text);
            foreach (var item in listStudent)
            { 
                DataRow row = dt.NewRow();
                row["RFID Tag"] = item.RfidTag;
                row["Student ID"] = item.StudentID;
                row["Name"] = item.StudentName;
                dt.Rows.InsertAt(row, 0);
                
            }
        }

        private void readFileDB(string text)
        {
            string[] readText = File.ReadAllLines(text);
            foreach (string s in readText)
            {
               for(int i = 0; i < listTag.Count; i++)
                {
                    if (s.Contains(listTag[i])){
                        addStudent(s);
                        break;
                    }
                }
            }
        }

        private void addStudent(string s)
        {
            string idTag = s.Substring(0,10);
            Console.WriteLine(idTag);
            int index = s.LastIndexOf(',');
            string idStudent = s.Substring(11,index-11);
            string name = s.Substring(index+1, s.Length - index-1);
            Console.WriteLine(name+"  "+idStudent);
            listStudent.Add(new Student(idTag, idStudent, name));
        }

        static DataTable ConvertToDataTable<T>(List<T> models)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Loop through all the properties            
            // Adding Column to our datatable
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names  
                dataTable.Columns.Add(prop.Name);
            }
            // Adding Row
            foreach (T item in models)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows  
                    values[i] = Props[i].GetValue(item, null);
                }
                // Finally add value to datatable  
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            if(tbFileName.Text =="" ||tbFolder.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nơi lưu file!");
                return;
            }
            string customPathFile = tbFolder.Text + tbFileName.Text;
#if DEBUG
            var studentList = new List<Student> {
                new Student
                {
                    RfidTag = listTag[0],
                    StudentID = "20162385",
                    StudentName = "Dong linh"
                },
                new Student
                {
                    RfidTag = listTag[1],
                    StudentID = "20162185",
                    StudentName = "Quang linh"
                }
            };
#endif
            try {
                ExcelExport.GenerateExcel(ConvertToDataTable(studentList), @customPathFile);
                MessageBox.Show("Lưu thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lưu không thành công. Vui lòng làm lại!");
            }
        }
    }
}
