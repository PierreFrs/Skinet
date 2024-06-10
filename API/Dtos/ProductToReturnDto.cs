// <copyright file="ProductToReturn.cs" company="p.fraisse@recygroup.local Pierre FRAISSE">
// Copyright (c) p.fraisse@recygroup.local Pierre FRAISSE. All rights reserved.
// </copyright>

namespace API.Dtos;

public class ProductToReturnDto
{
    public int Id { get; set; }
    
    public string Name { get; set; }
        
    public string Description { get; set; }
        
    public decimal Price { get; set; }
        
    public string PictureUrl { get; set; }
        
    public string ProductType { get; set; }
        
    public string ProductBrand { get; set; }
}