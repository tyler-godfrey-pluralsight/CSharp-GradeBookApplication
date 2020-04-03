using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.GradeBooks;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool weighting) : base(name, weighting)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
