using System;
using System.Collections.Generic;

namespace Tracio.Data.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? StockQuantity { get; set; }

    public string? Brand { get; set; }

    public double? Rating { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<BookingProduct> BookingProducts { get; set; } = new List<BookingProduct>();
}
