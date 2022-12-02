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
    [Migration("20220723121035_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Concrete.AppOperationClaim", b =>
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

            modelBuilder.Entity("Entities.Concrete.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int")
                        .HasColumnName("UserTypeId");

                    b.HasKey("Id");

                    b.ToTable("AppUsers", "dbo");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreatedDate = new DateTime(2022, 7, 23, 15, 10, 33, 957, DateTimeKind.Local).AddTicks(7047),
                            CreatedUserId = 1,
                            Email = "ali@gmail.com",
                            FirstName = "Ali Yasin",
                            GsmNumber = "",
                            IsDeleted = false,
                            LastName = "Doğan",
                            PasswordHash = new byte[] { 203, 118, 128, 141, 193, 235, 163, 168, 249, 144, 166, 212, 154, 19, 208, 141, 121, 109, 98, 82, 111, 251, 79, 44, 24, 179, 64, 253, 125, 182, 78, 167, 251, 103, 27, 119, 192, 143, 40, 63, 139, 22, 211, 114, 39, 75, 145, 130, 156, 121, 62, 65, 241, 151, 92, 174, 139, 101, 7, 31, 174, 87, 37, 249 },
                            PasswordSalt = new byte[] { 184, 150, 200, 252, 217, 98, 187, 170, 66, 246, 46, 78, 14, 4, 93, 56, 173, 44, 188, 228, 156, 138, 132, 247, 98, 214, 97, 220, 3, 128, 77, 128, 126, 231, 209, 104, 139, 124, 104, 50, 61, 11, 247, 113, 149, 242, 150, 250, 119, 141, 112, 247, 155, 187, 207, 73, 66, 225, 123, 71, 156, 180, 118, 88, 244, 201, 46, 131, 173, 155, 125, 231, 168, 213, 213, 187, 239, 157, 24, 245, 28, 171, 212, 79, 165, 187, 193, 170, 9, 47, 50, 167, 10, 161, 143, 243, 85, 243, 60, 231, 95, 130, 146, 159, 165, 131, 152, 12, 134, 170, 205, 175, 232, 230, 178, 141, 177, 147, 43, 136, 129, 58, 27, 189, 66, 108, 201, 93 },
                            ProfileImageUrl = "",
                            RefreshToken = new Guid("8d7b733c-653d-4e3a-813f-76764dc95c6e"),
                            UserName = "aliyasin",
                            UserTypeId = -1
                        },
                        new
                        {
                            Id = -2,
                            CreatedDate = new DateTime(2022, 7, 23, 15, 10, 33, 961, DateTimeKind.Local).AddTicks(1332),
                            CreatedUserId = 1,
                            Email = "admin@gmail.com",
                            FirstName = "Admin",
                            GsmNumber = "",
                            IsDeleted = false,
                            LastName = "ADMIN",
                            PasswordHash = new byte[] { 203, 118, 128, 141, 193, 235, 163, 168, 249, 144, 166, 212, 154, 19, 208, 141, 121, 109, 98, 82, 111, 251, 79, 44, 24, 179, 64, 253, 125, 182, 78, 167, 251, 103, 27, 119, 192, 143, 40, 63, 139, 22, 211, 114, 39, 75, 145, 130, 156, 121, 62, 65, 241, 151, 92, 174, 139, 101, 7, 31, 174, 87, 37, 249 },
                            PasswordSalt = new byte[] { 184, 150, 200, 252, 217, 98, 187, 170, 66, 246, 46, 78, 14, 4, 93, 56, 173, 44, 188, 228, 156, 138, 132, 247, 98, 214, 97, 220, 3, 128, 77, 128, 126, 231, 209, 104, 139, 124, 104, 50, 61, 11, 247, 113, 149, 242, 150, 250, 119, 141, 112, 247, 155, 187, 207, 73, 66, 225, 123, 71, 156, 180, 118, 88, 244, 201, 46, 131, 173, 155, 125, 231, 168, 213, 213, 187, 239, 157, 24, 245, 28, 171, 212, 79, 165, 187, 193, 170, 9, 47, 50, 167, 10, 161, 143, 243, 85, 243, 60, 231, 95, 130, 146, 159, 165, 131, 152, 12, 134, 170, 205, 175, 232, 230, 178, 141, 177, 147, 43, 136, 129, 58, 27, 189, 66, 108, 201, 93 },
                            ProfileImageUrl = "",
                            RefreshToken = new Guid("e04b19e5-9503-4d7b-afed-667b55e5b6d1"),
                            UserName = "admin",
                            UserTypeId = -2
                        });
                });

            modelBuilder.Entity("Entities.Concrete.AppUserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("UserTypeName");

                    b.HasKey("Id");

                    b.ToTable("AppUserTypes", "dbo");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            UserTypeName = "System Admin"
                        },
                        new
                        {
                            Id = -2,
                            UserTypeName = "Admin"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.AppUserTypeAppOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int")
                        .HasColumnName("OperationClaimId");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("char(4)")
                        .HasColumnName("Status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedUserId")
                        .HasColumnType("int");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int")
                        .HasColumnName("UserTypeId");

                    b.HasKey("Id");

                    b.HasIndex("OperationClaimId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("AppUserTypeAppOperationClaims", "dbo");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            OperationClaimId = 1,
                            Status = "1011",
                            UserTypeId = -2
                        },
                        new
                        {
                            Id = -2,
                            OperationClaimId = 2,
                            Status = "1111",
                            UserTypeId = -2
                        },
                        new
                        {
                            Id = -3,
                            OperationClaimId = 3,
                            Status = "1111",
                            UserTypeId = -2
                        });
                });

            modelBuilder.Entity("Entities.Concrete.AppUserTypeAppOperationClaim", b =>
                {
                    b.HasOne("Entities.Concrete.AppOperationClaim", "AppOperationClaim")
                        .WithMany("AppUserTypeAppOperationClaims")
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.AppUserType", "AppUserType")
                        .WithMany()
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppOperationClaim");

                    b.Navigation("AppUserType");
                });

            modelBuilder.Entity("Entities.Concrete.AppOperationClaim", b =>
                {
                    b.Navigation("AppUserTypeAppOperationClaims");
                });
#pragma warning restore 612, 618
        }
    }
}