using AutoMapper;
using LojaVirtualCleiton.Models;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtualCleiton.Mappers
{
    public class FornecedorViewModelMappingProfile: Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Fornecedor, FornecedorViewModel>();
            //.ForMember (dest=> dest.Categoria, opt => opt.MapFrom(src => src.Categoria.Nome));
            Mapper.CreateMap<FornecedorViewModel, Fornecedor>();
               // .ForMember(dest => dest.Categoria, opt =>opt.Ignore());
        }
    }
}