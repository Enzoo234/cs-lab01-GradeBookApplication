using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {

        RankedGradeBook (string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

    }
}
