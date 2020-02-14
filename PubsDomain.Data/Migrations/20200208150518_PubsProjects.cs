using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PubsDomain.Data.Migrations
{
    public partial class PubsProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    au_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    au_lname = table.Column<string>(nullable: true),
                    au_fname = table.Column<string>(nullable: true),
                    phone = table.Column<int>(nullable: false),
                    address = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    zip = table.Column<string>(nullable: true),
                    contract = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.au_id);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    title_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    pub_id = table.Column<int>(nullable: false),
                    price = table.Column<int>(nullable: false),
                    advance = table.Column<string>(nullable: true),
                    royalty = table.Column<string>(nullable: true),
                    ytd_sales = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true),
                    pubdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.title_id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    pub_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pub_name = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    Titlestitle_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.pub_id);
                    table.ForeignKey(
                        name: "FK_Publishers_Titles_Titlestitle_id",
                        column: x => x.Titlestitle_id,
                        principalTable: "Titles",
                        principalColumn: "title_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Royscheds",
                columns: table => new
                {
                    title_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lorange = table.Column<string>(nullable: true),
                    hirange = table.Column<string>(nullable: true),
                    royalty = table.Column<string>(nullable: true),
                    Titlestitle_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Royscheds", x => x.title_id);
                    table.ForeignKey(
                        name: "FK_Royscheds_Titles_Titlestitle_id",
                        column: x => x.Titlestitle_id,
                        principalTable: "Titles",
                        principalColumn: "title_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    stor_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ord_num = table.Column<int>(nullable: false),
                    ord_date = table.Column<DateTime>(nullable: false),
                    qty = table.Column<int>(nullable: false),
                    payterms = table.Column<string>(nullable: true),
                    title_id = table.Column<int>(nullable: false),
                    Titlestitle_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.stor_id);
                    table.ForeignKey(
                        name: "FK_Sales_Titles_Titlestitle_id",
                        column: x => x.Titlestitle_id,
                        principalTable: "Titles",
                        principalColumn: "title_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TitleAuthors",
                columns: table => new
                {
                    au_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title_id = table.Column<int>(nullable: false),
                    au_ord = table.Column<string>(nullable: true),
                    royaltyper = table.Column<string>(nullable: true),
                    Titlestitle_id = table.Column<int>(nullable: true),
                    Authorsau_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleAuthors", x => x.au_id);
                    table.ForeignKey(
                        name: "FK_TitleAuthors_Authors_Authorsau_id",
                        column: x => x.Authorsau_id,
                        principalTable: "Authors",
                        principalColumn: "au_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TitleAuthors_Titles_Titlestitle_id",
                        column: x => x.Titlestitle_id,
                        principalTable: "Titles",
                        principalColumn: "title_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    emp_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fname = table.Column<string>(nullable: true),
                    minit = table.Column<string>(nullable: true),
                    lname = table.Column<string>(nullable: true),
                    job_id = table.Column<int>(nullable: false),
                    job_lvl = table.Column<int>(nullable: false),
                    pub_id = table.Column<int>(nullable: false),
                    hire_date = table.Column<int>(nullable: false),
                    Publisherspub_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.emp_id);
                    table.ForeignKey(
                        name: "FK_Employees_Publishers_Publisherspub_id",
                        column: x => x.Publisherspub_id,
                        principalTable: "Publishers",
                        principalColumn: "pub_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pub_Infos",
                columns: table => new
                {
                    pub_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logo = table.Column<string>(nullable: true),
                    pr_info = table.Column<string>(nullable: true),
                    Publisherspub_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pub_Infos", x => x.pub_id);
                    table.ForeignKey(
                        name: "FK_Pub_Infos_Publishers_Publisherspub_id",
                        column: x => x.Publisherspub_id,
                        principalTable: "Publishers",
                        principalColumn: "pub_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    stor_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    discounttype = table.Column<string>(nullable: true),
                    lowqty = table.Column<int>(nullable: false),
                    highqty = table.Column<int>(nullable: false),
                    discount = table.Column<int>(nullable: false),
                    Salesstor_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.stor_id);
                    table.ForeignKey(
                        name: "FK_Discounts_Sales_Salesstor_id",
                        column: x => x.Salesstor_id,
                        principalTable: "Sales",
                        principalColumn: "stor_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    stor_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stor_name = table.Column<string>(nullable: true),
                    stor_address = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    zip = table.Column<string>(nullable: true),
                    Salesstor_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.stor_id);
                    table.ForeignKey(
                        name: "FK_Stores_Sales_Salesstor_id",
                        column: x => x.Salesstor_id,
                        principalTable: "Sales",
                        principalColumn: "stor_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    job_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job_desc = table.Column<int>(nullable: false),
                    min_lvl = table.Column<int>(nullable: false),
                    max_lvl = table.Column<int>(nullable: false),
                    Employeeemp_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.job_id);
                    table.ForeignKey(
                        name: "FK_Jobs_Employees_Employeeemp_id",
                        column: x => x.Employeeemp_id,
                        principalTable: "Employees",
                        principalColumn: "emp_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_Salesstor_id",
                table: "Discounts",
                column: "Salesstor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Publisherspub_id",
                table: "Employees",
                column: "Publisherspub_id");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_Employeeemp_id",
                table: "Jobs",
                column: "Employeeemp_id");

            migrationBuilder.CreateIndex(
                name: "IX_Pub_Infos_Publisherspub_id",
                table: "Pub_Infos",
                column: "Publisherspub_id");

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_Titlestitle_id",
                table: "Publishers",
                column: "Titlestitle_id");

            migrationBuilder.CreateIndex(
                name: "IX_Royscheds_Titlestitle_id",
                table: "Royscheds",
                column: "Titlestitle_id");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Titlestitle_id",
                table: "Sales",
                column: "Titlestitle_id");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_Salesstor_id",
                table: "Stores",
                column: "Salesstor_id");

            migrationBuilder.CreateIndex(
                name: "IX_TitleAuthors_Authorsau_id",
                table: "TitleAuthors",
                column: "Authorsau_id");

            migrationBuilder.CreateIndex(
                name: "IX_TitleAuthors_Titlestitle_id",
                table: "TitleAuthors",
                column: "Titlestitle_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Pub_Infos");

            migrationBuilder.DropTable(
                name: "Royscheds");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "TitleAuthors");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Titles");
        }
    }
}
