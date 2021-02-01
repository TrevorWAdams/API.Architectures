using System.Threading.Tasks;
using OnionArchitecture.Application.DTOs.Email;

namespace OnionArchitecture.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}
