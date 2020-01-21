using System.Net.Mail;

namespace CoreApi.Services.Validations.Emails
{
    public class EmailsValidation : IEmailsValidation
    {
        public (bool isValid, string message) IsEmailAddressValid(string emailAddress)
        {
            try
            {
                var addr = new MailAddress(emailAddress);
                return (addr.Address == emailAddress, "Email sent.");
            }
            catch
            {
                return (false, "Email Address Invalid!");
            }
        }
    }
}
