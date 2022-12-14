// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _HALKA.Data;

#nullable disable

namespace _HALKA.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220806185455_onbesinci")]
    partial class onbesinci
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_HALKA.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<string>("BookAbout")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookPoint")
                        .HasColumnType("int");

                    b.Property<string>("LibraryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Writer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("_HALKA.BookCategory", b =>
                {
                    b.Property<int>("BookCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookCategoryId"), 1L, 1);

                    b.Property<string>("BookCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookCategoryId");

                    b.ToTable("BookCategories");
                });

            modelBuilder.Entity("_HALKA.Coupon", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CouponId"), 1L, 1);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FinishTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CouponId");

                    b.ToTable("Coupons");
                });

            modelBuilder.Entity("_HALKA.Library", b =>
                {
                    b.Property<int>("LibraryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibraryId"), 1L, 1);

                    b.Property<string>("LibraryImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibraryLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibraryMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibraryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibraryPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibraryStaff")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibraryId");

                    b.ToTable("Libraries");
                });

            modelBuilder.Entity("_HALKA.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("BookPoint")
                        .HasColumnType("int");

                    b.Property<int?>("Class")
                        .HasColumnType("int");

                    b.Property<int?>("CommentScore")
                        .HasColumnType("int");

                    b.Property<string>("CouponCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Institution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsStudent")
                        .HasColumnType("bit");

                    b.Property<string>("LibraryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Score")
                        .HasColumnType("int");

                    b.Property<int?>("TestScore")
                        .HasColumnType("int");

                    b.Property<string>("UserImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("_HALKA.UserDto", b =>
                {
                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("userDtos");
                });
#pragma warning restore 612, 618
        }
    }
}
