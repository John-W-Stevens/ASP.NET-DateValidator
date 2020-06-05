using System;
using System.ComponentModel.DataAnnotations;

namespace DateValidator.Models
{

    // Add Custom Validation Class here:

    public class ValidDepartureDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Type cast 'value' into a DateTime:
            DateTime InputDate = Convert.ToDateTime(value);
            
            if (InputDate >= DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Departure date needs to be in the future.");
            }
        }
    }


    public class Trip
    {

        [Required]
        [Display(Name = "Departure Date:")]
        [DataType(DataType.Date)]
        [ValidDepartureDate] // use custom validation here
        public DateTime DepartureDate { get; set; }

    }
}
