
using alefbafilm6.Application.Services.Gallery.Commands.PostGallery;
using alefbafilm6.Domain.Entities.Gallery;
using alefbafilm6.Domain.Entities.Productions;
using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;
using Microsoft.AspNetCore.Http;

namespace alefbafilm6.Application.Services.Productions.Commands.PostProduct
{
    public class PostProductService: IPostProductService
    {
        private readonly IDataBaseContext _context;
        public PostProductService(IDataBaseContext context)
        {
            _context=context;
        }
        public ResultDto Execute(RequestPostProductServiceDto req)
        {

            Products products = new Products()
            {
                Title = req.Title,
                Description = req.Description,
                CategoryName = req.CategoryName,
                Genre= req.Genre,
                Time= req.Time,                
                ProductionDate= req.ProductionDate,
                PhotoBig= UploadFile(req.PhotoBig).FileName,
                PhotoSmall="" //UploadFile(req.PhotoSmall).FileName
            };
            _context.Products.Add(products);
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "اثر شما با موفقیت اضافه شد",
            };
        }
        private UploadDto UploadFile(IFormFile file)
        {
            //Necessary Package: Microsoft.AspNetCore.Http.Features
            //https://procodeguide.com/programming/file-upload-in-aspnet-core/
            if (file != null)
            {
                string folder = $@"wwwroot\images\production\";
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
