using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appr_Disaster_alleviation_foundation_app1.Models
{
    public class Registration
    {
        [Key]
        public string userregusername { get; set; }
        public string userregpassword { get; set; }
    }
}
