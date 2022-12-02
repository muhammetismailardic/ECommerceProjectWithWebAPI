﻿// <auto-generated />
using System;
using DataAccess.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ECommerceDbContext))]
    [Migration("20220921213453_UpdateUserTable")]
    partial class UpdateUserTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.Concrete.AppOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("AppOperationClaims", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "AppUser"
                        },
                        new
                        {
                            Id = 2,
                            Name = "AppUserTypeAppOperationClaim"
                        },
                        new
                        {
                            Id = 3,
                            Name = "AppUserType"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserTypeID")
                        .HasColumnType("int")
                        .HasColumnName("AppUserTypeID");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<string>("GsmNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("GsmNumber");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LastName");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("PasswordHash");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("PasswordSalt");

                    b.Property<string>("ProfileImageUrl")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("ProfileImageUrl");

                    b.Property<Guid>("RefreshToken")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.HasIndex("AppUserTypeID");

                    b.ToTable("AppUsers", "dbo");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            AppUserTypeID = -1,
                            CreatedDate = new DateTime(2022, 9, 22, 0, 34, 52, 746, DateTimeKind.Local).AddTicks(1546),
                            CreatedUserId = 1,
                            Email = "ali@gmail.com",
                            FirstName = "Ali Yasin",
                            GsmNumber = "",
                            IsDeleted = false,
                            LastName = "Doğan",
                            PasswordHash = new byte[] { 158, 173, 246, 14, 157, 42, 247, 134, 21, 96, 47, 89, 89, 135, 61, 208, 125, 87, 206, 96, 20, 216, 140, 79, 201, 251, 150, 206, 126, 180, 138, 140, 86, 94, 214, 106, 253, 53, 14, 106, 97, 86, 87, 87, 160, 195, 62, 216, 197, 242, 195, 66, 20, 111, 238, 123, 222, 114, 184, 137, 197, 64, 17, 204 },
                            PasswordSalt = new byte[] { 220, 182, 9, 15, 131, 147, 130, 194, 54, 128, 249, 198, 201, 112, 242, 239, 71, 128, 207, 166, 1, 109, 193, 181, 36, 47, 47, 105, 186, 208, 16, 101, 170, 236, 78, 10, 75, 177, 125, 14, 37, 33, 202, 37, 85, 106, 175, 16, 76, 27, 67, 24, 195, 53, 250, 141, 0, 168, 125, 143, 39, 193, 141, 152, 17, 50, 167, 99, 80, 3, 253, 140, 119, 136, 92, 28, 15, 157, 129, 5, 116, 61, 40, 120, 193, 204, 99, 172, 191, 170, 6, 192, 201, 81, 133, 224, 114, 71, 237, 161, 16, 98, 44, 217, 114, 46, 206, 119, 16, 101, 136, 171, 171, 152, 151, 4, 251, 158, 61, 44, 219, 8, 121, 123, 176, 166, 243, 12 },
                            ProfileImageUrl = "",
                            RefreshToken = new Guid("dd7e878f-e985-48a6-b152-4f755a212b7d"),
                            UserName = "aliyasin"
                        },
                        new
                        {
                            Id = -2,
                            AppUserTypeID = -2,
                            CreatedDate = new DateTime(2022, 9, 22, 0, 34, 52, 747, DateTimeKind.Local).AddTicks(2598),
                            CreatedUserId = 1,
                            Email = "admin@gmail.com",
                            FirstName = "Admin",
                            GsmNumber = "",
                            IsDeleted = false,
                            LastName = "ADMIN",
                            PasswordHash = new byte[] { 158, 173, 246, 14, 157, 42, 247, 134, 21, 96, 47, 89, 89, 135, 61, 208, 125, 87, 206, 96, 20, 216, 140, 79, 201, 251, 150, 206, 126, 180, 138, 140, 86, 94, 214, 106, 253, 53, 14, 106, 97, 86, 87, 87, 160, 195, 62, 216, 197, 242, 195, 66, 20, 111, 238, 123, 222, 114, 184, 137, 197, 64, 17, 204 },
                            PasswordSalt = new byte[] { 220, 182, 9, 15, 131, 147, 130, 194, 54, 128, 249, 198, 201, 112, 242, 239, 71, 128, 207, 166, 1, 109, 193, 181, 36, 47, 47, 105, 186, 208, 16, 101, 170, 236, 78, 10, 75, 177, 125, 14, 37, 33, 202, 37, 85, 106, 175, 16, 76, 27, 67, 24, 195, 53, 250, 141, 0, 168, 125, 143, 39, 193, 141, 152, 17, 50, 167, 99, 80, 3, 253, 140, 119, 136, 92, 28, 15, 157, 129, 5, 116, 61, 40, 120, 193, 204, 99, 172, 191, 170, 6, 192, 201, 81, 133, 224, 114, 71, 237, 161, 16, 98, 44, 217, 114, 46, 206, 119, 16, 101, 136, 171, 171, 152, 151, 4, 251, 158, 61, 44, 219, 8, 121, 123, 176, 166, 243, 12 },
                            ProfileImageUrl = "",
                            RefreshToken = new Guid("c439cb2b-866f-4d14-bef4-163aeb7afa78"),
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppUserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppUserTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("AppUserTypeName");

                    b.HasKey("Id");

                    b.ToTable("AppUserTypes", "dbo");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            AppUserTypeName = "System Admin"
                        },
                        new
                        {
                            Id = -2,
                            AppUserTypeName = "Admin"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppUserTypeAppOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppOperationClaimID")
                        .HasColumnType("int")
                        .HasColumnName("OperationClaimId");

                    b.Property<int>("AppUserTypeID")
                        .HasColumnType("int")
                        .HasColumnName("UserTypeId");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("char(4)")
                        .HasColumnName("Status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppOperationClaimID");

                    b.HasIndex("AppUserTypeID");

                    b.ToTable("AppUserTypeAppOperationClaims", "dbo");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            AppOperationClaimID = 1,
                            AppUserTypeID = -2,
                            Status = "1011"
                        },
                        new
                        {
                            Id = -2,
                            AppOperationClaimID = 2,
                            AppUserTypeID = -2,
                            Status = "1111"
                        },
                        new
                        {
                            Id = -3,
                            AppOperationClaimID = 3,
                            AppUserTypeID = -2,
                            Status = "1111"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppUser", b =>
                {
                    b.HasOne("Core.Entities.Concrete.AppUserType", "AppUserType")
                        .WithMany()
                        .HasForeignKey("AppUserTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUserType");
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppUserTypeAppOperationClaim", b =>
                {
                    b.HasOne("Core.Entities.Concrete.AppOperationClaim", "AppOperationClaim")
                        .WithMany("AppUserTypeAppOperationClaims")
                        .HasForeignKey("AppOperationClaimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Concrete.AppUserType", "AppUserType")
                        .WithMany()
                        .HasForeignKey("AppUserTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppOperationClaim");

                    b.Navigation("AppUserType");
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppOperationClaim", b =>
                {
                    b.Navigation("AppUserTypeAppOperationClaims");
                });
#pragma warning restore 612, 618
        }
    }
}