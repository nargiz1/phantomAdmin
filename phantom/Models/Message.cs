using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phantom.Models
{
    public class Message: Base
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Text { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
