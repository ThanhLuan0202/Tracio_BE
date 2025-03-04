using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? Description { get; set; }

    public int? StockQuantity { get; set; }

    public int? CategoryId { get; set; }

    public string? Condition { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? Image { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<BookingProduct> BookingProducts { get; set; } = new List<BookingProduct>();

    public virtual ProductsCategory? Category { get; set; }
}
