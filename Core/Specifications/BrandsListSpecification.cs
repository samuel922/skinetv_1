using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class BrandsListSpecification : BaseSpecifications<Product, string>
    {
        public BrandsListSpecification()
        {
            ApplySelect(x => x.Brand);
            ApplyDistinct();
        }
    }
}