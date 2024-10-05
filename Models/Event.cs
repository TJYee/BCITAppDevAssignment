using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCITAppDevAssignment.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }
    }
}