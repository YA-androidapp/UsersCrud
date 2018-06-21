using System.Threading.Tasks;

namespace UsersCrud.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
