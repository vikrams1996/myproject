using mallform.Models;
using System.ComponentModel.DataAnnotations;

namespace mallform.ViewModel
{
    public class TenantFormViewModel
    {

        [Required]
       [StringLength(50)]
        public string shopName { get; set; }
        
        [Required]
        [StringLength(50)]
        public string brandName { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]

        public string mobileNo { get; set; }

        [StringLength(50)]
        [Required]
        public string panNo { get; set; }

    
        public Tenant Tenant { get; set; }


        public string Size { get; set; }

        public string Floor { get; set; }

        public string shopNo { get; set; }

        public Unit Unit { get; set; }




    }
}