﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RESTfulApi.Api.Data;

namespace RESTfulApi.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200701061802_addBankruptTime")]
    partial class addBankruptTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("RESTfulApi.Api.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BankruptTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Industry")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Introduction")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Product")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e2f039ad-237c-4efe-97e9-15deccda6691"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "USA",
                            Industry = "Software",
                            Introduction = "Great Company",
                            Name = "Microsoft",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("e2b07120-ce3d-4e30-8fa8-a4fb76c663e5"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "USA",
                            Industry = "Software",
                            Introduction = "Don't be evil",
                            Name = "Google",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("a2f92442-73dc-4091-ad4d-4398b39f4d47"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "China",
                            Industry = "Software",
                            Introduction = "FuBao Company",
                            Name = "Alibaba",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "USA",
                            Industry = "Software",
                            Introduction = "Great Company",
                            Name = "Microsoft",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Don't be evil",
                            Name = "Google",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "China",
                            Industry = "Internet",
                            Introduction = "Fubao Company",
                            Name = "Alipapa",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237100"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "China",
                            Industry = "ECommerce",
                            Introduction = "From Shenzhen",
                            Name = "Tencent",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716400"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "China",
                            Industry = "Internet",
                            Introduction = "From Beijing",
                            Name = "Baidu",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542800"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "USA",
                            Industry = "Software",
                            Introduction = "Photoshop?",
                            Name = "Adobe",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237111"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "USA",
                            Industry = "Technology",
                            Introduction = "Wow",
                            Name = "SpaceX",
                            Product = "Rocket"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716411"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "Italy",
                            Industry = "Football",
                            Introduction = "Football Club",
                            Name = "AC Milan",
                            Product = "Football Match"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542811"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "China",
                            Industry = "ECommerce",
                            Introduction = "From Jiangsu",
                            Name = "Suning",
                            Product = "Goods"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237122"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Blocked",
                            Name = "Twitter",
                            Product = "Tweets"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716422"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Blocked",
                            Name = "Youtube",
                            Product = "Videos"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542822"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "China",
                            Industry = "Security",
                            Introduction = "- -",
                            Name = "360",
                            Product = "Security Product"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237133"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "China",
                            Industry = "ECommerce",
                            Introduction = "Brothers",
                            Name = "Jingdong",
                            Product = "Goods"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716433"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "China",
                            Industry = "Internet",
                            Introduction = "Music?",
                            Name = "NetEase",
                            Product = "Songs"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542833"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "USA",
                            Industry = "ECommerce",
                            Introduction = "Store",
                            Name = "Amazon",
                            Product = "Books"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237144"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Not Exists?",
                            Name = "AOL",
                            Product = "Website"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716444"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Who?",
                            Name = "Yahoo",
                            Product = "Mail"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542844"),
                            BankruptTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Is it a company?",
                            Name = "Firefox",
                            Product = "Browser"
                        });
                });

            modelBuilder.Entity("RESTfulApi.Api.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4b501cb3-d168-4cc0-b375-48fb33f318a4"),
                            CompanyId = new Guid("e2f039ad-237c-4efe-97e9-15deccda6691"),
                            DateOfBirth = new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MSFT231",
                            FirstName = "Nick",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("7eaa532c-1be5-472c-a738-94fd26e5fad6"),
                            CompanyId = new Guid("e2f039ad-237c-4efe-97e9-15deccda6691"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MSFT245",
                            FirstName = "Vince",
                            Gender = 2,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("aee28ab3-146f-4036-b417-decb89483cff"),
                            CompanyId = new Guid("e2f039ad-237c-4efe-97e9-15deccda6691"),
                            DateOfBirth = new DateTime(1990, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MSFT225",
                            FirstName = "Mande",
                            Gender = 1,
                            LastName = "Etfb"
                        },
                        new
                        {
                            Id = new Guid("a9e0b740-4f88-470f-88dc-7f5b1f72d8cc"),
                            CompanyId = new Guid("e2f039ad-237c-4efe-97e9-15deccda6691"),
                            DateOfBirth = new DateTime(1989, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MSFT345",
                            FirstName = "Zhu",
                            Gender = 1,
                            LastName = "Sir"
                        },
                        new
                        {
                            Id = new Guid("2c96ef7c-457c-4722-8b17-5d37240f5eaf"),
                            CompanyId = new Guid("e2f039ad-237c-4efe-97e9-15deccda6691"),
                            DateOfBirth = new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MSFT545",
                            FirstName = "Lv",
                            Gender = 2,
                            LastName = "Xiaolu"
                        },
                        new
                        {
                            Id = new Guid("0c781f03-b82f-45b2-9427-203e47ee47ed"),
                            CompanyId = new Guid("e2f039ad-237c-4efe-97e9-15deccda6691"),
                            DateOfBirth = new DateTime(1983, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MSFT145",
                            FirstName = "Anne",
                            Gender = 2,
                            LastName = "Dei"
                        },
                        new
                        {
                            Id = new Guid("72457e73-ea34-4e02-b575-8d384e82a481"),
                            CompanyId = new Guid("e2b07120-ce3d-4e30-8fa8-a4fb76c663e5"),
                            DateOfBirth = new DateTime(1997, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G003",
                            FirstName = "Mary",
                            Gender = 2,
                            LastName = "King"
                        },
                        new
                        {
                            Id = new Guid("7644b71d-d74e-43e2-ac32-8cbadd7b1c3a"),
                            CompanyId = new Guid("e2b07120-ce3d-4e30-8fa8-a4fb76c663e5"),
                            DateOfBirth = new DateTime(1977, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G097",
                            FirstName = "Kevin",
                            Gender = 1,
                            LastName = "Richardson"
                        },
                        new
                        {
                            Id = new Guid("679dfd33-32e4-4393-b061-f7abb8956f53"),
                            CompanyId = new Guid("a2f92442-73dc-4091-ad4d-4398b39f4d47"),
                            DateOfBirth = new DateTime(1967, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "A009",
                            FirstName = "卡",
                            Gender = 2,
                            LastName = "里"
                        },
                        new
                        {
                            Id = new Guid("1861341e-b42b-410c-ae21-cf11f36fc574"),
                            CompanyId = new Guid("a2f92442-73dc-4091-ad4d-4398b39f4d47"),
                            DateOfBirth = new DateTime(1957, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "A404",
                            FirstName = "Not",
                            Gender = 1,
                            LastName = "Man"
                        });
                });

            modelBuilder.Entity("RESTfulApi.Api.Entities.Employee", b =>
                {
                    b.HasOne("RESTfulApi.Api.Entities.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
