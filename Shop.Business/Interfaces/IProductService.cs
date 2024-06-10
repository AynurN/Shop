using Shop.Business.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Interfaces
{
    public  interface IProductService
    {
        void Create(ProductCreateDto product);
        ProductGetDto Get(int id);
        List<ProductGetDto> GetAll();
        void Delete(int id);
    }
}
