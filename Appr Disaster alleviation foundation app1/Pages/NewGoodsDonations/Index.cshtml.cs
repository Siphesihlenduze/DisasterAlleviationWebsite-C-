using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Appr_Disaster_alleviation_foundation_app1.Pages.NewGoodsDonations
{
    public class IndexModel : PageModel
    {
        public List<GoodsDonationsInfo> listgoods = new List<GoodsDonationsInfo>();
        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=DESKTOP-HQCNEQG;Initial Catalog=DisasterAllevationFoundation;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM NEWGOODSDONATIONS";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                GoodsDonationsInfo goodsdonationInfo = new GoodsDonationsInfo();
                                goodsdonationInfo.ID = "" + reader.GetInt32(0);
                                goodsdonationInfo.DESCRIPTION = reader.GetString(1);
                                goodsdonationInfo.CATEGORY = reader.GetString(2);
                                goodsdonationInfo.NUMBEROFITEMS = reader.GetString(3);
                                goodsdonationInfo.DATE = reader.GetString(4);
                                

                                listgoods.Add(goodsdonationInfo);
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

    public class GoodsDonationsInfo
    {
        public string ID;
        public string DESCRIPTION;
        public string CATEGORY;
        public string NUMBEROFITEMS;
        public string DATE;
        




    }
}
