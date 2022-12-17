using DevFreela.Core.DTOs;

namespace DevFreela.Infrastructure.Payments
{
    public interface IPaymentService
    {
        void ProcessPayment(PaymentInfoDTO paymentInfoDTO);
    }
}
