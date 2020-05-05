using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TAPolicyWebApplication.Model
{
    public class PolicyPlan
    {
        public int PlanID { get; set; }
        public string PlanName { get; set; }
        public double PlanBalance { get; set; }
        public string PlanDetails { get; set; }
        public string PlanStartDate { get; set; }
        public string PlanOwner { get; set; }
        public int NumberOfPlanParticipants { get; set; }
        public string PlanParticipantsName { get; set; }

    }
}