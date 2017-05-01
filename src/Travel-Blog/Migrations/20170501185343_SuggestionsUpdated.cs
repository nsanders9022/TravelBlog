using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelBlog.Migrations
{
    public partial class SuggestionsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suggestions_Places_PlaceId",
                table: "Suggestions");

            migrationBuilder.DropIndex(
                name: "IX_Suggestions_PlaceId",
                table: "Suggestions");

            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "Suggestions");

            migrationBuilder.AddColumn<string>(
                name: "SuggestedCity",
                table: "Suggestions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuggestedCountry",
                table: "Suggestions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuggestedCity",
                table: "Suggestions");

            migrationBuilder.DropColumn(
                name: "SuggestedCountry",
                table: "Suggestions");

            migrationBuilder.AddColumn<int>(
                name: "PlaceId",
                table: "Suggestions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Suggestions_PlaceId",
                table: "Suggestions",
                column: "PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suggestions_Places_PlaceId",
                table: "Suggestions",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
