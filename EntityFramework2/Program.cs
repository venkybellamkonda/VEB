using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                Student stud = new Student() { StudentName = "Venky" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
