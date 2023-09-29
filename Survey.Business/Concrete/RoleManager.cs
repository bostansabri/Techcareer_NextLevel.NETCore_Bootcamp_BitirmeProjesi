using Survey.Entity.Concrete;
using Survey.Business.Abstract;
using Survey.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Business.Concrete
{
    public class RoleManager : BaseManager<Role>, IRoleManager
    {
        public RoleManager(IRoleRepository repository) : base(repository)
        {
        }
    }
}
