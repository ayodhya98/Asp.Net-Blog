﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test2.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogPosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Heading = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlHandle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Visible = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostTag",
                columns: table => new
                {
                    TagsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    blogPostsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostTag", x => new { x.TagsId, x.blogPostsId });
                    table.ForeignKey(
                        name: "FK_BlogPostTag_blogPosts_blogPostsId",
                        column: x => x.blogPostsId,
                        principalTable: "blogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogPostTag_tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostTag_blogPostsId",
                table: "BlogPostTag",
                column: "blogPostsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPostTag");

            migrationBuilder.DropTable(
                name: "blogPosts");

            migrationBuilder.DropTable(
                name: "tags");
        }
    }
}
