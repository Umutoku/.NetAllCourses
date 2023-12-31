﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds;

public class ProductSeed : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(new Product()
            { Id = 1, Name = "kalem", CategoryId = 1, Price = 200, Stock = 20, CreatedDate = DateTime.Now });
    }
}