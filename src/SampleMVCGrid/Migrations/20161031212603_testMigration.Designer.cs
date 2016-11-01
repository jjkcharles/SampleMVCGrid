using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SampleMVCGrid;

namespace SampleMVCGrid.Migrations
{
    [DbContext(typeof(SampleDbContext))]
    [Migration("20161031212603_testMigration")]
    partial class testMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SampleMVCGrid.Models.Comment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("Postid");

                    b.Property<string>("Title");

                    b.HasKey("id");

                    b.HasIndex("Postid");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("SampleMVCGrid.Models.Post", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("SampleMVCGrid.Models.Comment", b =>
                {
                    b.HasOne("SampleMVCGrid.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("Postid");
                });
        }
    }
}
