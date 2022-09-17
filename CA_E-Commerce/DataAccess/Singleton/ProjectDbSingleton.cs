using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Singleton
{
    public class ProjectDbSingleton
    {
        //Oluşturulan class'ı instance alınmasını constructor'ı private yaparak engelliyoruz.
        private ProjectDbSingleton()
        {

        }

        //Class içerisinde static olarak bir _context oluşturuyoruz. Bu örneğe dışarıdan erişimi private tanımlayarak engelliyoruz.
        private static ProjectDbContext _context;

        //Context isimli property yukarıda alınan static yapıdaki örneğe ulaşmamızı sağlayan propert olarak tanımlandı.
        public static ProjectDbContext Context
        {
            get
            {
                if (_context==null)
                {
                    _context = new ProjectDbContext();
                }
                return _context;
            }
        }

    }
}
