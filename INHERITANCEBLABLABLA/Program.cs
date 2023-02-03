using System;
using System.IO;
//anadiendo libreria para procesar text-files
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;

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


            List<Employee> listaDeDatos = new List<Employee>();




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

                string digitOneId = id.Substring(0,1);
                int firstDigit = int.Parse(digitOneId);

                bool digitSalaried = firstDigit <= 4 && firstDigit >= 0;

                bool digitWaged = firstDigit <=7 && firstDigit >= 5;

                bool digitPartTime = firstDigit <=9 && firstDigit >= 8;





               
                



                //Condicion para checar si tiene salary o rate o hours como field
                if (digitSalaried)
                {
                    double salary = double.Parse(employeeData[7]);
                    Salaried salariedEmployee = new Salaried(id, name, address, phone, sin, birthdate, dept, salary);
                    listaDeDatos.Add(salariedEmployee);
                }
                else if(digitWaged || digitPartTime)
                {
                    double rate = double.Parse(employeeData[7]);
                    double hours = double.Parse(employeeData[8]);
                    if (digitPartTime)
                    {
                        PartTime partTimeEmployee = new PartTime(id, name, address, phone, sin, birthdate, dept, rate, hours);
                        listaDeDatos.Add(partTimeEmployee);
                    }
                    else
                    {
                        Waged wagedEmployeee = new Waged(id, name, address, phone, sin, birthdate, dept, rate, hours);
                        listaDeDatos.Add(wagedEmployeee);
                    };


                
                 };








            }

            // highest pay for the wage employees, including the name of the employee
            //se usa Waged porque como tenemos que regresar string and double, se contienen ambos en el objeto de la clase Waged.
            //regresa el objeto completo
            Waged highestWagedEmployee (List<Employee> listaEmpleados)
                //solo es el template de la funcion, listaEmpleados es solo un "argumento"
            {
                double maximumPay = 0; 
                Waged highestPayEmployee = null;
                // en lugar de null va a tomar el objeto completo

                foreach(Employee employee in listaEmpleados)
                {
                    if(employee is Waged employeeWagedType)
                        //es necesario ponerlo tipo Waged para poder hacer operaciones con el
                        //si el "item" es de tipo waged se va a llamar soloWagedEmployee
                    {
                        //Waged selectedEmployee = employee;
                        double wagedPayment = employeeWagedType.Pay;
                        if(wagedPayment > maximumPay)
                        {
                            maximumPay = wagedPayment;
                            highestPayEmployee = employeeWagedType;
                        };

                    }
                }

                return highestPayEmployee;
            }



            //llamar funcion
            
            Waged resultadoHighest = highestWagedEmployee(listaDeDatos);

            double highestWagedPay = resultadoHighest.Pay;

            Console.WriteLine("Highest waged pay: " + highestWagedPay.ToString("C2"));
            Console.WriteLine("Highest waged employee:" + resultadoHighest.Name);



            //LOWEST SALARIED
            Salaried lowestSalariedEmployee(List<Employee> listaEmpleados)
            //solo es el template de la funcion, listaEmpleados es solo un "argumento"
            {
                double minimumPay = 999999999;
                Salaried lowestPayEmployee = null;
                // en lugar de null va a tomar el objeto completo

                foreach (Employee employee in listaEmpleados)
                {
                    if (employee is Salaried employeeSalariedType)
                    //es necesario ponerlo tipo Salaried para poder hacer operaciones con el
                    //si el "item" es de tipo waged se va a llamar employeeSalariedType
                    {
                        //Salaried selectedEmployee = employee;
                        double salariedPayment = employeeSalariedType.Pay;
                        if (salariedPayment < minimumPay)
                        {
                            minimumPay = salariedPayment;
                            lowestPayEmployee = employeeSalariedType;
                        };

                    }
                }

                return lowestPayEmployee;
            }
            //llamar funcion

            Salaried resultadoLowest = lowestSalariedEmployee(listaDeDatos);

            double lowestSalariedPay = resultadoLowest.Pay;

            Console.WriteLine("Lowest salaried pay: " + lowestSalariedPay.ToString("C2"));
            Console.WriteLine("Lowest salaried employee:" + resultadoLowest.Name);


            //-----------PERCENTAGE---------
            double[] calculatePercentage(List<Employee> listaEmpleados)
                //se declara que tipo de variable REGRESARA la funcion
            {
               
                double totalWaged = 0;
                double totalPartTime = 0;
                

                double totalSalaried = 0;

                foreach (Employee employee in listaEmpleados)
                {
                    if (employee is Salaried)
                    {
                        totalSalaried += 1;
                        
                    }
                    else if(employee is Waged)
                    {
                        totalWaged += 1;
                    }
                    else
                    {
                        totalPartTime += 1;
                    }

                }


                double salariedPercentage = (totalSalaried / listaEmpleados.Count()) *100;
                double wagedPercentage = (totalWaged/ listaEmpleados.Count()) * 100;
                double partTimePercentage = (totalPartTime/ listaEmpleados.Count()) *100;


                double[] percentageArray = { salariedPercentage, wagedPercentage, partTimePercentage };
                return percentageArray;




            }


            double[] totalPercentages = calculatePercentage(listaDeDatos);
            Console.WriteLine("The percentage of Salaried Employees is: " + totalPercentages[0].ToString("N2") + "%");
            Console.WriteLine("The percentage of Waged Employees is: " + totalPercentages[1].ToString("N2") + "%");
            Console.WriteLine("The percentage of Part Time Employees is: " + totalPercentages[2].ToString("N2") + "%");





            //-----------AVERAGE WEEKLY PAY
            double averagePay(List<Employee> listaEmpleados)
            {
                double averagePaymentVariable = 0;

                foreach(Employee employee in listaEmpleados)
                {
                    averagePaymentVariable += employee.Pay;
                }

                double averageTotal = averagePaymentVariable / listaEmpleados.Count();
                return averageTotal;

            }
            double averageCall = averagePay(listaDeDatos);
            Console.WriteLine(averageCall.ToString("N2"));
        }
    }
}
