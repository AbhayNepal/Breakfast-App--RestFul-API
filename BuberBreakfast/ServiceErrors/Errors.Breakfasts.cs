using ErrorOr;
namespace BuberBreakfast.ServiceErrors;
public static class Errors{
    public static Error NotFound => Error.NotFound(
        code: "Breakfast.NotFound",
        description: "Breakfast Not Found"
    );
}