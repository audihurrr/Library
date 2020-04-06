using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.Catalog
{
    /// <summary>
    /// 
    /// </summary>
    public class AssetDetailModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int AssetId { get; set; }

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
        public int Year { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DeweyCallNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string  ISBN { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CurrentLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PatronName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Checkout LatestCheckout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<CheckoutHistory> CheckoutHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<AssetHoldModel> CurrentHolds { get; set; }
    }

    public class AssetHoldModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string PatronName { get; set;}

        /// <summary>
        /// 
        /// </summary>
        public string HoldPlaced { get; set; }

    }
}
