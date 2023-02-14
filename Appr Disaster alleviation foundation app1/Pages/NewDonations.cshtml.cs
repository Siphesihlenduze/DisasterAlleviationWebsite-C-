using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Appr_Disaster_alleviation_foundation_app1.Pages
{
    public class NewDonationsModel : PageModel
    {

        public bool ContainsData = false;
        public string donorname = "";
        public string donationdate = "";
        public string donationamount = "";



        public void OnGet()
        {
        }

        public void OnPost()
        {
            ContainsData = true;
            donorname = Request.Form["donorname"];
            donationdate = Request.Form["donationdate"];
            donationamount = Request.Form["donationamount"];



        }
    }


}
