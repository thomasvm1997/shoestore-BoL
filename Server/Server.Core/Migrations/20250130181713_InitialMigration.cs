using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Core.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShoeBrandId = table.Column<int>(type: "int", nullable: false),
                    ShoeCategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shoes_Brands_ShoeBrandId",
                        column: x => x.ShoeBrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shoes_Categories_ShoeCategoryId",
                        column: x => x.ShoeCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nike" },
                    { 2, "Adidas" },
                    { 3, "Puma" },
                    { 4, "Reebok" },
                    { 5, "New Balance" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Shoes for running and jogging", "Running" },
                    { 2, "Everyday wear shoes", "Casual" },
                    { 3, "Elegant formal shoes", "Formal" }
                });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "ShoeBrandId", "ShoeCategoryId", "Size" },
                values: new object[,]
                {
                    { 1, "High-quality Puma shoe, model Air Stride, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Puma Air Stride", 54.99m, 3, 2, 37 },
                    { 2, "High-quality Puma shoe, model Ultra Run, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Puma Ultra Run", 59.99m, 3, 3, 38 },
                    { 3, "High-quality Reebok shoe, model SpeedFlex, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Reebok SpeedFlex", 64.99m, 4, 1, 39 },
                    { 4, "High-quality Puma shoe, model PowerStep, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Puma PowerStep", 69.99m, 3, 2, 40 },
                    { 5, "High-quality Reebok shoe, model Enduro, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Reebok Enduro", 74.99m, 4, 3, 41 },
                    { 6, "High-quality Adidas shoe, model CloudFlow, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Adidas CloudFlow", 79.99m, 2, 1, 42 },
                    { 7, "High-quality Puma shoe, model Solar Glide, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Puma Solar Glide", 84.99m, 3, 2, 43 },
                    { 8, "High-quality Adidas shoe, model Velocity Boost, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Adidas Velocity Boost", 89.99m, 2, 3, 44 },
                    { 9, "High-quality Adidas shoe, model Sprint Edge, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Adidas Sprint Edge", 94.99m, 2, 1, 45 },
                    { 10, "High-quality Reebok shoe, model TrailBlazer, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Reebok TrailBlazer", 49.99m, 4, 2, 46 },
                    { 11, "High-quality Puma shoe, model HyperRush, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Puma HyperRush", 54.99m, 3, 3, 36 },
                    { 12, "High-quality Puma shoe, model AeroStride, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Puma AeroStride", 59.99m, 3, 1, 37 },
                    { 13, "High-quality Puma shoe, model Thunder Run, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Puma Thunder Run", 64.99m, 3, 2, 38 },
                    { 14, "High-quality Puma shoe, model FloatStep, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Puma FloatStep", 69.99m, 3, 3, 39 },
                    { 15, "High-quality New Balance shoe, model ZoomDrive, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "New Balance ZoomDrive", 74.99m, 5, 1, 40 },
                    { 16, "High-quality Reebok shoe, model VaporSwift, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Reebok VaporSwift", 79.99m, 4, 2, 41 },
                    { 17, "High-quality New Balance shoe, model PulseZoom, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "New Balance PulseZoom", 84.99m, 5, 3, 42 },
                    { 18, "High-quality Nike shoe, model AeroCushion, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Nike AeroCushion", 89.99m, 1, 1, 43 },
                    { 19, "High-quality Nike shoe, model GripMaster, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Nike GripMaster", 94.99m, 1, 2, 44 },
                    { 20, "High-quality Nike shoe, model Stealth Glide, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Nike Stealth Glide", 49.99m, 1, 3, 45 },
                    { 21, "High-quality Reebok shoe, model LunarStride, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Reebok LunarStride", 54.99m, 4, 1, 46 },
                    { 22, "High-quality Puma shoe, model RapidFlex, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Puma RapidFlex", 59.99m, 3, 2, 36 },
                    { 23, "High-quality Puma shoe, model Nova Flow, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Puma Nova Flow", 64.99m, 3, 3, 37 },
                    { 24, "High-quality Reebok shoe, model JumpX, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Reebok JumpX", 69.99m, 4, 1, 38 },
                    { 25, "High-quality New Balance shoe, model OmniRun, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "New Balance OmniRun", 74.99m, 5, 2, 39 },
                    { 26, "High-quality Nike shoe, model Phantom Flex, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Nike Phantom Flex", 79.99m, 1, 3, 40 },
                    { 27, "High-quality Adidas shoe, model TrailMax, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Adidas TrailMax", 84.99m, 2, 1, 41 },
                    { 28, "High-quality Reebok shoe, model SonicStep, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Reebok SonicStep", 89.99m, 4, 2, 42 },
                    { 29, "High-quality New Balance shoe, model CrossCharge, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "New Balance CrossCharge", 94.99m, 5, 3, 43 },
                    { 30, "High-quality Nike shoe, model AeroRun, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Nike AeroRun", 49.99m, 1, 1, 44 },
                    { 31, "High-quality Reebok shoe, model IgniteWave, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Reebok IgniteWave", 54.99m, 4, 2, 45 },
                    { 32, "High-quality Nike shoe, model GlideFuel, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Nike GlideFuel", 59.99m, 1, 3, 46 },
                    { 33, "High-quality Adidas shoe, model UltraLight, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Adidas UltraLight", 64.99m, 2, 1, 36 },
                    { 34, "High-quality Puma shoe, model AirVolt, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Puma AirVolt", 69.99m, 3, 2, 37 },
                    { 35, "High-quality Reebok shoe, model TerraBoost, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Reebok TerraBoost", 74.99m, 4, 3, 38 },
                    { 36, "High-quality New Balance shoe, model CloudRush, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "New Balance CloudRush", 79.99m, 5, 1, 39 },
                    { 37, "High-quality Adidas shoe, model HyperGrip, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Adidas HyperGrip", 84.99m, 2, 2, 40 },
                    { 38, "High-quality New Balance shoe, model SwiftStrike, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "New Balance SwiftStrike", 89.99m, 5, 3, 41 },
                    { 39, "High-quality Puma shoe, model SpeedStorm, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Puma SpeedStorm", 94.99m, 3, 1, 42 },
                    { 40, "High-quality Adidas shoe, model EdgeMax, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Adidas EdgeMax", 49.99m, 2, 2, 43 },
                    { 41, "High-quality Nike shoe, model AlphaCharge, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Nike AlphaCharge", 54.99m, 1, 3, 44 },
                    { 42, "High-quality New Balance shoe, model MaxPropel, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "New Balance MaxPropel", 59.99m, 5, 1, 45 },
                    { 43, "High-quality New Balance shoe, model ZeroGravity, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "New Balance ZeroGravity", 64.99m, 5, 2, 46 },
                    { 44, "High-quality Reebok shoe, model PowerDash, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Reebok PowerDash", 69.99m, 4, 3, 36 },
                    { 45, "High-quality Adidas shoe, model AeroSpeed, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Adidas AeroSpeed", 74.99m, 2, 1, 37 },
                    { 46, "High-quality Reebok shoe, model ZoomJet, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Reebok ZoomJet", 79.99m, 4, 2, 38 },
                    { 47, "High-quality Puma shoe, model StormRunner, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Puma StormRunner", 84.99m, 3, 3, 39 },
                    { 48, "High-quality Reebok shoe, model GlideWave, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Reebok GlideWave", 89.99m, 4, 1, 40 },
                    { 49, "High-quality Nike shoe, model HydroFlow, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Nike HydroFlow", 94.99m, 1, 2, 41 },
                    { 50, "High-quality Reebok shoe, model PulseStrider, with excellent comfort.", "https://images.unsplash.com/photo-1605348532760-6753d2c43329?q=80&w=1920&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Reebok PulseStrider", 49.99m, 4, 3, 42 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_ShoeBrandId",
                table: "Shoes",
                column: "ShoeBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_ShoeCategoryId",
                table: "Shoes",
                column: "ShoeCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shoes");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
