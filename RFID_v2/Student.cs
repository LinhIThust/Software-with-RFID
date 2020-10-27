using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_v2
{
    public class Student
    {
        public string RfidTag { get;  set; }
        public string StudentID { get; set; }
        public string StudentName { get; set; }

        public Student()
        {
        }

        public Student(string rfidTag, string studentID, string studentName)
        {
            RfidTag = rfidTag;
            StudentID = studentID;
            StudentName = studentName;
        }
    }
}
