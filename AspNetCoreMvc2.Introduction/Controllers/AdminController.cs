using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc2.Introduction.Controllers
{
    //eğer sana admin diye bir req gelirse sen çalış
    [Route("admin")]
    public class AdminController : Controller
    {
        //admin yazdığımızda default olarak save operasyonunun gelmesini isteyelim
        [Route("")]
        public string Save()
        {
            return "Saved";
        }

        [Route("delete/{id?}")]
        public string Delete(int id=0)
        {
            return String.Format("Deleted {0}",id);
        }

        [Route("update")]
        public string Update()
        {
            return "Update";
        }
    }
}