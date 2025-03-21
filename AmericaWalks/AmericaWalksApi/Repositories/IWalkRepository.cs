﻿using AmericaWalksApi.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmericaWalksApi.Repositories
{
    public interface IWalkRepository
    {
        Task<Walk>CreateAsync(Walk walk);
        Task<List<Walk>> GetAllAsync(string? filterOn = null, string? filterQuery = null);
        Task<Walk?> GetByIdAsync(Guid id);
        Task<Walk?> UpdateAsync(Guid id, Walk walk);
        Task<Walk?> DeleteAsync(Guid id);
    }
}
