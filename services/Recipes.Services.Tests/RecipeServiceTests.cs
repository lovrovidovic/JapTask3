using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using Recipes.Common.Enums;
using Recipes.Core.Dtos;
using Recipes.Core.Entities;
using Recipes.Core.Requests;
using Recipes.Database;
using Recipes.Services.Interfaces;
using Recipes.Services.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Services.Tests
{
    [TestFixture]
    public class RecipeServiceTests
    {
        private RecipeService _recipeService;
        private Mock<IMapper> mapperMock;
        private Mock<ICalculationService> _calculationServiceMock;
        private DbContextOptions<RecipesDbContext> _options;
        private RecipesDbContext _recipesContext;

        [OneTimeSetUp]
        public void SetUp()
        {
            _options = new DbContextOptionsBuilder<RecipesDbContext>()
                .UseInMemoryDatabase(databaseName: "RecipesTests").Options;
            _recipesContext = new RecipesDbContext(_options);
            mapperMock = new Mock<IMapper>();
            _calculationServiceMock = new Mock<ICalculationService>();
            _recipeService = new RecipeService(_recipesContext, mapperMock.Object, _calculationServiceMock.Object);

            _recipesContext.Users.Add(new User
            {
                Id = 1,
            });
            _recipesContext.Categories.Add(new Category
            {
                Id = 1,
                Recipes = new List<Recipe>
                {
                    new Recipe { Id = 1 },
                    new Recipe { Id = 2 },
                    new Recipe { Id = 3 },
                    new Recipe { Id = 4 },
                    new Recipe { Id = 5 },
                    new Recipe { Id = 6 },
                    new Recipe { Id = 7 },
                    new Recipe { Id = 8 },
                    new Recipe { Id = 9 },
                    new Recipe { Id = 10 },
                    new Recipe { Id = 11 },
                    new Recipe { Id = 12 },
                    new Recipe { Id = 13 },
                    new Recipe { Id = 14 },
                    new Recipe { Id = 15 },
                    new Recipe { Id = 16 },
                    new Recipe { Id = 17 },
                    new Recipe { Id = 18 },
                    new Recipe { Id = 19 },
                    new Recipe { Id = 20 }
                }
            });
            _recipesContext.Ingredients.AddRange(
                new Ingredient
                {
                    Id = 1,
                    Name = "First",
                    CreatedBy = 1,
                },
                new Ingredient
                {
                    Id = 2,
                    Name = "Second",
                    CreatedBy = 1,
                },
                new Ingredient
                {
                    Id = 3,
                    Name = "Third",
                    CreatedBy = 1,
                },
                new Ingredient
                {
                    Id = 4,
                    Name = "Fourth",
                    CreatedBy = 1,
                }
            );

            _recipesContext.SaveChanges();
        }

        //User can't create recipe with same ingredients
        [Test]
        public async Task CreateRecipeAsync_TwoEqualIngredients_CreateRecipeWithOneIngredient()
        {
            var request = new RequestCreateRecipe
            {
                Name = "RecipeWith2EqualIngredients",
                Description = "New Description",
                CategoryId = 1,
                UserId = 1,
                RecipeIngredient = new List<CreateRecipeIngredientDto> {
                    new CreateRecipeIngredientDto {
                        IngredientId = 1,
                        Quantity = 10,
                        UnitType = UnitType.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 1,
                        Quantity = 20,
                        UnitType = UnitType.kg
                    }
                }
            };

            await _recipeService.CreateRecipeAsync(request);
            Recipe createdRecipe = await _recipesContext.Recipes.FirstOrDefaultAsync(x => x.Name == request.Name);

            Assert.That(createdRecipe.RecipeIngredients, Is.Unique);
            Assert.That(createdRecipe.RecipeIngredients.Count, Is.EqualTo(1));
            Assert.That(createdRecipe.RecipeIngredients.First().IngredientId, Is.EqualTo(request.RecipeIngredient.First().IngredientId));
        }

        [Test]
        public async Task CreateRecipeAsync_FewIngredients_CreateRecipeWithCorrectIngredients()
        {
            var request = new RequestCreateRecipe
            {
                Name = "NewRecipeWith2EqualIngredients",
                Description = "New Description",
                CategoryId = 1,
                UserId = 1,
                RecipeIngredient = new List<CreateRecipeIngredientDto> {
                    new CreateRecipeIngredientDto {
                        IngredientId = 1,
                        Quantity = 10,
                        UnitType = UnitType.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 1,
                        Quantity = 20,
                        UnitType = UnitType.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 2,
                        Quantity = 10,
                        UnitType = UnitType.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 2,
                        Quantity = 10,
                        UnitType = UnitType.kg
                    },
                }
            };

            await _recipeService.CreateRecipeAsync(request);
            Recipe createdRecipe = await _recipesContext.Recipes.FirstOrDefaultAsync(x => x.Name == request.Name);

            Assert.That(createdRecipe.RecipeIngredients, Is.Unique);
            Assert.That(createdRecipe.RecipeIngredients.Count, Is.EqualTo(2));
            Assert.That(createdRecipe.RecipeIngredients, Has.Exactly(1).Matches<RecipeIngredient>(x => x.IngredientId == 1)
                .And.Exactly(1).Matches<RecipeIngredient>(x => x.IngredientId == 2));
        }

        [Test]
        public async Task CreateRecipeAsync_ManyIngredients_CreateRecipeWithCorrectIngredients()
        {
            var request = new RequestCreateRecipe
            {
                Name = "NewRecipeWithManyEqualIngredients",
                Description = "New Description",
                CategoryId = 1,
                UserId = 1,
                RecipeIngredient = new List<CreateRecipeIngredientDto> {
                    new CreateRecipeIngredientDto {
                        IngredientId = 1,
                        Quantity = 10,
                        UnitType = UnitType.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 2,
                        Quantity = 10,
                        UnitType = UnitType.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 1,
                        Quantity = 20,
                        UnitType = UnitType.kg
                    },

                    new CreateRecipeIngredientDto {
                        IngredientId = 2,
                        Quantity = 10,
                        UnitType = UnitType.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 3,
                        Quantity = 10,
                        UnitType = UnitType.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 2,
                        Quantity = 10,
                        UnitType = UnitType.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 4,
                        Quantity = 10,
                        UnitType = UnitType.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 3,
                        Quantity = 10,
                        UnitType = UnitType.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 4,
                        Quantity = 10,
                        UnitType = UnitType.kg
                    },
                }
            };

            await _recipeService.CreateRecipeAsync(request);
            Recipe createdRecipe = await _recipesContext.Recipes.FirstOrDefaultAsync(x => x.Name == request.Name);

            Assert.That(createdRecipe.RecipeIngredients, Is.Unique);
            Assert.That(createdRecipe.RecipeIngredients.Count, Is.EqualTo(4));
            Assert.That(createdRecipe.RecipeIngredients, Has.Exactly(1).Matches<RecipeIngredient>(x => x.IngredientId == 1)
                .And.Exactly(1).Matches<RecipeIngredient>(x => x.IngredientId == 2)
                .And.Exactly(1).Matches<RecipeIngredient>(x => x.IngredientId == 3)
                .And.Exactly(1).Matches<RecipeIngredient>(x => x.IngredientId == 4));
        }

        //Load more tests
        [Test]
        public async Task GetRecipesAsync_TakeDifferentPages_GetsDifferentPages()
        {
            var firstRequest = new RequestSearchRecipe { Page = 0, CategoryId = 1 };
            var secondRequest = new RequestSearchRecipe { Page = 1, CategoryId = 1 };

            var firstResult = await _recipeService.GetRecipesAsync(firstRequest);
            var firstIngredientIds = firstResult.Data.Select(x => x.Id).ToList();
            var secondResult = await _recipeService.GetRecipesAsync(secondRequest);
            var secondIngredientIds = secondResult.Data.Select(x => x.Id).ToList();

            Assert.That(firstResult.Count, Is.EqualTo(10));
            Assert.That(secondResult.Count, Is.EqualTo(10));
            Assert.That(firstIngredientIds, Is.Not.EquivalentTo(secondIngredientIds));
            Assert.That(firstIngredientIds.Intersect(secondIngredientIds), Is.Empty);
            Assert.That(firstResult.Count, Is.EqualTo(secondResult.Count));
        }

        [Test]
        public async Task GetRecipesAsync_TakeSamePage_GetSamePage()
        {
            var firstRequest = new RequestSearchRecipe { Page = 0, CategoryId = 1 };
            var secondRequest = new RequestSearchRecipe { Page = 0, CategoryId = 1 };

            var firstResult = await _recipeService.GetRecipesAsync(firstRequest);
            var firstIngredientIds = firstResult.Data.Select(x => x.Id).ToList();
            var secondResult = await _recipeService.GetRecipesAsync(secondRequest);
            var secondIngredientIds = secondResult.Data.Select(x => x.Id).ToList();

            Assert.That(firstResult.Count, Is.EqualTo(10));
            Assert.That(secondResult.Count, Is.EqualTo(10));
            Assert.That(firstIngredientIds, Is.EquivalentTo(secondIngredientIds));
            Assert.That(firstResult.Count, Is.EqualTo(secondResult.Count));
        }

        [Test]
        public async Task GetRecipesAsync_TakeNonExistantPage_GetsEmptyResult()
        {
            var firstRequest = new RequestSearchRecipe { Page = 100, CategoryId = 1 };
            var secondRequest = new RequestSearchRecipe { Page = 200, CategoryId = 1 };

            var firstResult = await _recipeService.GetRecipesAsync(firstRequest);
            var firstIngredientIds = firstResult.Data.Select(x => x.Id).ToList();
            var secondResult = await _recipeService.GetRecipesAsync(secondRequest);
            var secondIngredientIds = secondResult.Data.Select(x => x.Id).ToList();

            Assert.That(firstResult.Count, Is.EqualTo(0));
            Assert.That(secondResult.Count, Is.EqualTo(0));
            Assert.That(firstIngredientIds, Is.EquivalentTo(secondIngredientIds));
            Assert.That(firstResult.Count, Is.EqualTo(secondResult.Count));
        }

        //Create recipe tests
        [Test]
        public async Task CreateRecipeAsync_SendRequest_CreatesRecipe()
        {
            var request = new RequestCreateRecipe
            {
                Name = "CreateRecipeTest1",
                Description = "New Description",
                CategoryId = 1,
                UserId = 1,
                RecipeIngredient = new List<CreateRecipeIngredientDto> {
                    new CreateRecipeIngredientDto {
                        IngredientId = 1,
                        Quantity = 10,
                        UnitType = UnitType.kg
                    }
                }
            };

            var result = await _recipeService.CreateRecipeAsync(request);
            Recipe createdRecipe = await _recipesContext.Recipes.FirstOrDefaultAsync(x => x.Name == request.Name);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True);
                Assert.That(createdRecipe, Is.Not.Null);
                Assert.That(createdRecipe.Description, Is.EqualTo(request.Description));
                Assert.That(createdRecipe.CategoryId, Is.EqualTo(request.CategoryId));
                Assert.That(createdRecipe.CreatedBy, Is.EqualTo(request.UserId));
                Assert.That(createdRecipe.RecipeIngredients.First().IngredientId, Is.EqualTo(request.RecipeIngredient.First().IngredientId));
                Assert.That(createdRecipe.RecipeIngredients.First().Quantity, Is.EqualTo(request.RecipeIngredient.First().Quantity));
                Assert.That(createdRecipe.RecipeIngredients.First().UnitType, Is.EqualTo(request.RecipeIngredient.First().UnitType));
            });
        }

        [Test]
        public async Task CreateRecipeAsync_SendRequestWithoutIngredients_ReturnsFalse()
        {
            var request = new RequestCreateRecipe
            {
                Name = "CreateRecipeTest2",
                Description = "New Description",
                CategoryId = 1,
                UserId = 1,
                RecipeIngredient = new List<CreateRecipeIngredientDto> { }
            };

            var result = await _recipeService.CreateRecipeAsync(request);

            Assert.That(result, Is.False);
        }
    }
}
