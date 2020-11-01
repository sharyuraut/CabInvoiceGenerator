using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        //Variables
        private int numberOfRides;
        private double totalFare;
        private double averageFare;

        /// <summary>
        /// Parameter constructor for setting rides
        /// </summary>
        /// <param name="numberOfRides"></param>
        /// <param name="totalFare"></param>
        public InvoiceSummary(int numberOfRides,double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            //this.averageFare = this.totalFare / this.numberOfRides;
        }
        /// <summary>
        /// Parameter contructor overloaded
        /// </summary>
        /// <param name="numberOfRides"></param>
        /// <param name="totalFare"></param>
        /// <param name="averageFare"></param>
        public InvoiceSummary(int numberOfRides, double totalFare, double averageFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = averageFare;
        }
        /// <summary>
        /// Overriding equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is InvoiceSummary)) return false;

            InvoiceSummary inputObj = (InvoiceSummary)obj;
            return this.numberOfRides==inputObj.numberOfRides && this.totalFare==inputObj.totalFare && this.averageFare==inputObj.averageFare;
        }
        /// <summary>
        /// Overriding GetHashCode Mehtod
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.numberOfRides.GetHashCode() ^ this.totalFare.GetHashCode() ^ this.averageFare.GetHashCode();
        }
    }
}
