using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Appr_Disaster_alleviation_foundation_app1.Pages.MonetaryDonations
{
    public class IndexModel : PageModel
    {
        public List<MonetaryInfo> listmonetary = new List<MonetaryInfo>();
        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=DESKTOP-HQCNEQG;Initial Catalog=DisasterAllevationFoundation;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM MONETARYDONATIONS";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MonetaryInfo monetaryinfo = new MonetaryInfo();
                                monetaryinfo.ID = "" + reader.GetInt32(0);
                                monetaryinfo.DONORNAME = reader.GetString(1);
                                monetaryinfo.DATE = reader.GetString(2);
                                monetaryinfo.AMOUNT = reader.GetString(3);
                                

                                listmonetary.Add(monetaryinfo);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ToString());

            }
        }
    }

    public class MonetaryInfo
    {
        public string ID;
        public string DONORNAME;
        public string DATE;
        public string AMOUNT;
        




    }
   
    
}
