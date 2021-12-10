using System.Text.Json.Serialization;

namespace Recipes.Common.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserType
    {
        Admin,
        User
    }
}
