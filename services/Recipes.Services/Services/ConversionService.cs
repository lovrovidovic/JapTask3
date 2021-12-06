using Recipes.Common.Enums;
using Recipes.Core.Dtos;
using Recipes.Core.Entities;
using Recipes.Services.Interfaces;
using System;
using System.Linq;

namespace Recipes.Services.Services
{
    public class ConversionService : IConversionService
    {
        //kalkulacije u drugi servis
        public float ConvertQuantity(float quantity, UnitType unit)
        {
            if (unit == UnitType.kg || unit == UnitType.l)
            {
                return quantity * 1000;
            }
            return quantity;
        }
    }
}
