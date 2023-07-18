using alefbafilms.domian.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Domain.Entities.Gallery
{
    public class Gallery: BaseEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string Filename { get; set; }
        public ICollection<GalleryInCategory> GalleryCategory { get; set; }
    }
}
