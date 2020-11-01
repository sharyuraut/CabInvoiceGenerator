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
        /// <summary>
        /// uc2-Check Multiple Rides
        /// </summary>
        [Test]
        public void GivenMultipleRides_ShouldReturnInvoiceSummary()
        {
            ig = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary summary = ig.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0);

            Assert.AreEqual(expectedSummary, summary);
        }
        /// <summary>
        /// uc3-Return multiple results
        /// </summary>
        [Test]
        public void GetEnhancedInvoice_ShouldReturn_TotalFare_TotalRides_AverageFare()
        {
            ig = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            int countRide = 2;
            double tfare = 30.0;
            double averageFare = ig.CalculateAverage(countRide, tfare);

            InvoiceSummary summary = ig.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0);
            double averageFareExpected = 15.0;

            Assert.AreEqual(expectedSummary, summary);
            Assert.AreEqual(averageFareExpected, averageFare);
        }
        /// <summary>
        /// Test case4 to return invoice given userid
        /// </summary>
        //[Test]
        //public void GetInvoiceService__GivenUserId_ShouldReturnListOfRides()
        //{
        //    ig = new InvoiceGenerator(RideType.NORMAL);
        //    string uName = "user1";

        //    InvoiceSummary user = ig.GetInvoiceSummary(uName);
        //    InvoiceSummary expectedUser = new GetInvoiceSummary("user1");

        //    Assert.AreEqual(uName, expectedUser);
        //}
        [Test]
        public void GivenDistanceAndTIme_ShouldReturnTotalFare_ForPremiumRide()
        {
            ///<summary>
            ///Creaating instance of invoice generator for premium ride
            ///</summary>
            ig = new InvoiceGenerator(RideType.PREMIUM);
            double distance = 2.0;
            int time = 5;

            ///<summary>
            ///Calculatinng fare
            ///</summary>
            double fare = ig.CalculateFare(distance, time);
            double expected = 40;
            Assert.AreEqual(expected, fare);
        }
    }
}