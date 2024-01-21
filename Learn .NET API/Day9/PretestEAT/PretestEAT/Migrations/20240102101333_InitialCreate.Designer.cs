// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PretestEAT.Models;

#nullable disable

namespace PretestEAT.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240102101333_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PretestEAT.Models.Employee", b =>
                {
                    b.Property<string>("EmpID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.HasKey("EmpID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmpID = "e1",
                            FirstName = "Nguyen Van",
                            LastName = " A",
                            Password = "123",
                            Salary = 1000f
                        },
                        new
                        {
                            EmpID = "e2",
                            FirstName = "Nguyen Van",
                            LastName = " B",
                            Password = "123",
                            Salary = 1000f
                        },
                        new
                        {
                            EmpID = "e3",
                            FirstName = "Nguyen Van",
                            LastName = " C",
                            Password = "123",
                            Salary = 1000f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
