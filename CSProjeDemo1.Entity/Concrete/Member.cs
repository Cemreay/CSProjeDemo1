using CSProjeDemo1.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entity.Concrete
{
    public class Uye:BaseEntity,IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string UyeNo { get; set; }
        List<Book>UyeKitap { get; set; }=new List<Book>();
    }
}
