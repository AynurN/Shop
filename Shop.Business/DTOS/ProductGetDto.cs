using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.DTOS
{
    public record ProductGetDto(int Id, string Name, double SalePrice);
    
}
