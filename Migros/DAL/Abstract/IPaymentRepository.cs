using Models.Entities;
using DAL.EfBase;

namespace DAL.Abstract
{
    public interface IPaymentRepository : IEfBaseRepository<Payment>
    {
        void Insert(Payment entity);
        object Get(int ıd);
        void Update(object mappedEntity);
    }
}
