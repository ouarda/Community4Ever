﻿// <auto-generated />
using C4E.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace C4E.Migrations
{
    [DbContext(typeof(C4EContext))]
    partial class C4EContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("C4E.Models.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("persons");
                });
#pragma warning restore 612, 618
        }
    }
}
