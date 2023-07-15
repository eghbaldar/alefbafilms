﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using alefbafilms.Persistence.Contexts;

#nullable disable

namespace alefbafilms.Persistence.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("alefbafilms.domian.Entities.Users.Role", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            id = 1L,
                            InsertTime = new DateTime(2023, 7, 6, 0, 36, 30, 238, DateTimeKind.Local).AddTicks(6026),
                            name = "Admin"
                        },
                        new
                        {
                            id = 2L,
                            InsertTime = new DateTime(2023, 7, 6, 0, 36, 30, 238, DateTimeKind.Local).AddTicks(6069),
                            name = "Operator"
                        },
                        new
                        {
                            id = 3L,
                            InsertTime = new DateTime(2023, 7, 6, 0, 36, 30, 238, DateTimeKind.Local).AddTicks(6080),
                            name = "User"
                        },
                        new
                        {
                            id = 4L,
                            InsertTime = new DateTime(2023, 7, 6, 0, 36, 30, 238, DateTimeKind.Local).AddTicks(6090),
                            name = "Guest"
                        });
                });

            modelBuilder.Entity("alefbafilms.domian.Entities.Users.User", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("alefbafilms.domian.Entities.Users.UserInRole", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserInRoles");
                });

            modelBuilder.Entity("alefbafilms.domian.Entities.Users.UserInRole", b =>
                {
                    b.HasOne("alefbafilms.domian.Entities.Users.Role", "Role")
                        .WithMany("UserInRole")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("alefbafilms.domian.Entities.Users.User", "User")
                        .WithMany("UserInRole")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("alefbafilms.domian.Entities.Users.Role", b =>
                {
                    b.Navigation("UserInRole");
                });

            modelBuilder.Entity("alefbafilms.domian.Entities.Users.User", b =>
                {
                    b.Navigation("UserInRole");
                });
#pragma warning restore 612, 618
        }
    }
}
