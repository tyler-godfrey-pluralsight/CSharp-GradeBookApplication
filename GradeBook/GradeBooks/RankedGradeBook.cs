using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.GradeBooks;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
    }
}
