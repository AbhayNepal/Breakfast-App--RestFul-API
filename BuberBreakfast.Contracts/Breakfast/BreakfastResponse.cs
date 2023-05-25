namespace BuberBreakfast.Contracts.Breakfast
{
    public record BreakfastResponse(
        Guid id,
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime LastModifiedDateTime,
        DateTime EndDateTime,
        List<string> Savory,
        List<string> Sweet
    );
}
