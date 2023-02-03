using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCEBLABLABLA
{
    internal class Salaried : Employee
    {
        //Field adicional de esta clase
        private double salary;


        //----PROPERTY debe ser publica, para poder accesar en el programa



        //----CONSTRUCTOR
        //
        public Salaried(string id, string name, string address, string phone, long sin, string birthdate, string dept, double salary)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.birthdate = birthdate;
            this.dept = dept;
            this.salary = salary;
        }
    }
}
