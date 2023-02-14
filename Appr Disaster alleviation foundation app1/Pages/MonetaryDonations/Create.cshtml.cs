using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Appr_Disaster_alleviation_foundation_app1.Pages.MonetaryDonations
{
    public class CreateModel : PageModel
    {
        public MonetaryInfo monetaryInfo = new MonetaryInfo();
        public String errorMessage = "";
        public String successMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            monetaryInfo.DONORNAME = Request.Form["donorname"];
            monetaryInfo.DATE = Request.Form["date"];
            monetaryInfo.AMOUNT = Request.Form["amount"];
            

            if (monetaryInfo.DONORNAME.Length == 0 || monetaryInfo.DATE.Length == 0 ||
                monetaryInfo.AMOUNT.Length == 0)
            {
                errorMessage = "Please fill in all the fields";
                return;


            }

            try
            {
                String connectionString = "Data Source=DESKTOP-HQCNEQG;Initial Catalog=DisasterAllevationFoundation;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO MONETARYDONATIONS" +
                        "(DONORNAME, DATE, AMOUNT) VALUES" +
                        "(@donorname, @date, @amount);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@donorname", monetaryInfo.DONORNAME);
                        command.Parameters.AddWithValue("@date", monetaryInfo.DATE);
                        command.Parameters.AddWithValue("@amount", monetaryInfo.AMOUNT);
                        

                        command.ExecuteNonQuery();
                    }
                }


            }

            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            monetaryInfo.DONORNAME = ""; monetaryInfo.DATE = ""; monetaryInfo.AMOUNT = "";
            successMessage = "Monetary donation successfully added";

            Response.Redirect("/MonetaryDonations/Index");

        }
    }
}
