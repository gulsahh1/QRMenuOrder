using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR.EntitiyLayer.Entities;

namespace DataAccessLayer.Abstract;

public interface IProductDal : IGenericDal<Product>
{
    List<Product> GetProductWithCategory();
    int ProductCount();
   
    int ProductCountByCategoryNameCoffee();
    int ProductCountByCategoryNameDrink();
    decimal ProductPriceAvg();

    string ProductNameByMaxPrice();
    string ProductNameByMinPrice();
    decimal ProductPriceByCoffee();


}
