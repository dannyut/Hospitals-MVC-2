using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalsMVC2.Migrations
{
    public partial class SeedHospitalsInitTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hospitals",
                columns: new[] { "HospitalId", "Address", "Email", "Name", "Phone" },
                values: new object[] { 1, "Dallas, TX", "UTSMC@test.com", "UT Southwestern Medical Center", "(123) 123-4567" });

            migrationBuilder.InsertData(
                table: "Hospitals",
                columns: new[] { "HospitalId", "Address", "Email", "Name", "Phone" },
                values: new object[] { 2, "Dallas, TX", "BUMC@test.com", "Baylor University Medical Center", "(111) 111-1111" });

            migrationBuilder.InsertData(
                table: "Hospitals",
                columns: new[] { "HospitalId", "Address", "Email", "Name", "Phone" },
                values: new object[] { 3, "Dallas, TX", "MCD@test.com", "Medical City Dallas", "(222) 222-2222" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hospitals",
                keyColumn: "HospitalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hospitals",
                keyColumn: "HospitalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hospitals",
                keyColumn: "HospitalId",
                keyValue: 3);
        }
    }
}
