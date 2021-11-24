﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Recipes.Database;

namespace Recipes.Database.Migrations
{
    [DbContext(typeof(RecipesDbContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Recipes.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Salata"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2009, 6, 12, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Palacinke"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2018, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Waffle"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Hamburger"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2001, 5, 16, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Sendvic"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2005, 1, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Torta"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2021, 11, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Kolac"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2020, 5, 8, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Pita"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2020, 4, 14, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Pizza"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2018, 8, 6, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Sladoled"
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2017, 7, 9, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Jela s rostilja"
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2000, 4, 4, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Peciva"
                        });
                });

            modelBuilder.Entity("Recipes.Core.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<float>("NormativePrice")
                        .HasColumnType("real");

                    b.Property<float>("NormativeQuantity")
                        .HasColumnType("real");

                    b.Property<int>("NormativeUnit")
                        .HasColumnType("integer");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Brasno",
                            NormativePrice = 18.4f,
                            NormativeQuantity = 25f,
                            NormativeUnit = 0,
                            UnitPrice = 0.000736f
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Mlijeko",
                            NormativePrice = 10.3f,
                            NormativeQuantity = 15f,
                            NormativeUnit = 3,
                            UnitPrice = 0.0006866667f
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Secer",
                            NormativePrice = 5.5f,
                            NormativeQuantity = 250f,
                            NormativeUnit = 1,
                            UnitPrice = 0.022f
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Maslac",
                            NormativePrice = 20f,
                            NormativeQuantity = 2f,
                            NormativeUnit = 0,
                            UnitPrice = 0.01f
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Mlijecna cokolada",
                            NormativePrice = 10f,
                            NormativeQuantity = 500f,
                            NormativeUnit = 1,
                            UnitPrice = 0.02f
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Crna cokolada",
                            NormativePrice = 17.4f,
                            NormativeQuantity = 500f,
                            NormativeUnit = 1,
                            UnitPrice = 0.0348f
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Jaje",
                            NormativePrice = 3.6f,
                            NormativeQuantity = 10f,
                            NormativeUnit = 4,
                            UnitPrice = 0.36f
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Voda",
                            NormativePrice = 1.2f,
                            NormativeQuantity = 1f,
                            NormativeUnit = 3,
                            UnitPrice = 0.0012f
                        });
                });

            modelBuilder.Entity("Recipes.Core.Entities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Description = "Fini cokoladni kolac.",
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Cokoladni kolac"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2009, 6, 12, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Description = "Osvjezavajuci bijeli kolac",
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Bijeli kolac"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2018, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Description = "Kolac koji ima kokos",
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Rafaelo"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Description = "Kolac koji ima ferrero roche (samo u imenu)",
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Ferrero"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2001, 5, 16, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Description = "Kolac napravljen s jabukama",
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Kolac s jagodama"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2005, 1, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Description = "Kolac napravljen s jagodama",
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Kolac s jabukama"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2021, 11, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Description = "Kolac za djecu",
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Kinder"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2020, 5, 8, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Description = "Dva kolaca u jednom",
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Twix"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2020, 4, 14, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Description = "Kolac s ljesnacima i karamelom",
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Snickers"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 7,
                            CreatedAt = new DateTime(1999, 8, 10, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Description = "Kolac s orahom",
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Orah"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 7,
                            CreatedAt = new DateTime(1998, 8, 10, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Description = "Ovaj kolac sluzi za pokazivanje funkcionalnosti load more buttona",
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Specijalitet kuce"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2017, 7, 9, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Description = "Dummy Description",
                            ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Dummy recept"
                        });
                });

            modelBuilder.Entity("Recipes.Core.Entities.RecipeIngredient", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("integer");

                    b.Property<int>("IngredientId")
                        .HasColumnType("integer");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<int>("Unit")
                        .HasColumnType("integer");

                    b.HasKey("RecipeId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("RecipeIngredients");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            IngredientId = 1,
                            Quantity = 2f,
                            Unit = 0
                        },
                        new
                        {
                            RecipeId = 1,
                            IngredientId = 2,
                            Quantity = 2.5f,
                            Unit = 3
                        },
                        new
                        {
                            RecipeId = 1,
                            IngredientId = 3,
                            Quantity = 500f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 2,
                            IngredientId = 4,
                            Quantity = 20f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 2,
                            IngredientId = 8,
                            Quantity = 350f,
                            Unit = 2
                        },
                        new
                        {
                            RecipeId = 3,
                            IngredientId = 7,
                            Quantity = 4f,
                            Unit = 4
                        },
                        new
                        {
                            RecipeId = 3,
                            IngredientId = 5,
                            Quantity = 400f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 3,
                            IngredientId = 6,
                            Quantity = 1.7f,
                            Unit = 0
                        },
                        new
                        {
                            RecipeId = 4,
                            IngredientId = 1,
                            Quantity = 275f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 5,
                            IngredientId = 8,
                            Quantity = 1.1f,
                            Unit = 3
                        },
                        new
                        {
                            RecipeId = 5,
                            IngredientId = 4,
                            Quantity = 125f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 5,
                            IngredientId = 7,
                            Quantity = 1f,
                            Unit = 4
                        },
                        new
                        {
                            RecipeId = 6,
                            IngredientId = 2,
                            Quantity = 50f,
                            Unit = 2
                        },
                        new
                        {
                            RecipeId = 6,
                            IngredientId = 5,
                            Quantity = 15f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 7,
                            IngredientId = 6,
                            Quantity = 3.2f,
                            Unit = 0
                        },
                        new
                        {
                            RecipeId = 7,
                            IngredientId = 4,
                            Quantity = 80f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 8,
                            IngredientId = 2,
                            Quantity = 1f,
                            Unit = 3
                        },
                        new
                        {
                            RecipeId = 8,
                            IngredientId = 7,
                            Quantity = 3f,
                            Unit = 4
                        },
                        new
                        {
                            RecipeId = 9,
                            IngredientId = 2,
                            Quantity = 2f,
                            Unit = 3
                        },
                        new
                        {
                            RecipeId = 9,
                            IngredientId = 3,
                            Quantity = 1.9f,
                            Unit = 0
                        },
                        new
                        {
                            RecipeId = 9,
                            IngredientId = 4,
                            Quantity = 20f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 9,
                            IngredientId = 8,
                            Quantity = 70f,
                            Unit = 2
                        },
                        new
                        {
                            RecipeId = 10,
                            IngredientId = 1,
                            Quantity = 5f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 10,
                            IngredientId = 7,
                            Quantity = 2f,
                            Unit = 4
                        },
                        new
                        {
                            RecipeId = 11,
                            IngredientId = 5,
                            Quantity = 100f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 11,
                            IngredientId = 4,
                            Quantity = 740f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 12,
                            IngredientId = 5,
                            Quantity = 100f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 12,
                            IngredientId = 4,
                            Quantity = 740f,
                            Unit = 1
                        });
                });

            modelBuilder.Entity("Recipes.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "123",
                            Username = "user"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "sifra",
                            Username = "Mark"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "lozinka",
                            Username = "John"
                        });
                });

            modelBuilder.Entity("Recipes.Core.Entities.Recipe", b =>
                {
                    b.HasOne("Recipes.Core.Entities.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recipes.Core.Entities.User", "User")
                        .WithMany("Recipes")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Recipes.Core.Entities.RecipeIngredient", b =>
                {
                    b.HasOne("Recipes.Core.Entities.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recipes.Core.Entities.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Recipes.Core.Entities.Category", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("Recipes.Core.Entities.Ingredient", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("Recipes.Core.Entities.Recipe", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("Recipes.Core.Entities.User", b =>
                {
                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
