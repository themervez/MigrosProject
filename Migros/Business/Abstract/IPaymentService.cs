using Business.Configuration.Response;
using DTO.Payment;
using Models.Entities;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        public IEnumerable<SearchPaymentResponse> GetAll();
        public CommandResponse Insert(CreatePaymentRequest request);
        public CommandResponse Update(UpdatePaymentRequest request);
        public CommandResponse Delete(Payment payment);

        IEnumerable<SearchPaymentResponse2> GetAllForReport();
    }
}
