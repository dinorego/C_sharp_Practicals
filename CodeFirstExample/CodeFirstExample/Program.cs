using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EnumTestContext())
            {
                context.Departments.Add(new Department { Name = DepartmentNames.English });

                context.SaveChanges();

                var department = (from d in context.Departments
                    select d).FirstOrDefault();

                Console.WriteLine(
                    "DepartmentID: {0} Name: {1}",
                    department.DepartmentID,
                    department.Name);
                Console.ReadLine();
            }
        }
    }

    public partial class EnumTestContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
    }

    public enum DepartmentNames
    {
        English,
        Math,
        Economics
    }

    public partial class Department
    {
        public int DepartmentID { get; set; }
        public DepartmentNames Name { get; set; }
        public decimal Budget { get; set; }
    }
}
