﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseService.Migrations
{
    [DbContext(typeof(ListContext))]
    partial class ListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("library.ToDoItems", b =>
                {
                    b.Property<string>("ToDoItemsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("deadline")
                        .HasColumnType("TEXT");

                    b.HasKey("ToDoItemsId");

                    b.ToTable("items");
                });
#pragma warning restore 612, 618
        }
    }
}
