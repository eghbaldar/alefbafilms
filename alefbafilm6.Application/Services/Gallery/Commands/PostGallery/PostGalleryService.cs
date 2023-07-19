﻿using alefbafilm6.Domain.Entities.Gallery;
using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Gallery.Commands.PostGallery
{
    public class PostGalleryService : IPostGalleryService
    {
        private readonly IDataBaseContext _context;
        public PostGalleryService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestPostGalleryServiceDto req)
        {
            alefbafilm6.Domain.Entities.Gallery.Gallery _gallery = //Why did not we use only "Gallery"? because of beign the same folder name as Gallery.cs
                new alefbafilm6.Domain.Entities.Gallery.Gallery()
                {
                    Name = req.Name,
                    Filename = Guid.NewGuid() + req.Filename,
                    Detail = req.Detail,
                    InsertTime = DateTime.Now,
                };
            var cat = _context.GalleryCategory.Find(req.IdGalleryCategory);
            List<GalleryInCategory> _galleryCategory = new List<GalleryInCategory>();
            _galleryCategory.Add(new GalleryInCategory
            {
                IdCategory = req.IdGalleryCategory,
                IdGallery = _gallery.Id,
                GalleryCategory = cat,
                Gallery = _gallery,
            });
            _gallery.GalleryCategory = _galleryCategory;

            _context.Gallery.Add(_gallery);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "عکس جدید اضافه شد - New Photo Added To Gallery",
            };
        }
    }
}
