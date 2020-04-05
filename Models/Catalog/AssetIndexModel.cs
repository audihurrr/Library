using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.Catalog
{
    public class AssetIndexModel
    {
        /// <summary>
        /// Collection of Asset Index Listing Models. 
        /// Creates Page Model for every page, and particular model for every component
        /// for consistency.
        /// </summary>
        public IEnumerable<AssetIndexListingModel> Assets { get; set; }
    }
}
