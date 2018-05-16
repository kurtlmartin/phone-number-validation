using System.Text.RegularExpressions;

namespace PhoneNumberValidation
{
    public class Validation
    {
        public bool IsPhoneNumberValide(string phoneNumber)
        {
            var regexObj = new Regex(@"^(?:(?:\+?[0-9]{1,3}\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$");
            
            return regexObj.IsMatch(phoneNumber);
        }
    }
}