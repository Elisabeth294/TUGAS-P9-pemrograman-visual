using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WarkopKasir.Models;

namespace WarkopKasir.Controllers
{
    public class ProdukController : Controller
    {
        private readonly AppDbContext _context;

        public ProdukController(AppDbContext context)
        {
            _context = context;
        }

        // Tampilkan semua produk
        public IActionResult Index()
        {
            var data = _context.Produks.ToList();
            return View(data);
        }

        // Tampilkan form tambah produk
        public IActionResult Create()
        {
            return View();
        }

        // Proses tambah produk
        [HttpPost]
        public IActionResult Create(Produk produk)
        {
            if (ModelState.IsValid)
            {
                _context.Produks.Add(produk);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produk);
        }

        // Tampilkan form edit
        public IActionResult Edit(int id)
        {
            var produk = _context.Produks.Find(id);
            if (produk == null) return NotFound();
            return View(produk);
        }

        // Proses update
        [HttpPost]
        public IActionResult Edit(Produk produk)
        {
            if (ModelState.IsValid)
            {
                _context.Produks.Update(produk);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produk);
        }

        // Tampilkan konfirmasi hapus
        public IActionResult Delete(int id)
        {
            var produk = _context.Produks.Find(id);
            if (produk == null) return NotFound();
            return View(produk);
        }

        // Proses hapus
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var produk = _context.Produks.Find(id);
            if (produk == null) return NotFound();

            _context.Produks.Remove(produk);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
