using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    public partial class dateta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("6cb1a723-1eb9-4057-8eb1-3102eeb9dffa"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("788272d4-b657-44a7-90e6-4022bb23cf3a"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("8078d1d4-3c58-4d9d-b532-c9fddc081d09"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("a316df9f-6187-4dfe-ade2-295e138f1518"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("a5186b38-6469-42e8-8857-325f82942b78"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("c354f848-6634-42f9-9969-fd004ca76e9d"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("0d192cb0-7ea8-4b51-9f9b-8eb533aefaef"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("3b7b0f0b-add6-42bf-bd60-ae67f1cb0515"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("45c8a5ed-7ac1-4c86-a5d7-619490c7cb20"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("58926572-0d7d-4670-baa2-bf1458f6cd27"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("69c850fd-512b-49c3-ba38-a45d63a0c17b"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("18613893-9891-40cc-be6d-3cc2171c30d2"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("228bd693-88c4-4919-9286-c6321805ff74"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("6b433a32-94ce-414d-a9df-ba7760055336"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("82fa4211-6e22-4e02-9d6e-1b53d9de7a25"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("a45c8106-459c-4695-a3b6-a7406d54022a"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("a9aac366-f947-4c05-8809-643ec6df686a"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("b1a01300-236b-4661-adee-e7864ea74a1e"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("b665d4c6-3e20-4aff-b127-ee429e585713"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("bcc730dd-0fb8-484f-96dd-cecd52406d9b"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("e6e60612-12b6-49cd-8db3-c461cac84b94"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("2f57ccad-fd7d-48d7-935c-afe9d8f558c1"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("432836d2-0deb-42f7-bb5e-bc6638f1fa1f"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("47b4b713-2ea6-41e9-9506-412e06bf136f"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("53f75b0e-74de-4478-a2f4-484f544ec6eb"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("59f44b8f-ef2a-4893-a4c7-3c7b614637d9"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("b0b93450-60fb-4c2d-ab30-179ba54e3129"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("b96784c5-3b09-4b6f-81f0-6daef145dc70"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("ba4f9afe-45fc-4177-8255-9fe1565b826f"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("d8e815db-03ce-43a8-add6-ffc2500a619a"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("fa669045-b33e-4228-b2bd-30e3e6c05926"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("1c2c0b08-bba2-42f8-942e-249014ac6bd3"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("623a7e4d-aadf-451b-bf19-0decf2a9f14a"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("6c921493-4505-4026-8255-353307784576"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("83eaca99-d85f-4228-82b9-9e0422d23e3c"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("ce5d4946-04e4-48f7-a047-678b60d6b14a"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("dbdc2639-493b-47a7-b81c-eccb2d381eb2"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("fd2a138a-0c43-43dd-bab4-b091649f9708"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("0fd1c530-0fa0-4a38-992c-f53a229c5dec"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("291857df-1462-4b13-b7c5-ad88a436df02"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("37f40be9-3c33-448b-bf2f-6d2e2d37604c"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("3ba8283b-fbe1-42d7-b158-0067af26b6ed"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("444bfe5c-a924-4f07-a0fc-a286ea5825e5"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("72c25b91-62a3-448a-b721-722bd0e3ccd3"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("779327ce-7304-4433-924a-cd109862996a"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("aa8cf8f9-ccce-453a-81fa-23ce02687283"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("b16ccc51-ff2c-482e-bc8a-868d6b905b27"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("b296577b-4ee3-4d20-8889-bf18dfa31475"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("edbd8a1d-2afe-4838-b50a-701358ca2639"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("2da1bc0e-faf8-404b-a88f-420808b4100f"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("49e029b3-e6c0-4c84-b8a1-b5b4567d4871"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("be8e4e67-d12d-410e-be13-d70511ac5537"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("0299ec05-a500-4c2b-9b6f-2284bbb5ce44"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("04323a3e-6d61-4ff7-95ba-13d737f5d466"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("0f8bb62a-a4df-4446-bc26-7362100f6585"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("2bca80cb-b941-4c79-b7ac-39fd98a1549b"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("3c1ad2d8-0c89-4504-8ce8-495ee0136610"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("41341125-9c35-4968-b56a-bc460a59f10c"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("47094a2c-ad4d-422c-853a-e5e2426549b5"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("76c67f7c-cd28-4821-b8c7-18a9736fa046"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("9f51eff6-8f37-4224-bc5c-0286f07a9e8f"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("a682d03c-14b0-4686-ab00-f0385e06b480"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("ba35398f-1b81-49f9-99c2-a570c0db25e5"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("bba535ac-e12d-4d29-bfae-8d005d997632"));

            migrationBuilder.DeleteData(
                table: "nhanViens",
                keyColumn: "IdNhanVien",
                keyValue: new Guid("08185d6e-b5a1-473c-97ef-f62ff4a86004"));

            migrationBuilder.DeleteData(
                table: "nhanViens",
                keyColumn: "IdNhanVien",
                keyValue: new Guid("2963eb8f-b5ca-47b0-964c-05084829fb41"));

            migrationBuilder.DeleteData(
                table: "nhanViens",
                keyColumn: "IdNhanVien",
                keyValue: new Guid("36f4657e-104b-4a43-95ba-b600f70fb18c"));

            migrationBuilder.DeleteData(
                table: "nhanViens",
                keyColumn: "IdNhanVien",
                keyValue: new Guid("f654e805-dc34-4f15-98c3-27a3caa73c53"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("0ff22cfa-f37c-4ff8-b1f0-5e33afd425ee"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("100f85da-1672-4525-a0f9-ddaec78a5a11"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("3759b65f-52b0-458d-a6cc-94373f0d2814"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("3954ef34-e6f2-4a72-a588-6f4e232ecb5b"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("42e91258-b261-4624-9aba-67e04ab0e9b4"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("45de5bc5-370e-4141-9c6d-255c00e2f283"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("4edaf08e-c6cd-4da3-8175-e8f48182113a"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("68059006-432b-4608-830a-f58cfa7f71cf"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("6bb81b89-288b-43a9-8303-8d7a3c87df62"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("6f8152fd-1ed3-45f1-a6f0-2cfc22a80fd1"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("818c5b73-d9de-4021-b67c-75698e030d0a"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("946919be-19cf-491a-9ac1-c74d7e3f76ab"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("9be46525-5757-4c2f-9a45-b597a922afad"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("c5845a44-fa44-43b9-94ed-d29ea63f0389"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("cde80bc4-b903-4f7f-af58-92aec0d9e5e1"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("fc05a39f-557d-4734-b58d-7fa47d5725e9"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("08070e87-39b3-4e88-92d6-3b6a8fd28cca"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("251cb829-a8b7-41b3-9a5f-2cae55af1d28"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("4f736bef-459d-4eed-9701-467ae40e755f"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("6c4c5b45-bc03-4612-8d1c-a8fdc9366fc8"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("731e0872-7498-4fdc-8c63-5bb7f8106acc"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("794a4bab-ee94-47ae-b663-209fa95956d7"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("96b05ac3-0a15-4eca-b233-3a2713c2f6c1"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("a9626cca-3b7a-495b-bcdb-b86bc71a162c"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("ae72cecb-5563-4eb6-b885-56d2f53fa536"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("db56cb97-4ba7-41c9-8cf8-2b7b57304cef"));

            migrationBuilder.InsertData(
                table: "chatLieus",
                columns: new[] { "IdChatLieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenChatLieu" },
                values: new object[,]
                {
                    { new Guid("0f1f5819-4be0-4b1b-b155-c9efc60b4083"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da thật" },
                    { new Guid("2ab9add0-9758-4c15-9766-dbf12e1234af"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5428), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Lộn" },
                    { new Guid("db98d0c0-e622-4661-b481-68d73191164e"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Polyester" },
                    { new Guid("ea640fbb-1eb5-4538-a0b2-38b3b8f07c6b"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Cotton" },
                    { new Guid("f59b37a8-6f81-4e63-a467-344f7f0aa6b3"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Tự Nhiên" },
                    { new Guid("fddb872b-6590-401c-98e6-7df62d0d6cbe"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Dệt" }
                });

            migrationBuilder.InsertData(
                table: "danhMuc",
                columns: new[] { "IdDanhMuc", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("22040117-dca4-4388-815d-4a42bf0aafea"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5455), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Cổ Trung" },
                    { new Guid("3ab70879-eee9-4e51-bd1f-3d8d337be1d9"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5455), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Cổ Cao" },
                    { new Guid("790ec83f-e164-454e-9589-be414762fd6f"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5452), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Da" },
                    { new Guid("7ab3e390-cb7a-4570-b85e-a7c2f4861868"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5450), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Thể Thao" },
                    { new Guid("84b25828-23ae-4262-aa10-16dab96268fd"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5454), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Cổ Thấp" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("30918eb8-145d-46da-874c-d714895e6e20"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Eva" },
                    { new Guid("48fcea3b-521f-4f28-9002-c84912c0982b"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" },
                    { new Guid("66cf421e-ea9b-4555-a25d-206769683aee"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chunky" },
                    { new Guid("a713987d-b5e9-4607-9ab8-61fca63bce3b"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" },
                    { new Guid("abb0b36a-8d93-4401-9f1a-3924688a8320"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" },
                    { new Guid("cd379e5a-03cc-4283-9592-b782d30534c3"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Cao Su Lưu Hóa" },
                    { new Guid("dfb9fccb-dde4-4b98-938d-deb2c2bbaff7"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế PVC" },
                    { new Guid("e3793813-fa6c-4094-8754-c5b1b98ed468"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Giày Lười" },
                    { new Guid("f1a54ea3-b573-4fa2-a756-46587a77dfaf"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế BPU" },
                    { new Guid("fe5c2058-86cf-4743-9533-6b512d5c7e64"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chisty" }
                });

            migrationBuilder.InsertData(
                table: "khachHangs",
                columns: new[] { "IdKhachHang", "AuthProvider", "Email", "HoTen", "KichHoat", "MatKhau", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoDienThoai" },
                values: new object[,]
                {
                    { new Guid("01668f1b-1923-4846-a9a6-8f6f2268d29a"), "Local", "nguyenvanvinh@gmail.com", "Nguyễn Văn Vinh", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0912345678" },
                    { new Guid("17989a49-b57d-47b1-a28c-0d789d524b18"), "Google", "trinhthiquyen@gmail.com", "Trịnh Thị Quyên", 1, "1", new DateTime(2024, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5530), "System", "System", "0898765432" },
                    { new Guid("22ad9911-df30-488a-be58-06a7fc12876a"), "Local", "nguyenhoangp@gmail.com", "Nguyễn Hoàng Phong", 1, "1", new DateTime(2025, 6, 4, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5529), new DateTime(2025, 4, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5528), "Admin", "Admin", "0923456789" },
                    { new Guid("2a8f9d8a-a823-41a2-b0c1-a85ca629b5d0"), "Google", "nguyenthikhanh@gmail.com", "Nguyễn Thị Khánh", 1, "1", new DateTime(2025, 6, 14, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5522), new DateTime(2025, 6, 9, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5521), "Admin", "System", "0834567890" },
                    { new Guid("3b01fc6a-8913-4b86-9856-13b291c37469"), "Facebook", "lyvanro@gmail.com", "Lý Văn Rô", 0, "1", new DateTime(2025, 6, 14, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5532), new DateTime(2025, 1, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5531), "Admin", "Admin", "0945678901" },
                    { new Guid("56b56323-a78c-49c0-b12e-a5667b63b665"), "Local", "hoanganhgialai@gmail.com", "Hoàng Anh Gia Lai", 1, "1", new DateTime(2025, 5, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5517), new DateTime(2025, 3, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5517), "System", "System", "0965432109" },
                    { new Guid("695eb85b-3230-4b2c-8e11-59c62361fed4"), "Google", "dminhai@gmail.com", "Đỗ Minh Hải", 1, "1", new DateTime(2025, 5, 5, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5527), new DateTime(2025, 3, 16, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5527), "System", "System", "0867891234" },
                    { new Guid("7e14fd5a-96d5-458a-ae47-f129f8329b24"), "Facebook", "phamvannam@outlook.com", "Phạm Văn Nam", 0, "1", new DateTime(2025, 5, 25, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5526), new DateTime(2025, 3, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5526), "Admin", "Admin", "0919876543" },
                    { new Guid("884a121a-c0d1-421d-a7c9-78cad5a96964"), "Facebook", "vuvanich@gmail.com", "Vũ Văn Ich", 0, "Fb@12345", new DateTime(2025, 6, 19, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5520), new DateTime(2025, 6, 4, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5520), "Admin", "Admin", "0856781234" },
                    { new Guid("adf88202-f67f-4328-96e9-6df4de555037"), "Facebook", "phamvancanh@gmail.com", "Phạm Văn Cảnh", 0, "1", new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5508), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5508), "Admin", "Admin", "0971123456" },
                    { new Guid("bc5ba611-42ba-45d1-82f0-a6e4d1818403"), "Google", "tranthibe@gmail.com", "Trần Thị Bé", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0987654321" },
                    { new Guid("d2612d36-23b0-4ea8-a69f-8ee0b4721e2e"), "Local", "lethimai@gmail.com", "Lê Thị Mai", 1, "1", new DateTime(2024, 12, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5525), new DateTime(2024, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5524), "Admin", "System", "0387654321" },
                    { new Guid("df6455c8-7070-447f-a8b1-5a41618f1236"), "Facebook", "ngovanf@gmail.com", "Ngô Văn Phát", 0, "1", new DateTime(2024, 12, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5515), new DateTime(2024, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5515), "Admin", "Admin", "0376543210" },
                    { new Guid("e37def42-0129-4296-bbc2-3326c0454a40"), "Facebook", "tranvanly@yahoo.com", "Trần Văn Lý", 1, "1", new DateTime(2025, 4, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5523), new DateTime(2024, 10, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5522), "Admin", "Admin", "0901234567" },
                    { new Guid("f3c99e07-a283-4925-8a2f-e8a6ae8ebccd"), "Google", "phanthiha@gmail.com", "Phan Thị Hà", 1, "1", new DateTime(2025, 2, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5519), new DateTime(2025, 1, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5518), "Admin", "Admin", "0845678901" },
                    { new Guid("f3fd1946-3dfb-4adb-8943-8cd9e44f16eb"), "Local", "lethidau@gmail.com", "Lê Thị Dậu", 1, "1", new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5512), new DateTime(2025, 6, 14, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5509), "Admin", "System", "0356789123" },
                    { new Guid("f9bccf0e-3bd3-4b45-807b-97f193f2a94e"), "Google", "dangvanem@gmail.com", "Đặng Văn Em", 1, "1", new DateTime(2025, 6, 23, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5514), new DateTime(2025, 4, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5513), "Admin", "Admin", "0398765432" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("16409bbf-25b3-4638-97d8-185ebf0cb022"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5647), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5647), "Admin", "Admin", "43" },
                    { new Guid("51ab6cdc-0eb8-4b13-adb8-138264bf830e"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5642), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5642), "Admin", "Admin", "38" },
                    { new Guid("71ce4914-967d-4cd3-9be1-f6c37746cf62"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5641), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5641), "Admin", "Admin", "37" },
                    { new Guid("7c7cef6f-19da-485e-a36e-46336e26ee16"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5648), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5649), "Admin", "Admin", "45" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("9bfc9f1e-0df7-4fc9-9360-803a10528778"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5644), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5644), "Admin", "Admin", "40" },
                    { new Guid("a399b217-b185-4ed4-96f9-4cbca53a3d8a"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5645), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5645), "Admin", "Admin", "41" },
                    { new Guid("a7ea02e4-1a18-48ec-8900-f4480061f0df"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5646), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5646), "Admin", "Admin", "42" },
                    { new Guid("b6b97457-37b3-496c-b304-dd11ad68a34f"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5648), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5648), "Admin", "Admin", "44" },
                    { new Guid("ba6c5efb-8515-433e-b66f-e83e7bd425cf"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5635), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5635), "Admin", "Admin", "35" },
                    { new Guid("bc346ba9-71e2-4838-aa32-81025066e9a9"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5640), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5640), "Admin", "Admin", "36" },
                    { new Guid("f2debce6-bd68-483b-84e3-ab4375c01a43"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5643), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5643), "Admin", "Admin", "39" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("17148d00-3193-40af-8223-10c83cea99d4"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5661), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5661), "Admin", "Admin", "Cổ Điển" },
                    { new Guid("513c3841-4b12-444c-b524-f28bccdee9cb"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5659), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5659), "Admin", "Admin", "Thể Thao" },
                    { new Guid("720ea981-72d8-4c29-be04-bc3bd88f8c27"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5662), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5662), "Admin", "Admin", "Hiện Đại" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("1453fe7a-31fc-425a-bdee-97773307b190"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Xanh lá" },
                    { new Guid("2db2b13d-76f7-4dec-ba6d-ef66a006d730"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5685), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5685), "Admin", "Admin", "Nâu" },
                    { new Guid("3a4637dd-9109-46b4-9e9e-83732bfab299"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5680), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5681), "Admin", "Admin", "Xanh dương" },
                    { new Guid("66b099c8-fef8-4daa-be13-5c86e51e591b"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5686), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5686), "Admin", "Admin", "Hồng" },
                    { new Guid("6c124fc5-aaba-4db3-9d2b-6664b72dedc2"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đỏ" },
                    { new Guid("8186b26d-79ea-4557-bbd9-cbada090aa6e"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5687), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5687), "Admin", "Admin", "Cam" },
                    { new Guid("98c22469-57fc-4d2f-89dc-79b5553385b4"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5683), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5684), "Admin", "Admin", "Xám" },
                    { new Guid("bec91427-0187-4efe-b969-fec175091629"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5688), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5688), "Admin", "Admin", "Kim loại" },
                    { new Guid("e63d9519-af25-4e60-820d-5cabad736342"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5689), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5689), "Admin", "Admin", "Phát quang" },
                    { new Guid("e64275fe-beb0-4648-95f3-bf9e6cd5f104"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5684), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5684), "Admin", "Admin", "Xanh Navy" },
                    { new Guid("edf5d287-85b3-42cf-a312-640ac35c9700"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5682), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5683), "Admin", "Admin", "Trắng" },
                    { new Guid("f4bbfdc9-d8c8-4750-9e22-74680c847837"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5681), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5682), "Admin", "Admin", "Đen" }
                });

            migrationBuilder.InsertData(
                table: "nhanViens",
                columns: new[] { "IdNhanVien", "AnhNhanVien", "AuthProvider", "DiaChi", "Email", "IdchucVu", "KichHoat", "MatKhau", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoDienThoai", "TenNhanVien", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("4dd88800-81a8-4bf9-8fd3-2992576dc9e1"), "1.png", "Local", "Hà Nội", "annthph52133@gmail.com", new Guid("11111111-1111-1111-1111-111111111111"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0976819974", "Nguyễn Thế Bình An", 1 },
                    { new Guid("4f685461-ce64-4fde-8298-32c53bbfdbc1"), "1.png", "Local", "Đà Nẵng", "namdtph39830@fpt.edu.vn", new Guid("22222222-2222-2222-2222-222222222222"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0855896668", "Đào Thành Nam", 1 },
                    { new Guid("86b7d593-aaab-43c5-b491-f306b949b8b2"), "1.png", "Local", "Đà Nẵng", "longkhph35837@fpt.edu.vn", new Guid("22222222-2222-2222-2222-222222222222"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0377804800", "Kim Hoàng Long", 1 },
                    { new Guid("b565f22b-383e-4fab-af87-fbff13d3d44b"), "1.png", "Local", "Đà Nẵng", "tranha10112004@gmail.com", new Guid("11111111-1111-1111-1111-111111111111"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0969293263", "Trần Ngọc Hà", 1 }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("180ed218-dea4-40b0-a9d1-3d6b35141f55"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5720), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5720), "Admin", "Admin", "Fila" },
                    { new Guid("21bfbde8-87fa-4554-82e2-7e34a171dd5b"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5717), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5716), "Admin", "Admin", "Reebok" },
                    { new Guid("5199cf05-12a4-4b5b-9fb9-5d77b6a5d67f"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5725), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5725), "Admin", "Admin", "Dior" },
                    { new Guid("530ac4e9-f278-4edb-ba03-493bcf842228"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5724), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5724), "Admin", "Admin", "Balenciaga" },
                    { new Guid("531ff11d-eac0-477f-9106-b7fde26f7580"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5719), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5719), "Admin", "Admin", "New Balance" },
                    { new Guid("7978534c-3c8a-460e-b12c-8c48bff02795"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5716), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5715), "Admin", "Admin", "Puma" },
                    { new Guid("7bf9b6aa-ee45-4eef-87be-713e14a73aa1"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5714), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5714), "Admin", "Admin", "Adidas" },
                    { new Guid("7bfb1c6e-a115-4dbb-bac0-229cb9197363"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5722), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5722), "Admin", "Admin", "Gucci" },
                    { new Guid("9636d662-51be-4d5b-830f-c954a0de0ce0"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5726), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5726), "Admin", "Admin", "Shondo" },
                    { new Guid("af322831-d2bf-4f58-920a-36c9e6d7e2bc"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5713), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5712), "Admin", "Admin", "Nike" },
                    { new Guid("b992bdf4-7280-4ecf-8463-c7850ea4a1fb"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5719), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5718), "Admin", "Admin", "Vans" },
                    { new Guid("da5ac1ff-c98b-41e2-ac3f-7bc142663659"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5723), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5723), "Admin", "Admin", "Louis Vuitton" },
                    { new Guid("e92f5e03-68a2-4b09-ad12-082c5d5ff37b"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5718), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5717), "Admin", "Admin", "Converse" },
                    { new Guid("ee555f96-473b-48b0-be06-214b6fbdaea8"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5728), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5728), "Admin", "Admin", "Ananas" },
                    { new Guid("ee5f8e2e-7529-4be9-a7e1-8904af81192e"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5727), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5727), "Admin", "Admin", "Biti’s" },
                    { new Guid("f3d0e7fa-9536-412d-905c-92384dac43ea"), 1, new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5721), new DateTime(2025, 6, 24, 10, 25, 26, 963, DateTimeKind.Local).AddTicks(5721), "Admin", "Admin", "MLB" }
                });

            migrationBuilder.InsertData(
                table: "diaChi",
                columns: new[] { "IdDiaChi", "DiaChiMacDinh", "DistrictId", "DistrictName", "HoTen", "IdKhachHang", "MoTa", "ProvinceId", "ProvinceName", "SoDienThoai", "WardId", "WardName" },
                values: new object[,]
                {
                    { new Guid("11f50eef-bf9d-41db-8258-8f0361c218fb"), true, 201, "Quận Bình Thạnh", "Trần Thị Bé", new Guid("bc5ba611-42ba-45d1-82f0-a6e4d1818403"), "Tòa nhà Landmark 81, Bình Thạnh", 2, "Hồ Chí Minh", "0987654321", "00201", "Phường 22" },
                    { new Guid("1443fed3-a132-436a-861e-f5ff1c347c28"), true, 101, "Quận Đống Đa", "Nguyễn Văn Vinh", new Guid("01668f1b-1923-4846-a9a6-8f6f2268d29a"), "Số 10, Ngõ 15, Đường Láng", 1, "Hà Nội", "0912345678", "00101", "Phường Láng Thượng" },
                    { new Guid("145e77ea-4867-4100-a539-268546e6b242"), false, 901, "Thành phố Hạ Long", "Vũ Văn Ich", new Guid("884a121a-c0d1-421d-a7c9-78cad5a96964"), "Số 30, Đường Lê Lợi", 9, "Quảng Ninh", "0856781234", "00901", "Phường Bãi Cháy" },
                    { new Guid("3bcad86e-9c68-46ce-80e1-27d0cd6b4050"), true, 1001, "Huyện Tây Hòa", "Hoàng Anh J", new Guid("2a8f9d8a-a823-41a2-b0c1-a85ca629b5d0"), "Thôn Hồng Thái, Xã Đông Hòa", 10, "Phú Yên", "0976543210", "01001", "Xã Đông Hòa" },
                    { new Guid("52887bb4-e73f-4752-9f0a-885a32b65757"), false, 701, "Quận Ninh Kiều", "Hoàng Anh Gia Lai", new Guid("56b56323-a78c-49c0-b12e-a5667b63b665"), "Khu dân cư Bình Minh", 7, "Cần Thơ", "0965432109", "00701", "Phường Tân An" },
                    { new Guid("7566d921-e740-4e8d-896f-0e2f3791d3ac"), false, 301, "Quận Hải Châu", "Phạm Văn Cảnh", new Guid("adf88202-f67f-4328-96e9-6df4de555037"), "Số 5, Đường Trần Phú", 3, "Đà Nẵng", "0971123456", "00301", "Phường Thạch Thang" },
                    { new Guid("c0c2456b-6ad4-4d9f-90f1-eda5704e54f8"), true, 801, "Thành phố Nha Trang", "Phan Thị Hà", new Guid("f3c99e07-a283-4925-8a2f-e8a6ae8ebccd"), "Số 15, Đường Hoàng Diệu", 8, "Khánh Hòa", "0845678901", "00801", "Phường Phước Long" },
                    { new Guid("d296f25c-a5ad-414c-88c4-67aa77892a69"), true, 401, "Thị xã Thuận An", "Lê Thị Dậu", new Guid("f3fd1946-3dfb-4adb-8943-8cd9e44f16eb"), "Khu phố 1, Phường Vĩnh Phú", 4, "Bình Dương", "0356789123", "00401", "Phường Vĩnh Phú" },
                    { new Guid("d3cf6537-8e49-421f-8f7f-ca2ce778b578"), true, 601, "Thành phố Huế", "Ngô Văn Phát", new Guid("df6455c8-7070-447f-a8b1-5a41618f1236"), "Số 20, Đường Nguyễn Huệ", 6, "Thừa Thiên Huế", "0376543210", "00601", "Phường Vĩnh Ninh" },
                    { new Guid("e4f330ae-3f0f-4c5e-a51e-c710ffc20a89"), false, 501, "Huyện Long Thành", "Đặng Văn Em", new Guid("f9bccf0e-3bd3-4b45-807b-97f193f2a94e"), "Ấp An Hòa, Xã An Bình", 5, "Đồng Nai", "0398765432", "00501", "Xã An Bình" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("0f1f5819-4be0-4b1b-b155-c9efc60b4083"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("2ab9add0-9758-4c15-9766-dbf12e1234af"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("db98d0c0-e622-4661-b481-68d73191164e"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("ea640fbb-1eb5-4538-a0b2-38b3b8f07c6b"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("f59b37a8-6f81-4e63-a467-344f7f0aa6b3"));

            migrationBuilder.DeleteData(
                table: "chatLieus",
                keyColumn: "IdChatLieu",
                keyValue: new Guid("fddb872b-6590-401c-98e6-7df62d0d6cbe"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("22040117-dca4-4388-815d-4a42bf0aafea"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("3ab70879-eee9-4e51-bd1f-3d8d337be1d9"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("790ec83f-e164-454e-9589-be414762fd6f"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("7ab3e390-cb7a-4570-b85e-a7c2f4861868"));

            migrationBuilder.DeleteData(
                table: "danhMuc",
                keyColumn: "IdDanhMuc",
                keyValue: new Guid("84b25828-23ae-4262-aa10-16dab96268fd"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("30918eb8-145d-46da-874c-d714895e6e20"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("48fcea3b-521f-4f28-9002-c84912c0982b"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("66cf421e-ea9b-4555-a25d-206769683aee"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("a713987d-b5e9-4607-9ab8-61fca63bce3b"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("abb0b36a-8d93-4401-9f1a-3924688a8320"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("cd379e5a-03cc-4283-9592-b782d30534c3"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("dfb9fccb-dde4-4b98-938d-deb2c2bbaff7"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("e3793813-fa6c-4094-8754-c5b1b98ed468"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("f1a54ea3-b573-4fa2-a756-46587a77dfaf"));

            migrationBuilder.DeleteData(
                table: "deGiay",
                keyColumn: "IdDeGiay",
                keyValue: new Guid("fe5c2058-86cf-4743-9533-6b512d5c7e64"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("11f50eef-bf9d-41db-8258-8f0361c218fb"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("1443fed3-a132-436a-861e-f5ff1c347c28"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("145e77ea-4867-4100-a539-268546e6b242"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("3bcad86e-9c68-46ce-80e1-27d0cd6b4050"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("52887bb4-e73f-4752-9f0a-885a32b65757"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("7566d921-e740-4e8d-896f-0e2f3791d3ac"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("c0c2456b-6ad4-4d9f-90f1-eda5704e54f8"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("d296f25c-a5ad-414c-88c4-67aa77892a69"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("d3cf6537-8e49-421f-8f7f-ca2ce778b578"));

            migrationBuilder.DeleteData(
                table: "diaChi",
                keyColumn: "IdDiaChi",
                keyValue: new Guid("e4f330ae-3f0f-4c5e-a51e-c710ffc20a89"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("17989a49-b57d-47b1-a28c-0d789d524b18"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("22ad9911-df30-488a-be58-06a7fc12876a"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("3b01fc6a-8913-4b86-9856-13b291c37469"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("695eb85b-3230-4b2c-8e11-59c62361fed4"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("7e14fd5a-96d5-458a-ae47-f129f8329b24"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("d2612d36-23b0-4ea8-a69f-8ee0b4721e2e"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("e37def42-0129-4296-bbc2-3326c0454a40"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("16409bbf-25b3-4638-97d8-185ebf0cb022"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("51ab6cdc-0eb8-4b13-adb8-138264bf830e"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("71ce4914-967d-4cd3-9be1-f6c37746cf62"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("7c7cef6f-19da-485e-a36e-46336e26ee16"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("9bfc9f1e-0df7-4fc9-9360-803a10528778"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("a399b217-b185-4ed4-96f9-4cbca53a3d8a"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("a7ea02e4-1a18-48ec-8900-f4480061f0df"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("b6b97457-37b3-496c-b304-dd11ad68a34f"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("ba6c5efb-8515-433e-b66f-e83e7bd425cf"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("bc346ba9-71e2-4838-aa32-81025066e9a9"));

            migrationBuilder.DeleteData(
                table: "kichCos",
                keyColumn: "IdKichCo",
                keyValue: new Guid("f2debce6-bd68-483b-84e3-ab4375c01a43"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("17148d00-3193-40af-8223-10c83cea99d4"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("513c3841-4b12-444c-b524-f28bccdee9cb"));

            migrationBuilder.DeleteData(
                table: "kieuDangs",
                keyColumn: "IdKieuDang",
                keyValue: new Guid("720ea981-72d8-4c29-be04-bc3bd88f8c27"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("1453fe7a-31fc-425a-bdee-97773307b190"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("2db2b13d-76f7-4dec-ba6d-ef66a006d730"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("3a4637dd-9109-46b4-9e9e-83732bfab299"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("66b099c8-fef8-4daa-be13-5c86e51e591b"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("6c124fc5-aaba-4db3-9d2b-6664b72dedc2"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("8186b26d-79ea-4557-bbd9-cbada090aa6e"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("98c22469-57fc-4d2f-89dc-79b5553385b4"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("bec91427-0187-4efe-b969-fec175091629"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("e63d9519-af25-4e60-820d-5cabad736342"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("e64275fe-beb0-4648-95f3-bf9e6cd5f104"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("edf5d287-85b3-42cf-a312-640ac35c9700"));

            migrationBuilder.DeleteData(
                table: "mauSacs",
                keyColumn: "IdMauSac",
                keyValue: new Guid("f4bbfdc9-d8c8-4750-9e22-74680c847837"));

            migrationBuilder.DeleteData(
                table: "nhanViens",
                keyColumn: "IdNhanVien",
                keyValue: new Guid("4dd88800-81a8-4bf9-8fd3-2992576dc9e1"));

            migrationBuilder.DeleteData(
                table: "nhanViens",
                keyColumn: "IdNhanVien",
                keyValue: new Guid("4f685461-ce64-4fde-8298-32c53bbfdbc1"));

            migrationBuilder.DeleteData(
                table: "nhanViens",
                keyColumn: "IdNhanVien",
                keyValue: new Guid("86b7d593-aaab-43c5-b491-f306b949b8b2"));

            migrationBuilder.DeleteData(
                table: "nhanViens",
                keyColumn: "IdNhanVien",
                keyValue: new Guid("b565f22b-383e-4fab-af87-fbff13d3d44b"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("180ed218-dea4-40b0-a9d1-3d6b35141f55"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("21bfbde8-87fa-4554-82e2-7e34a171dd5b"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("5199cf05-12a4-4b5b-9fb9-5d77b6a5d67f"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("530ac4e9-f278-4edb-ba03-493bcf842228"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("531ff11d-eac0-477f-9106-b7fde26f7580"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("7978534c-3c8a-460e-b12c-8c48bff02795"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("7bf9b6aa-ee45-4eef-87be-713e14a73aa1"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("7bfb1c6e-a115-4dbb-bac0-229cb9197363"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("9636d662-51be-4d5b-830f-c954a0de0ce0"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("af322831-d2bf-4f58-920a-36c9e6d7e2bc"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("b992bdf4-7280-4ecf-8463-c7850ea4a1fb"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("da5ac1ff-c98b-41e2-ac3f-7bc142663659"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("e92f5e03-68a2-4b09-ad12-082c5d5ff37b"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("ee555f96-473b-48b0-be06-214b6fbdaea8"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("ee5f8e2e-7529-4be9-a7e1-8904af81192e"));

            migrationBuilder.DeleteData(
                table: "thuongHieus",
                keyColumn: "IdThuongHieu",
                keyValue: new Guid("f3d0e7fa-9536-412d-905c-92384dac43ea"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("01668f1b-1923-4846-a9a6-8f6f2268d29a"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("2a8f9d8a-a823-41a2-b0c1-a85ca629b5d0"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("56b56323-a78c-49c0-b12e-a5667b63b665"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("884a121a-c0d1-421d-a7c9-78cad5a96964"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("adf88202-f67f-4328-96e9-6df4de555037"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("bc5ba611-42ba-45d1-82f0-a6e4d1818403"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("df6455c8-7070-447f-a8b1-5a41618f1236"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("f3c99e07-a283-4925-8a2f-e8a6ae8ebccd"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("f3fd1946-3dfb-4adb-8943-8cd9e44f16eb"));

            migrationBuilder.DeleteData(
                table: "khachHangs",
                keyColumn: "IdKhachHang",
                keyValue: new Guid("f9bccf0e-3bd3-4b45-807b-97f193f2a94e"));

            migrationBuilder.InsertData(
                table: "chatLieus",
                columns: new[] { "IdChatLieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenChatLieu" },
                values: new object[,]
                {
                    { new Guid("6cb1a723-1eb9-4057-8eb1-3102eeb9dffa"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Polyester" },
                    { new Guid("788272d4-b657-44a7-90e6-4022bb23cf3a"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Tự Nhiên" },
                    { new Guid("8078d1d4-3c58-4d9d-b532-c9fddc081d09"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7114), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da Lộn" },
                    { new Guid("a316df9f-6187-4dfe-ade2-295e138f1518"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Dệt" },
                    { new Guid("a5186b38-6469-42e8-8857-325f82942b78"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Vải Cotton" },
                    { new Guid("c354f848-6634-42f9-9969-fd004ca76e9d"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Da thật" }
                });

            migrationBuilder.InsertData(
                table: "danhMuc",
                columns: new[] { "IdDanhMuc", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("0d192cb0-7ea8-4b51-9f9b-8eb533aefaef"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Cổ Trung" },
                    { new Guid("3b7b0f0b-add6-42bf-bd60-ae67f1cb0515"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7131), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Da" },
                    { new Guid("45c8a5ed-7ac1-4c86-a5d7-619490c7cb20"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7134), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Cổ Cao" },
                    { new Guid("58926572-0d7d-4670-baa2-bf1458f6cd27"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Cổ Thấp" },
                    { new Guid("69c850fd-512b-49c3-ba38-a45d63a0c17b"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7130), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Giày Thể Thao" }
                });

            migrationBuilder.InsertData(
                table: "deGiay",
                columns: new[] { "IdDeGiay", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenDeGiay" },
                values: new object[,]
                {
                    { new Guid("18613893-9891-40cc-be6d-3cc2171c30d2"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế PVC" },
                    { new Guid("228bd693-88c4-4919-9286-c6321805ff74"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chisty" },
                    { new Guid("6b433a32-94ce-414d-a9df-ba7760055336"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Chunky" },
                    { new Guid("82fa4211-6e22-4e02-9d6e-1b53d9de7a25"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Cao Su Lưu Hóa" },
                    { new Guid("a45c8106-459c-4695-a3b6-a7406d54022a"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Eva" },
                    { new Guid("a9aac366-f947-4c05-8809-643ec6df686a"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế cao su" },
                    { new Guid("b1a01300-236b-4661-adee-e7864ea74a1e"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế BPU" },
                    { new Guid("b665d4c6-3e20-4aff-b127-ee429e585713"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế vải" },
                    { new Guid("bcc730dd-0fb8-484f-96dd-cecd52406d9b"), 1, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế Giày Lười" },
                    { new Guid("e6e60612-12b6-49cd-8db3-c461cac84b94"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đế nhựa" }
                });

            migrationBuilder.InsertData(
                table: "khachHangs",
                columns: new[] { "IdKhachHang", "AuthProvider", "Email", "HoTen", "KichHoat", "MatKhau", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoDienThoai" },
                values: new object[,]
                {
                    { new Guid("08070e87-39b3-4e88-92d6-3b6a8fd28cca"), "Facebook", "phamvancanh@gmail.com", "Phạm Văn Cảnh", 0, "1", new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7193), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7192), "Admin", "Admin", "0971123456" },
                    { new Guid("1c2c0b08-bba2-42f8-942e-249014ac6bd3"), "Local", "nguyenhoangp@gmail.com", "Nguyễn Hoàng Phong", 1, "1", new DateTime(2025, 5, 27, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7215), new DateTime(2025, 4, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7215), "Admin", "Admin", "0923456789" },
                    { new Guid("251cb829-a8b7-41b3-9a5f-2cae55af1d28"), "Local", "lethidau@gmail.com", "Lê Thị Dậu", 1, "1", new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7197), new DateTime(2025, 6, 6, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7194), "Admin", "System", "0356789123" },
                    { new Guid("4f736bef-459d-4eed-9701-467ae40e755f"), "Local", "nguyenvanvinh@gmail.com", "Nguyễn Văn Vinh", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0912345678" },
                    { new Guid("623a7e4d-aadf-451b-bf19-0decf2a9f14a"), "Facebook", "tranvanly@yahoo.com", "Trần Văn Lý", 1, "1", new DateTime(2025, 4, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 10, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7209), "Admin", "Admin", "0901234567" },
                    { new Guid("6c4c5b45-bc03-4612-8d1c-a8fdc9366fc8"), "Local", "hoanganhgialai@gmail.com", "Hoàng Anh Gia Lai", 1, "1", new DateTime(2025, 5, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7203), new DateTime(2025, 3, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7202), "System", "System", "0965432109" },
                    { new Guid("6c921493-4505-4026-8255-353307784576"), "Local", "lethimai@gmail.com", "Lê Thị Mai", 1, "1", new DateTime(2024, 12, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7211), "Admin", "System", "0387654321" },
                    { new Guid("731e0872-7498-4fdc-8c63-5bb7f8106acc"), "Google", "nguyenthikhanh@gmail.com", "Nguyễn Thị Khánh", 1, "1", new DateTime(2025, 6, 6, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7208), new DateTime(2025, 6, 1, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7207), "Admin", "System", "0834567890" },
                    { new Guid("794a4bab-ee94-47ae-b663-209fa95956d7"), "Facebook", "vuvanich@gmail.com", "Vũ Văn Ich", 0, "Fb@12345", new DateTime(2025, 6, 11, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7206), new DateTime(2025, 5, 27, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7206), "Admin", "Admin", "0856781234" },
                    { new Guid("83eaca99-d85f-4228-82b9-9e0422d23e3c"), "Facebook", "lyvanro@gmail.com", "Lý Văn Rô", 0, "1", new DateTime(2025, 6, 6, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7218), new DateTime(2025, 1, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7218), "Admin", "Admin", "0945678901" },
                    { new Guid("96b05ac3-0a15-4eca-b233-3a2713c2f6c1"), "Google", "dangvanem@gmail.com", "Đặng Văn Em", 1, "1", new DateTime(2025, 6, 15, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7199), new DateTime(2025, 4, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7198), "Admin", "Admin", "0398765432" },
                    { new Guid("a9626cca-3b7a-495b-bcdb-b86bc71a162c"), "Google", "phanthiha@gmail.com", "Phan Thị Hà", 1, "1", new DateTime(2025, 2, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7205), new DateTime(2025, 1, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7204), "Admin", "Admin", "0845678901" },
                    { new Guid("ae72cecb-5563-4eb6-b885-56d2f53fa536"), "Google", "tranthibe@gmail.com", "Trần Thị Bé", 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0987654321" },
                    { new Guid("ce5d4946-04e4-48f7-a047-678b60d6b14a"), "Google", "dminhai@gmail.com", "Đỗ Minh Hải", 1, "1", new DateTime(2025, 4, 27, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7214), new DateTime(2025, 3, 8, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7214), "System", "System", "0867891234" },
                    { new Guid("db56cb97-4ba7-41c9-8cf8-2b7b57304cef"), "Facebook", "ngovanf@gmail.com", "Ngô Văn Phát", 0, "1", new DateTime(2024, 12, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7201), new DateTime(2024, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7200), "Admin", "Admin", "0376543210" },
                    { new Guid("dbdc2639-493b-47a7-b81c-eccb2d381eb2"), "Facebook", "phamvannam@outlook.com", "Phạm Văn Nam", 0, "1", new DateTime(2025, 5, 17, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7213), new DateTime(2025, 3, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7212), "Admin", "Admin", "0919876543" },
                    { new Guid("fd2a138a-0c43-43dd-bab4-b091649f9708"), "Google", "trinhthiquyen@gmail.com", "Trịnh Thị Quyên", 1, "1", new DateTime(2024, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7217), new DateTime(2023, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7216), "System", "System", "0898765432" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("0fd1c530-0fa0-4a38-992c-f53a229c5dec"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7272), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7272), "Admin", "Admin", "41" },
                    { new Guid("291857df-1462-4b13-b7c5-ad88a436df02"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7265), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7265), "Admin", "Admin", "35" },
                    { new Guid("37f40be9-3c33-448b-bf2f-6d2e2d37604c"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7275), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7275), "Admin", "Admin", "44" },
                    { new Guid("3ba8283b-fbe1-42d7-b158-0067af26b6ed"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7270), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7270), "Admin", "Admin", "39" }
                });

            migrationBuilder.InsertData(
                table: "kichCos",
                columns: new[] { "IdKichCo", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKichCo" },
                values: new object[,]
                {
                    { new Guid("444bfe5c-a924-4f07-a0fc-a286ea5825e5"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7274), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7274), "Admin", "Admin", "43" },
                    { new Guid("72c25b91-62a3-448a-b721-722bd0e3ccd3"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7276), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7276), "Admin", "Admin", "45" },
                    { new Guid("779327ce-7304-4433-924a-cd109862996a"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7269), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7269), "Admin", "Admin", "38" },
                    { new Guid("aa8cf8f9-ccce-453a-81fa-23ce02687283"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7273), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7273), "Admin", "Admin", "42" },
                    { new Guid("b16ccc51-ff2c-482e-bc8a-868d6b905b27"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7267), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7267), "Admin", "Admin", "36" },
                    { new Guid("b296577b-4ee3-4d20-8889-bf18dfa31475"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7271), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7271), "Admin", "Admin", "40" },
                    { new Guid("edbd8a1d-2afe-4838-b50a-701358ca2639"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7268), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7268), "Admin", "Admin", "37" }
                });

            migrationBuilder.InsertData(
                table: "kieuDangs",
                columns: new[] { "IdKieuDang", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenKieuDang" },
                values: new object[,]
                {
                    { new Guid("2da1bc0e-faf8-404b-a88f-420808b4100f"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7290), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7290), "Admin", "Admin", "Cổ Điển" },
                    { new Guid("49e029b3-e6c0-4c84-b8a1-b5b4567d4871"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7289), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7288), "Admin", "Admin", "Thể Thao" },
                    { new Guid("be8e4e67-d12d-410e-be13-d70511ac5537"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7292), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7291), "Admin", "Admin", "Hiện Đại" }
                });

            migrationBuilder.InsertData(
                table: "mauSacs",
                columns: new[] { "IdMauSac", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenMauSac" },
                values: new object[,]
                {
                    { new Guid("0299ec05-a500-4c2b-9b6f-2284bbb5ce44"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7320), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7320), "Admin", "Admin", "Kim loại" },
                    { new Guid("04323a3e-6d61-4ff7-95ba-13d737f5d466"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7315), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7315), "Admin", "Admin", "Xám" },
                    { new Guid("0f8bb62a-a4df-4446-bc26-7362100f6585"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7313), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7313), "Admin", "Admin", "Đen" },
                    { new Guid("2bca80cb-b941-4c79-b7ac-39fd98a1549b"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Đỏ" },
                    { new Guid("3c1ad2d8-0c89-4504-8ce8-495ee0136610"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7321), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7321), "Admin", "Admin", "Phát quang" },
                    { new Guid("41341125-9c35-4968-b56a-bc460a59f10c"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7314), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7314), "Admin", "Admin", "Trắng" },
                    { new Guid("47094a2c-ad4d-422c-853a-e5e2426549b5"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7317), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7317), "Admin", "Admin", "Nâu" },
                    { new Guid("76c67f7c-cd28-4821-b8c7-18a9736fa046"), 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "Xanh lá" },
                    { new Guid("9f51eff6-8f37-4224-bc5c-0286f07a9e8f"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7311), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7311), "Admin", "Admin", "Xanh dương" },
                    { new Guid("a682d03c-14b0-4686-ab00-f0385e06b480"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7319), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7319), "Admin", "Admin", "Cam" },
                    { new Guid("ba35398f-1b81-49f9-99c2-a570c0db25e5"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7318), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7318), "Admin", "Admin", "Hồng" },
                    { new Guid("bba535ac-e12d-4d29-bfae-8d005d997632"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7316), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7316), "Admin", "Admin", "Xanh Navy" }
                });

            migrationBuilder.InsertData(
                table: "nhanViens",
                columns: new[] { "IdNhanVien", "AnhNhanVien", "AuthProvider", "DiaChi", "Email", "IdchucVu", "KichHoat", "MatKhau", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "SoDienThoai", "TenNhanVien", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("08185d6e-b5a1-473c-97ef-f62ff4a86004"), "1.png", "Local", "Đà Nẵng", "namdtph39830@fpt.edu.vn", new Guid("22222222-2222-2222-2222-222222222222"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0855896668", "Đào Thành Nam", 1 },
                    { new Guid("2963eb8f-b5ca-47b0-964c-05084829fb41"), "1.png", "Local", "Hà Nội", "hieupdph40428@fpt.edu.vn", new Guid("11111111-1111-1111-1111-111111111111"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0976819974", "Phạm Đức Hiếu", 1 },
                    { new Guid("36f4657e-104b-4a43-95ba-b600f70fb18c"), "1.png", "Local", "Đà Nẵng", "longkhph35837@fpt.edu.vn", new Guid("22222222-2222-2222-2222-222222222222"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0377804800", "Kim Hoàng Long", 1 },
                    { new Guid("f654e805-dc34-4f15-98c3-27a3caa73c53"), "1.png", "Local", "Đà Nẵng", "tranha10112004@gmail.com", new Guid("11111111-1111-1111-1111-111111111111"), 1, "1", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", "0969293263", "Trần Ngọc Hà", 1 }
                });

            migrationBuilder.InsertData(
                table: "thuongHieus",
                columns: new[] { "IdThuongHieu", "KichHoat", "NgayCapNhat", "NgayTao", "NguoiCapNhat", "NguoiTao", "TenThuongHieu" },
                values: new object[,]
                {
                    { new Guid("0ff22cfa-f37c-4ff8-b1f0-5e33afd425ee"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7353), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7353), "Admin", "Admin", "Shondo" },
                    { new Guid("100f85da-1672-4525-a0f9-ddaec78a5a11"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7348), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7348), "Admin", "Admin", "Fila" },
                    { new Guid("3759b65f-52b0-458d-a6cc-94373f0d2814"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7340), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7340), "Admin", "Admin", "Nike" },
                    { new Guid("3954ef34-e6f2-4a72-a588-6f4e232ecb5b"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7344), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7344), "Admin", "Admin", "Reebok" },
                    { new Guid("42e91258-b261-4624-9aba-67e04ab0e9b4"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7355), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7355), "Admin", "Admin", "Ananas" },
                    { new Guid("45de5bc5-370e-4141-9c6d-255c00e2f283"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7346), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7346), "Admin", "Admin", "Vans" },
                    { new Guid("4edaf08e-c6cd-4da3-8175-e8f48182113a"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7354), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7354), "Admin", "Admin", "Biti’s" },
                    { new Guid("68059006-432b-4608-830a-f58cfa7f71cf"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7345), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7345), "Admin", "Admin", "Converse" },
                    { new Guid("6bb81b89-288b-43a9-8303-8d7a3c87df62"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7343), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7343), "Admin", "Admin", "Puma" },
                    { new Guid("6f8152fd-1ed3-45f1-a6f0-2cfc22a80fd1"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7349), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7349), "Admin", "Admin", "MLB" },
                    { new Guid("818c5b73-d9de-4021-b67c-75698e030d0a"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7342), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7341), "Admin", "Admin", "Adidas" },
                    { new Guid("946919be-19cf-491a-9ac1-c74d7e3f76ab"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7351), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7350), "Admin", "Admin", "Louis Vuitton" },
                    { new Guid("9be46525-5757-4c2f-9a45-b597a922afad"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7347), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7347), "Admin", "Admin", "New Balance" },
                    { new Guid("c5845a44-fa44-43b9-94ed-d29ea63f0389"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7352), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7351), "Admin", "Admin", "Balenciaga" },
                    { new Guid("cde80bc4-b903-4f7f-af58-92aec0d9e5e1"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7352), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7352), "Admin", "Admin", "Dior" },
                    { new Guid("fc05a39f-557d-4734-b58d-7fa47d5725e9"), 1, new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7350), new DateTime(2025, 6, 16, 16, 55, 37, 630, DateTimeKind.Local).AddTicks(7349), "Admin", "Admin", "Gucci" }
                });

            migrationBuilder.InsertData(
                table: "diaChi",
                columns: new[] { "IdDiaChi", "DiaChiMacDinh", "DistrictId", "DistrictName", "HoTen", "IdKhachHang", "MoTa", "ProvinceId", "ProvinceName", "SoDienThoai", "WardId", "WardName" },
                values: new object[,]
                {
                    { new Guid("2f57ccad-fd7d-48d7-935c-afe9d8f558c1"), true, 801, "Thành phố Nha Trang", "Phan Thị Hà", new Guid("a9626cca-3b7a-495b-bcdb-b86bc71a162c"), "Số 15, Đường Hoàng Diệu", 8, "Khánh Hòa", "0845678901", "00801", "Phường Phước Long" },
                    { new Guid("432836d2-0deb-42f7-bb5e-bc6638f1fa1f"), true, 601, "Thành phố Huế", "Ngô Văn Phát", new Guid("db56cb97-4ba7-41c9-8cf8-2b7b57304cef"), "Số 20, Đường Nguyễn Huệ", 6, "Thừa Thiên Huế", "0376543210", "00601", "Phường Vĩnh Ninh" },
                    { new Guid("47b4b713-2ea6-41e9-9506-412e06bf136f"), true, 1001, "Huyện Tây Hòa", "Hoàng Anh J", new Guid("731e0872-7498-4fdc-8c63-5bb7f8106acc"), "Thôn Hồng Thái, Xã Đông Hòa", 10, "Phú Yên", "0976543210", "01001", "Xã Đông Hòa" },
                    { new Guid("53f75b0e-74de-4478-a2f4-484f544ec6eb"), false, 701, "Quận Ninh Kiều", "Hoàng Anh Gia Lai", new Guid("6c4c5b45-bc03-4612-8d1c-a8fdc9366fc8"), "Khu dân cư Bình Minh", 7, "Cần Thơ", "0965432109", "00701", "Phường Tân An" },
                    { new Guid("59f44b8f-ef2a-4893-a4c7-3c7b614637d9"), false, 501, "Huyện Long Thành", "Đặng Văn Em", new Guid("96b05ac3-0a15-4eca-b233-3a2713c2f6c1"), "Ấp An Hòa, Xã An Bình", 5, "Đồng Nai", "0398765432", "00501", "Xã An Bình" },
                    { new Guid("b0b93450-60fb-4c2d-ab30-179ba54e3129"), false, 301, "Quận Hải Châu", "Phạm Văn Cảnh", new Guid("08070e87-39b3-4e88-92d6-3b6a8fd28cca"), "Số 5, Đường Trần Phú", 3, "Đà Nẵng", "0971123456", "00301", "Phường Thạch Thang" },
                    { new Guid("b96784c5-3b09-4b6f-81f0-6daef145dc70"), true, 201, "Quận Bình Thạnh", "Trần Thị Bé", new Guid("ae72cecb-5563-4eb6-b885-56d2f53fa536"), "Tòa nhà Landmark 81, Bình Thạnh", 2, "Hồ Chí Minh", "0987654321", "00201", "Phường 22" },
                    { new Guid("ba4f9afe-45fc-4177-8255-9fe1565b826f"), true, 401, "Thị xã Thuận An", "Lê Thị Dậu", new Guid("251cb829-a8b7-41b3-9a5f-2cae55af1d28"), "Khu phố 1, Phường Vĩnh Phú", 4, "Bình Dương", "0356789123", "00401", "Phường Vĩnh Phú" },
                    { new Guid("d8e815db-03ce-43a8-add6-ffc2500a619a"), true, 101, "Quận Đống Đa", "Nguyễn Văn Vinh", new Guid("4f736bef-459d-4eed-9701-467ae40e755f"), "Số 10, Ngõ 15, Đường Láng", 1, "Hà Nội", "0912345678", "00101", "Phường Láng Thượng" },
                    { new Guid("fa669045-b33e-4228-b2bd-30e3e6c05926"), false, 901, "Thành phố Hạ Long", "Vũ Văn Ich", new Guid("794a4bab-ee94-47ae-b663-209fa95956d7"), "Số 30, Đường Lê Lợi", 9, "Quảng Ninh", "0856781234", "00901", "Phường Bãi Cháy" }
                });
        }
    }
}
