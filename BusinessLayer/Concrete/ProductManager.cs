using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using SignalR.EntitiyLayer.Entities;

namespace BusinessLayer.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;
    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }
    public void TAdd(Product entity)
    {
        _productDal.Add(entity);
    }

    public void TDelete(Product entity)
    {
         _productDal.Delete(entity);
    }

    public Product TGetById(int id)
    {
       return _productDal.GetById(id);
    }

    public List<Product> TGetListAll()
    {
       return _productDal.GetListAll();
    }

    public List<Product> TGetProductWithCategory()
    {
        return _productDal.GetProductWithCategory();
    }

    public int TProductCount()
    {
        return _productDal.ProductCount();
    }

    public int TProductCountByCategoryNameDrink()
    {
        return _productDal.ProductCountByCategoryNameDrink();
    }

    public int TProductCountByCategoryNameCoffee()
    {
        return _productDal.ProductCountByCategoryNameCoffee();
    }

    public void TUpdate(Product entity)
    {
        _productDal.Update(entity);
    }

    public decimal TProductPriceAvg()
    {
        return _productDal.ProductPriceAvg();
    }

    public string TProductNameByMaxPrice()
    {
       return _productDal.ProductNameByMaxPrice();
    }

    public string TProductNameByMinPrice()
    {
       return _productDal.ProductNameByMinPrice();
    }

    public decimal TProductPriceByCoffee()
    {
        return _productDal.ProductPriceByCoffee();

    }
}
