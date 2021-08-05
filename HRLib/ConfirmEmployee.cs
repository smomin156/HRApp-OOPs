using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        #region Fields
        private double basic;
        private string designation;
        public double Basic
        {
            get { return basic; }
            protected set 
            {
                if (basic <= 5000)
                {
                    throw new MinimumSalaryException("salary less than 5000");
                }
                basic = value; 
            }
        }
        public string Designation
        {
            get { return designation; }
            protected set { designation = value; }
        }
        #endregion

        #region Constructor
        public ConfirmEmployee(string eName, string eAddress, double eBasic, string eDesignation) : base(eName, eAddress)
        {
            this.Basic = eBasic;
            this.Designation = eDesignation;
        }
        #endregion
        #region Methods
        public sealed override double CalculateSalary()//cannot overide method
        {
            double hra, conv, pf;
            
            if (Basic >= 30000)
            {
                hra = Basic * .3;
                conv = Basic * .3;
                pf = Basic * .1;
            }
            else if (Basic >= 20000)
            {
                hra = Basic * .2;
                conv = Basic * .2;
                pf = Basic * .1;
            }
            else
            {
                hra = Basic * .1;
                conv = Basic * .1;
                pf = Basic * .1;
            }
            return Basic + hra + conv - pf;
        }
        public override string ToString()
        {
            return string.Format($"Name :{Name} Address: {Address} Basic :{Basic} Designation :{Designation}");
        } 
        #endregion
    }
}
