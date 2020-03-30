using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestPrinterBilling.Migrations
{
    public partial class AddPrintCountstoInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblMACHINE",
                columns: table => new
                {
                    MACHINE_ID = table.Column<int>(nullable: false),
                    SERIALNUM = table.Column<int>(nullable: false),
                    DEVICEMODEL = table.Column<string>(nullable: false),
                    USER_ID = table.Column<int>(nullable: false),
                    PRICE_BW = table.Column<double>(nullable: false),
                    PRICE_CLR = table.Column<double>(nullable: false),
                    PRICE_CLRLRG = table.Column<double>(nullable: false),
                    PREV_RDS_BW = table.Column<int>(nullable: false),
                    PREV_RDS_CLR = table.Column<int>(nullable: false),
                    PREV_RDS_CLRLRG = table.Column<int>(nullable: false),
                    CUR_RDS_BW = table.Column<int>(nullable: false),
                    CUR_RDS_CLR = table.Column<int>(nullable: false),
                    CUR_RDS_CLRLRG = table.Column<int>(nullable: false),
                    PrintCountBW = table.Column<int>(nullable: false),
                    PrintCountColor = table.Column<int>(nullable: false),
                    PrintCountLarge= table.Column<int>(nullable: false),
                    QTY_BW = table.Column<int>(nullable: false),
                    QTY_CLR = table.Column<int>(nullable: false),
                    QTY_CLRLRG = table.Column<int>(nullable: false),
                    PREV_INVOICE_ID = table.Column<string>(nullable: false),
                    PREV_INVOICE_TOTAL = table.Column<double>(nullable: false),
                    CUR_INVOICE_ID = table.Column<string>(nullable: false),
                    CUR_INVOICE_TOTAL = table.Column<double>(nullable: false),
                    STATUS = table.Column<string>(nullable: false),
                    CONTRACT_START = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    CONTRACT_END = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    COLLECTION_METHOD = table.Column<string>(nullable: false),
                    LOCATION = table.Column<string>(nullable: false),
                    MIN_CHARGE = table.Column<string>(nullable: false),
                    IS_ACTIVE = table.Column<bool>(nullable: false, defaultValueSql: "('TRUE')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblMACHI__DE783B9974160401", x => x.MACHINE_ID);
                });

            migrationBuilder.CreateTable(
                name: "tblUSERS",
                columns: table => new
                {
                    USER_ID = table.Column<int>(nullable: false),
                    USERNAME = table.Column<string>(nullable: false),
                    PASSWORD = table.Column<string>(nullable: false),
                    CONTACTNAME = table.Column<string>(name: "CONTACT NAME", nullable: false),
                    EMAIL = table.Column<string>(nullable: false),
                    ISADMIN = table.Column<bool>(nullable: false, defaultValueSql: "('FALSE')"),
                    PHONE = table.Column<string>(nullable: false),
                    COMPANY = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblUSERS__F3BEEBFF9AF1F5C3", x => x.USER_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblMACHINE");

            migrationBuilder.DropTable(
                name: "tblUSERS");
        }
    }
}
