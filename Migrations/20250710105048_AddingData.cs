using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameShelf.Migrations
{
    /// <inheritdoc />
    public partial class AddingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Genre", "Name", "Price", "Rating" },
                values: new object[,]
                {
                    { 1, "Vast open world action RPG with challenging combat.", "RPG", "Elden Ring", 59.99m, 4.9000000000000004 },
                    { 2, "Futuristic open-world RPG in Night City.", "RPG", "Cyberpunk 2077", 49.99m, 4.2000000000000002 },
                    { 3, "Epic fantasy RPG with rich storytelling.", "RPG", "The Witcher 3", 29.99m, 4.9000000000000004 },
                    { 4, "Action adventure in Norse mythology.", "Action", "God of War Ragnarok", 69.99m, 4.7999999999999998 },
                    { 5, "Open-world adventure with robotic creatures.", "Action", "Horizon Forbidden West", 59.99m, 4.5999999999999996 },
                    { 6, "Viking saga with exploration and combat.", "Action", "Assassin’s Creed Valhalla", 39.99m, 4.2999999999999998 },
                    { 7, "Horror survival in a mysterious European village.", "Horror", "Resident Evil Village", 34.99m, 4.4000000000000004 },
                    { 8, "Sci-fi horror classic rebuilt with modern graphics.", "Horror", "Dead Space Remake", 59.99m, 4.7000000000000002 },
                    { 9, "Charming farming and life simulation.", "Simulation", "Stardew Valley", 14.99m, 4.9000000000000004 },
                    { 10, "Life simulation with character creation and storytelling.", "Simulation", "The Sims 4", 29.99m, 4.5 },
                    { 11, "Build and manage realistic cities.", "Simulation", "Cities: Skylines II", 49.99m, 4.2999999999999998 },
                    { 12, "Open-world racing in beautiful landscapes.", "Racing", "Forza Horizon 5", 59.99m, 4.7999999999999998 },
                    { 13, "Realistic racing simulator with hundreds of cars.", "Racing", "Gran Turismo 7", 69.99m, 4.4000000000000004 },
                    { 14, "Fun arcade racing with beloved Nintendo characters.", "Racing", "Mario Kart 8 Deluxe", 59.99m, 4.9000000000000004 },
                    { 15, "Modern military shooter with intense action.", "Shooter", "Call of Duty: MW III", 69.99m, 4.2000000000000002 },
                    { 16, "Fast-paced battle royale shooter.", "Shooter", "Apex Legends", 0.00m, 4.4000000000000004 },
                    { 17, "Tactical team-based shooter.", "Shooter", "Valorant", 0.00m, 4.5 },
                    { 18, "Competitive MOBA with strategic gameplay.", "MOBA", "League of Legends", 0.00m, 4.5999999999999996 },
                    { 19, "Classic multiplayer online battle arena.", "MOBA", "Dota 2", 0.00m, 4.4000000000000004 },
                    { 20, "Sandbox building and survival adventure.", "Sandbox", "Minecraft", 26.95m, 4.9000000000000004 },
                    { 21, "2D sandbox exploration and crafting.", "Sandbox", "Terraria", 9.99m, 4.7000000000000002 },
                    { 22, "Deep RPG based on D&D rules.", "RPG", "Baldur’s Gate 3", 59.99m, 4.9000000000000004 },
                    { 23, "Narrative-driven RPG with philosophical storytelling.", "RPG", "Disco Elysium", 39.99m, 4.7999999999999998 },
                    { 24, "Relaxing life sim with charming villagers.", "Simulation", "Animal Crossing: NH", 59.99m, 4.7999999999999998 },
                    { 25, "3D platformer with inventive level design.", "Platformer", "Super Mario Odyssey", 59.99m, 4.9000000000000004 },
                    { 26, "Atmospheric 2D metroidvania with challenging combat.", "Platformer", "Hollow Knight", 14.99m, 4.7999999999999998 },
                    { 27, "Precision platformer with emotional narrative.", "Platformer", "Celeste", 19.99m, 4.7000000000000002 },
                    { 28, "Turn-based strategy spanning human history.", "Strategy", "Civilization VI", 29.99m, 4.5999999999999996 },
                    { 29, "Epic strategy battles in the Warhammer universe.", "Strategy", "Total War: Warhammer III", 59.99m, 4.5 },
                    { 30, "Social deduction party game.", "Party Game", "Among Us", 4.99m, 4.2999999999999998 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
