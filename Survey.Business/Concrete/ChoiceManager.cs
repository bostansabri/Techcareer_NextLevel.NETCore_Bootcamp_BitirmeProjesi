﻿using TechSurvey.Business.Abstract;
using TechSurvey.DAL.Repository.Abstract;
using TechSurvey.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSurvey.Business.Concrete
{
    public class ChoiceManager : BaseManager<Choice>, IChoiceManager
    {
    }
}
