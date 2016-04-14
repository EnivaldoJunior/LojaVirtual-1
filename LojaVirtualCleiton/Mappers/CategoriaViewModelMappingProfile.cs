using AutoMapper;
using LojaVirtualCleiton.Models;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtualCleiton.Mappers
{
    public class CategoriaViewModelMappingProfile: Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Categoria, CategoriaViewModel>();
            //.ForMember (dest=> dest.Categoria, opt => opt.MapFrom(src => src.Categoria.Nome));
            Mapper.CreateMap<CategoriaViewModel, Categoria>();
               // .ForMember(dest => dest.Categoria, opt =>opt.Ignore());
        }
    }
}