using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using LojaVirtualCleiton.Models;
using AutoMapper;
using LojaVirtualCleiton.Mappers;

namespace TesteLojaVirtual
{
    [TestClass]
    public class TestProdutoMapper
    {
        [TestInitialize]
        public void Int()
        {
            AutoMapperConfig.RegisterMappings();
        }

        [TestMethod]
        public void DeveMapearDeProdutoParaProdutoViewModel()
        {
            var produto = new Produto
            {
                Nome = "Chuteira Nike",
                Categoria = new Categoria
                {
                    Nome = "Calcados"
                }
            };
            var produtoViewModel = Mapper.Map<ProdutoViewModel>(produto);
            Assert.IsNotNull(produtoViewModel);
        }


        [TestMethod]
        public void DeveMapearNomeDoProduto()
        {
            var produto = new Produto
            {
                Nome = "Chuteira Nike",
                Categoria = new Categoria
                {
                    Nome = "Calcados"
                }
            };
            var produtoViewModel = Mapper.Map<ProdutoViewModel>(produto);
            Assert.AreEqual("Chuteira Nike",produtoViewModel.Nome);

        }

        [TestMethod]
        public void DeveMapearNomeDaCategoria()
        {
            var produto = new Produto
            {
                Nome = "Chuteira Nike",
                Categoria = new Categoria
                {
                    Nome = "Calcados"
                }
            };
            var produtoViewModel = Mapper.Map<ProdutoViewModel>(produto);
            Assert.AreEqual("Calcados", produtoViewModel.Categoria);




        }
    }
}
