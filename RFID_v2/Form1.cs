using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
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
        string rxData = "";
        public Form1()
        {
            InitializeComponent();
            listTag = new List<string>();
            dt = new DataTable();
            dt.Columns.Add("RFID Tag");
            dt.Columns.Add("Studen ID");
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
    //#if DEBUG
    //        rxData = "A79C45E997\nA79C45E997\nA79C45E997\nA79C45E997\n";
    //#endif
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
            foreach (var item in listTag)
            { 
                DataRow row = dt.NewRow();
                row["RFID Tag"] = item;
                dt.Rows.InsertAt(row, 0);
                
            }
        }
    }
}
