using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    class ProductManager
    {
        private readonly IProduction _production;

        public ProductManager(IProduction iproduct) 
        {
            _production = iproduct;
        }

        public void Create() 
        {
            _production.Create();
        }
    }
}
