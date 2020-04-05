using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryData;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class CatalogController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        private ILibraryAsset _assets;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="assets"></param>
        public CatalogController(ILibraryAsset assets)
        {
            _assets = assets;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var assetModels = _assets.GetAll();
       
            return View();
        }
    }
}