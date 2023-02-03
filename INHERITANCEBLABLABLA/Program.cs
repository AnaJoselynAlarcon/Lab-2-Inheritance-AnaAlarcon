using System;
using System.IO;
//anadiendo libreria para procesar text-files
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace INHERITANCEBLABLABLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txtPath = "employees.txt";

            //Funcion para leer txt files
            //Creando un array de strings
            //Cuando lees de un archivo todos los datos nacen strings
            string[] employeesList = File.ReadAllLines(txtPath);

            //Loop en la lista para crear objetos
            foreach (string line in employeesList)
            {
                string[] employeeData = line.Split(':');
                string id = employeeData[0];
                string name = employeeData[1];
                string address = employeeData[2];
                string phone = employeeData[3];
                long sin = long.Parse(employeeData[4]);
                string birthdate = employeeData[5];
                string dept = employeeData[6];
                

                //Condicion para checar si tiene salary o rate
                if(employeeData.Count() == 7)
                {
                    double salary = double.Parse(employeeData[7]);
                    Salaried salariedEmployee = new Salaried(id, name, address, phone, sin, birthdate, dept, salary);
                }
                else if(employeeData.Count() > 7)
                {
                    double rate = double.Parse(employeeData[7]);
                    double hours = double.Parse(employeeData[8]);
                    PartTime partTimeEmployee = new PartTime(id, name, address, phone, sin, birthdate, dept, rate, hours)
                };

                if


            }


        }
    }
}
