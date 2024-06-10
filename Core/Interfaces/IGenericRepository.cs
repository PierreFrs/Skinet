// <copyright file="IGenericRepository.cs" company="p.fraisse@recygroup.local Pierre FRAISSE">
// Copyright (c) p.fraisse@recygroup.local Pierre FRAISSE. All rights reserved.
// </copyright>

using Core.Entities;
using Core.Specification;

namespace Core.Interfaces;

public interface IGenericRepository<T>
    where T : BaseEntity
{
    Task<T> GetByIdAsync(int id);
    
    Task<IReadOnlyList<T>> ListAllAsync();
    
    Task<T> GetEntityWithSpec(ISpecification<T> spec);
    
    Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
}