using System.Text.Json.Serialization;

namespace Recipes.Common.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SortOrder
    {
        DESC,
        ASC,
        NONE
    }
}
