using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logbook.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? LastSeen { get; set; }
        public int Activity { get; set; }
        public int TestScore { get; set; }
        public int ClassworkScore { get; set; }
        public int Crystals { get; set; }
        public string? Comment { get; set; }
        public string? ImageName { get; set; }
    }
}
