using DAL.EfBase;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IUserRepository : IEfBaseRepository<User>
    {
        User GetUserWithPassword(string email);
    }
}
