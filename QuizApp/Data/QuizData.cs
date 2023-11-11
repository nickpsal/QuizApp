using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Data
{
    internal class QuizData
    {
        public required string question { get; set; }
        public required List<Answers> Answers { get; set; }
    }
}
