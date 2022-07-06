using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Task
    {
        public Task(string Name, string Description, DateTime Start, string Status, DateTime End)
        {
            Name = name;
            Description = description;
            Start = startDate;
            Status = status;
            End = endDate;
        }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public string status { get; set; }
        public DateTime endDate { get; set; }
    }
}
