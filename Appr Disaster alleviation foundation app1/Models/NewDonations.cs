using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appr_Disaster_alleviation_foundation_app1.Models
{
    public class NewDonations
    {

        [Key]
        public string DonorName { get; set; }
        public int DonationAmount { get; set; }
        public DateTime DateOfDonation { get; set; }
        public string ItemDesc { get; set; }
        public string DateOfGoodsDonation { get; set; }
    }
}
