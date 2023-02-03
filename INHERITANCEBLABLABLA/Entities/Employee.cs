using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCEBLABLABLA
{
    internal class Employee
    {
        //----FIELDS--- deben ser privados en una clase
        // Protected = privados pero heredables
        protected string id;
        protected string name;
        protected string address;
        protected string phone;
        protected long sin;
        protected string birthdate;
        protected string dept;


        //Properties : leer y modificar el valor de FIELDS, desde program



        //------CONSTRUCTOR------
        //Si tienes un constructor definido por el usuario, para que las propiedades protected sean heredables = NO ARG constructor.
        //Siempre deben ser publicos
        public Employee()
        {

        }


        
    }
}
