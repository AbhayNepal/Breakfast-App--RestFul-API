using BuberBreakfast.Models;
using BuberBreakfast.ServiceErrors;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
    public readonly Dictionary<Guid ,Breakfast> _breakfasts = new();
    
    public void CreateBreakfast(Breakfast breakfast)
    {
        _breakfasts.Add(breakfast.Id, breakfast);
    }

    public void Delete(Guid id)
    {
        _breakfasts.Remove(id);
    }

    public ErrorOr<Breakfast> GetBreakfast(Guid  id){
      if(_breakfasts.TryGetValue(id,out var breakfast)){
        return breakfast;
      }
      return Errors.NotFound;
    }

    public void UpsertBreakfast(Breakfast breakfast)
    {
       _breakfasts[breakfast.Id] = breakfast;
       Console.WriteLine("updated breakfast");
    }
}