using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission3.Models
{
    public class CalculatorModel
    {
        [Range(0,100)]
        public byte assignments { get; set; }
        [Range(0, 100)]
        public byte groupproject { get; set; }
        [Range(0, 100)]
        public byte quizzes { get; set; }
        [Range(0, 100)]
        public byte exams { get; set; }
        [Range(0, 100)]
        public byte intex { get; set; }
    }
}
