﻿namespace alefbafilm6.Domain.Entities.Gallery
{
    public class GalleryInCategory
    {
        public long Id { get; set; }
        public virtual Gallery Gallery { get; set; }
        public long IdGallery { get; set; }
        public virtual GalleryCategory GalleryCategory { get; set; }
        public int IdCategory { get; set; }
    }
}
