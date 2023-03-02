using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_db.Migrations
{
    /// <inheritdoc />
    public partial class AddDoctorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicament_Medicaments_MedicamentId",
                table: "PatientMedicament");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicament_Patients_PatientId",
                table: "PatientMedicament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PatientMedicament",
                table: "PatientMedicament");

            migrationBuilder.RenameTable(
                name: "PatientMedicament",
                newName: "Prescriptions");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicament_MedicamentId",
                table: "Prescriptions",
                newName: "IX_Prescriptions_MedicamentId");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Visitations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescriptions",
                table: "Prescriptions",
                columns: new[] { "PatientId", "MedicamentId" });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.DoctorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visitations_DoctorId",
                table: "Visitations",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Medicaments_MedicamentId",
                table: "Prescriptions",
                column: "MedicamentId",
                principalTable: "Medicaments",
                principalColumn: "MedicamentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Patients_PatientId",
                table: "Prescriptions",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitations_Doctor_DoctorId",
                table: "Visitations",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Medicaments_MedicamentId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Patients_PatientId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitations_Doctor_DoctorId",
                table: "Visitations");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Visitations_DoctorId",
                table: "Visitations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescriptions",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Visitations");

            migrationBuilder.RenameTable(
                name: "Prescriptions",
                newName: "PatientMedicament");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_MedicamentId",
                table: "PatientMedicament",
                newName: "IX_PatientMedicament_MedicamentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PatientMedicament",
                table: "PatientMedicament",
                columns: new[] { "PatientId", "MedicamentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicament_Medicaments_MedicamentId",
                table: "PatientMedicament",
                column: "MedicamentId",
                principalTable: "Medicaments",
                principalColumn: "MedicamentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicament_Patients_PatientId",
                table: "PatientMedicament",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
