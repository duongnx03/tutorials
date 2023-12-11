using System;
using AutoMapper;

namespace Demo_DTO.Models
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<ProductDTO, Product>();
			CreateMap<Product, ProductDTO>();
		}
	}
}

