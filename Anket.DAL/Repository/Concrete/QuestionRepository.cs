using Survey.Entity.Concrete;
using Survey.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DAL.Repository.Concrete
{
    public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
    {
    }
}
