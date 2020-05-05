using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TAPolicyWebApplication.Model;

namespace TAPolicyWebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnGetPolicy_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51278/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Call GET Method  
                HttpResponseMessage response = await client.GetAsync("api/policy/RetirementPlan");
                if (response.IsSuccessStatusCode)
                {
                    List<PolicyPlan> plans = await response.Content.ReadAsAsync<List<PolicyPlan>>();

                    int index = 0;
                    if (plans != null)
                    {
                        foreach(PolicyPlan pname in plans)
                        {
                            index = index + 1; ;
                            pname.PlanParticipantsName = "Participants No " + Convert.ToString(index);
                        }
                        gvPlans.DataSource = plans;
                        gvPlans.DataBind();
                    }

                }
                else
                {

                }
            }
        }
    }
}