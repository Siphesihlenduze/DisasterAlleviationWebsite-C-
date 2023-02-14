using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Appr_Disaster_alleviation_foundation_app1.Pages.NewGoodsDonations
{
    public class CreateModel : PageModel
    {
        public GoodsDonationsInfo goodsDonationsInfo = new GoodsDonationsInfo();
        public String errorMessage = "";
        public String successMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            goodsDonationsInfo.DESCRIPTION = Request.Form["description"];
            goodsDonationsInfo.CATEGORY = Request.Form["category"];
            goodsDonationsInfo.NUMBEROFITEMS = Request.Form["numberofitems"];
            goodsDonationsInfo.DATE = Request.Form["date"];
            

            if (goodsDonationsInfo.DESCRIPTION.Length == 0 || goodsDonationsInfo.CATEGORY.Length == 0 ||
               goodsDonationsInfo.NUMBEROFITEMS.Length == 0 || goodsDonationsInfo.DATE.Length == 0)
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
                    String sql = "INSERT INTO NEWGOODSDONATIONS" +
                        "(DESCRIPTION, CATEGORY, NUMBEROFITEMS, DATE) VALUES" +
                        "(@description, @category, @numberofitems, @date);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@description", goodsDonationsInfo.DESCRIPTION);
                        command.Parameters.AddWithValue("@category", goodsDonationsInfo.CATEGORY);
                        command.Parameters.AddWithValue("@numberofitems", goodsDonationsInfo.NUMBEROFITEMS);
                        command.Parameters.AddWithValue("@date", goodsDonationsInfo.DATE);
                        

                        command.ExecuteNonQuery();
                    }
                }


            }

            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            goodsDonationsInfo.DESCRIPTION = ""; goodsDonationsInfo.CATEGORY = ""; goodsDonationsInfo.NUMBEROFITEMS = ""; goodsDonationsInfo.DATE = "";
            successMessage = "Disaster successfully added";

            Response.Redirect("/NewGoodsDonations/Index");

        }
    }
}
