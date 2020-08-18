using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models.Invent
{
    public interface IBaseAddress
    {
        [Display(Name = "Street Address 1")]
        [Required]
        [StringLength(50)]
        string street1 { get; set; }

        [Display(Name = "Street Address 2")]
        [StringLength(50)]
        string street2 { get; set; }

        [Display(Name = "City")]
        [StringLength(30)]
        string city { get; set; }

        [Display(Name = "State")]
        [StringLength(30)]
        string province { get; set; }

        [Display(Name = "Country")]
        [StringLength(30)]
        string country { get; set; }
        
        //[Display(Name = "Phone")]
        //[StringLength(30)]
        //string phone { get; set; }

        //[Display(Name = "Email")]
        //[StringLength(30)]
        //string email { get; set; }

        //[Display(Name = "Primary Contact")]
        //[StringLength(30)]
        //string contact { get; set; }

        //[Display(Name = "Website")]
        //[StringLength(30)]
        //string website { get; set; }

        //[Display(Name = "Notes")]
        //[StringLength(30)]
        //string notes { get; set; }
    }
}
