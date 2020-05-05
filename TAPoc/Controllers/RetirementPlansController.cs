using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TAPoc.Models;
namespace TAPoc.Controllers
{
    [RoutePrefix("api/policy")]
    public class RetirementPlansController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("RetirementPlan")]
        public IHttpActionResult Get()
        {
            List<PolicyPlan> plan = new List<PolicyPlan>
            {
                new PolicyPlan{PlanID=1,PlanName="Retirement Plan A",PlanDetails="Retirement A",PlanBalance=200,PlanOwner="Owner1",PlanStartDate="2020/04/01"},
                new PolicyPlan{PlanID=2,PlanName="Retirement Plan B",PlanDetails="Retirement B",PlanBalance=300,PlanOwner="Owner2",PlanStartDate="2020/05/01"},
            new PolicyPlan{PlanID=3,PlanName="Retirement Plan C",PlanDetails="Retirement C",PlanBalance=400,PlanOwner="Owner3",PlanStartDate="2020/03/01"}
            };

            return Ok(plan);
        }
    }
}
