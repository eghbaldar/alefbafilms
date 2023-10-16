using alefbafilms.domian.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Domain.Entities.Productions
{
    public class Products:BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string Genre { get; set; }
        public string? Time { get; set; }
        public DateTime ProductionDate { get; set; }= DateTime.Now;
        public string  PhotoBig { get; set; }
        public string PhotoSmall{ get; set; }

    }
}
