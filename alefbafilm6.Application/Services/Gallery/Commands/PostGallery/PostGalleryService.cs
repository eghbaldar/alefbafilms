using alefbafilm6.Domain.Entities.Gallery;
using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;
using Microsoft.AspNetCore.Http;
using System;

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
                    Detail = req.Detail,
                    InsertTime = DateTime.Now,
                };

            var uploadedResult = UploadFile(req.Filename);
            _gallery.Filename = uploadedResult.FileName;

            var cat = _context.GalleryCategory.Find(req.IdGalleryCategory);
            List<GalleryInCategory> _galleryCategory = new List<GalleryInCategory>();
            _galleryCategory.Add(new GalleryInCategory
            {
                GalleryCategoryId = req.IdGalleryCategory,
                GalleryId = _gallery.Id,
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
        private UploadDto UploadFile(IFormFile file)
        {
            //Necessary Package: Microsoft.AspNetCore.Http.Features
            //https://procodeguide.com/programming/file-upload-in-aspnet-core/
            if (file != null)
            {
                string folder = $@"images\ProductImages\";
                var uploadsRootFolder = Path.Combine(Environment.CurrentDirectory, folder);
                if (!Directory.Exists(uploadsRootFolder))
                {
                    Directory.CreateDirectory(uploadsRootFolder);
                }


                if (file == null || file.Length == 0)
                {
                    return new UploadDto()
                    {
                        Status = false,
                        FileName = "",
                    };
                }

                string fileName = DateTime.Now.Ticks.ToString() + file.FileName;
                var filePath = Path.Combine(uploadsRootFolder, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                return new UploadDto()
                {
                    FileName = fileName,
                    Status = true,
                };
            }
            return null;
        }
    }
}
