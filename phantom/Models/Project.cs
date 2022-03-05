using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phantom.Models
{
    public class Project: Base
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
    }
}
