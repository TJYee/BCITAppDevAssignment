using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCITAppDevAssignment.Models
{
    public class Registration
    {
        public int RegistrationID { get; set; }
        public int EventID { get; set; }
        public int ParticipantID { get; set; }
        public string AdditionalInformation { get; set; }

        public virtual Event Event { get; set; }
        public virtual Participant Participant { get; set; }
    }
}