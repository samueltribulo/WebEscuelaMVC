using System.ComponentModel.DataAnnotations;

namespace WebEscuelaMVC.Validations
{
    public class MayorACienValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            var numero = (int)value;

            if (numero <= 100)
            {
                return new ValidationResult("El numero debe ser mayor a 100");
            }

            return ValidationResult.Success;
        }
    }
}
