using TechSurvey.Entity.Concrete;
using TechSurvey.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSurvey.DAL.Repository.Concrete
{
    public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
    {
    }
}
