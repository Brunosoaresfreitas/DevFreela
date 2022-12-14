using DevFreela.Core.DTOs;

namespace DevFreela.Infrastructure.Payments
{
    public interface IPaymentService
    {
        Task<bool> ProcessPayment(PaymentInfoDTO paymentInfoDTO);
    }
}
