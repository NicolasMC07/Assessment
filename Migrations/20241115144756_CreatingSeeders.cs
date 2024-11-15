using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APiClinique.Migrations
{
    /// <inheritdoc />
    public partial class CreatingSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 15, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9231), "admin@example.com", "admin", "admin123", "admin" },
                    { 2, new DateTime(2024, 11, 15, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9263), "doctorone@example.com", "doctor one", "doctor123", "doctor" },
                    { 3, new DateTime(2024, 11, 15, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9265), "doctortwo@example.com", "doctor two", "doctor123", "doctor" },
                    { 4, new DateTime(2024, 11, 15, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9266), "patientone@example.com", "patient one", "patient123", "patient" },
                    { 5, new DateTime(2024, 11, 15, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9268), "patienttwo@example.com", "patient two", "patient123", "patient" },
                    { 6, new DateTime(2024, 11, 15, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9269), "patientthree@example.com", "patient three", "patient123", "patient" },
                    { 7, new DateTime(2024, 11, 15, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9270), "patientfour@example.com", "patient four", "patient123", "patient" },
                    { 8, new DateTime(2024, 11, 15, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9272), "doctorthree@example.com", "doctor three", "doctor123", "doctor" },
                    { 9, new DateTime(2024, 11, 15, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9317), "adminuser@example.com", "admin user", "admin123", "admin" },
                    { 10, new DateTime(2024, 11, 15, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9318), "patientfive@example.com", "patient five", "patient123", "patient" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 3 },
                    { 3, 8 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 2, 5 },
                    { 3, 6 },
                    { 4, 7 },
                    { 5, 10 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "appointment_date", "DoctorId", "IsCanceled", "PatientId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 16, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9457), 1, false, 1 },
                    { 2, new DateTime(2024, 11, 17, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9464), 2, false, 2 },
                    { 3, new DateTime(2024, 11, 18, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9466), 1, false, 3 },
                    { 4, new DateTime(2024, 11, 19, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9467), 3, false, 4 },
                    { 5, new DateTime(2024, 11, 20, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9469), 2, false, 5 },
                    { 6, new DateTime(2024, 11, 21, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9470), 1, false, 1 },
                    { 7, new DateTime(2024, 11, 22, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9471), 3, false, 3 },
                    { 8, new DateTime(2024, 11, 23, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9473), 2, false, 4 },
                    { 9, new DateTime(2024, 11, 24, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9474), 1, false, 2 },
                    { 10, new DateTime(2024, 11, 25, 9, 47, 56, 634, DateTimeKind.Local).AddTicks(9475), 3, false, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
