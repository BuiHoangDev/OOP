using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHang
{
   public class Cls_Student
    {
        string studentID, studentName, classID, subjectID;

        public string SubjectID
        {
            get { return subjectID; }
            set { subjectID = value; }
        }

        public string ClassID
        {
            get { return classID; }
            set { classID = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        double mark;

        public double Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        int times;

        public int Times
        {
            get { return times; }
            set { times = value; }
        }


    }
}
