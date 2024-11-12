using Microsoft.AspNetCore.Mvc;
using CarvedRock.Data.Entities;
using CarvedRock.Domain;

namespace CarvedRock.Api.Controllers;

[ApiController]
[Route("[controller]")]
public partial class ProductController
    (
        ILogger<ProductController> logger,
        IProductLogic productLogic
    ) : ControllerBase
{

    [HttpGet]
    public async Task<IEnumerable<Product>> Get(string category = "all")
    {
        logger.LogInformation("Getting products in API for {category}", category);
        return await productLogic.GetProductsForCategoryAsync(category);
    }
}
