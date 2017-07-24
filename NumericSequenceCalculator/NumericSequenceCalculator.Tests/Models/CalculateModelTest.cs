using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using NumericSequenceCalculator.Models;
using System.Collections.Generic;

namespace NumericSequenceCalculator.Tests.Models
{
    [TestClass]
    public class CalculateModelTest
    {
        [TestMethod]
        public void Enter_Empty_NumberToGenerate()
        {
            var model = new Calculate();
            ValidationContext context = new ValidationContext(model, null, null);
            var result = new List<ValidationResult>();
            Validator.ValidateObject(model, context);
            // Act
            var valid = Validator.TryValidateObject(model, context, result, true);

            Assert.IsFalse(valid);
        }
        
        [TestMethod]
        public void Enter_Valid_NumberToGenerate1()
        {
            var model = new Calculate();
            model.NumberToGenerate = 10;
            ValidationContext context = new ValidationContext(model, null, null);
            var result = new List<ValidationResult>();

            // Act
            var valid = Validator.TryValidateObject(model, context, result, true);

            Assert.IsTrue(valid);
        }
    }
}
