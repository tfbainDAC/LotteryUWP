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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
               "The ball number must be between 1 and 49")]
        public void TestInvalidBonusBall()
        {
            //arrange
            // Test the bonus ball throws exception for an invalid entry
            LottoT lotto = new LottoT();

            //act
            lotto.BonusBall = 88;
        }

        [TestMethod]
        public void TestInvalidBonusBallTryCatch()
        {
            //arrange
            // Test the bonus ball throws exception for an invalid entry
            LottoT lotto = new LottoT();
            try
            {
                //act
                lotto.BonusBall = 88;
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentException);
                Assert.AreEqual(ex.Message, "The ball number must be between 1 and 49");
            }
        }
    }
}
