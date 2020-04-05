using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models.Catalog;
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

            var listingResult = assetModels
                .Select(result => new AssetIndexListingModel
                { 
                    Id = result.Id,
                    AuthorOrDirector = _assets.GetAuthorOrDirector(result.Id),
                    DeweyCallNumer = _assets.GetDeweyIndex(result.Id),
                    ImageUrl = result.ImageUrl,
                    Type = _assets.GetType(result.Id),
                    Title = result.Title,
                });

            var model = new AssetIndexModel()
            {
                Assets = listingResult
            };

            return View(model);
        }
    }
}