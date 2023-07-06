using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation object 
            // ProductTest();
            //IoC
            //CategoryTest();
        }
        //private static void CategoryTest()
        //{
        //    CategoryMananger categoryMananger = new CategoryMananger(new EfCategoryDal());
        //    foreach (var category in categoryMananger.GetAll().Data)
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryMananger(new EfCategoryDal()));

        //    var result = productManager.GetProductDetails();
        //    if (result.Success)
        //    {
        //        foreach (var product in result.Data)
        //        {
        //            Console.WriteLine("{0}/{1}", product.ProductName, product.CategoryName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}
    }
}