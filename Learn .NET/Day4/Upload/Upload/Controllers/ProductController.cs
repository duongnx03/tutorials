using System;
using Microsoft.AspNetCore.Mvc;
using Upload.IRepository;
using Upload.Models;

namespace Upload.Controllers
{
	public class ProductController : Controller
	{
		private readonly IProductRepo repo;
		IWebHostEnvironment env;// xu li upload file vat ly vao wwwrot

		public ProductController(IProductRepo repo, IWebHostEnvironment env)
		{
			this.repo = repo;
			this.env = env;
		}

		public async Task<IActionResult> Index()
		{
			return View(await repo.GetProducts());
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(Product product)
		{
			if (ModelState.IsValid)
			{
				//xu ly file upload vao wwwroot
				var filename = GetUniqueFilename(product.UploadImage.FileName);
				//lay duong dan vao folder images
				var upload = Path.Combine(env.WebRootPath, "images");
				var filepath = Path.Combine(upload, filename);
				//upload file vat ly vao duong dan da lay
				var stream = new FileStream(filepath, FileMode.Create);
				await product.UploadImage.CopyToAsync(stream);

				//lay du lieu vao db
				product.Image = filename;
				await repo.Create(product);
				return RedirectToAction("Index");
			}
			return View();
		}

		[NonAction]
		private string GetUniqueFilename(string filename)
		{
			filename = Path.GetFileName(filename);
			return Path.GetFileNameWithoutExtension(filename) + "-" + DateTime.Now.Ticks + Path.GetExtension(filename);
		}

		public async Task<IActionResult> Delete(int id)
		{
			await repo.Delete(id);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Edit(int id)
		{
			var product = await repo.GetProduct(id);
			return View(product);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, Product product)
		{
			if (ModelState.IsValid)
			{
				if(product.UploadImage != null)
				{
                    //xu ly file upload vao wwwroot
                    var filename = GetUniqueFilename(product.UploadImage.FileName);
                    //lay duong dan vao folder images
                    var upload = Path.Combine(env.WebRootPath, "images");
                    var filepath = Path.Combine(upload, filename);
                    //upload file vat ly vao duong dan da lay
                    var stream = new FileStream(filepath, FileMode.Create);
                    await product.UploadImage.CopyToAsync(stream);

					product.Image = filename;
				}
				else
				{
					//truong hop khong edit hinh
					Product old = await repo.GetProduct(id);
					product.Image = old.Image;
				}
				await repo.Update(product);
                return RedirectToAction("Index");
			}
			return View(product);
		}
	}
}

