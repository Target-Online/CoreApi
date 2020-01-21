namespace CoreApi.Services.Validations.Logins
{
    public interface ILoginsValidation
    {
        (bool userEmailCorrect, string message) verifyUserEmail(string userEmail);
    }
}
