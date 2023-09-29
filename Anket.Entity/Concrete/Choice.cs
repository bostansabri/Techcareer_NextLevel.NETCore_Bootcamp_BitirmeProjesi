using Survey.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Entity.Concrete
{
    public class Choice : BaseEntity
    {
        public string? Choice1 { get; set; }
        public string? Choice2 { get; set;}
        public string? Choice3 { get; set;}
        public string? Choice4 { get; set;}

        public ICollection<Question> Questions { get; set; }
    }
}
