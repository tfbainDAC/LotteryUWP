using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tickets;

namespace UnitTestTickets
{
    [TestClass]
    public class LottoTTests
    {
        [TestMethod]
        public void TestLottoDate() {
            //arrange
            // Test the date on the ticket is correct
            DateTime todaysDate = new DateTime();
            todaysDate = DateTime.Now;
            string expected = todaysDate.ToString("MMMM dd");  // set up todays date in format MMMM dd

            //act
            LottoT lotTicket = new LottoT();    // create new lottery ticket, this should show todays date
            string response = lotTicket.DateOfPurchase.ToString("MMMM dd");  // receive date in format MMMM dd

            //assert
            Assert.AreEqual(expected, response);
 
        }

        [TestMethod]
        public void TestSortedNumbers()
        {

        }
    }
}
