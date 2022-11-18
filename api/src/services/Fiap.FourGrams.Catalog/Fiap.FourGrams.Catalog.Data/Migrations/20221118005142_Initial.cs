﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.FourGrams.Catalog.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GR01_CATEGOR",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Desconto = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GR01_CATEGOR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GR02_PRODUTO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescricaoResumida = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Destaque = table.Column<bool>(type: "bit", nullable: false),
                    CategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrecoKilo = table.Column<double>(type: "float", nullable: true),
                    PrecoUnitario = table.Column<double>(type: "float", nullable: true),
                    DescontoExclusivo = table.Column<double>(type: "float", nullable: true),
                    CaminhoImagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GR02_PRODUTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GR02_PRODUTO_GR01_CATEGOR_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "GR01_CATEGOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GR02_PRODUTO_CategoriaId",
                table: "GR02_PRODUTO",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GR02_PRODUTO");

            migrationBuilder.DropTable(
                name: "GR01_CATEGOR");
        }
    }
}
