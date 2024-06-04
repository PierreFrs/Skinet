// <copyright file="IProductRepository.cs" company="p.fraisse@recygroup.local Pierre FRAISSE">
// Copyright (c) p.fraisse@recygroup.local Pierre FRAISSE. All rights reserved.
// </copyright>

using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository
{
    Task<Product> GetProductByIdAsync(int id);
    
    Task<IReadOnlyList<Product>> GetProductsAsync();
    
    Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
    
    Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
}