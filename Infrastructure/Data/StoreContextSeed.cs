// <copyright file="StoreContextSeed.cs" company="p.fraisse@recygroup.local Pierre FRAISSE">
// Copyright (c) p.fraisse@recygroup.local Pierre FRAISSE. All rights reserved.
// </copyright>

using System.Text.Json;
using Core.Entities;
using Infrastructue.Data;

namespace Infrastructure.Data;

public class StoreContextSeed
{
    public static async Task SeedAsync(StoreContext context)
    {
        if (!context.ProductBrands.Any())
        {
            var brandsData = File.ReadAllText("../Infrastructure/Data/SeedData/brands.json");
            var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
            
            context.ProductBrands.AddRange(brands);

            await context.SaveChangesAsync();
        }

        if (!context.ProductTypes.Any())
        {
            var typesData = File.ReadAllText("../Infrastructure/Data/SeedData/types.json");
            var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);
            
            context.ProductTypes.AddRange(types);

            await context.SaveChangesAsync();
        }

        if (!context.Products.Any())
        {
            var productsData = File.ReadAllText("../Infrastructure/Data/SeedData/products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(productsData);
            
            context.Products.AddRange(products);

            await context.SaveChangesAsync();
        }

        if (context.ChangeTracker.HasChanges())
        {
            await context.SaveChangesAsync();
        }
    }
}