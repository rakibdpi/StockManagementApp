using System;

namespace StockManagementApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int Serial { get; set; }
        public string Name { get; set; }
        public string LoginBy { get; set; }
        public DateTime CreateDate { get; set; }
        //public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}