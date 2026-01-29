using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyTiemToc.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSQL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "MoTa",
                table: "DichVu");

            migrationBuilder.RenameColumn(
                name: "MaDichVu",
                table: "DichVu",
                newName: "DichVuId");

            migrationBuilder.AlterColumn<string>(
                name: "HoTen",
                table: "KhachHang",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "DienThoai",
                table: "KhachHang",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<int>(
                name: "DichVuId",
                table: "KhachHang",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenDichVu",
                table: "DichVu",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_DichVuId",
                table: "KhachHang",
                column: "DichVuId");

            migrationBuilder.AddForeignKey(
                name: "FK_KhachHang_DichVu_DichVuId",
                table: "KhachHang",
                column: "DichVuId",
                principalTable: "DichVu",
                principalColumn: "DichVuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KhachHang_DichVu_DichVuId",
                table: "KhachHang");

            migrationBuilder.DropIndex(
                name: "IX_KhachHang_DichVuId",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "DichVuId",
                table: "KhachHang");

            migrationBuilder.RenameColumn(
                name: "DichVuId",
                table: "DichVu",
                newName: "MaDichVu");

            migrationBuilder.AlterColumn<string>(
                name: "HoTen",
                table: "KhachHang",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DienThoai",
                table: "KhachHang",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "KhachHang",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TenDichVu",
                table: "DichVu",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "MoTa",
                table: "DichVu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
