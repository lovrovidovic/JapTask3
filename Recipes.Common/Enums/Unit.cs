using System.Text.Json.Serialization;

namespace Recipes.Common.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Unit
    {
        kg,
        g,
        ml,
        l,
        kom
    }
}
