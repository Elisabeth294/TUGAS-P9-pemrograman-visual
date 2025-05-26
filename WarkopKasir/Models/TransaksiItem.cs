namespace WarkopKasir.Models
{
    public class TransaksiItem
    {
        public int Id { get; set; }

        public int TransaksiId { get; set; }
        public Transaksi Transaksi { get; set; }

        public int ProdukId { get; set; }
        public Produk Produk { get; set; }

        public int Jumlah { get; set; }
    }
}
