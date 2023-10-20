using alefbafilm6.Application.Services.Productions.Queries.GetProductions;
using alefbafilm6.Common.Constants;
using alefbafilm6.Domain.Entities.Productions;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static alefbafilm6.Common.Constants.ProductionsConstants;

namespace alefbafilm6.Infrastructure.MappingProfiles.Productions
{
    public class ProductionsMappingProfile: Profile
    {
        public ProductionsMappingProfile()
        {
            CreateMap<Products, GetProductionsServiceDto>()
                .ForMember(dest => dest.InsertTime, act => act.MapFrom(y => Convert(y.InsertTime.Date.ToString())))
                .ForMember(dest => dest.ProductionDate_Persian, act => act.MapFrom(y => Convert(y.ProductionDate.Date.ToString())))
                .ForMember(dest => dest.GenreName, act => act.MapFrom(y => GetGenre(int.Parse(y.Genre))))
                .ForMember(dest => dest.Category, act => act.MapFrom(y => GetCat(int.Parse(y.CategoryName))))
                .ReverseMap(); //this line must not be before "ForMember" at all.
        }
        private string Convert(string GregorianDate)
        {
            DateTime d = DateTime.Parse(GregorianDate);
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}/{1}/{2}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));
        }
        private string GetGenre(int value)
        {
            ProductionsConstants _productionsConstants = new ProductionsConstants();
            var genre = _productionsConstants.Genre().Where(g=>g.Id== value).FirstOrDefault();
            return genre.Name;
        }
        private string GetCat(int value)
        {
            ProductionsConstants _productionsConstants = new ProductionsConstants();
            var cat = _productionsConstants.Category().Where(g => g.Id == value).FirstOrDefault();
            return cat.Name;
        }
    }
}
