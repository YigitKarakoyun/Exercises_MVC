using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjeMvcKisiselBlog.Models.Entity;

namespace ProjeMvcKisiselBlog.Models.Class
{
    public class CollectionClass
    {
        public IEnumerable<TBL_HAKKIMDA> tbl_HAKKIMDA;
        public IEnumerable<TBL_ILETISIM> tbl_ILETISIM;
        public IEnumerable<TBL_MESSAGE> tbl_MESAJ;
    }
}