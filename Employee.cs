using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Employee : Person
    {
        private string id = "ABC567EFG";

        public Employee(string name, string ssn) :base(name, ssn)
        {

        }
        public override void PrintName()
        {
            Console.WriteLine(name +" Employee Id: "+id);
        }


    }
}
