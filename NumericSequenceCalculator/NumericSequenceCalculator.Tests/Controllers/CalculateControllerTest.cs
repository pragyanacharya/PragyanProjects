using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceCalculator.Controllers;
using NumericSequenceCalculator.Models.ViewModels;
using System.Collections.Generic;

namespace NumericSequenceCalculator.Tests.Controllers
{
    [TestClass]
    public class CalculateControllerTest
    {
        [TestMethod]
        public void GetSequence()
        {
            // Arrange
            CalculateController controller = new CalculateController();

            // Act
            ViewResult result = controller.GetSequence() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetSequence_ViewName()
        {
            // Arrange
            CalculateController controller = new CalculateController();

            // Act
            ViewResult result = controller.GetSequence() as ViewResult;

            // Assert
            Assert.AreEqual("GetSequence", result.ViewName);
        }

        [TestMethod]
        public void _SequenceNumbers()
        {
            // Arrange
            CalculateController controller = new CalculateController();

            // Act
            PartialViewResult result = controller._SequenceNumbers(0, "") as PartialViewResult;

            // Assert
             Assert.IsNotNull(result);
        }

        [TestMethod]
        public void _SequenceNumbers_ViewName()
        {
            // Arrange
            CalculateController controller = new CalculateController();

            // Act
            PartialViewResult result = controller._SequenceNumbers(0, "") as PartialViewResult;

            // Assert
            Assert.AreEqual("_SequenceNumbers", result.ViewName);
        }
        [TestMethod]
        public void _SequenceNumbers_Default()
        {
            // Arrange
            CalculateController controller = new CalculateController();

            // Act
            PartialViewResult result = controller._SequenceNumbers(9, null) as PartialViewResult;
            var model = result.ViewData.Model as List<SequenceResult>;
            // Assert
            Assert.AreEqual("0", model.Count.ToString());
        }
        [TestMethod]
        public void _SequenceNumbers_All()
        {
            // Arrange
            CalculateController controller = new CalculateController();

            // Act
            PartialViewResult result = controller._SequenceNumbers(9, "All") as PartialViewResult;
            var model = result.ViewData.Model as List<SequenceResult>;
            // Assert
            Assert.AreEqual("9", model.Count.ToString());
        }
        [TestMethod]
        public void _SequenceNumbers_Even()
        {
            // Arrange
            CalculateController controller = new CalculateController();

            // Act
            PartialViewResult result = controller._SequenceNumbers(9, "Even") as PartialViewResult;
            var model = result.ViewData.Model as List<SequenceResult>;
            // Assert
            Assert.AreEqual("4", model.Count.ToString());
        }
        [TestMethod]
        public void _SequenceNumbers_Odd()
        {
            // Arrange
            CalculateController controller = new CalculateController();

            // Act
            PartialViewResult result = controller._SequenceNumbers(9, "Odd") as PartialViewResult;
            var model = result.ViewData.Model as List<SequenceResult>;
            // Assert
            Assert.AreEqual("5", model.Count.ToString());
        }
        [TestMethod]
        public void _SequenceNumbers_Fibonacci()
        {
            // Arrange
            CalculateController controller = new CalculateController();

            // Act
            PartialViewResult result = controller._SequenceNumbers(9, "Fibonacci") as PartialViewResult;
            var model = result.ViewData.Model as List<SequenceResult>;
            // Assert
            Assert.AreEqual("9", model.Count.ToString());
        }
        [TestMethod]
        public void _SequenceNumbers_Multiples_Count()
        {
            // Arrange
            CalculateController controller = new CalculateController();

            // Act
            PartialViewResult result = controller._SequenceNumbers(9, "Multiples") as PartialViewResult;
            var model = result.ViewData.Model as List<SequenceResult>;
            // Assert
            Assert.AreEqual("9", model.Count.ToString());
        }

        [TestMethod]
        public void _SequenceNumbers_Multiples_C_Count()
        {
            // Arrange
            CalculateController controller = new CalculateController();

            // Act
            PartialViewResult result = controller._SequenceNumbers(9, "Multiples") as PartialViewResult;
            var model = result.ViewData.Model as List<SequenceResult>;
            // Assert
            Assert.AreEqual("3", model.FindAll(x=>x.Number=="C").Count.ToString());
        }
        [TestMethod]
        public void _SequenceNumbers_Multiples_E_Count()
        {
            // Arrange
            CalculateController controller = new CalculateController();

            // Act
            PartialViewResult result = controller._SequenceNumbers(10, "Multiples") as PartialViewResult;
            var model = result.ViewData.Model as List<SequenceResult>;
            // Assert
            Assert.AreEqual("2", model.FindAll(x => x.Number == "E").Count.ToString());
        }
        [TestMethod]
        public void _SequenceNumbers_Multiples_Z_Count()
        {
            // Arrange
            CalculateController controller = new CalculateController();

            // Act
            PartialViewResult result = controller._SequenceNumbers(15, "Multiples") as PartialViewResult;
            var model = result.ViewData.Model as List<SequenceResult>;
            // Assert
            Assert.AreEqual("1", model.FindAll(x => x.Number == "Z").Count.ToString());
        }
    }
}
