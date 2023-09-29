using Survey.Business.Abstract;
using Survey.DAL.Repository.Abstract;
using Survey.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Business.Concrete
{
    public class ChoiceManager : BaseManager<Choice>, IChoiceManager
    {
        public ChoiceManager(IChoiceRepository repository) : base(repository)
        {
        }
    }
}
