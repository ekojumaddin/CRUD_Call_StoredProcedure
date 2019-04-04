using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_CallSP.Models
{
    public class barang
    {
        public int kode_barang { get; set; }
        public string nama_barang { get; set; }
        public int harga_barang { get; set; }
        public int total_barang { get; set; }
    }
}