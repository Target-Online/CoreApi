using CoreApi.Models.Configuration;
using CoreApi.Services.shared.Helpers;
using CoreApi.Services.Validations.Emails;
using Microsoft.Extensions.Options;
using System.Net.Mail;

namespace CoreApi.Services
{
    public class EmailsService : IEmailsService
    {
        private readonly ICipherService _cipherService;
        private readonly IEmailHelper _emailhelper;
        private readonly IEmailsValidation _emailsValidation;
        private readonly EnvironmentConfig _environmentConfig;

        public EmailsService(IOptions<EnvironmentConfig> environmentConfig, ICipherService cipherService, IEmailHelper emailhelper, IEmailsValidation emailsValidation)
        {
            _environmentConfig = environmentConfig.Value;
            _cipherService = cipherService;
            _emailhelper = emailhelper;
            _emailsValidation = emailsValidation;
        }

        public string SendEmail(Models.Email email)
        {
            var isValidEmail = _emailsValidation.IsEmailAddressValid(email.FromEmail);

            if (isValidEmail.isValid)
            {
                SmtpClient _smtpClient = _emailhelper.smtpClient(email.FromEmail, email.EmailPassword, email.Host, email.Port);
                _smtpClient.Send(email.FromEmail, email.ToEmail, email.Subject, email.Body);
                return isValidEmail.message;
            }

            return isValidEmail.message;
        }
    }
}
