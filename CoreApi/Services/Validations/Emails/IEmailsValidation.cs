namespace CoreApi.Services.Validations.Emails
{
    public interface IEmailsValidation
    {
        (bool isValid, string message) IsEmailAddressValid(string emailAddress);
    }
}
