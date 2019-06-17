using System;

namespace StockManagementApp.Models
{
    public class Company
    {
        public int Id { get; set; }
        public int SerialNo { get; set; }
        public string Name { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}