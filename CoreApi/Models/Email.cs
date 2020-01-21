namespace CoreApi.Models
{
    public class Email
    {
        public string FromEmail { get; set; }
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string EmailPassword { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}
