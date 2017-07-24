using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumericSequenceCalculator.Models.ViewModels
{
    public class SequenceResult
    {
        public string Number { get; set; }

        public IList<string> GetEvenNumbers(int NumberToGenerate)
        {
            var numberList = Enumerable.Range(1, NumberToGenerate).ToList().Where(i => i % 2 == 0);
            return numberList.ToList().ConvertAll<string>(x => x.ToString());
        }
        public IList<string> GetOddNumbers(int NumberToGenerate)
        {
            var numberList = Enumerable.Range(1, NumberToGenerate).ToList().Where(i => i % 2 != 0);
            return numberList.ToList().ConvertAll<string>(x => x.ToString());
        }
        public IList<string> GetFibonacciNumbers(int NumberToGenerate)
        {
            int ord1 = 0, ord2 = 0, ord3 = 0;
            var FibSeries = Enumerable.Range(1, NumberToGenerate).Select(a =>
               {
                   ord1 = a == 1 ? 0 : ord2;
                   ord2 = a == 1 ? 1 : ord3;
                   ord3 = a == 1 ? 0 : ord1 + ord2;
                   return ord3;
               });
            return FibSeries.ToList().ConvertAll<string>(x => x.ToString());
        }
        public IList<string> GetMultiples(int NumberToGenerate)
        {
            var list = Enumerable.Range(1, NumberToGenerate).ToList().Select(i => i.ToString()).ToArray();
            for (int i = 0; i < list.Length; i++)
            {
                if (Convert.ToInt32(list[i]) % 3 == 0 && Convert.ToInt32(list[i]) % 5 == 0)
                    list[i] = "Z";
                else
                if (Convert.ToInt32(list[i]) % 3 == 0)
                    list[i] = "C";
                else
                if (Convert.ToInt32(list[i]) % 5 == 0)
                    list[i] = "E";
               
            }
            return list.ToList<string>();
        }
    }
}