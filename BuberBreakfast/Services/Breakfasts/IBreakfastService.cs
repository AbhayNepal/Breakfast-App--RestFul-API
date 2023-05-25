using System;

using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService{
    ErrorOr<Created> CreateBreakfast(Breakfast request);
    ErrorOr<Breakfast> Delete(Guid id);
    ErrorOr<Updated> GetBreakfast(Guid  id);
    ErrorOr<Deleted> UpsertBreakfast(Breakfast breakfast);
}