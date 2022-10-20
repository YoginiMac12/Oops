using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class Student1
    {
        private int rollno, mark1, mark2, mark3;
        private string name;
        private double per;
        private int total;
        public void GetValues(int r, string n)
        {
            rollno = r;
            name = n;

        }
        public void Caluculate(int m1, int m2, int m3)
        {

            mark1 = m1;
            mark2 = m2;
            mark3 = m3;
            total = m1 + m2 + m3;
            per = (double)total / 3;

        }
        public string ShowValues()
        {
            return $"rollno   {rollno}\nname   {name}\ntoatl   {total}\npercentage    {per}";

        }
    }
}
