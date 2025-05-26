using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using MiniMarket.Models;
namespace MiniMarket.ViewModels
{
    public class ProductPageModel
    {
        [ValidateNever]
        public List<MiniMarket.Models.Product> Products { get; set; }
        public Product NewProduct {  get; set; }
       
    }
}
