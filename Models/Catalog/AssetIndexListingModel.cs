using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.Catalog
{
    public class AssetIndexListingModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ImageUrl { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string AuthorOrDirector { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DeweyCallNumer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NumberOfCopies { get; set; }
    }
}
