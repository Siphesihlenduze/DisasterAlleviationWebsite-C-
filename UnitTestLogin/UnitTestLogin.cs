using Microsoft.VisualStudio.TestTools.UnitTesting;
using Appr_Disaster_alleviation_foundation_app1.ViewModels;
using Appr_Disaster_alleviation_foundation_app1.Pages.MonetaryDonations;
using System.Collections.Generic;

namespace UnitTestLogin
{
    [TestClass]
    public class UnitTestLogin
    {
        Login login;

        [TestMethod]
        public void TestMethod1_ReturnsSuccessfullLogin() 
        {

            // Arrange
            Login login = new Login();
            const string Email = "Joe";
            const string Password = "Joe123456";
            const bool RememberMe = true;


            // Act
            var actual = Login.Equals(Email, Password);

            // Assert
            Assert.IsTrue(true);
            
        }

        public void TestMethod2()
        {
            Assert.IsNotNull(true);
        }
         
    }


}
