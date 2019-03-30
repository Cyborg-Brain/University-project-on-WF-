using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing.Domain.Entities.Infrastructure;
using Testing.Domain.Entities.Models;
using Testing.Domain.Repository.Interface;
using Testing.Models;


namespace Testing.Domain.Data
{
    public class AdminRepository : GenericRepository<Person>,IAdminRepository
    {
        public AdminRepository():base()
        {
        }

   
    }
}
