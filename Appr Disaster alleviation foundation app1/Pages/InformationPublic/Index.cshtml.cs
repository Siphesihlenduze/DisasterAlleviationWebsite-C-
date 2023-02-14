using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Appr_Disaster_alleviation_foundation_app1.Pages.InformationPublic
{
    public class IndexModel : PageModel
    {
        public List<DisasterInfo> listdisasters = new List<DisasterInfo>();
        public List<GoodsDonationsInfo> listgoods = new List<GoodsDonationsInfo>();
        public List<MonetaryInfo> listmonetary = new List<MonetaryInfo>();


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


    

    public class MonetaryInfo
    {
        public string ID;
        public string DONORNAME;
        public string DATE;
        public string AMOUNT;





    }




