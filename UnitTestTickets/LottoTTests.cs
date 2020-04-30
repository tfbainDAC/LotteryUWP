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
        public void TestAllCorrectBallNumbers() 
        {
            //arrange
            LottoT lotTicket = new LottoT();
            int[] testNumbers = { 17, 18, 14, 1, 49, 5 };

            //act
            lotTicket.Numbers = testNumbers;

            //assert   -  want to check this throws an exception
            Assert.AreEqual(testNumbers, lotTicket.Numbers);  
            //AssertFailedException.Equals(testNumbers, lotTicket.Numbers);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
               "The ball numbers must be between 1 and 49")]
        public void TestAllWithInvalidBalls()  // can this be refactored to test for example one with zero
        {
            //arrange
            LottoT lotTicket = new LottoT();
            int[] testNumbers = { 17, 18, 14, 1, 50, 5 };

            //act
            lotTicket.Numbers = testNumbers;

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
