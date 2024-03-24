using CSProjeDemo1.Entity.Abstract;
using CSProjeDemo1.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entity.Concrete
{
   public class Book:BaseEntity
    {
        public string ISBN { get; set; }
        public string Baslık { get; set; }
        public string Yazar { get; set; }
        public DateTime YayınYılı { get; set; }
        public  State? Durum { get; set; }
        public  BookGenre KitapTuruId { get; set; }
        public BookGenre KitapTuru { get; set; }
    }
}
