using System;
using System.Collections.Generic;

namespace WarkopKasir.Models
{
    public class Transaksi
    {
        public int Id { get; set; }
        public DateTime Tanggal { get; set; } = DateTime.Now;

        // List item transaksi
        public List<TransaksiItem> Items { get; set; } = new();
    }
}
