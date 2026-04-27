using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR.EntitiyLayer.Entities;

namespace BusinessLayer.Abstract;

public interface IProductService : IGenericService<Product>
{
    List<Product> TGetProductWithCategory();
    int TProductCount();
    int TProductCountByCategoryNameCoffee();
    int TProductCountByCategoryNameDrink();
    decimal TProductPriceAvg();
    string TProductNameByMaxPrice();
    string TProductNameByMinPrice();
    decimal TProductPriceByCoffee();
}
