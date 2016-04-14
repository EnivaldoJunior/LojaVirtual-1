using FluentNHibernate.Mapping;

namespace Modelo
{
    public class ProdutoMap: ClassMap<Produto>
    {
        public ProdutoMap()
        {
            Id( x =>x.Id).GeneratedBy.GuidComb();
            Map(x => x.Nome);
            References(x => x.Categoria);
            References(x => x.Fornecedor);
        }
    }
}
