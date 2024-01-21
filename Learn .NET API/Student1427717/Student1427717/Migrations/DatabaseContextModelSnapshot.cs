// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Student1427717.Models;

#nullable disable

namespace Student1427717.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Student1427717.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Role")
                        .HasColumnType("bit");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = "e1",
                            Age = 22,
                            EmployeeName = "Tri",
                            Password = "123",
                            Role = true
                        },
                        new
                        {
                            EmployeeId = "e2",
                            Age = 20,
                            EmployeeName = "Dien",
                            Password = "123",
                            Role = false
                        },
                        new
                        {
                            EmployeeId = "e3",
                            Age = 32,
                            EmployeeName = "Duong",
                            Password = "123",
                            Role = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
