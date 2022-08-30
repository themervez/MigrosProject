using DAL.Abstract;
using DAL.DbContexts;
using DAL.EfBase;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EF
{
    public class EFUserRepository : EfBaseRepository<User, MigrosDbContext>, IUserRepository
    {
        public EFUserRepository(MigrosDbContext context) : base(context)
        {
        }

        public User GetUserWithPassword(string email)
        {
            return Context.Users
                .Include(x => x.Password)
                .FirstOrDefault(x => x.Email == email);
        }
    }
}
