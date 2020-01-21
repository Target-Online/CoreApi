using CoreApi.Models.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace CoreApi.Services.shared.Helpers
{
    public class EmailHelper : IEmailHelper
    {
        private readonly EnvironmentConfig _environmentConfig;

        public EmailHelper(IOptions<EnvironmentConfig> environmentConfig)
        {
            _environmentConfig = environmentConfig.Value;
        }

        public void constructEmailBody(Models.Email email)
        {
            var message = new StringBuilder();
            message.Append(email.Body);
        }

        public SmtpClient smtpClient(string emailAccount, string password, string host, int port)
        {
            return new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(emailAccount, password),
                EnableSsl = false
            };
        }
    }
}
