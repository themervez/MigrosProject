using BackgroundJobs.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundJobs.Concrete
{
    public class SendMailService : ISendMailService
    {
        public void SendMail(int userId, string name)
        {
            
            Console.WriteLine($"E-mail has been sent to {name} with {userId} Id ");
        }
    }
}
