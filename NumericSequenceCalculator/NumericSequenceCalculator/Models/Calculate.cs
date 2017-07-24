using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NumericSequenceCalculator.Models
{
    public class Calculate
    {
        [RegularExpression("^([1-9][0-9]*)$", ErrorMessage = "Enter only positive non zero whole number")]
        [Required(ErrorMessage = "Please enter a number.")]
        public int NumberToGenerate { get; set; }

        public string SequenceName { get; set; }


    }
}