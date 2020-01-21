using System.Net.Mail;

namespace CoreApi.Services.shared.Helpers
{
    public interface IEmailHelper
    {
        SmtpClient smtpClient(string emailAccount, string password, string host, int port);
        void constructEmailBody(Models.Email email);
    }
}
