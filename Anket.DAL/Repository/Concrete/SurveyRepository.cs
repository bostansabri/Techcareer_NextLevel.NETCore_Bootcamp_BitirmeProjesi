using TechSurvey.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSurvey.Entity.Concrete;

namespace TechSurvey.DAL.Repository.Concrete
{
    public class SurveyRepository : BaseRepository<Survey>, ISurveyRepository
    {
    }
}
