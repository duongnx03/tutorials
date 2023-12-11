using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductOrder.Models;

namespace ProductOrder.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderDbContext db;

        public OrderController(OrderDbContext db)
        {
            this.db = db;
        }

        public async Task< IActionResult> Index()
        {
            var list = await db.Orders.ToListAsync();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var order = await db.Orders.SingleOrDefaultAsync(o => o.Id == id);
            var listOrderDetails = await db.OrderDetails.Where(od => od.OrderId == id).ToListAsync();
            //xoa du lieu trong orderdetail
            foreach (var item in listOrderDetails)
            {
                db.OrderDetails.Remove(item);
            }
            //xoa du lieu trong order
            db.Orders.Remove(order);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(string id)
        {
            var listOrderDetails = await db.OrderDetails.Where(od => od.OrderId == id).ToListAsync();
            ViewBag.OrderId = id;
            return View(listOrderDetails);
        }



        public IActionResult CreateOrderDetail(string OrderId)
        {
            ViewBag.OrderId = OrderId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderDetail(OrderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                db.OrderDetails.Add(orderDetail);
                await db.SaveChangesAsync();
                return Redirect($"Details/{orderDetail.OrderId}");
            }
            ViewBag.OrderId = orderDetail.OrderId;
            return View();
        }

        public async Task<IActionResult> DeleteOrderDetails(string OrderId, string ProductName)
        {
            var orderDetails = await db.OrderDetails.SingleOrDefaultAsync
                            (od => od.OrderId == OrderId && od.ProductName == ProductName);
            db.OrderDetails.Remove(orderDetails);
            await db.SaveChangesAsync();
            return Redirect($"Details/{OrderId}");
        }
    }
}

