using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCEBLABLABLA
{
    internal class Waged : Employee
    {
        //Fields especiales de la clase
        private double hours;
        private double rate;


        //Consturtor
        public Waged(string id, string name, string address, string phone, long sin, string birthdate, string dept, double rate, double hours)
        {
            //Asignar valores a cada field
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.birthdate = birthdate;
            this.dept = dept;
            this.hours = hours;
            this.rate = rate;
        }
    }
}
