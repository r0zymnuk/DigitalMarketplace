﻿namespace DigitalMarketplace.Core.Models;
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Category? Parent { get; set; }
    public List<Category>? Children { get; set; }
}
