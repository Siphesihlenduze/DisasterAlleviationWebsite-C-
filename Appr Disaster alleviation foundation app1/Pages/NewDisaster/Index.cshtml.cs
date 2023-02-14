using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Appr_Disaster_alleviation_foundation_app1.Pages.NewDisaster
{
    public class IndexModel : PageModel
    {
        public List<DisasterInfo> listdisasters = new List<DisasterInfo>();
        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=DESKTOP-HQCNEQG;Initial Catalog=DisasterAllevationFoundation;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM NEWDISASTER";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DisasterInfo disasterInfo = new DisasterInfo();
                                disasterInfo.ID = "" + reader.GetInt32(0);
                                disasterInfo.DESCRIPTION = reader.GetString(1);
                                disasterInfo.REQAIDTYPE = reader.GetString(2);
                                disasterInfo.DISASTERLOC = reader.GetString(3);
                                disasterInfo.DISASTERSTARTDATE = reader.GetString(4);
                                disasterInfo.DISASTERENDDATE = reader.GetString(5);
                                disasterInfo.ALLOCATEMONEY = reader.GetString(6);
                                disasterInfo.ALLOCATEGOODS = reader.GetString(7);
                                disasterInfo.CREATED_AT = reader.GetDateTime(8).ToString();
                                
                                listdisasters.Add(disasterInfo);
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

    public class DisasterInfo
    {
        public string ID;
        public string DESCRIPTION;
        public string REQAIDTYPE;
        public string DISASTERLOC;
        public string DISASTERSTARTDATE;
        public string DISASTERENDDATE;
        public string ALLOCATEMONEY;
        public string ALLOCATEGOODS;
        public string CREATED_AT;
        
       


    }
}
