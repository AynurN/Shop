using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.DTOS
{
    public record ProductCreateDto(string Name, double salePrice, double costPrice);
   
}
