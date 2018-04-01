using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RPGPlaza.Data.Migrations
{
    public partial class SavageWorldsDatabasesforCharacters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SWArmors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArmorValue = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    TimePeriod = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWArmors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWArmorsCustom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArmorValue = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    TimePeriod = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWArmorsCustom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWBooks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWCharacters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdvancesHeroicJson = table.Column<string>(nullable: true),
                    AdvancesLegendaryJson = table.Column<string>(nullable: true),
                    AdvancesNoviceJson = table.Column<string>(nullable: true),
                    AdvancesSeasonedJson = table.Column<string>(nullable: true),
                    AdvancesVeteranJson = table.Column<string>(nullable: true),
                    Agility = table.Column<int>(nullable: false),
                    ArmoursJson = table.Column<string>(nullable: true),
                    Background = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EdgesJson = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    HindrancesJson = table.Column<string>(nullable: true),
                    MundaneItemsJson = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Race = table.Column<string>(nullable: true),
                    SkillsJson = table.Column<string>(nullable: true),
                    Smarts = table.Column<int>(nullable: false),
                    Spirit = table.Column<int>(nullable: false),
                    Strength = table.Column<int>(nullable: false),
                    Vigor = table.Column<int>(nullable: false),
                    Wealth = table.Column<double>(nullable: false),
                    WeaponsJson = table.Column<string>(nullable: true),
                    XP = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWCharacters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWEdges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(nullable: false),
                    EdgeTypeId = table.Column<int>(nullable: false),
                    Effects = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Requirement = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWEdges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWEdgesCustom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Effects = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Requirement = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWEdgesCustom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWEdgeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWEdgeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWHindrances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(nullable: false),
                    Effects = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWHindrances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWHindrancesCustom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Effects = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWHindrancesCustom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWMundaneItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWMundaneItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWMundaneItemsCustom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWMundaneItemsCustom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWRaces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ModifiersJson = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWRaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWRacesCustom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ModifiersJson = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWRacesCustom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWSkillCustom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LinkedAttribute = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWSkillCustom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWSkills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(nullable: false),
                    LinkedAttribute = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWWeapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Damage = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    TimePeriod = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWWeapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWWeaponsCustom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<double>(nullable: false),
                    Damage = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    TimePeriod = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWWeaponsCustom", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SWArmors");

            migrationBuilder.DropTable(
                name: "SWArmorsCustom");

            migrationBuilder.DropTable(
                name: "SWBooks");

            migrationBuilder.DropTable(
                name: "SWCharacters");

            migrationBuilder.DropTable(
                name: "SWEdges");

            migrationBuilder.DropTable(
                name: "SWEdgesCustom");

            migrationBuilder.DropTable(
                name: "SWEdgeTypes");

            migrationBuilder.DropTable(
                name: "SWHindrances");

            migrationBuilder.DropTable(
                name: "SWHindrancesCustom");

            migrationBuilder.DropTable(
                name: "SWMundaneItems");

            migrationBuilder.DropTable(
                name: "SWMundaneItemsCustom");

            migrationBuilder.DropTable(
                name: "SWRaces");

            migrationBuilder.DropTable(
                name: "SWRacesCustom");

            migrationBuilder.DropTable(
                name: "SWSkillCustom");

            migrationBuilder.DropTable(
                name: "SWSkills");

            migrationBuilder.DropTable(
                name: "SWWeapons");

            migrationBuilder.DropTable(
                name: "SWWeaponsCustom");
        }
    }
}
