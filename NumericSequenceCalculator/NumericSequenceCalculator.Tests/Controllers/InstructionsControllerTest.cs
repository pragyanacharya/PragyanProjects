using NumericSequenceCalculator.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace NumericSequenceCalculator.Tests.Controllers
{
    [TestClass]
    public class InstructionsControllerTest
    {
        [TestMethod]
        public void ReadMe()
        {
            // Arrange
            InstructionsController controller = new InstructionsController();

            // Act
            ViewResult result = controller.ReadMe() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ReadMe_ViewName()
        {
            // Arrange
            InstructionsController controller = new InstructionsController();

            // Act
            ViewResult result = controller.ReadMe() as ViewResult;

            // Assert
            Assert.AreEqual("ReadMe",result.ViewName);
        }
        [TestMethod]
        public void Contact()
        {
            // Arrange
            InstructionsController controller = new InstructionsController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contact_ViewName()
        {
            // Arrange
            InstructionsController controller = new InstructionsController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull("Contact",result.ViewName);
        }

        [TestMethod]
        public void Contact_ViewBag_Message()
        {
            // Arrange
            InstructionsController controller = new InstructionsController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull("Contact Details", result.ViewBag.Message);
        }
    }
}
