using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question7
{
    public class Attendance
    {
        private int _workingDays; 
        private int _leaveTaken; 
        private int _permissionsTaken; 
        public int NoOfDaysWorked { get; set; }
        public int Salary { get; set; }
        public Attendance(int workingDays,int leaveTaken,int permissionsTaken)
        {
            _workingDays = workingDays;
            _leaveTaken = leaveTaken;
            _permissionsTaken = permissionsTaken;
            NoOfDaysWorked = _workingDays-_leaveTaken-_permissionsTaken;
        }
        public static Attendance operator+ (Attendance attendance1,Attendance attendance2)
        {
            Attendance attendance3 = new Attendance(0,0,0);
            attendance3.NoOfDaysWorked = attendance1.NoOfDaysWorked+attendance2.NoOfDaysWorked;
            attendance3.Salary = attendance3.NoOfDaysWorked*500;
            return attendance3;
        }
    }
}