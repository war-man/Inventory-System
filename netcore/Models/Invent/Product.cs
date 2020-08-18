using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models.Invent
{
    public class Product: INetcoreBasic
    {
        public Product()
        {
            this.createdAt = DateTime.UtcNow;
        }
        [Display(Name = "Active Product? ")]
        [Required]
        public bool productStatus { get; set; }

        [StringLength(38)]
        [Display(Name = "Product Id")]
        public string productId { get; set; }

        [StringLength(50)]
        [Display(Name = "Product Sku")]
        [Required]
        public string productCode { get; set; }

        [StringLength(50)]
        [Display(Name = "Product Name")]
        [Required]
        public string productName { get; set; }

        [StringLength(50)]
        [Display(Name = "Description")]
        [Required]
        public string description { get; set; }

        [StringLength(50)]
        [Display(Name = "Barcode")]
        public string barcode { get; set; }

        [StringLength(50)]
        [Display(Name = "Serial Number")]
        public string serialNumber { get; set; }

        [Display(Name = "Product Type")]
        [Required]
        public ProductType productType { get; set; }
       
        [Display(Name = "Unit")]
        [Required]
        public UOM uom { get; set; }

        [Display(Name = "Qty")]
        [Required]
        public float Qty { get; set; }

        [Display(Name = "Min Qty")]
        [Required]
        public float minQuantity { get; set; }
        
        [Display(Name = "ReStock Flag")]
        public bool flag { get; set; }

        [Display(Name = "Product Link")]
        public string link { get; set; }

        [Display(Name = "Notes")]
        public string notes { get; set; }
    }
}
