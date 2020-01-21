namespace CoreApi.Services
{
    public interface IEmailsService
    {
        string SendEmail(Models.Email email);
    }
}
