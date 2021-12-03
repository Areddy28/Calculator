using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorTwo.Models
{
    public enum Operation
    {
        plus,
        minus,
        multiply,
        divide
    }
    public class Calculator
    {
        
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        
        public Operation Operation { get; set; }
        
        public double Result { get; set; }

    }
}
