using AgricultureUIPresentation.Models;
using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUIPresentation.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            var values = _imageService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddImage()
        {
            return View(new ImageAddViewModel());
        }

        [HttpPost]
        public IActionResult AddImage(ImageAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _imageService.Insert(new Image()
                {
                    Title = model.Title,
                    ImageUrl = model.ImageUrl,
                    Description = model.Description
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult DeleteImage(int id)
        {
            var values = _imageService.GetById(id);
            _imageService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditImage(int id)
        {
            var values = _imageService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditImage(Image image)
        {
            _imageService.Update(image);
            return RedirectToAction("Index");
        }
    }
}
