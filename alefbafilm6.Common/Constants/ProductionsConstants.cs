using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Common.Constants
{
    public class ProductionsConstants
    {
        public class ProductionCategory
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class ProductionGenre
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public List<ProductionCategory> Category()
        {
            List<ProductionCategory> cat = new List<ProductionCategory>()
            {
                new ProductionCategory { Id=1 , Name="فیلم کوتاه" },
                new ProductionCategory { Id=2 , Name="فیلم بلند" },
                new ProductionCategory { Id=3 , Name= "تبلیغاتی"  },
                new ProductionCategory { Id=4 , Name="جُنگ" },
            };
            return cat;

        }
        public List<ProductionGenre> Genre()
        {
            List<ProductionGenre> genre = new List<ProductionGenre>()
            {
                new ProductionGenre{ Id=1, Name = "موزیک ویدیو" },
                new ProductionGenre{ Id=2,Name = "انیمیشن"},
                new ProductionGenre{ Id=3,Name = "مستند" },
                new ProductionGenre{ Id=4,Name="داستانی" },
                new ProductionGenre{ Id=5,Name="تجربی" },
            };
            return genre;
        }
    }
}
