using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using Recipes.Common.Enums;
using Recipes.Core.Entities;
using Recipes.Database;
using Recipes.Services.Interfaces;
using Recipes.Services.Services;
using System;
using System.Collections.Generic;

namespace Recipes.Services.Tests
{
    [TestFixture]
    public class ConversionServiceTests
    {
        private ConversionService _conversionService;
        private Mock<IConversionService> conversionServiceMock;

        [SetUp]
        public void SetUp()
        {
            conversionServiceMock = new Mock<IConversionService>();
            _conversionService = new ConversionService();
        }

        //CalculateIngredientUnitCost tests
        [Test]
        public void CalculateIngredientUnitCost_SimpleIngredient_CorrectCalculation()
        {
            var ingredient = new Ingredient
            {
                Id = 1,
                NormativePrice = 10,
                NormativeQuantity = 10,
                NormativeUnit = Unit.g,
            };

            var result = _conversionService.CalculateIngredientUnitCost(ingredient);
            var expectedPrice = ingredient.NormativePrice / ingredient.NormativeQuantity;

            Assert.That(result, Is.EqualTo(expectedPrice));
        }

        [Test]
        public void CalculateIngredientUnitCost_IngredientWithKgUnit_CorrectCalculation()
        {
            var ingredient = new Ingredient
            {
                Id = 1,
                NormativePrice = 10,
                NormativeQuantity = 10,
                NormativeUnit = Unit.kg,
            };

            var result = _conversionService.CalculateIngredientUnitCost(ingredient);
            var expectedPrice = ingredient.NormativePrice / (ingredient.NormativeQuantity * 1000);

            Assert.That(result, Is.EqualTo(expectedPrice));
        }

        [Test]
        public void CalculateIngredientUnitCost_IngredientWithCrazyPrice_CorrectCalculation()
        {
            var ingredient = new Ingredient
            {
                Id = 1,
                NormativePrice = 42354.14F,
                NormativeQuantity = 33.333F,
                NormativeUnit = Unit.l,
            };

            var result = _conversionService.CalculateIngredientUnitCost(ingredient);
            var expectedPrice = ingredient.NormativePrice / (ingredient.NormativeQuantity * 1000);

            Assert.That(result, Is.EqualTo(expectedPrice));
        }

        //CalculateRecipeCost tests
        [Test]
        public void CalculateRecipeCost_RecipeWithOneIngredient_CorrectCalculation()
        {
            var recipe = new Recipe
            {
                Id = 1,
                CategoryId = 1,
                RecipeIngredients = new List<RecipeIngredient>()
                    {
                        new RecipeIngredient
                        {
                            IngredientId = 1,
                            RecipeId = 1,
                            Quantity = 100,
                            Unit = Unit.g,
                            Ingredient = new Ingredient{
                                Id = 1,
                                NormativePrice = 10,
                                NormativeQuantity = 10,
                                NormativeUnit = Unit.g,
                                UnitPrice = 1
                            }
                        }
                    }
            };

            var result = _conversionService.CalculateRecipeCost(recipe);

            Assert.That(result, Is.EqualTo(100));
        }

        [Test]
        public void CalculateRecipeCost_RecipeWithManyIngredients_CorrectCalculation()
        {
            var recipe = new Recipe
            {
                Id = 1,
                CategoryId = 1,
                RecipeIngredients = new List<RecipeIngredient>()
                    {
                        new RecipeIngredient
                        {
                            IngredientId = 1,
                            RecipeId = 1,
                            Quantity = 100,
                            Unit = Unit.g,
                            Ingredient = new Ingredient{
                                Id = 1,
                                NormativePrice = 10,
                                NormativeQuantity = 10,
                                NormativeUnit = Unit.g,
                                UnitPrice = 1
                            }
                        },
                        new RecipeIngredient
                        {
                            IngredientId = 2,
                            RecipeId = 1,
                            Quantity = 50,
                            Unit = Unit.g,
                            Ingredient = new Ingredient{
                                Id = 2,
                                NormativePrice = 20,
                                NormativeQuantity = 10,
                                NormativeUnit = Unit.g,
                                UnitPrice = 2
                            }
                        },
                        new RecipeIngredient
                        {
                            IngredientId = 3,
                            RecipeId = 1,
                            Quantity = 20,
                            Unit = Unit.g,
                            Ingredient = new Ingredient{
                                Id = 3,
                                NormativePrice = 30,
                                NormativeQuantity = 10,
                                NormativeUnit = Unit.g,
                                UnitPrice = 3
                            }
                        }
                    }
            };

            var result = _conversionService.CalculateRecipeCost(recipe);

            Assert.That(result, Is.EqualTo(260));
        }

        [Test]
        public void CalculateRecipeCost_RecipeWithCrazyIngredients_CorrectCalculation()
        {
            var recipe = new Recipe
            {
                Id = 1,
                CategoryId = 1,
                RecipeIngredients = new List<RecipeIngredient>()
                    {
                        new RecipeIngredient
                        {
                            IngredientId = 1,
                            RecipeId = 1,
                            Quantity = 378.4f,
                            Unit = Unit.g,
                            Ingredient = new Ingredient{
                                Id = 1,
                                NormativePrice = 71,
                                NormativeQuantity = 2,
                                NormativeUnit = Unit.kg,
                                UnitPrice = 71/2000
                            }
                        },
                        new RecipeIngredient
                        {
                            IngredientId = 2,
                            RecipeId = 1,
                            Quantity = 3.5f,
                            Unit = Unit.kg,
                            Ingredient = new Ingredient{
                                Id = 2,
                                NormativePrice = 787.6f,
                                NormativeQuantity = 500,
                                NormativeUnit = Unit.g,
                                UnitPrice = 787.6f/500
                            }
                        },
                        new RecipeIngredient
                        {
                            IngredientId = 3,
                            RecipeId = 1,
                            Quantity = 11.6f,
                            Unit = Unit.l,
                            Ingredient = new Ingredient{
                                Id = 3,
                                NormativePrice = 12.54f,
                                NormativeQuantity = 1.2f,
                                NormativeUnit = Unit.l,
                                UnitPrice = 12.54f / (1.2f * 1000)
                            }
                        }
                    }
            };

            var result = _conversionService.CalculateRecipeCost(recipe);
            var expectedPrice = (float)Math.Round((((71 / 2000) * 378.4f) + ((787.6f / 500) * (3.5f * 1000)) + ((12.54f / (1.2f * 1000)) * (11.6f * 1000))), 2);

            Assert.AreEqual(expectedPrice, result);
        }
    }
}
