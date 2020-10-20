using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class MappingPorfiles : Profile
    {
        public MappingPorfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
                .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
                CreateMap<Address, AddressDto>().ReverseMap();
                CreateMap<CustomerBasketDto, CustomerBasket>();
                CreateMap<BasketItemDto, BasketItem>();
        }
    }
}
