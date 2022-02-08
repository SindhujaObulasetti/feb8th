using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stFeb
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string EmpId { get; set; }
        public decimal Salary { get; set; }
        public decimal SalaryCalculated()
        {
            return Salary * 8;
        }
        public abstract string Nationality();
        public abstract string City();
        public abstract string Region();
        public abstract string PostalCode();
        public abstract string Country();
        public abstract string Phone();
        public abstract string Language();


    }
    public class Employee1 : Employee
    {
        public override string Nationality()
        {
            return "Indian";
        }
        public override string City()
        {
            return "Vijayawada";
        }
        public override string Region()
        {
            return "South India";
        }
        public override string PostalCode()
        {
            return "521301";
        }
        public override string Country()
        {
            return "India";
        }
        public override string Phone()
        {
            return "1234567890";
        }
        public override string Language()
        {
            return "Telugu";
        }
    }
}
