using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SingletonDb
{
    public class ProjectDbSingleton
    {
        private ProjectDbSingleton()
        {

        }
        private static ProjectDbContext _context;
        public static ProjectDbContext Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new ProjectDbContext();
                }
                return _context;
            }
        }
    }
}
