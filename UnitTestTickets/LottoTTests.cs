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
            string today = todaysDate.ToString("MMMM dd");
            LottoT lotTicket = new LottoT();
            string expected = todaysDate.ToString("MMMM dd");

            //act
            string response = lotTicket.dateOfPurchase.ToString("MMMM dd");

            //assert
            Assert.AreEqual(response, expected);
            /*******  Note this will fail as the sub class does not call the baseclass constructor */
            /****** add this into notes ****/
        }
    }
}
