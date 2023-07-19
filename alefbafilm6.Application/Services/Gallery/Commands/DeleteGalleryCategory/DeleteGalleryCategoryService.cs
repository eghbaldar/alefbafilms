﻿using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Gallery.Commands.DeleteGalleryCategory
{
    public class DeleteGalleryCategoryService : IDeleteGalleryCategoryService
    {
        private readonly IDataBaseContext _context;
        public DeleteGalleryCategoryService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(int Id)
        {
            var galleryCategory = _context.GalleryCategory.Find(Id);
            if(galleryCategory == null)
            {
                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "دسته مورد تظر یافت نشد - Considered Category not Found",
                };
            }

            _context.GalleryCategory.Remove(galleryCategory);
            _context.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "دسته مورد نظر با موفقیت حذف شد - Considered Category was Deleted!",
            };
        }
    }
}