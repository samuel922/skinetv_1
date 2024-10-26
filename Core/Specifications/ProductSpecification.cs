using System.Linq;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductSpecification : BaseSpecifcations<Product>
    {
        public ProductSpecification(ProductSpecParams specParams) : base(x =>
          (string.IsNullOrEmpty(specParams.Search) || x.Name.Contains(specParams.Search)) &&
         (specParams.Brands.Count == 0 || specParams.Brands.Contains(x.Brand)) &&
         (specParams.Types.Count == 0 || specParams.Types.Contains(x.Type)))
        {
            ApplyPagination(specParams.PageSize * (specParams.PageIndex - 1), specParams.PageSize);
            switch (specParams.Sort)
            {
                case "priceAsc":
                    AddOrderBy(x => x.Price);
                    break;
                case "priceDesc":
                    AddOrderByDesc(x => x.Price);
                    break;
                default:
                    AddOrderBy(x => x.Name);
                    break;
            }
        }
    }
}