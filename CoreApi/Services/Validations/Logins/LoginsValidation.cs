using CoreApi.Entities;
using CoreApi.Services.Validations.Emails;
using System.Linq;

namespace CoreApi.Services.Validations.Logins
{
    public class LoginsValidation : ILoginsValidation
    {
        private readonly Context _ffsaDbContext;
        private readonly IEmailsValidation _emailsValidation;

        public LoginsValidation(Context ffsaDbContext, IEmailsValidation emailsValidation)
        {
            _ffsaDbContext = ffsaDbContext;
            _emailsValidation = emailsValidation;
        }

        public (bool userEmailCorrect, string message) verifyUserEmail(string userEmail)
        {
            if (!_emailsValidation.IsEmailAddressValid(userEmail).isValid)
            {
                return (false, "Invalid email address!");
            }
            else if (_ffsaDbContext.Users.SingleOrDefault(u => u.Email == userEmail) != null)
            {
                return (false, "Email already exists!");
            }

            return (true, "User Details Approved.");
        }
    }
}
