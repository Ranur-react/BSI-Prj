using API.Contexts;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class DivisionRepository: GeneralRepository<MyContext, Division, string>
    {
        public DivisionRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
