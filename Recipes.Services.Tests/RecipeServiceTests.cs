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
        private Mock<IConversionService> conversionServiceMock;
        private DbContextOptions<RecipesDbContext> _options;
        private RecipesDbContext _recipesContext;

        [OneTimeSetUp]
        public void SetUp()
        {
            _options = new DbContextOptionsBuilder<RecipesDbContext>()
                .UseInMemoryDatabase(databaseName: "RecipesTests").Options;
            _recipesContext = new RecipesDbContext(_options);
            mapperMock = new Mock<IMapper>();
            conversionServiceMock = new Mock<IConversionService>();
            _recipeService = new RecipeService(_recipesContext, mapperMock.Object, conversionServiceMock.Object);

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
                    new Recipe { Id = 10 }
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
                        Unit = Unit.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 1,
                        Quantity = 20,
                        Unit = Unit.kg
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
                        Unit = Unit.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 1,
                        Quantity = 20,
                        Unit = Unit.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 2,
                        Quantity = 10,
                        Unit = Unit.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 2,
                        Quantity = 10,
                        Unit = Unit.kg
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
                        Unit = Unit.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 2,
                        Quantity = 10,
                        Unit = Unit.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 1,
                        Quantity = 20,
                        Unit = Unit.kg
                    },
                    
                    new CreateRecipeIngredientDto {
                        IngredientId = 2,
                        Quantity = 10,
                        Unit = Unit.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 3,
                        Quantity = 10,
                        Unit = Unit.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 2,
                        Quantity = 10,
                        Unit = Unit.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 4,
                        Quantity = 10,
                        Unit = Unit.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 3,
                        Quantity = 10,
                        Unit = Unit.kg
                    },
                    new CreateRecipeIngredientDto {
                        IngredientId = 4,
                        Quantity = 10,
                        Unit = Unit.kg
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
        [TestCase(2, 4)]
        [TestCase(4, 10)]
        public async Task GetRecipesAsync_TakeLessAndMore_GetsLessAndMoreRecipes(int lowTakeAmmount, int highTakeAmmount)
        {
            var lowRequest = new RequestSearchRecipe { TakeAmmount = lowTakeAmmount, CategoryId = 1 };
            var highRequest = new RequestSearchRecipe { TakeAmmount = highTakeAmmount, CategoryId = 1 };

            var lowResult = await _recipeService.GetRecipesAsync(lowRequest);
            var highResult = await _recipeService.GetRecipesAsync(highRequest);

            Assert.That(lowResult.Count, Is.EqualTo(lowTakeAmmount));
            Assert.That(highResult.Count, Is.EqualTo(highTakeAmmount));
            Assert.That(lowResult.Count, Is.LessThan(highResult.Count));
        }

        [TestCase(200, 300)]
        public async Task GetRecipesAsync_TakeMoreThanAvailable_GetsMaxRecipes(int lowTakeAmmount, int highTakeAmmount)
        {
            var lowRequest = new RequestSearchRecipe { TakeAmmount = lowTakeAmmount, CategoryId = 1 };
            var highRequest = new RequestSearchRecipe { TakeAmmount = highTakeAmmount, CategoryId = 1 };

            var lowResult = await _recipeService.GetRecipesAsync(lowRequest);
            var highResult = await _recipeService.GetRecipesAsync(highRequest);

            Assert.That(lowResult.Count, Is.LessThan(lowTakeAmmount));
            Assert.That(highResult.Count, Is.LessThan(highTakeAmmount));
            Assert.That(lowResult.Count, Is.EqualTo(highResult.Count));
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
                        Unit = Unit.kg
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
                Assert.That(createdRecipe.RecipeIngredients.First().Unit, Is.EqualTo(request.RecipeIngredient.First().Unit));
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
                RecipeIngredient = new List<CreateRecipeIngredientDto> {}
            };

            var result = await _recipeService.CreateRecipeAsync(request);

            Assert.That(result, Is.False);
        }
    }
}
