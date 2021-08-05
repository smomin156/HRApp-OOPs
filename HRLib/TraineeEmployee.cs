using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
   public class TraineeEmployee:Employee
    {
        #region Fields
        private int noOfDays;
        private double ratePerDay;
        public int NoOfDays
        {
            get { return noOfDays; }
            protected set { noOfDays = value; }
        }
        public double RatePerDay
        {
            get { return ratePerDay; }
            protected set { ratePerDay = value; }
        }
        #endregion

        #region Constructor
        public TraineeEmployee(string eName, string eAddress, int days, double rate) : base(eName, eAddress)
        {
            this.NoOfDays = days;
            this.RatePerDay = rate;
        }
        #endregion

        #region Methods
        public override double CalculateSalary()
        {
            return NoOfDays * RatePerDay;
        }

        public override string ToString()
        {
            return string.Format($"Name :{Name} Address :{Address} No Of Days :{NoOfDays} Rate Per Day :{RatePerDay}");
        } 
        #endregion
    }
}
