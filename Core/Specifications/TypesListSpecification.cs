using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class TypesListSpecification : BaseSpecifications<Product, string>
    {
        public TypesListSpecification()
        {
            ApplySelect(x => x.Type);
            ApplyDistinct();
        }
    }
}