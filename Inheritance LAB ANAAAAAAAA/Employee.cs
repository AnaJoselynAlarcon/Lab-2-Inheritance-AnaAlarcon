using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance_LAB_ANAAAAAAAA
{
    internal class Employee
    {
        protected string id;
        protected string name;
        protected string address;
        protected string phone;
        protected long sin;
        protected string dob;
        protected string dept;


        public string Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public string Phone
        {
            get { return phone; }
        }

        public long Sin
        {
            get { return sin; }
        }

        public string Dob
        {
            get { return dob; }
        }

        public string Dept
        {
            get { return dept; }
        }



        /// <summary>
        /// no-Arg constructor
        /// </summary>
        public Employee()
        {

        }

        //METHOD FOR PAYMENT
        public virtual double Pay
        {
            get
            {
                return 0;
            }
        }

    }

    
}
