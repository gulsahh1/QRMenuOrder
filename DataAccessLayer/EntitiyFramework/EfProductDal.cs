using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SignalR.EntitiyLayer.Entities;

namespace DataAccessLayer.EntitiyFramework;

public class EfProductDal : GenericRepository<Product>, IProductDal
{
    public EfProductDal(SignalRContext context) : base(context)
    {
    }

    public List<Product> GetProductWithCategory()
    {
        var context = new SignalRContext();
        var values = context.Products.Include(x => x.Category).ToList();
        return values;
    }

    public int ProductCount()
    {
       using var context =new SignalRContext();
        return context.Products.Count();
    }

    public int ProductCountByCategoryNameDrink()
    {
        using var context =new SignalRContext();
        return context.Products.Where( x=> x.CategoryID == (context.Categories.Where(y=>y.Name == "İçecek").Select(z=>z.CategoryID).FirstOrDefault())).Count();
    }

    public int ProductCountByCategoryNameCoffee()
    {
        using var context =new SignalRContext();
        return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.Name == "Kahve").Select(z => z.CategoryID).FirstOrDefault())).Count();
    }

    public decimal ProductPriceAvg()
    {
        using var context = new SignalRContext();

        return context.Products.Average(x => x.Price);
    }

    public string ProductNameByMaxPrice()
    {
       using var context =new SignalRContext();
        return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault() ?? "Ürün Bulunamadı";
    }

    public string ProductNameByMinPrice()
    {
        using var context = new SignalRContext();
        return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault() ?? "Ürün Bulunamadı";
    }

    public decimal ProductPriceByCoffee()
    {
        using var context = new SignalRContext();
        return context.Products.Where(x => x.CategoryID == (context.Categories.
        Where(y => y.Name == "Kahve").Select(z => z.CategoryID).FirstOrDefault())).Average(w =>w.Price);
    }
}
