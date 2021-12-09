﻿using Recipes.Common.Enums;
using Recipes.Core.Entities;

namespace Recipes.Services.Interfaces
{
    public interface IConversionService
    {
        float ConvertQuantity(float quantity, UnitType unit);
    }
}
