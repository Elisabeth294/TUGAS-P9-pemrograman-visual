using System.ComponentModel.DataAnnotations.Schema;

namespace WarkopKasir.Models
{
    [Table("produk")] // Nama tabel sesuai yang ada di database
    public class Produk
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public decimal Harga { get; set; }
    }
}
