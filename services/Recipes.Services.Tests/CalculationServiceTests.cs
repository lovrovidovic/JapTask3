using Moq;
using NUnit.Framework;
using Recipes.Common.Enums;
using Recipes.Core.Entities;
using Recipes.Services.Interfaces;
using Recipes.Services.Services;
using System;
using System.Collections.Generic;

namespace Recipes.Services.Tests
{
    [TestFixture]
    public class CalculationServiceTests
    {
        private CalculationService _calculationService;
        private Mock<IConversionService> _conversionServiceMock;

        [SetUp]
        public void SetUp()
        {
            _conversionServiceMock = new Mock<IConversionService>();
            _calculationService = new CalculationService(_conversionServiceMock.Object);
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
                NormativeUnit = UnitType.g,
            };
            _conversionServiceMock.Setup(x => x.ConvertQuantity(It.IsAny<float>(), It.IsAny<UnitType>()))
                .Returns((float quantity, UnitType unit) => { return quantity; });


            var result = _calculationService.CalculateIngredientUnitCost(ingredient);
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
                NormativeUnit = UnitType.kg,
            };
            _conversionServiceMock.Setup(x => x.ConvertQuantity(It.IsAny<float>(), It.Is<UnitType>(x => x == UnitType.kg)))
                .Returns((float quantity, UnitType unit) => { return quantity * 1000; });

            var result = _calculationService.CalculateIngredientUnitCost(ingredient);
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
                NormativeUnit = UnitType.l,
            };
            _conversionServiceMock.Setup(x => x.ConvertQuantity(It.IsAny<float>(), It.Is<UnitType>(x => x == UnitType.l)))
                .Returns((float quantity, UnitType unit) => { return quantity * 1000; });

            var result = _calculationService.CalculateIngredientUnitCost(ingredient);
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
                            UnitType = UnitType.g,
                            Ingredient = new Ingredient{
                                Id = 1,
                                NormativePrice = 10,
                                NormativeQuantity = 10,
                                NormativeUnit = UnitType.g,
                                UnitPrice = 1
                            }
                        }
                    }
            };
            _conversionServiceMock.Setup(x => x.ConvertQuantity(It.IsAny<float>(), It.Is<UnitType>(x => x == UnitType.ml || x == UnitType.g)))
                .Returns((float quantity, UnitType unit) => { return quantity; });

            var result = _calculationService.CalculateRecipeCost(recipe);

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
                            UnitType = UnitType.g,
                            Ingredient = new Ingredient{
                                Id = 1,
                                NormativePrice = 10,
                                NormativeQuantity = 10,
                                NormativeUnit = UnitType.g,
                                UnitPrice = 1
                            }
                        },
                        new RecipeIngredient
                        {
                            IngredientId = 2,
                            RecipeId = 1,
                            Quantity = 50,
                            UnitType = UnitType.g,
                            Ingredient = new Ingredient{
                                Id = 2,
                                NormativePrice = 20,
                                NormativeQuantity = 10,
                                NormativeUnit = UnitType.g,
                                UnitPrice = 2
                            }
                        },
                        new RecipeIngredient
                        {
                            IngredientId = 3,
                            RecipeId = 1,
                            Quantity = 20,
                            UnitType = UnitType.g,
                            Ingredient = new Ingredient{
                                Id = 3,
                                NormativePrice = 30,
                                NormativeQuantity = 10,
                                NormativeUnit = UnitType.g,
                                UnitPrice = 3
                            }
                        }
                    }
            };
            _conversionServiceMock.Setup(x => x.ConvertQuantity(It.IsAny<float>(), It.Is<UnitType>(x => x == UnitType.ml || x == UnitType.g)))
                .Returns((float quantity, UnitType unit) => { return quantity; });

            var result = _calculationService.CalculateRecipeCost(recipe);

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
                            UnitType = UnitType.g,
                            Ingredient = new Ingredient{
                                Id = 1,
                                NormativePrice = 71,
                                NormativeQuantity = 2,
                                NormativeUnit = UnitType.kg,
                                UnitPrice = 71/2000
                            }
                        },
                        new RecipeIngredient
                        {
                            IngredientId = 2,
                            RecipeId = 1,
                            Quantity = 3.5f,
                            UnitType = UnitType.kg,
                            Ingredient = new Ingredient{
                                Id = 2,
                                NormativePrice = 787.6f,
                                NormativeQuantity = 500,
                                NormativeUnit = UnitType.g,
                                UnitPrice = 787.6f/500
                            }
                        },
                        new RecipeIngredient
                        {
                            IngredientId = 3,
                            RecipeId = 1,
                            Quantity = 11.6f,
                            UnitType = UnitType.l,
                            Ingredient = new Ingredient{
                                Id = 3,
                                NormativePrice = 12.54f,
                                NormativeQuantity = 1.2f,
                                NormativeUnit = UnitType.l,
                                UnitPrice = 12.54f / (1.2f * 1000)
                            }
                        }
                    }
            };
            _conversionServiceMock.Setup(x => x.ConvertQuantity(It.IsAny<float>(), It.Is<UnitType>(x => x == UnitType.l || x == UnitType.kg)))
                .Returns((float quantity, UnitType unit) => { return quantity * 1000; });
            _conversionServiceMock.Setup(x => x.ConvertQuantity(It.IsAny<float>(), It.Is<UnitType>(x => x == UnitType.ml || x == UnitType.g)))
                .Returns((float quantity, UnitType unit) => { return quantity; });

            var result = _calculationService.CalculateRecipeCost(recipe);
            var expectedPrice = (float)Math.Round((((71 / 2000) * 378.4f) + ((787.6f / 500) * (3.5f * 1000)) + ((12.54f / (1.2f * 1000)) * (11.6f * 1000))), 2);

            Assert.AreEqual(expectedPrice, result);
        }
    }
}
