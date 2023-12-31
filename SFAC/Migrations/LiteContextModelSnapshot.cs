﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SFAC.Models.Core;

#nullable disable

namespace SFAC.Migrations
{
    [DbContext(typeof(LiteContext))]
    partial class LiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("SFAC.Models.Room.Room_Model", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Removal_Time")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("room_Models");
                });
#pragma warning restore 612, 618
        }
    }
}
