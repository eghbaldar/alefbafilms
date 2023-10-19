using alefbafilm6.Application.Services.Productions.Queries.GetProductions;
using alefbafilm6.Domain.Entities.Productions;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Infrastructure.MappingProfiles.Productions
{
    public class ProductionsMappingProfile: Profile
    {
        public ProductionsMappingProfile()
        {
            CreateMap<Products, GetProductionsServiceDto>()
                .ForMember(dest => dest.InsertTime, act => act.MapFrom(y => Convert(y.InsertTime.Date.ToString())))
                .ForMember(dest => dest.ProductionDate, act => act.MapFrom(y => Convert(y.ProductionDate.Date.ToString())))
                .ReverseMap(); //this line must not be before "ForMember" at all.
        }
        private string Convert(string GregorianDate)
        {
            DateTime d = DateTime.Parse(GregorianDate);
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}/{1}/{2}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));
        }
    }
}
