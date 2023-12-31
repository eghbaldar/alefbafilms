﻿using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Gallery.Commands.UpdateGalleryCategory
{
    public class UpdateGalleryCategoryService : IUpdateGalleryCategoryService
    {
        private readonly IDataBaseContext _context;
        public UpdateGalleryCategoryService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Exectue(int Id, string Name)
        {
            try
            {
                var galleryCategory = _context.GalleryCategory.Find(Id);
                if (galleryCategory == null)
                {
                    return new ResultDto
                    {
                        IsSuccess = true,
                        Message = "دسته ای یافت نشد",
                    };
                }
                galleryCategory.Name = Name;
                _context.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "تغییرات اعمال شد",
                };
            } catch (Exception ex)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "خطایی رخ داده است",
                };
            }
        }
    }
}
