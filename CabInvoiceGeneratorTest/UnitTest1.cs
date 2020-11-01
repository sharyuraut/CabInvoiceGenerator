using NUnit.Framework;
using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        /// <summary>
        /// Invoice Generator Reference
        /// </summary>
        InvoiceGenerator ig = null;

        /// <summary>
        /// Test Case for calculating Fare Function
        /// </summary>
        [Test]
        public void GivenDistanceAndTIme_ShouldReturnTotalFare()
        {
            ///<summary>
            ///Creaating instance of invoice generator for normal ride
            ///</summary>
            ig = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;

            ///<summary>
            ///Calculatinng fare
            ///</summary>
            double fare = ig.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
    }
}