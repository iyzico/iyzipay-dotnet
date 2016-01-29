using System;

namespace Iyzipay.Model
{
  public  class InstallmentPrice 
    {
        public decimal? Price { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? InstallmentNumber { get; set; }
    }
}
