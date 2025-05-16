using Core.DTO;
using Methods.Repositories;
using Microsoft.AspNetCore.Mvc;
using PortafolioStore;

public class StoreController : Controller
{
    private readonly CategoryRepository _categoryRepo;
    private readonly ProductRepository _productRepo;

    public StoreController(CategoryRepository categoryRepo, ProductRepository productRepo)
    {
        _categoryRepo = categoryRepo;
        _productRepo = productRepo;
    }

    public IActionResult Index()
    {
        var model = new StoreViewModel
        {
            Categories = _categoryRepo.GetList(),
            Products = _productRepo.GetList()
        };
        return View(model);
    }

    [HttpPost]
    public IActionResult AddCategory([FromBody] StoreViewModel model)
    {
        try
        {
            _categoryRepo.Add(model.NewCategory);
            return Json(new { success = true });
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = ex.Message });
        }
    }

    [HttpPost]
    public IActionResult AddProduct([FromBody] StoreViewModel model)
    {
        try
        {
            _productRepo.Add(model.NewProduct);
            return Json(new { success = true });
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = ex.Message });
        }
    }

}
