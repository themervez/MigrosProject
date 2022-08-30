using DAL.Abstract;
using DAL.DbContexts;
using DAL.EfBase;
using Models.Entities;

namespace DAL.Concrete.EF
{
    public class EFPaymentRepository : EfBaseRepository<Payment, MigrosDbContext>, IPaymentRepository
    {
        public EFPaymentRepository(MigrosDbContext context) : base(context)
        {
        }

        public object Get(int ıd)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Payment entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(object mappedEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}
