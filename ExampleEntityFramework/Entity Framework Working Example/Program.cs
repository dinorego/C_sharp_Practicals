using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Working_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Entity_Framework_TestingEntities2 model = new Entity_Framework_TestingEntities2();
            List<EmployeeTable> lstEmp = new List<EmployeeTable>();
            Console.WriteLine();
            Console.WriteLine("     Name" + "         " + "Address" + "    " + "EmailId" + "                 " + "Mobile Number" + "  " + "Dept Name");
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var item in lstEmp)
            {
                Console.WriteLine(item.PersonLastName + "  | " + item.PersonAddress + " |  " + item.PersonEmailAddress+ "  |  " + item.PersonNumber + " |  " + item.EmploymentTitle);
            }
            Console.ReadLine();
        }
    }
}
