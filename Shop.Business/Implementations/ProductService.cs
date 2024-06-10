using Shop.Business.DTOS;
using Shop.Business.Interfaces;
using Shop.Core.Models;
using Shop.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Implementations
{
    public class ProductService : IProductService
    {
        public void Create(ProductCreateDto product)
        { 
            ShopData.products.Add(new Product(product.Name, product.costPrice, product.salePrice));
        }

        public void Delete(int id)
        {
           Product? product= ShopData.products.Find(x => x.ID == id);
            if (product != null)
            { 
                ShopData.products.Remove(product);

            }
            else
            throw new Exception("Product could not be found!");

           

        }

        public ProductGetDto Get(int id)
        {
           Product? product= ShopData.products.Find(x=> x.ID==id);
            return new(product.ID,product.Name,product.SalePrice);

        }

        public List<ProductGetDto> GetAll()
        {
            List<Product> products = ShopData.products;
            List<ProductGetDto> productGetDtos = new List<ProductGetDto>();
            foreach (var item in products)
            {
                productGetDtos.Add(new ProductGetDto(item.ID, item.Name, item.SalePrice));
            }
            return productGetDtos;
        }
    }
}
