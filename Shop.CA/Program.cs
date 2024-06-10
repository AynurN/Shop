using Shop.Business.DTOS;
using Shop.Business.Implementations;
using Shop.Business.Interfaces;

namespace Shop.CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductService productService=new ProductService();
            ProductCreateDto product1=new ProductCreateDto("Book1", 25,15 );
            ProductCreateDto product2=new ProductCreateDto("Book2", 30,20 );
            ProductCreateDto product3=new ProductCreateDto("Book3", 25,10 );
            productService.Create(product1);
            productService.Create(product2);
            productService.Create(product3);
            Console.WriteLine(productService.Get(2));
            Console.WriteLine("==========================");
            productService.GetAll().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("=========================================");
            productService.Delete(1);
            productService.GetAll().ForEach(x => Console.WriteLine(x));

        }
    }
}
