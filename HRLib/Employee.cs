using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public abstract class Employee
    {
        #region Fields
        private string name;
        private string address;
        public string Name
        {
            get { return name; }
           protected set { name = value; }
        }
        public string Address
        {
            get { return address; }
            protected set { address = value; }
        }
        #endregion

        #region Constructor
        public Employee(string eName, string eAddress)
        {
            this.Name = eName;
            this.Address = eAddress;
        }
        #endregion

        #region Methods
        public abstract double CalculateSalary();

        //public override string ToString()
        //{
        //    return string.Format($"Name {Name}  Address{Address}");
        //}
        #endregion
    }
}
