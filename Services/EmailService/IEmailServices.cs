namespace Email_API.Services.EmailService
{
    public interface IEmailServices
    {
        void SendEmail (EmailDto request);
    }
}
