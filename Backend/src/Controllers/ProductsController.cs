using Microsoft.AspNetCore.Mvc;

[Controller]

public class ProductsController {

    IProductsService _productsService;

    public ProductsController(IProductsService productsService) {
        _productsService = productsService;
    }

    [HttpGet("/products")]
    public string returnProductsPlaceholderString() {
        string productsString = _productsService.getProductsPlaceholderString();
        return productsString;
    }
}
