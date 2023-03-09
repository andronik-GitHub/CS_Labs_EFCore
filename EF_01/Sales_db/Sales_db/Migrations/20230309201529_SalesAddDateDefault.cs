using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sales_db.Migrations
{
    /// <inheritdoc />
    public partial class SalesAddDateDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("01467d49-46cf-48d7-875c-64283df9d39b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("01a2da6b-1612-4833-908a-6bf9ff7ab349"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0220e020-2078-470c-a3a6-fba42496867a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("03773fb0-5311-4be2-b071-55a3ef224ca5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("03c40320-8741-4121-9325-badf83c1e93d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0555937e-b30a-44cb-a3af-f7e0d0943de8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("05f58364-1afb-43b4-81da-0a8e6f6d1dfd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("06552856-fa56-44db-bac2-0c2e43cb0b41"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0854a580-8d26-47b6-a972-c9a57dbe8e9f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("096d24e3-f759-436e-9c3b-037ee34e98a0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("09a39f95-ee2e-4396-a89a-34694eab61f0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0b3f4ad6-72eb-4f2e-b7cc-cfc19b42300d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0c8c0736-da79-4f93-8c51-2b6c5900a288"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0d5465f8-df76-422b-9079-5ba9fafc8918"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0e1f8c55-c3af-4ad3-a99b-a2eedb9e83e9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0ee47890-118a-4a56-a940-5932c59531d2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1013ea64-d9f8-433c-98ca-e27ebb228a17"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("10bd024e-3ff4-43b8-9549-de882a0bd06a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("12fe66e7-d5f1-4edf-bb9b-8ae2012c072c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("170f7904-3b8d-4bcb-b7da-1d2ee5e117c1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1781a0e1-f3e3-4665-b7a4-73b4d52540b0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("17a10fe8-6781-41c9-9141-c6875b0cfad3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("180e7170-7a5c-4985-8c94-ee44c48a367a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1afd1fa0-b4b5-4856-adc7-9f4932fd4978"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1b224ca1-0c00-48f4-af2e-dd0430994c11"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1b58df58-9ea2-478a-949d-d13f30f12d28"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1bb4c36b-d4ae-414d-92c5-dda582f48e99"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1cb21ded-6603-4960-8ff6-4e94660af9bf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1cbf5e9d-c15f-4112-9606-00aa79bbcddf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1dea70a6-008b-49ca-993f-6fa6798f6a4c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1f072cf7-a15f-4d09-93c0-ba77af34cbb5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1f6d49ac-0bfa-4d2f-b75e-2903194f0e8c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1f78217b-f138-4d85-9338-6f2d5ac278b3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1f9b999c-4e1b-44ee-9e81-2f71442e74ef"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("202a50e9-0f7b-4e66-9dfb-591628c934dd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("215f159f-ffc5-4416-ab09-29a77857a520"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2234ed4f-67fe-48d3-ae00-d222826fd8c4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("23c42d30-7ee2-4b27-8a1f-bc6da470033b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("23cfc5b7-e175-4c11-b754-4339ebb13380"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("246a9dd1-44a3-4723-8fce-bad06d2abbe4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("24e324a5-bdcf-4c4f-bb25-37ca4dd89723"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2857ab68-db1b-4bab-bb7c-9d8a5a71cad3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2d5baa3d-764d-4fcd-a727-aa96424ce94a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("35335193-a2b7-4857-8973-009189f6d327"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3611f76f-190f-4f3c-834b-432fb8ff1b0a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("36cecce1-a3d7-4869-9848-c214bd5a0115"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("36effc28-46f9-44ba-863f-39fce30c030c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("38bbd32f-9a88-47b5-878a-b7b318b636c4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3ce85fce-0184-4245-9d24-42a9672ee1fb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3ceb29bb-e128-4762-bcbe-4d0e4fb9a219"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3e2fe303-cb1e-4c93-91b9-9f159ca8cdc8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3f9e8d68-2f64-4a3e-ae77-e577ef9cf695"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("41bc5536-d4f0-4a67-81f5-ad612ffb1374"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("43bec3ff-db9d-4e75-90be-8f46183d566f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("43c92f58-6192-4f65-a813-7342085081b2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("44260ab8-2d46-4350-94c4-2f9cb4d0bd3c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("45c6037f-72a7-4576-a38b-a54e3939f29c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("45d10d0f-7b3c-4f3a-ab08-b6ce011ee088"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4652553e-6565-4840-9c06-64dfbb86ac66"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("48a4f8b8-050d-432b-a193-299354e25e8e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("49a3b063-1135-4dbe-817f-027013a7f7ad"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4abafd2a-0a9c-471e-b0b4-d1a2399f8eae"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4c66f488-0512-4332-a81b-a754b81849cf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("519ff599-e872-46d3-8008-a8777a38a3e6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("521f5e67-faa3-471d-bf9a-5bf130505278"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("52b241c4-dad2-4ec7-9d25-07a892f0c247"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("52fb3b38-b91c-4c9b-81c9-ecbf50df1085"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("54724408-433c-4ecc-b95a-0bf291d69f76"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5543ab48-d99c-4ddd-95be-4d459d382a1a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5960bb73-27f5-4286-8840-43e2e33699c0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5a9cb0a2-2913-4492-ab5f-1670023d5f0d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5bdc0df7-814e-4edd-9d10-5a2d558be949"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5c074cf8-60be-4ef1-84f7-9bbcb5b43ab8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5c15fb5e-af56-437b-860b-d4a49609964f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5c5e5079-90c7-4408-88be-621a4aa4c7a6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5d7a2787-29e3-4f7e-b715-0640011093dd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("60ccea16-3d70-4829-b73c-423e829324db"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6147383f-5e18-42fc-b3cf-a994bcd2b29b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("61a7ace5-cfac-4048-9073-80fbf6752db1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("61c168ae-f40a-41a6-a63a-44f7a5260ebd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("626cad4e-193f-4d2c-993c-0acdc5218f6d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("62c5c938-bf56-4949-babd-309af06cce58"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6341ba48-b9d6-430e-a430-995caae509ff"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6351b7d5-4c00-414d-ace5-4795e3703eec"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6362084f-9fa7-45b3-b173-638442b19946"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("67757067-314d-4856-81ba-fdcf1c7e04ca"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6a4107d1-fe0d-449d-aa9a-f7a8eac1a574"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6a9884a7-3e5f-4ce1-a659-03873c4e946d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6c3d62c3-a396-4d8b-b9a2-301135789c64"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6d20eb6b-ec56-4419-8df9-7ec20ee38f1f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6f9a56da-dcef-4118-84ee-2120e45eda99"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("705f570e-e437-457d-810f-a1c0cfaa8a74"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7112510b-417b-4b12-87e1-7bda44e90265"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7248f5ee-d65d-4f22-8402-e212e6c79781"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("74698389-abd0-4ed1-ac31-b8390b03396b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("750ee119-b47f-483a-9fca-2800e66236e6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7546bc18-9032-42f1-ad54-aae9d615aed9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("768d5dbb-16c5-4d63-af8c-7cb242f9e7b2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7805e718-7b70-4006-92ad-6198e6fcd9b1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("79570e3f-116e-4f81-bdab-b32f6a92ef00"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7b46355f-780f-4f4e-9dac-b3099690bfb3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7cd5586d-b97b-49f8-a7a6-a75955555c62"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7d1b4b4a-3da3-4974-924e-c8ecec63e97d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7d34540e-278e-4a5f-bc95-6a37b0ac47ab"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7f6da968-ee50-414d-81d0-9866b482fb89"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("80e68f4b-6e1e-4c62-ac36-2a9097129733"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("832d17fa-cade-41b5-aa5f-afa4e4023090"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("83301124-2a3f-4e4b-91e1-7b1178a57ada"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8351e83a-ef6a-4c5c-b504-11ac2ec46232"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("855d1caa-dacb-4373-80fa-f44c91df71aa"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("85956002-d826-4a14-a880-575bfeeb938f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("87290f46-08ed-4bb0-8339-1b4af16d663b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("88a1c601-a9ec-4b8b-8f96-144653235384"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("92d15790-91ed-4d8f-9190-ad4ad32abc95"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("93e08f32-8db8-407f-9b09-b16fcc10409f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("95582036-86cc-4846-982e-2f47edfcfa3b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9860c533-5b3e-4001-b86f-ce1dec15e343"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("98cfb74d-6044-4f70-b6b3-d2eeef29ae92"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("99959ee5-68c5-4175-8d69-cd4021bb9cae"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9a2bae98-463d-4be6-9b5f-658113b70ce4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9a421b60-33fd-4dc6-9f6a-3c3c9448baf9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a15e91cb-c96c-442c-9c20-03dedbbd4c62"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a239a89d-86e4-4c30-896c-316577e4532b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a3492069-4661-444e-a979-4d9ebedcc9aa"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a43276d4-52fd-4ce1-926e-3ba8643f8b95"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a53fc109-d6d4-4f04-a33e-9353f605318c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a6542146-831a-4fcd-ab88-5078cfe59de7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a8b1f508-4cfb-4eef-8816-6e068c7f0f4b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("aa5958f6-8fb3-4e0f-8172-90bbb60c8259"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ada39510-d6ce-49b9-9b7b-6b6c0cfbd989"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ae3dc4d2-0faf-41f7-b702-24076c2a2e26"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("afa2c4c0-dcbd-4188-beae-c92eca602f84"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b0ecdd20-9943-40d6-a6bc-c1dd07b4814e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b0eea16e-3d2d-46cd-9ccf-898c980736a8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b4920019-d81e-462c-b7c5-56855472612f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b5fc2f45-d44a-4a22-8dd4-931810ca9c60"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b769ffc0-75ee-4144-bbbc-095af29b6ce0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b85bf7ae-8771-4204-b286-d8423ba370fe"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b92b38f8-ba6e-43fc-bbca-206d46c606b8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("bacf5967-c2ab-4692-bba5-b9f42ce8e960"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("bc9a1e22-fc9b-4e7a-a27e-fbe74f51c756"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("bdc921ad-5383-43c8-9fe2-1fc8f8af7fa1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("bf5a8164-380a-4a8d-b89a-11764b259c64"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c001e689-12ae-4b83-a682-c274e7341bcb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c07bee53-9ce4-438f-a09e-258063dbb81b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c088a39a-bd46-4960-b29d-90ee26657286"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c0a81c8f-163e-4cd2-a430-fe95c0fad0cb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c2b89259-7f3a-4720-97c4-92c73c0e46c7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c5a1b9c3-3fa3-496a-aec4-972cd561683f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c5d0f5fa-eb28-4ce2-904b-dc065f16ba21"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c6c6bbda-27d3-4f42-af56-083cf89cd922"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ca76fa80-7513-424b-a0a9-965795eac057"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cdc9bee5-f6bf-47fa-92c4-6e3dba0fc555"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ce1847e0-f073-4e58-a1c6-dae233d240c2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cf2fd51d-5887-40ff-b60f-deedf7158b39"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d0634beb-1112-4f2c-b09c-8fbf3fca8073"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d1a88ab2-4fbc-4fea-9b53-8e2c58676bb0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d5c5a0e9-0cc7-436a-b627-31e8ae7aef27"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d7cc593a-1077-47df-9dc9-73ffbfc546b7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d8771dea-8570-4aca-9b12-b8638f4003b2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d8c48ab3-058d-4558-973b-39a9952e7ffb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d9074a28-d06b-40f2-b144-bd61553446da"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("da66e9d4-d2ac-45f2-8cae-c0b74e05b1db"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("db271b02-e088-4936-993c-0099c07779da"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("dc2d3a17-3187-4fc0-a169-a830b285347b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("dccab61e-4a1b-4468-b536-10e17b84d1f3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("dcd23c7a-2bfd-4496-9f9d-e2a2dce8a43c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("dd753820-bb14-4859-a83a-91a251430ff6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("df1594ec-d9f9-4656-bdff-ef10c53351fc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("dff1e590-79f6-4fec-bc88-a812c2548229"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e089dfb9-b8d0-44d7-aed6-c66868c4cf38"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e1dfd745-a9a2-4ac3-a3db-771cf10f5ed9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e347bdb9-ff8f-44e2-aefa-895c2f99f971"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e39879f9-ed70-4786-a9a0-3e1975db476f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("eb1725b8-a044-48f6-9cfb-d3a3b0618fb2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("eb34a885-7a88-4bed-955f-a19b425babed"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ec4b8f28-fb72-4f17-bb21-708b1f3c0ca0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ed75771b-7aa7-4225-bb5d-bec7d526a814"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("edcdaa56-387a-48a0-8ce9-324330bdc846"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ef27d606-63a1-4c1c-8af8-baa946656edb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f07cd31c-753b-46fe-a59a-7554ce729e1a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f21d4876-260c-4f4b-aba0-69b24c692476"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f56be6d8-c8e3-45fd-818e-57afe31f1bbb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f59a7824-fc32-403f-8e91-543f7f095f00"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f67b6c76-76ef-4298-9f72-becbe618ff8c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f79c39d9-f1f0-4f91-8c0d-f603b2424740"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f87bede5-cb9b-4311-b4ae-d0f51146a8ca"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fb4cabe0-ca81-49e5-9df8-ef485a8bd426"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fdb32f8e-91c4-48e9-915c-b07af161de97"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fde3878d-2cc9-4e04-8c86-a85c5dc50bd2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fe678a41-8497-4bec-8041-d81d633aff38"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fee6d657-8fed-44a9-a94a-98bfd8656e40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("01d7529c-f8ce-44ff-8a9b-86684893bcc8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0d10b1a7-4afa-4664-b45a-498b639c1de1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0d4883a4-0042-469a-8528-d9ea25b4821b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("102210b2-be90-4d80-8f18-2d0c7df358c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("121d742b-8d30-414b-9ec4-3cf6edefd552"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("200f995b-98e6-4183-9dfc-78dd01e29bf9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2177a53c-5c26-4286-ad4e-5d85d20013b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27f8b2be-dc0a-49bf-b9c9-cf7c3cc2e55b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2e9b544f-c9f9-45b8-8dea-8375d4752cfd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("329ece97-ac04-4914-af39-1f3954ae2241"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("364de7ea-2bf7-4278-81de-cd177a252a92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("39e11df2-dba2-4922-97cb-1f446a705743"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3e1f3fa7-ae7d-4cd7-8d65-25250f6e7da0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("415b05e5-e93e-4c73-9f74-175325de5677"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("422186fd-e49e-47c1-b3e2-41bfebcecbcf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4693bbfd-debd-4529-b4cb-47601e3c5973"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4cc3c631-6c48-4033-b354-6ada44df601a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4d17ba5b-7b5b-4078-873e-f510d9b90208"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4da1e92a-2a57-4e19-8c57-0a850b2be088"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5063bce1-ef3b-45d3-8a57-c88a9500ce0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5a932fee-1f53-4ea6-a5ac-cefea3649770"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("65f5da3b-714a-4dd2-b038-43407a3f4e2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("72545b79-3427-452c-b719-7f24199590f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("78039435-b8f2-445f-ac9d-4f1360440ad8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7c67c079-8965-4a74-9c48-4b32faaec6f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8059adb8-03ed-4f20-8959-e565658eeead"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8cf05902-10dd-4743-a55f-4b37a1a5c239"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("919601c6-7d6d-44d9-b5be-64ea416288c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("95a7b346-b58c-422a-be32-a28c64959b7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("97a4722e-b393-433e-aab3-4783a08b157f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("989da071-98e3-4778-8d54-6ed156f6ea56"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a2178599-404d-44f0-8514-2120af0c9235"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a5c870d2-ac37-4ebc-87c2-691198233de2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a6e19fe2-b594-4480-87a4-e0814353379f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("abb082b3-7481-47c4-86cb-d7b05ed999b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b0f8dca5-6dc7-403d-89f3-3ee1b5a92ac1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b7e6871a-442c-4847-991f-bc98e8b36a05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bab3f59d-9525-4dce-82ab-075813abb1e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bad1e7cf-1e25-47f9-b2cd-28392cd74e44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("be515a3a-3243-4a25-9b47-eb6ac5907ffc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c15c6f42-d9c3-4047-9b7e-28570d343fb7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c54e6ba9-0a80-4dcf-a3a0-238e45314556"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cd3c62c8-f025-4f12-9180-7f4a70a19cf2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d0587c09-83f0-406f-a6df-7b68701e6810"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d1eeb939-310e-4569-a593-c22f1eb4c111"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d6b0f9f8-f9c4-42c5-8389-d70ae4c0a423"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d8072d7d-e071-4c83-b8a7-e32ef32fc1cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dbd9c622-49ab-48ca-8f66-0f58a32fb17c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e534fa05-7958-4374-8120-8c5b21229067"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e6594d6d-de15-4c93-a1d8-53be56cdcadd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f6e0b805-45b5-47b1-83c2-eb0958c30080"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f910b7fc-6138-469d-8865-290d5c92cd6c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("01f75749-52f5-4e9a-8100-df63a5e51288"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("06fa4c3a-75ed-4a83-a4ac-ac8fd63422ca"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("08048909-88ad-4674-afb3-aef669e594a9"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("127855c6-a5ae-4dce-a5d9-54f29e3a659b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("18cf28ea-d68c-4d66-815c-e48df43283c8"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1ce75586-2018-4733-8a0a-3efb844825fe"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1e0e61a2-b7a9-45a7-b534-35a60def93c0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1f3f4d63-871e-4bda-a4ac-4e93167aeb88"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3024c57f-a401-42f9-983e-29d576bebb7d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4721ae1b-42b1-419e-bd50-58d2478e129a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("49708029-abf6-4894-a1ff-62e78b6aef9b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4ad2a743-ec88-47a4-b2cd-dd77925162ba"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("52be392a-0e90-4ee6-bdf5-19bd71b0b99f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("5ed462d9-dc38-434b-a47b-082ea6cfc142"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("61eec3ce-c991-43f7-b8fb-18ecbd3e6c57"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("6d600aa7-6fef-4c27-aa48-e0cab3eb9062"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("709b03da-fcbd-46d8-b2a1-c74ba00e806d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("70d03fb5-7366-4900-9a37-dc8a6ab45ef0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("72bb3e9d-a5a5-4a9b-8993-3c5af06c966d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("77329b06-3e4d-4134-a6b9-7bad94c363da"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("77a77b0d-6e61-466e-999e-b527a467e012"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7bb1416d-6d6d-4ea7-9c6a-03d3ea812911"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7bd7cd7e-34dd-4e4e-a7f0-97c57d08911c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("81946acd-4fb0-4659-9f2d-e7dc59bc2ec5"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("83271bb8-6dce-4750-bd41-0dccbe12902c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("85079940-b9ca-4968-8a72-e82f6b821082"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("86613e11-40ae-47ab-9046-908804451bfc"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("8d21d07b-3206-4af9-853f-4b71b5119ec0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("8ed39936-36f0-4d32-ac38-85cdd2cc3dec"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("9206a601-fa76-4c7d-8829-218d3df1ced0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("9dfa53ec-07fb-4cde-90b9-feb052264886"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a464dc8d-e106-4c5c-b7d5-8f06a6d1ad2a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a62acfbb-78ac-4f8b-a15e-a48187289a5a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a82831f8-1f02-4c6f-90a7-372b7e020ad7"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("ae0c6ee8-12f5-4dd5-af0f-211da487f839"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b009d909-a7c4-436f-84fd-c634d36bbf79"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b10b8c75-bf53-4e8c-ad94-3785a9665dba"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b2b80c44-2c3f-49a0-aaa3-e73300e7ce6f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b3c1b1b5-d2b2-4344-9a2e-3856e9c3b521"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b91e4864-de28-48a7-85dc-014fee58d527"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("bc0cbca8-8c64-4153-bb0d-eaa0e23c35fb"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("c2000e73-1c53-466c-9010-e09c6454d2a0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("c9d85aec-afc4-4242-84ba-5e2e7a099f1d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("cd2dec55-0940-4b3c-8e5e-4cc794a8c1bc"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("de8a0fea-a91d-43c8-b96b-bead30f30dfd"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("eb480503-5f59-4336-b785-1d79a9f65593"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("ec5aef00-ce9d-4414-a2c9-f0f6c77baa6b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("ee64dcf5-09d2-4a5b-b200-584010dec67e"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f03ff422-6b2d-4797-a746-16e2caad209b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f96d51a1-087d-4ce8-9d57-d286c6b559fb"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("0079536e-544e-40ff-8a80-22eb7a6cca68"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("0276be0f-814f-47a7-92b7-351367d90c29"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("3af2e467-759c-4ece-953e-0551a0afd5f1"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("55024425-bfc7-4a67-8e92-515f67af9d16"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("621c43c6-9bf2-4a08-81c6-ce6c1cf4b353"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("8065cb9f-997f-4840-b55c-2d437fd040e2"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("84c0766c-86ee-4555-a20b-6658ad05b217"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("9fe9f3e4-fb46-4c88-a695-312bb5ad2d3e"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("c9e9c103-5aaf-42e2-bc00-158c52ce5b29"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("cbeb045d-18cc-40b4-b496-19cde5a2e28d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("db0424d2-137c-4e05-bbbf-3dfed30969fb"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("e24df6e0-57a7-4603-8fd2-a52dc234d45c"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("fc368fc4-69e9-4418-b0d8-3f9e5f2ed43b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0b6d33e1-15bb-48df-984d-0b5b1aae4d01"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0c1c2a6a-0143-41b4-82a7-4deb6921c9c9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3fd3f9a1-591e-493a-ace9-d2c3d67d9e68"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("692574d5-9127-4e89-9531-12016e5bfbfa"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("773b01cb-8803-42fe-8b9d-d8474f23110c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7c7df6d3-aabf-41e6-8878-649275d81412"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a655eb65-9c52-4412-96e7-8e6ccb7fbbb8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b73e65f9-0482-4cba-8731-b8ab70d1edef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5e3d36b9-cdbd-4998-86cd-b00677e0b145"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6772eb82-c522-4d95-8982-f8dfa68acbd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6e1b0ea0-f38c-4346-9ed0-707a3eac23e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87b2e49d-fddf-4270-af8a-fb8b86306592"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9af4dc6b-334b-4b2f-98da-7e30c8ca4531"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d13f3252-7bc4-47f9-8a2f-22516b90231d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ed13d2e9-0743-49e5-878a-daeb2b71fb64"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("edd6ec45-51a1-419f-8ab7-76f4b0797ed3"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("073bdd3b-ead6-436b-b61c-bf07b0941fa0"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("3d329f8f-8c52-4cd1-848f-f9ba06c6c05a"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("3d4d4fbf-13d2-49d0-a716-f12a368e7697"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("415cc263-1269-42c4-8797-7a7efea1b6f4"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("c05aba51-74a8-4009-9522-180c6e706f5b"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("ccfbc074-5d6b-447d-879e-931424597046"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("cd0185bc-d479-4693-b07e-adcb1e3d8589"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Sales",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CreaditCardNumber", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("006786d4-217f-4258-93f6-b9e9ebd3d17c"), "6709723185496914", "CamilaWhite_MacGyver@gmail.com", "Camila White" },
                    { new Guid("021dc818-a6d2-4518-95e5-bbd382d96211"), "6388-4417-9977-9231", "BruceLubowitz_Frami67@yahoo.com", "Bruce Lubowitz" },
                    { new Guid("030e3bf3-683f-4b13-b8bf-ba305deae3ff"), "5409-1828-0843-7745", "JaysonWalker_Thompson@yahoo.com", "Jayson Walker" },
                    { new Guid("04fcf81a-cbe9-4dfa-9e49-108766d8071e"), "6771-8995-4798-8153", "MilesSchroeder97@hotmail.com", "Miles Schroeder" },
                    { new Guid("0875f759-2665-4d9c-98bb-c0011f507a86"), "5406-3286-0790-0945", "MaybellTorp.Hackett37@gmail.com", "Maybell Torp" },
                    { new Guid("098f228a-8d94-431d-9042-e99b3ddf8384"), "6759-2044-8316-7761", "DelmerWyman_Collins25@gmail.com", "Delmer Wyman" },
                    { new Guid("09a313d2-6e7c-43be-b060-217fee266b43"), "3619-914656-2721", "AhmedKling_Christiansen@gmail.com", "Ahmed Kling" },
                    { new Guid("09a64576-0195-40e8-977a-a6e2401ef0fb"), "5265-6238-9259-5206", "AugustaShanahan_Schuppe15@yahoo.com", "Augusta Shanahan" },
                    { new Guid("0b7f0bab-f700-47b1-b683-10ead29a43fd"), "6383-6577-6595-9201", "ConcepcionMann_Hamill@gmail.com", "Concepcion Mann" },
                    { new Guid("0b84ab1d-6620-46b1-a198-78d97644fae5"), "6394-1622-2408-9812", "RomanKreiger.Oberbrunner16@yahoo.com", "Roman Kreiger" },
                    { new Guid("0c62160e-d50a-4de1-87c4-cf313199a8bd"), "6767-1695-6447-6102", "LeonoraJones28@gmail.com", "Leonora Jones" },
                    { new Guid("0f780098-b109-4df0-b7f7-ea17195af81e"), "3749-172631-31222", "EloiseHills.Nienow9@hotmail.com", "Eloise Hills" },
                    { new Guid("0f801127-626e-4698-98bc-8ed59192d70b"), "6759-6968-6486-3588-35", "DaxProhaska.Abshire14@yahoo.com", "Dax Prohaska" },
                    { new Guid("0fea0245-db98-4e23-864e-b13f018d948b"), "6378-6488-1470-0974", "MarianUllrich.Kling@hotmail.com", "Marian Ullrich" },
                    { new Guid("1053af7b-c0b7-407e-b542-8ac0bf234291"), "3753-522781-61064", "GodfreyRatke_Boyer@hotmail.com", "Godfrey Ratke" },
                    { new Guid("12ab0a02-f8e2-4179-9b78-30e8f2042c69"), "6771271940557524", "JayneDuBuque_Jenkins@gmail.com", "Jayne DuBuque" },
                    { new Guid("12e3c0f2-01c4-4695-8a85-ee3e10901a12"), "6771-8938-4229-7386", "MohammadPurdy.Hansen@gmail.com", "Mohammad Purdy" },
                    { new Guid("135878b1-1967-4a37-a214-45b0a0efff67"), "6763-3042-6874-4257", "InesDietrich_Bergstrom@hotmail.com", "Ines Dietrich" },
                    { new Guid("13789c2c-0956-477f-b45e-c9b70170c66d"), "3529-8369-3380-1915", "MabellePouros.Hodkiewicz@gmail.com", "Mabelle Pouros" },
                    { new Guid("15b995b9-5376-4138-afe4-3ffd833f264d"), "3695-227005-6930", "StephaniaFritsch20@hotmail.com", "Stephania Fritsch" },
                    { new Guid("18528092-fcff-4e46-9e46-37ce291df69a"), "3662-955549-2937", "TyriqueKoss.Beatty27@gmail.com", "Tyrique Koss" },
                    { new Guid("1877fde2-7783-4766-be4e-0fc08bbc3672"), "4472497868759", "FrancesVandervort.Mayert@yahoo.com", "Frances Vandervort" },
                    { new Guid("1a0cc868-3423-45dd-bab4-04857c636987"), "6440-4943-8890-7339", "PaxtonSanford.OReilly@hotmail.com", "Paxton Sanford" },
                    { new Guid("1a3ecb93-309b-46bf-a748-6a8d4b27c2ce"), "6709287222030540", "ElmerGoodwin_Balistreri@hotmail.com", "Elmer Goodwin" },
                    { new Guid("1acb7936-d959-44ab-9f4b-f81bc9fc9795"), "5038-0796-6882-0706", "LandenLangworth.Reinger23@yahoo.com", "Landen Langworth" },
                    { new Guid("1ad3bc8b-2213-479f-b22a-c600820c01b6"), "3435-971643-01823", "NaomiLockman.Will15@yahoo.com", "Naomi Lockman" },
                    { new Guid("1c025304-6b92-436b-a4d0-5274079c9dfb"), "6759-2817-8269-4054-96", "LizaWeimann56@gmail.com", "Liza Weimann" },
                    { new Guid("1cbaa9ef-a66d-4587-8692-2063a42c374d"), "6453-6227-2873-8586-7235", "LysanneWiza_McDermott@yahoo.com", "Lysanne Wiza" },
                    { new Guid("1d42e95d-483c-4a30-8ba9-8db23ee4e565"), "6767-1428-7601-6684", "KathrynDonnelly_Sipes@gmail.com", "Kathryn Donnelly" },
                    { new Guid("1e546a0e-10a6-4b91-bd81-67f56914a3e3"), "6462-8659-6121-4065", "CaterinaGleason59@hotmail.com", "Caterina Gleason" },
                    { new Guid("1ef15277-58b7-4b3c-8b25-4a8b4aad15a8"), "676178256965081046", "DarianaCruickshank_Gusikowski70@hotmail.com", "Dariana Cruickshank" },
                    { new Guid("1fd5c6b6-dd9a-431d-86c3-e3c52d70ec55"), "4052123504133", "ClaySchroeder.Cartwright64@hotmail.com", "Clay Schroeder" },
                    { new Guid("23673e1d-86aa-4a84-af87-86b4d7dd7265"), "6375-5909-9128-7487", "RalphGrimes19@yahoo.com", "Ralph Grimes" },
                    { new Guid("2412da04-a25b-4946-b887-621fddc63a0a"), "5211-0730-0224-2064", "JaneBednar.Wehner35@hotmail.com", "Jane Bednar" },
                    { new Guid("276ee370-c710-44a0-ae48-7c51a73604d2"), "3529-4215-2872-7955", "RosannaHarber_Bednar58@hotmail.com", "Rosanna Harber" },
                    { new Guid("2778c905-31f9-4f98-a92a-deeff26bc136"), "6763-4250-7891-7807", "StantonPaucek61@yahoo.com", "Stanton Paucek" },
                    { new Guid("281d19a7-3c3f-4e5f-b074-53088a39ab07"), "6767-6558-2711-1892-859", "AliviaSteuber.Brekke42@yahoo.com", "Alivia Steuber" },
                    { new Guid("29dab737-9602-414e-9f70-4c7662800379"), "6011-6254-7240-0323-6097", "SelinaBogisich.Schamberger@hotmail.com", "Selina Bogisich" },
                    { new Guid("2a55fb17-fae1-4b5a-80ad-f3392b80c034"), "6767-5283-5862-4351", "PabloBalistreri_Bailey@gmail.com", "Pablo Balistreri" },
                    { new Guid("2a56b0b5-f8f6-4127-acab-0aa76d3448b3"), "3547-5620-7230-5256", "AlexandraHeller.Dickinson@hotmail.com", "Alexandra Heller" },
                    { new Guid("2a750fb3-47d5-4b5a-9623-8a379e58933d"), "677164202444464167", "KayleighOsinski.Gaylord80@hotmail.com", "Kayleigh Osinski" },
                    { new Guid("2b2f7052-d9e8-4c96-b715-baedfbc61d49"), "5038-5328-2722-3642", "CydneyCronin.Swift@yahoo.com", "Cydney Cronin" },
                    { new Guid("2b71c016-edb3-4a19-b64d-3d19c3e9d0a5"), "3694-860282-4367", "JeffSmitham_Leannon48@yahoo.com", "Jeff Smitham" },
                    { new Guid("2b8517ad-269b-47e4-a452-eddd116082aa"), "5453-4044-6302-4872", "ManuelaBrakus.Kilback@yahoo.com", "Manuela Brakus" },
                    { new Guid("2c13c8cc-4b52-47f6-a2bb-5e0aaf973d02"), "6759-8338-3557-3750-03", "LewBlick.Langworth@yahoo.com", "Lew Blick" },
                    { new Guid("2cdd0803-a6dc-4127-beb4-a29d394a3e26"), "6374-2793-5205-0772", "BiankaHickle.Wintheiser88@gmail.com", "Bianka Hickle" },
                    { new Guid("34670200-8228-4db7-820f-a06671c0f310"), "6759-9528-3944-8119-945", "BerylMarquardt.Carter56@gmail.com", "Beryl Marquardt" },
                    { new Guid("37c1728b-ec33-43fd-aaa8-eb40757f12f4"), "4333306904088", "DemarcusBernier_Terry15@gmail.com", "Demarcus Bernier" },
                    { new Guid("3943acd1-b8ae-4fb2-8ea4-0b31346f2693"), "3610-340953-4823", "DamienThompson.Grady18@yahoo.com", "Damien Thompson" },
                    { new Guid("39444374-fee2-4e70-96a3-be3c2ba51d94"), "3407-496611-06550", "SigmundRowe_Heathcote73@yahoo.com", "Sigmund Rowe" },
                    { new Guid("3a33da0f-fa81-43cf-b729-239e571943f5"), "6771-8961-0400-9142", "SamirCorkery81@hotmail.com", "Samir Corkery" },
                    { new Guid("3a565125-4ad5-4f20-ae1b-509f4ef6f96b"), "5408-4576-2240-5198", "RobynSteuber74@yahoo.com", "Robyn Steuber" },
                    { new Guid("3bb3a5b4-e038-4169-aad5-a259b54a3eb7"), "3465-512623-68611", "JarrellKulas54@gmail.com", "Jarrell Kulas" },
                    { new Guid("3bee795b-82e4-4dda-aa95-1f58f062cfab"), "3528-8605-7928-0870", "DonnaFeeney_Turner89@gmail.com", "Donna Feeney" },
                    { new Guid("3ff8457c-be43-489d-9c03-457897ba95f5"), "6011-6207-6586-4722-3475", "ElizabethThiel.Corkery70@yahoo.com", "Elizabeth Thiel" },
                    { new Guid("412f64c7-f5d5-446e-b985-c70b9add6044"), "6759-5554-0428-3767", "DouglasBartoletti_Jenkins@yahoo.com", "Douglas Bartoletti" },
                    { new Guid("42901f69-5ad9-45ea-a6e9-4846ad9f6323"), "6486-6253-7589-8137-1515", "JessycaErdman_Dibbert70@gmail.com", "Jessyca Erdman" },
                    { new Guid("4431237c-04c5-4100-b14e-88a240fe8228"), "6304603366252048281", "BrandiMayert_Erdman@hotmail.com", "Brandi Mayert" },
                    { new Guid("443eedee-6f10-4227-a2ef-aaf9339bff63"), "6767-0147-4891-8619-020", "GarettBins_Streich37@gmail.com", "Garett Bins" },
                    { new Guid("4554088c-0125-4e75-843e-25c546a77644"), "4797259844212", "AlessiaQuigley.Howell@yahoo.com", "Alessia Quigley" },
                    { new Guid("465fd87b-535e-4480-8a04-fbc980eb1c2b"), "6767-2103-0150-0935", "ForrestKoepp.Skiles63@hotmail.com", "Forrest Koepp" },
                    { new Guid("46820d6f-ec48-44db-b6ec-fbff9a5a37e7"), "3787-684484-75455", "LouveniaAuer55@hotmail.com", "Louvenia Auer" },
                    { new Guid("47454c02-935e-4119-84e8-563d132c6eba"), "6011-4699-1306-1587", "JackyFadel_Wehner45@gmail.com", "Jacky Fadel" },
                    { new Guid("4a97aec3-a7f3-413f-a97e-5e67f5684030"), "6011-6275-0481-1072-0289", "TreHarvey_Pagac47@gmail.com", "Tre Harvey" },
                    { new Guid("4af24a6d-6eaa-4cf1-a8c4-6f8bd3ec6b86"), "677102344432286940", "YvonneBraun_Welch@yahoo.com", "Yvonne Braun" },
                    { new Guid("4c2d2201-2996-4863-b5c3-599bad60b0cb"), "4514-3838-2577-4640", "SvenKirlin_Grimes@hotmail.com", "Sven Kirlin" },
                    { new Guid("4ca5cd77-6195-4190-9467-b86336d19be6"), "6759-9368-8437-1282", "AnsleyTorphy.Marquardt1@yahoo.com", "Ansley Torphy" },
                    { new Guid("4cdf313f-3d1f-4c8a-9150-b5131f0942e7"), "4232-4212-9489-7194", "TrystanBashirian_Bashirian@gmail.com", "Trystan Bashirian" },
                    { new Guid("4d2bb590-62e7-406e-9830-fbc9ea9c719b"), "6767-2336-8015-0576-50", "JevonBalistreri92@hotmail.com", "Jevon Balistreri" },
                    { new Guid("4d52189d-afbf-408b-9cef-a1f0ef884e6b"), "3435-604041-18928", "ShawnSchmitt_Bailey11@gmail.com", "Shawn Schmitt" },
                    { new Guid("4d825081-7845-4325-8c14-8102523644ca"), "6771-8932-5660-6965", "MaxFrami_Romaguera44@gmail.com", "Max Frami" },
                    { new Guid("4e7ce02a-2cca-4cd5-ba19-e57dbaad2956"), "5018595665895167433", "TristinBashirian.Walter@gmail.com", "Tristin Bashirian" },
                    { new Guid("523da4b8-f4e4-4487-9e1f-e7f487bd3ade"), "3458-200371-84707", "LelandJenkins.OReilly96@yahoo.com", "Leland Jenkins" },
                    { new Guid("5330dd35-73a8-468f-851e-71a8613983cd"), "5450-5219-5188-9509", "HaroldCorkery_Kuhic@yahoo.com", "Harold Corkery" },
                    { new Guid("54f35cce-a70d-4b4e-951a-117c9543f2e9"), "3784-740213-48371", "RosamondMcGlynn_Green36@hotmail.com", "Rosamond McGlynn" },
                    { new Guid("5635c1f4-fd3a-44fc-8201-e6927c112c4d"), "6304710873264315", "LuisLarson_Herzog@gmail.com", "Luis Larson" },
                    { new Guid("58ae6dec-bbfc-424f-92d0-42ed14d9e477"), "6767-8711-1709-9176-634", "RudyLegros.Lueilwitz34@hotmail.com", "Rudy Legros" },
                    { new Guid("5904ef22-2ec3-4806-b786-9c2e3204b54e"), "3529-7357-0393-9428", "BradKlocko.Lynch@gmail.com", "Brad Klocko" },
                    { new Guid("597fa502-1193-4e9a-b399-5032a28c0b87"), "6767-0533-8409-0998", "BryanaGoodwin.Abernathy@hotmail.com", "Bryana Goodwin" },
                    { new Guid("59ce3ce4-c694-4c1d-b513-3a74c4201fd7"), "670688963564502993", "KurtisZulauf23@hotmail.com", "Kurtis Zulauf" },
                    { new Guid("5c3d25e4-1043-4435-86f4-133286413316"), "3528-9583-5128-7186", "AdellOConner_Douglas68@hotmail.com", "Adell O'Conner" },
                    { new Guid("6106e1e3-15a1-44ed-8845-4283f177eb3a"), "3547-8547-0820-6200", "QuinnSchimmel25@yahoo.com", "Quinn Schimmel" },
                    { new Guid("6142dbdd-1099-4a03-a3c1-f440092da3ee"), "6011-7613-3657-0321", "WeldonHowe41@gmail.com", "Weldon Howe" },
                    { new Guid("6156205d-c7a7-483c-bd07-0f1a1a750727"), "5290-1176-3993-8265", "TorreySauer20@yahoo.com", "Torrey Sauer" },
                    { new Guid("61b70fb0-3de4-49ca-a9c0-969db53fa434"), "4388-6872-6953-1370", "LiamMiller.Cole60@yahoo.com", "Liam Miller" },
                    { new Guid("629541b2-7170-4622-885c-02422921f427"), "3448-435803-02238", "ElvisSchmeler.Tromp82@yahoo.com", "Elvis Schmeler" },
                    { new Guid("62dcc88b-5236-4cc5-807b-1dd5905e25bb"), "3018-570394-3541", "WillardGulgowski.Rempel75@yahoo.com", "Willard Gulgowski" },
                    { new Guid("63d8f46d-087f-446b-a5fe-08cebd3727f0"), "3606-321855-4042", "MarcellaSenger_Goyette@hotmail.com", "Marcella Senger" },
                    { new Guid("643d1179-5fc6-4f80-a521-f4ede0be5a66"), "3667-441979-5828", "GenesisLarkin_Crona@hotmail.com", "Genesis Larkin" },
                    { new Guid("644893e0-eb56-4311-991f-b18119e3cc64"), "6390-0538-3150-0347", "VivianneOrtiz35@yahoo.com", "Vivianne Ortiz" },
                    { new Guid("661f4f63-e8be-4442-8e7b-1aaeac761821"), "4525270692355", "ShaunBrown_Botsford@hotmail.com", "Shaun Brown" },
                    { new Guid("66636546-ef61-4193-ad1d-ffd7ee0adc71"), "6771834900248192", "DavinLebsack.Frami@yahoo.com", "Davin Lebsack" },
                    { new Guid("6681515a-f779-438f-8c1d-a442d8368680"), "6011-7204-0726-2366", "JessikaEmmerich_Trantow@yahoo.com", "Jessika Emmerich" },
                    { new Guid("6762cfd9-f933-47bb-80d6-5fd0a9d86d03"), "4663530679100", "GinoStrosin34@gmail.com", "Gino Strosin" },
                    { new Guid("688d8e05-b64b-414b-9d47-4b7213a97ab0"), "6771798066395856898", "MaxineJast87@yahoo.com", "Maxine Jast" },
                    { new Guid("69b2b826-636f-419b-9be6-26d3b7b0071c"), "3582-3719-8359-6870", "HarryGrimes.OConner@yahoo.com", "Harry Grimes" },
                    { new Guid("6ada95ed-ea33-4816-bd59-6555e4a1cb3c"), "3528-9705-1464-1605", "AlfredoWolf16@hotmail.com", "Alfredo Wolf" },
                    { new Guid("6e26d664-7a33-4824-a67c-e703eab2a4c5"), "6392-2686-7044-0896", "ElbertConroy90@yahoo.com", "Elbert Conroy" },
                    { new Guid("6f671fdb-8f72-4255-98c7-ea0d18db9d62"), "5441-1195-4756-4082", "ClementineLangosh_Yundt83@yahoo.com", "Clementine Langosh" },
                    { new Guid("709fdb99-97a2-4750-9bf1-84a2b44636dd"), "3658-516839-0894", "CarolynBednar84@hotmail.com", "Carolyn Bednar" },
                    { new Guid("753cbe1c-8f7f-449c-be6b-e1fa31a7840f"), "3528-3649-5268-8890", "ClarabelleSchimmel76@hotmail.com", "Clarabelle Schimmel" },
                    { new Guid("7891a965-853c-47a4-b255-01e57a16550a"), "6759-5421-1733-4459", "ErwinLittel59@gmail.com", "Erwin Littel" },
                    { new Guid("790b06d7-e943-42b3-b3e0-82f6d713407d"), "3564-9944-8150-4021", "ConnerCummings90@hotmail.com", "Conner Cummings" },
                    { new Guid("79900278-e13b-4a73-b5f4-c38582e6dbeb"), "6463-6264-8068-5342-1951", "DanaEffertz_Blick47@gmail.com", "Dana Effertz" },
                    { new Guid("7a21749f-d463-47d6-bc97-45fe259bdbcb"), "6767-8632-5040-3233-45", "DorotheaAnderson_Wiegand44@gmail.com", "Dorothea Anderson" },
                    { new Guid("7aa99a9e-ac84-4648-b1dc-6a32bc92bf3c"), "5430-0644-8944-3379", "ShaniaSpencer36@yahoo.com", "Shania Spencer" },
                    { new Guid("7d87e010-32c4-4760-a8d9-dc3b79d64ddc"), "3482-608086-06850", "ClementineOrtiz_Kessler76@gmail.com", "Clementine Ortiz" },
                    { new Guid("8118415e-4215-45c2-b34a-caf7f2fb98c2"), "4942098201915", "ClemensCollins.Bins56@hotmail.com", "Clemens Collins" },
                    { new Guid("829f41be-7a68-4b9c-b578-c833c12efff7"), "677179776132805636", "KaileePrice56@hotmail.com", "Kailee Price" },
                    { new Guid("82b2952a-5ce2-4d7b-b9ea-a6006360e251"), "5244-2214-2486-5548", "KaleyCronin3@yahoo.com", "Kaley Cronin" },
                    { new Guid("85b78a08-8f57-4c5d-9668-48062c2ce551"), "6771-8987-1490-3193", "KayleeRogahn9@yahoo.com", "Kaylee Rogahn" },
                    { new Guid("87a584eb-40a9-4b53-aabd-9e37b9b76d9c"), "3528-1762-4493-3722", "ZionAnderson.Keebler@hotmail.com", "Zion Anderson" },
                    { new Guid("87d8a978-07ab-4381-9964-b014d002447d"), "5345-2005-0206-7332", "EdgarJenkins_Hartmann17@hotmail.com", "Edgar Jenkins" },
                    { new Guid("88373a83-5b33-44c2-afdd-6c5bfbbe55a1"), "6771-8930-4213-3316", "AlbertBruen47@hotmail.com", "Albert Bruen" },
                    { new Guid("89b06742-0e54-4e83-b5df-20b17b9ab606"), "3528-9128-7195-7539", "LuigiKshlerin43@hotmail.com", "Luigi Kshlerin" },
                    { new Guid("92e58fa4-d186-4e2d-af8f-6b0db280bd83"), "5407-1297-0580-3737", "IanKessler_Farrell@hotmail.com", "Ian Kessler" },
                    { new Guid("94eb1d9a-ab0e-4886-bb31-adb3820ece4f"), "4135-2061-5472-2634", "JefferyKovacek93@gmail.com", "Jeffery Kovacek" },
                    { new Guid("94f7a4a8-2239-4f51-ad31-5bcf1cc7e44f"), "3039-592421-8405", "YasmineGleason.Effertz@hotmail.com", "Yasmine Gleason" },
                    { new Guid("950efac8-a344-437d-b93a-054700b8c185"), "6455-6202-3933-8855-7026", "SallieSanford.Watsica32@hotmail.com", "Sallie Sanford" },
                    { new Guid("95d3aff7-f4f0-4cf6-9155-ea00ed4f1e63"), "5221-8543-2520-3265", "LindseyConnelly.Rippin23@yahoo.com", "Lindsey Connelly" },
                    { new Guid("96b7359c-7834-4d25-abab-40a59c3a9d77"), "6706872643348911", "DerekRunte_DAmore@gmail.com", "Derek Runte" },
                    { new Guid("973c0185-332f-460b-b9d6-7d76d5f78b50"), "6759-2169-6569-2704-660", "LisetteBarton30@gmail.com", "Lisette Barton" },
                    { new Guid("98ab048a-a085-4239-a368-01897a894f1c"), "3408-499719-74620", "OfeliaSatterfield_Gislason34@yahoo.com", "Ofelia Satterfield" },
                    { new Guid("996fa36b-652c-48d4-8a63-5560f2552914"), "6399-2560-3648-3398", "MauricioFrami89@hotmail.com", "Mauricio Frami" },
                    { new Guid("9abcfbec-344e-41cb-877c-0c1192ae5a41"), "3496-771249-62866", "JaimeFeest_Romaguera29@yahoo.com", "Jaime Feest" },
                    { new Guid("9cc0345e-9a5a-47d9-b3ec-53094699ce45"), "6767-0857-2311-4709", "DollyFlatley.Bechtelar@yahoo.com", "Dolly Flatley" },
                    { new Guid("9e215e5a-8d98-41d0-aec9-f817abded334"), "5406-9154-5484-6104", "JoshuaKub_Barton@gmail.com", "Joshua Kub" },
                    { new Guid("a10a65d6-279b-4953-97ff-1d27d4d36f89"), "6759-6516-5293-3495-934", "RoscoeCrooks.Hane97@gmail.com", "Roscoe Crooks" },
                    { new Guid("a12c53b6-7b1a-4689-98b1-4cb8ed43bbc9"), "4313-3460-0864-6110", "MaymieMurphy_Marquardt62@gmail.com", "Maymie Murphy" },
                    { new Guid("a5179855-a263-437f-9f58-7f205a30a203"), "5300-7236-4951-1253", "CoyCummerata0@gmail.com", "Coy Cummerata" },
                    { new Guid("a7fd2678-4da8-4fec-9883-8ab6b377b502"), "5271-9509-4398-6148", "LandenStroman_Pfeffer63@hotmail.com", "Landen Stroman" },
                    { new Guid("ab5e5d7b-fc7d-48b2-9a23-e7ec2e6ac96a"), "6761-4171-3201-3097", "AuroreGrant.Walter86@yahoo.com", "Aurore Grant" },
                    { new Guid("ab7de419-e68f-4e81-98e2-bbd81400a57e"), "3719-772332-79918", "GrahamKreiger_Metz@gmail.com", "Graham Kreiger" },
                    { new Guid("ae4e71ef-da16-4ef1-9eb5-611ad75c2400"), "5478-4080-5892-2011", "MarvinReichert64@hotmail.com", "Marvin Reichert" },
                    { new Guid("aeeda029-5216-47bd-a388-12a9e02c9561"), "4748-6460-1617-8948", "AsaCollins.Wuckert93@yahoo.com", "Asa Collins" },
                    { new Guid("b02b833f-fe38-4e5b-b0a0-42eeeb975032"), "6372-9096-0902-2578", "JoesphSchmidt.Heller@yahoo.com", "Joesph Schmidt" },
                    { new Guid("b1022aea-f036-4875-a259-9cee3f35b208"), "5190-6956-3051-3436", "SamaraTillman80@yahoo.com", "Samara Tillman" },
                    { new Guid("b182c552-8d1c-4205-acb1-25181a8bcf70"), "6759-1880-6187-7174", "RyleighHettinger15@yahoo.com", "Ryleigh Hettinger" },
                    { new Guid("b6bf4640-e6d1-405d-a6a0-892c733c6540"), "6767-3548-0339-0652-938", "BerneiceGreenholt14@hotmail.com", "Berneice Greenholt" },
                    { new Guid("b9ba1499-795d-4fe6-b70c-aae08c856525"), "6771-8994-6295-9973", "AlexaKessler.Hilpert26@gmail.com", "Alexa Kessler" },
                    { new Guid("b9c8d766-6411-43a7-b8cd-67e7d40eb2c2"), "6767-8802-6869-5603", "RoelPfeffer.Kreiger@yahoo.com", "Roel Pfeffer" },
                    { new Guid("baa86c67-c56a-4592-bf2b-6a9c7ab030ef"), "6759-6405-6132-1725-16", "LaceyKuhn_Cremin@yahoo.com", "Lacey Kuhn" },
                    { new Guid("badd5ca9-2396-49ed-a682-b8b8abc3143e"), "5496-3986-5757-7662", "DedricOHara.DAmore66@hotmail.com", "Dedric O'Hara" },
                    { new Guid("be09cfdd-d442-417b-a69d-cd69b59d03ae"), "3538-0557-4458-3260", "LaverneHerman.Frami@hotmail.com", "Laverne Herman" },
                    { new Guid("bf07c4b4-69d2-4bae-8b36-19f9017128db"), "6011-6202-5287-3970-4705", "HowardLarson_Bode33@gmail.com", "Howard Larson" },
                    { new Guid("c095aacf-7ebb-446c-81bc-71aa2f18baad"), "4054317863606", "StevePaucek5@yahoo.com", "Steve Paucek" },
                    { new Guid("c1659e4d-9d36-4d5c-a6a4-5c65d6626491"), "3457-920138-23568", "LindsayCruickshank_Lang27@yahoo.com", "Lindsay Cruickshank" },
                    { new Guid("c17992ca-495e-4371-a94a-d76ef7860a84"), "4997099645288", "JohnnyDeckow.Swift@yahoo.com", "Johnny Deckow" },
                    { new Guid("c1e63639-c2bc-4b94-8214-21e3c5eddc67"), "6759-4374-9190-1077-31", "TrishaRath_Sawayn68@gmail.com", "Trisha Rath" },
                    { new Guid("c4aea3bf-7f52-45be-8924-7ecf11ef387f"), "3046-546752-8864", "LyricSchuppe41@yahoo.com", "Lyric Schuppe" },
                    { new Guid("c71bc46d-31a7-417c-947e-4ce82995a725"), "6759717151884328907", "IsmaelSkiles_Stark95@gmail.com", "Ismael Skiles" },
                    { new Guid("c82bbec4-7c0e-4c89-8728-c2f03e9a57f1"), "6759258124011445568", "KristinaLabadie91@hotmail.com", "Kristina Labadie" },
                    { new Guid("caeb21f4-11e2-43de-8f8c-eb81f328a878"), "3775-810668-19438", "MichaelLeffler.Balistreri@yahoo.com", "Michael Leffler" },
                    { new Guid("cb863443-d650-412f-bc11-c9e0effee152"), "6767-7674-0583-5530-78", "JaydenBalistreri_Terry57@yahoo.com", "Jayden Balistreri" },
                    { new Guid("cb94a2bf-14da-4c33-ba67-560178f02330"), "4169183264950", "HenrietteCremin_Ryan@hotmail.com", "Henriette Cremin" },
                    { new Guid("cbd18116-f500-404e-8a3a-b6316a331fca"), "5439-1630-2119-6965", "TyrellWatsica_Bahringer@gmail.com", "Tyrell Watsica" },
                    { new Guid("cbdd7c2f-fd95-4640-ac4b-603a71076086"), "6767-0029-9284-5658-25", "JaylenHeller83@gmail.com", "Jaylen Heller" },
                    { new Guid("cdf7a7fe-a9c3-428e-9445-ad3cb275b07c"), "6370-2643-9198-4680", "AlvisRunolfsdottir_Cummings@hotmail.com", "Alvis Runolfsdottir" },
                    { new Guid("cebfd7b8-ae72-45d6-8e5e-6f4d05c62baa"), "6763741785581888", "AnikaDach_Hodkiewicz7@hotmail.com", "Anika Dach" },
                    { new Guid("d51436c4-c20b-406e-bec8-2891577ddf2d"), "6759-4073-5544-6615", "DoraBecker_Abbott@yahoo.com", "Dora Becker" },
                    { new Guid("d55433a4-07ec-40c4-abd8-ab8451a904e0"), "6377-6547-3019-3196", "KoleParisian0@hotmail.com", "Kole Parisian" },
                    { new Guid("d58f365e-effd-4612-82ac-b94359b59b29"), "6500-0857-1899-9595", "DedrickBayer_Raynor99@gmail.com", "Dedrick Bayer" },
                    { new Guid("d5c6b683-85b0-488c-b8ec-796c27d4d9b4"), "6304586730508080", "RockyBlanda_Ondricka13@yahoo.com", "Rocky Blanda" },
                    { new Guid("d6c8e85f-7696-466e-9b17-fc9f4967cef9"), "6759-1343-4685-4462-521", "RosalindPollich_Koch48@gmail.com", "Rosalind Pollich" },
                    { new Guid("d7d1d2ba-b253-45e2-880f-a9b19ed605df"), "6389-0300-8078-6200", "CruzBauch_Torp76@yahoo.com", "Cruz Bauch" },
                    { new Guid("d8e3b9ff-538b-406a-9dc5-fe99b9f4eca6"), "5020-8724-7815-9756", "DeloresWiegand.Greenfelder61@hotmail.com", "Delores Wiegand" },
                    { new Guid("d94a2c35-2ada-451c-a76b-705b7694b7c0"), "3472-855770-97230", "TomasSchumm.Veum65@yahoo.com", "Tomas Schumm" },
                    { new Guid("d965373c-9585-4d6b-9533-35a4a634463e"), "6011-6239-4596-2715-7664", "JolieGislason_Collins@gmail.com", "Jolie Gislason" },
                    { new Guid("da608b9f-fcad-47a0-b2e5-38b84d5298e3"), "3528-2192-8119-5167", "RickieSchneider_Nikolaus@yahoo.com", "Rickie Schneider" },
                    { new Guid("dc02bef1-326a-49cc-aa7c-aaad231507d9"), "4316236421570", "LylaAbbott.Kautzer@hotmail.com", "Lyla Abbott" },
                    { new Guid("dc05fdd2-2a26-4c06-8ba0-22ad8982b3e7"), "6759-9809-4600-0927", "MariahKemmer_Koepp56@hotmail.com", "Mariah Kemmer" },
                    { new Guid("dd08507a-e2a6-4350-a00b-524ce6770329"), "3051-337973-8269", "AlejandrinBorer69@yahoo.com", "Alejandrin Borer" },
                    { new Guid("dd2a2e89-8d76-4df0-a909-e32d8d0a847d"), "3529-0920-3120-5423", "ThomasMacejkovic_Bauch@gmail.com", "Thomas Macejkovic" },
                    { new Guid("de3ca515-7a43-4f7f-9202-690144130809"), "3529-0140-0795-2622", "AlessandroSchumm_Fadel12@gmail.com", "Alessandro Schumm" },
                    { new Guid("deb71043-9552-4edf-8254-d3e97e8212c3"), "3529-2240-6629-1602", "ManuelHarvey94@hotmail.com", "Manuel Harvey" },
                    { new Guid("e12f1d1c-4d16-48dd-81a8-535d9fb5c0e1"), "5020-8871-6087-4470", "DarrelKlein.Abbott23@yahoo.com", "Darrel Klein" },
                    { new Guid("e35edf90-af35-462f-a192-4f259d7f9237"), "6771-8935-5532-6042", "VadaHeaney_Labadie45@hotmail.com", "Vada Heaney" },
                    { new Guid("e363dca5-f08d-4da6-88a1-5b5b5dc026e7"), "6759-2991-2998-4925-075", "AmelieKuvalis.Connelly16@gmail.com", "Amelie Kuvalis" },
                    { new Guid("e3aa155f-5978-4c71-a56e-316c2be6ea31"), "3636-894938-4332", "KurtBlanda6@gmail.com", "Kurt Blanda" },
                    { new Guid("e3b42f63-76d6-49b1-9a11-89632f84669d"), "6377-2609-9393-5982", "AshtonGleason13@hotmail.com", "Ashton Gleason" },
                    { new Guid("e421413f-495b-4c80-bab2-0803504626e8"), "5205-7738-3696-9059", "LucyBrekke_Kemmer5@hotmail.com", "Lucy Brekke" },
                    { new Guid("e44c3d7f-e289-4173-bda9-f1e8b8660d82"), "6471-6218-0315-3560-5098", "LoriReichert61@gmail.com", "Lori Reichert" },
                    { new Guid("e4cf4ad8-c0c8-4200-9d9d-c956441d1bd7"), "6767-4276-0422-0328-274", "MeganeKiehn34@hotmail.com", "Megane Kiehn" },
                    { new Guid("e7384509-12a3-4cde-ad11-fb8135b02562"), "6706654618830978221", "MacBoyle41@hotmail.com", "Mac Boyle" },
                    { new Guid("e9c24218-70e0-4779-aa4f-5fc0cf1b4456"), "6528-6233-6338-7419-5906", "DedricBahringer74@yahoo.com", "Dedric Bahringer" },
                    { new Guid("ea436819-23ab-4794-b24f-53da95d9d28f"), "5479-2379-6658-7544", "JaniceCassin_Marvin53@yahoo.com", "Janice Cassin" },
                    { new Guid("eb6318a2-0d76-4c57-a9d9-2e41d76298ac"), "5038-7477-9565-7163", "MayraDach.Mohr68@hotmail.com", "Mayra Dach" },
                    { new Guid("ee14aaee-508e-4910-a723-30e2589092c4"), "5454-1873-4031-8828", "LutherKunde.Konopelski@gmail.com", "Luther Kunde" },
                    { new Guid("efbb4071-fd96-4ad5-a075-82fcef716dcf"), "6372-9164-1547-3309", "CandiceKassulke_Senger12@hotmail.com", "Candice Kassulke" },
                    { new Guid("f03cc9dd-a933-4f2a-805c-c2df8e8e3594"), "6383-3733-7155-5942", "StewartWalter.Cronin@yahoo.com", "Stewart Walter" },
                    { new Guid("f0991711-df08-4472-aca5-456881b74bd2"), "6304463913551701", "StanUpton_Daugherty@hotmail.com", "Stan Upton" },
                    { new Guid("f1831fb1-0fe3-42e6-aff0-b446be6a16d1"), "6767-3175-2430-5222", "GavinNicolas15@gmail.com", "Gavin Nicolas" },
                    { new Guid("f25b6f4e-60ed-4c6e-a7e1-005f1fb5dee3"), "3528-9580-8486-4640", "ParkerAnderson.Fahey36@hotmail.com", "Parker Anderson" },
                    { new Guid("f3a7c543-c35c-4bfb-8e19-307c04ebc53c"), "6767-0913-3011-7549", "MosesMarks.Deckow@hotmail.com", "Moses Marks" },
                    { new Guid("f41837c8-0f26-44fe-a31e-99b4e125e44f"), "6011-6568-3397-6460", "EwellSenger.DAmore@gmail.com", "Ewell Senger" },
                    { new Guid("f55b7166-a7c2-4797-bfb8-08433074f402"), "6771-8936-1339-3539", "LeonardoSchaefer_Kulas92@gmail.com", "Leonardo Schaefer" },
                    { new Guid("f7422cd9-9dc0-4562-a726-28ca9d8713ff"), "3739-882139-31111", "MarjoryParker.Runte@gmail.com", "Marjory Parker" },
                    { new Guid("f975b2d3-408a-4f1e-a089-081fa50c9815"), "6011-6230-4286-7412-0965", "AlekFriesen86@hotmail.com", "Alek Friesen" },
                    { new Guid("fd445249-1cb7-4267-baa3-7a2d3001acff"), "3529-6042-5353-2704", "MateoYundt_Kertzmann32@hotmail.com", "Mateo Yundt" },
                    { new Guid("fe050eaf-ba6f-4070-a3f7-bde12f410741"), "6499-0727-2464-6629", "GiovannaNitzsche39@yahoo.com", "Giovanna Nitzsche" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("03ad722c-3692-4357-af12-23dd57d71be3"), "natus", 35044.38098885582457272m, 8000 },
                    { new Guid("047a0534-b104-4b49-bb60-03c9027a0306"), "repudiandae", 77976.79935714673162313m, 1787 },
                    { new Guid("0644f007-13b6-4f9f-b9fa-bb7dce70d4a1"), "ut", 4878.200580837236382032m, 1182 },
                    { new Guid("14a38f11-22da-451f-939c-1acde17df029"), "vel", 44200.69582786218905499m, 4518 },
                    { new Guid("15fce25d-f183-44d9-b256-0de5a531781d"), "culpa", 14036.11021231031351016m, 6503 },
                    { new Guid("235ade12-ae38-4d45-b530-f777631e24a1"), "ea", 83096.5318123533594201m, 4178 },
                    { new Guid("28ada937-667e-43ed-bb95-5f22551cd874"), "nisi", 88660.12843383477448449m, 2493 },
                    { new Guid("2b912ab9-23d4-4687-84b4-6fa74d29db8e"), "earum", 35579.1589921588765587m, 4610 },
                    { new Guid("30565baa-dfdf-4c8d-858b-a1ab6437689d"), "ab", 6241.443394897334863346m, 1979 },
                    { new Guid("324f406a-8e19-4a10-90f9-a63aba6f7c02"), "dolorem", 33720.05958125056803764m, 4039 },
                    { new Guid("335c0385-7f29-4a49-8387-9674bbb5eaf0"), "voluptatem", 69015.98182908056091285m, 3323 },
                    { new Guid("37817282-8153-448d-813c-a8f570f47834"), "optio", 73610.03868248083162001m, 8466 },
                    { new Guid("3b9e40c6-4dc2-454f-95bf-00512ac44310"), "enim", 18831.12536179734021472m, 8410 },
                    { new Guid("400ba8bd-2f7a-4aa8-962f-77e7549423b3"), "est", 95736.27389067809812312m, 1639 },
                    { new Guid("410dcd9c-2b9e-46f2-8e78-dfcb5c5fb513"), "deserunt", 91691.208690001537227m, 4331 },
                    { new Guid("467f98c1-7621-4c70-87a6-f9d4a6cc1ac2"), "quia", 28670.25636821353721192m, 3523 },
                    { new Guid("4e1f6e63-dce5-4e09-a287-0ca5fe1225d9"), "aspernatur", 24037.72434086043940509m, 4183 },
                    { new Guid("4f9255d4-0c45-46d8-ae0c-8c7733ddb003"), "quibusdam", 79994.52733940182933855m, 6406 },
                    { new Guid("535e3bff-242a-4a92-962f-e1f5b26d845a"), "et", 51796.65788813482042558m, 7182 },
                    { new Guid("57e5a61a-b035-4d2d-b4cf-0f4cd4878b1a"), "aperiam", 68534.36858946369914569m, 1638 },
                    { new Guid("59460549-3540-4a17-95d3-8576499fb722"), "et", 54338.43083468343090641m, 7915 },
                    { new Guid("6267a42c-bfc4-4e2d-8919-83f5f83125df"), "aperiam", 74759.52399879616103856m, 9314 },
                    { new Guid("6bb845c1-f3ac-45d7-a636-3ea051a67f18"), "consequatur", 80679.63070004789891276m, 7433 },
                    { new Guid("6c0573fe-2576-4ee7-ad19-597b372df8a0"), "amet", 26585.91431935154728075m, 722 },
                    { new Guid("70bed9e0-daf9-4af7-8e53-3e2c271676ef"), "magni", 11087.7355442868838375m, 2568 },
                    { new Guid("70ccd522-3b41-407d-bf72-faee81668a7b"), "est", 81211.59463391870089362m, 1543 },
                    { new Guid("77020648-17c4-4116-98b9-989f6e405942"), "ut", 1824.574927137244439867m, 5265 },
                    { new Guid("77471f23-0558-4bea-8db2-897d73ab15e0"), "maiores", 63204.05883881124331305m, 8850 },
                    { new Guid("83cd4eb1-128e-4ba6-ab93-b8f69567b7a5"), "sint", 74714.54491533315167056m, 8314 },
                    { new Guid("873ae435-d6c3-4cb2-8fc2-b8d691f5fdba"), "reiciendis", 53238.29199109497987753m, 7874 },
                    { new Guid("8c58f60d-b008-46f0-af08-daebf2c7ef29"), "corporis", 44807.91768539627170229m, 4552 },
                    { new Guid("8e614d4d-9efe-4f74-8b64-428c383d212f"), "et", 13093.22068780822444938m, 7677 },
                    { new Guid("8f054704-df45-4d54-905b-8302d5e9d2bc"), "tenetur", 1805.4880555510300102m, 1149 },
                    { new Guid("958dc4a6-8ad8-4a23-9bd2-89bde4515842"), "voluptatibus", 96518.6208806096965326m, 2134 },
                    { new Guid("9b8e1dbd-dbde-4773-a759-65977122976f"), "libero", 74239.17392949743270407m, 7707 },
                    { new Guid("9efaa266-2eae-4ac2-8ab8-759d7d0d8e37"), "aut", 70567.32670110492398364m, 9781 },
                    { new Guid("a0ce8904-95f8-4005-abee-07fd0e25d937"), "nemo", 52627.19874294989264783m, 3970 },
                    { new Guid("a191c40d-b13c-4d36-a024-d2ddca61f658"), "occaecati", 22750.0697539760900163m, 407 },
                    { new Guid("a246aa01-5ba8-443d-bcd7-67e1f444b046"), "nam", 34356.11929294616460297m, 6995 },
                    { new Guid("a829b9be-a03b-401b-be58-084cf7c90c7b"), "aut", 83787.38759034560759223m, 4675 },
                    { new Guid("ae721f08-6109-4ab1-8ad1-c369777dfd78"), "sapiente", 26990.71944301401121956m, 911 },
                    { new Guid("b05bff7b-721a-417c-937f-4718c0918f40"), "natus", 72574.82870590273982707m, 9853 },
                    { new Guid("b2e1b46e-146b-4f75-b177-97daa68184d3"), "occaecati", 39181.71708543995726395m, 1975 },
                    { new Guid("b3fcfbda-bcc0-46d5-9d80-6e83498840b0"), "voluptatem", 25265.09711149228054052m, 2676 },
                    { new Guid("b7b4c499-146c-4480-a577-e45c97190997"), "cumque", 52000.91529900072655762m, 1825 },
                    { new Guid("badab562-43d1-4851-84e4-4abc3ac166d9"), "est", 86971.61159519467172412m, 6656 },
                    { new Guid("bed1599e-925b-4132-9110-6375d3918cbd"), "est", 52513.89440463298242949m, 5976 },
                    { new Guid("c4165cda-1264-45ee-bd27-9bd978789774"), "laboriosam", 2831.63893731479402519m, 607 },
                    { new Guid("c75e37de-d1da-48f7-ba5d-52e2c51c5618"), "dolor", 62509.37951143160465722m, 4587 },
                    { new Guid("c8b39cc5-11c2-485c-ab97-0ca0e8b8c20d"), "debitis", 71946.6629062078469957m, 6210 },
                    { new Guid("cf5b46cc-8db2-499f-a318-78382adcd7fb"), "quia", 96509.4931879032051806m, 905 },
                    { new Guid("d06556a7-4186-4ad9-996f-4c991b94133b"), "repellendus", 20799.20198358147800711m, 4632 },
                    { new Guid("d8e43f10-e862-4d5b-8dc3-5fd1c53ea8ab"), "omnis", 93320.22447159711101703m, 21 },
                    { new Guid("dfe646ba-d1f3-4ceb-a563-ae6c4c909c50"), "eaque", 2968.410024143467621685m, 6571 },
                    { new Guid("eb5b5933-f5fe-47dc-be66-e78bf43a6dd4"), "est", 52617.65174041501702638m, 319 },
                    { new Guid("ec610406-2279-4310-9690-fd3473c86aee"), "minus", 50570.18436968652429938m, 3280 },
                    { new Guid("f138307a-039f-4b82-8eda-f16f196c3ad2"), "quos", 34218.96303370455935873m, 1701 },
                    { new Guid("f1a7e474-e6b5-4193-b651-b31d45bad174"), "id", 59479.12394755077984012m, 5212 },
                    { new Guid("f9d26056-4e52-4814-a08c-960ec2ecae78"), "quo", 92504.19958735301990827m, 7286 },
                    { new Guid("fa2bacf8-2580-4680-aa48-1ae455e436a1"), "quasi", 65014.13246825426450784m, 5588 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[,]
                {
                    { new Guid("0ed7a85f-bb2d-442f-a063-d5e4c194778f"), "eos" },
                    { new Guid("22599e47-150a-4d18-83d0-e1b26d68f7c8"), "voluptatem" },
                    { new Guid("301c11c8-2f67-4cc9-8dac-3e0e77e5da2a"), "nesciunt" },
                    { new Guid("3f13c629-05b6-42b9-abf5-3239162e3400"), "illo" },
                    { new Guid("538e2a4b-33c3-4c1a-994d-f6de641f3181"), "eum" },
                    { new Guid("5a0e7222-bf85-47d4-8efe-92b1b83ea6cb"), "ullam" },
                    { new Guid("5f396972-e01f-40ea-b189-09321aeaf7ba"), "veniam" },
                    { new Guid("6f76286a-1218-4ea1-bb03-24524887ce47"), "est" },
                    { new Guid("7ad918ca-35da-43b3-9c42-5ed807e2610a"), "incidunt" },
                    { new Guid("7c811978-6b14-4671-97f4-74bdfcf34201"), "consequuntur" },
                    { new Guid("934aab66-ab48-4b33-b852-df4824d27f30"), "alias" },
                    { new Guid("94ea4193-fda6-4d63-9aa3-eb04e2f8f85e"), "sunt" },
                    { new Guid("97cb1c39-1808-4ae0-bc03-5186ca615ac7"), "illum" },
                    { new Guid("a13090ea-996b-47b8-be54-cde332e28ca6"), "aut" },
                    { new Guid("a57cba50-dadf-4195-956f-1b491a0a83c6"), "enim" },
                    { new Guid("bd097e7f-3292-4c80-a274-d2e1f660a757"), "hic" },
                    { new Guid("d1f568ee-0c7b-45ab-b33e-8a6cffbb1924"), "quia" },
                    { new Guid("d564862c-7cd5-4321-b518-dffc168ff8fc"), "reiciendis" },
                    { new Guid("da180ab4-8f91-4e93-b80e-28790bd7c249"), "doloremque" },
                    { new Guid("f9dc00d0-ee45-4fb4-a5c3-7d2deb3c8d23"), "voluptas" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[,]
                {
                    { new Guid("0438aaa6-c712-4b09-ab80-3306e7b7c4c0"), new Guid("f41837c8-0f26-44fe-a31e-99b4e125e44f"), new DateTime(2018, 11, 10, 13, 5, 36, 257, DateTimeKind.Local).AddTicks(5616), new Guid("d8e43f10-e862-4d5b-8dc3-5fd1c53ea8ab"), new Guid("a13090ea-996b-47b8-be54-cde332e28ca6") },
                    { new Guid("05c389df-4efe-473e-8aba-1ecb6885cdf5"), new Guid("d55433a4-07ec-40c4-abd8-ab8451a904e0"), new DateTime(2021, 2, 11, 17, 28, 24, 283, DateTimeKind.Local).AddTicks(7908), new Guid("d8e43f10-e862-4d5b-8dc3-5fd1c53ea8ab"), new Guid("5a0e7222-bf85-47d4-8efe-92b1b83ea6cb") },
                    { new Guid("08f4973e-0a89-4cb4-aca6-01e1625dfc00"), new Guid("5c3d25e4-1043-4435-86f4-133286413316"), new DateTime(2019, 7, 4, 4, 45, 35, 514, DateTimeKind.Local).AddTicks(3687), new Guid("cf5b46cc-8db2-499f-a318-78382adcd7fb"), new Guid("7ad918ca-35da-43b3-9c42-5ed807e2610a") },
                    { new Guid("0e4ba060-1b61-4ecd-b845-44edfb0bf5e7"), new Guid("fe050eaf-ba6f-4070-a3f7-bde12f410741"), new DateTime(2023, 2, 23, 2, 34, 9, 996, DateTimeKind.Local).AddTicks(2305), new Guid("324f406a-8e19-4a10-90f9-a63aba6f7c02"), new Guid("d564862c-7cd5-4321-b518-dffc168ff8fc") },
                    { new Guid("0fcaa747-8f66-43c4-94c7-d69cda6a263e"), new Guid("82b2952a-5ce2-4d7b-b9ea-a6006360e251"), new DateTime(2020, 5, 9, 14, 32, 30, 107, DateTimeKind.Local).AddTicks(4461), new Guid("8e614d4d-9efe-4f74-8b64-428c383d212f"), new Guid("94ea4193-fda6-4d63-9aa3-eb04e2f8f85e") },
                    { new Guid("0fdf56ee-77d5-42a5-a3ba-16a5829f5c23"), new Guid("1fd5c6b6-dd9a-431d-86c3-e3c52d70ec55"), new DateTime(2020, 8, 12, 3, 23, 13, 351, DateTimeKind.Local).AddTicks(4323), new Guid("14a38f11-22da-451f-939c-1acde17df029"), new Guid("22599e47-150a-4d18-83d0-e1b26d68f7c8") },
                    { new Guid("1bab506d-453d-4902-8d94-5e7dae33dfd5"), new Guid("f41837c8-0f26-44fe-a31e-99b4e125e44f"), new DateTime(2019, 3, 29, 6, 59, 46, 243, DateTimeKind.Local).AddTicks(4432), new Guid("d8e43f10-e862-4d5b-8dc3-5fd1c53ea8ab"), new Guid("a13090ea-996b-47b8-be54-cde332e28ca6") },
                    { new Guid("1cf067be-cbd5-4e8b-8b66-f5c4cc3feeea"), new Guid("fe050eaf-ba6f-4070-a3f7-bde12f410741"), new DateTime(2018, 7, 19, 17, 45, 30, 987, DateTimeKind.Local).AddTicks(1152), new Guid("324f406a-8e19-4a10-90f9-a63aba6f7c02"), new Guid("d564862c-7cd5-4321-b518-dffc168ff8fc") },
                    { new Guid("229e07bc-4ac5-49ee-b188-e0759dd9350e"), new Guid("d55433a4-07ec-40c4-abd8-ab8451a904e0"), new DateTime(2019, 8, 3, 5, 21, 18, 958, DateTimeKind.Local).AddTicks(2057), new Guid("d8e43f10-e862-4d5b-8dc3-5fd1c53ea8ab"), new Guid("5a0e7222-bf85-47d4-8efe-92b1b83ea6cb") },
                    { new Guid("2a0ef789-300c-4ec8-90d0-7ddc6c0fa425"), new Guid("aeeda029-5216-47bd-a388-12a9e02c9561"), new DateTime(2020, 8, 7, 14, 0, 12, 559, DateTimeKind.Local).AddTicks(599), new Guid("d06556a7-4186-4ad9-996f-4c991b94133b"), new Guid("934aab66-ab48-4b33-b852-df4824d27f30") },
                    { new Guid("2d88861c-c5ab-401f-bd10-e7139d9e2d9f"), new Guid("1fd5c6b6-dd9a-431d-86c3-e3c52d70ec55"), new DateTime(2022, 9, 14, 6, 5, 56, 796, DateTimeKind.Local).AddTicks(8672), new Guid("14a38f11-22da-451f-939c-1acde17df029"), new Guid("22599e47-150a-4d18-83d0-e1b26d68f7c8") },
                    { new Guid("2daf7ebe-0dbf-425b-9451-98bb32dde2c4"), new Guid("62dcc88b-5236-4cc5-807b-1dd5905e25bb"), new DateTime(2022, 1, 13, 21, 27, 15, 227, DateTimeKind.Local).AddTicks(2775), new Guid("14a38f11-22da-451f-939c-1acde17df029"), new Guid("934aab66-ab48-4b33-b852-df4824d27f30") },
                    { new Guid("333b0c29-f475-49ff-9576-56438f8a7813"), new Guid("0b84ab1d-6620-46b1-a198-78d97644fae5"), new DateTime(2022, 12, 17, 6, 33, 13, 775, DateTimeKind.Local).AddTicks(2610), new Guid("c4165cda-1264-45ee-bd27-9bd978789774"), new Guid("a13090ea-996b-47b8-be54-cde332e28ca6") },
                    { new Guid("33ecfff0-ec6f-41b6-ba27-497c8fac93a2"), new Guid("0b84ab1d-6620-46b1-a198-78d97644fae5"), new DateTime(2020, 1, 14, 1, 59, 7, 78, DateTimeKind.Local).AddTicks(5788), new Guid("c4165cda-1264-45ee-bd27-9bd978789774"), new Guid("a13090ea-996b-47b8-be54-cde332e28ca6") },
                    { new Guid("3b905ec8-f3c5-4435-b5cd-b839f9f537fd"), new Guid("d55433a4-07ec-40c4-abd8-ab8451a904e0"), new DateTime(2019, 10, 2, 16, 3, 31, 177, DateTimeKind.Local).AddTicks(6348), new Guid("d8e43f10-e862-4d5b-8dc3-5fd1c53ea8ab"), new Guid("5a0e7222-bf85-47d4-8efe-92b1b83ea6cb") },
                    { new Guid("404f97e0-5bd9-4587-a0ae-88accdbbca44"), new Guid("5c3d25e4-1043-4435-86f4-133286413316"), new DateTime(2022, 10, 7, 16, 30, 48, 325, DateTimeKind.Local).AddTicks(7648), new Guid("cf5b46cc-8db2-499f-a318-78382adcd7fb"), new Guid("7ad918ca-35da-43b3-9c42-5ed807e2610a") },
                    { new Guid("4472d6ea-031b-4bc7-9c46-9b0db018b6cd"), new Guid("82b2952a-5ce2-4d7b-b9ea-a6006360e251"), new DateTime(2021, 4, 24, 17, 8, 27, 807, DateTimeKind.Local).AddTicks(79), new Guid("8e614d4d-9efe-4f74-8b64-428c383d212f"), new Guid("94ea4193-fda6-4d63-9aa3-eb04e2f8f85e") },
                    { new Guid("4be65de3-015c-4a61-856a-0621c1d23585"), new Guid("82b2952a-5ce2-4d7b-b9ea-a6006360e251"), new DateTime(2021, 3, 10, 23, 26, 14, 985, DateTimeKind.Local).AddTicks(5978), new Guid("8e614d4d-9efe-4f74-8b64-428c383d212f"), new Guid("94ea4193-fda6-4d63-9aa3-eb04e2f8f85e") },
                    { new Guid("4e43785b-5609-42d7-8c37-6e486277b18a"), new Guid("fe050eaf-ba6f-4070-a3f7-bde12f410741"), new DateTime(2018, 7, 30, 9, 58, 21, 516, DateTimeKind.Local).AddTicks(9830), new Guid("324f406a-8e19-4a10-90f9-a63aba6f7c02"), new Guid("d564862c-7cd5-4321-b518-dffc168ff8fc") },
                    { new Guid("524790c3-bb36-4fb3-9f36-dc3bcd2e5fa9"), new Guid("fe050eaf-ba6f-4070-a3f7-bde12f410741"), new DateTime(2022, 3, 25, 21, 52, 53, 6, DateTimeKind.Local).AddTicks(4948), new Guid("324f406a-8e19-4a10-90f9-a63aba6f7c02"), new Guid("d564862c-7cd5-4321-b518-dffc168ff8fc") },
                    { new Guid("56e5e4b1-17c6-426e-b3ae-63b56367d2e6"), new Guid("aeeda029-5216-47bd-a388-12a9e02c9561"), new DateTime(2020, 4, 16, 14, 18, 24, 3, DateTimeKind.Local).AddTicks(1900), new Guid("d06556a7-4186-4ad9-996f-4c991b94133b"), new Guid("934aab66-ab48-4b33-b852-df4824d27f30") },
                    { new Guid("5ea0e5c7-44dc-4ffe-ac1e-cd5568b3d3c7"), new Guid("1fd5c6b6-dd9a-431d-86c3-e3c52d70ec55"), new DateTime(2021, 7, 8, 0, 53, 54, 559, DateTimeKind.Local).AddTicks(301), new Guid("14a38f11-22da-451f-939c-1acde17df029"), new Guid("22599e47-150a-4d18-83d0-e1b26d68f7c8") },
                    { new Guid("66ded862-c023-472e-9072-e4cdfb2995e3"), new Guid("0b84ab1d-6620-46b1-a198-78d97644fae5"), new DateTime(2021, 8, 29, 6, 49, 31, 798, DateTimeKind.Local).AddTicks(6953), new Guid("c4165cda-1264-45ee-bd27-9bd978789774"), new Guid("a13090ea-996b-47b8-be54-cde332e28ca6") },
                    { new Guid("6c4af733-910a-4145-b710-ccdb9474fb3c"), new Guid("fe050eaf-ba6f-4070-a3f7-bde12f410741"), new DateTime(2021, 3, 12, 14, 11, 20, 76, DateTimeKind.Local).AddTicks(7163), new Guid("324f406a-8e19-4a10-90f9-a63aba6f7c02"), new Guid("d564862c-7cd5-4321-b518-dffc168ff8fc") },
                    { new Guid("74c2e3bb-bc5d-43a5-b0b3-3e83bafc9305"), new Guid("15b995b9-5376-4138-afe4-3ffd833f264d"), new DateTime(2019, 5, 26, 13, 29, 24, 104, DateTimeKind.Local).AddTicks(1436), new Guid("d06556a7-4186-4ad9-996f-4c991b94133b"), new Guid("a57cba50-dadf-4195-956f-1b491a0a83c6") },
                    { new Guid("78c0b5d5-9ba7-4be4-b743-5c7bd83161dd"), new Guid("1fd5c6b6-dd9a-431d-86c3-e3c52d70ec55"), new DateTime(2019, 7, 1, 18, 11, 36, 156, DateTimeKind.Local).AddTicks(8271), new Guid("14a38f11-22da-451f-939c-1acde17df029"), new Guid("22599e47-150a-4d18-83d0-e1b26d68f7c8") },
                    { new Guid("7cb4cd7f-4e58-4a84-b5a6-42873e348009"), new Guid("62dcc88b-5236-4cc5-807b-1dd5905e25bb"), new DateTime(2019, 11, 8, 19, 1, 25, 553, DateTimeKind.Local).AddTicks(5066), new Guid("14a38f11-22da-451f-939c-1acde17df029"), new Guid("934aab66-ab48-4b33-b852-df4824d27f30") },
                    { new Guid("85515701-dada-4ca1-9eee-db0367c0c196"), new Guid("0b84ab1d-6620-46b1-a198-78d97644fae5"), new DateTime(2022, 6, 23, 22, 56, 53, 823, DateTimeKind.Local).AddTicks(9720), new Guid("c4165cda-1264-45ee-bd27-9bd978789774"), new Guid("a13090ea-996b-47b8-be54-cde332e28ca6") },
                    { new Guid("917e36f1-b7af-408e-94f1-b2e12247cc6b"), new Guid("f41837c8-0f26-44fe-a31e-99b4e125e44f"), new DateTime(2018, 6, 13, 20, 20, 7, 501, DateTimeKind.Local).AddTicks(6988), new Guid("d8e43f10-e862-4d5b-8dc3-5fd1c53ea8ab"), new Guid("a13090ea-996b-47b8-be54-cde332e28ca6") },
                    { new Guid("9578c45d-1757-417f-96ce-0b918f0cc99e"), new Guid("15b995b9-5376-4138-afe4-3ffd833f264d"), new DateTime(2019, 9, 11, 22, 42, 50, 289, DateTimeKind.Local).AddTicks(4240), new Guid("d06556a7-4186-4ad9-996f-4c991b94133b"), new Guid("a57cba50-dadf-4195-956f-1b491a0a83c6") },
                    { new Guid("99ebfba7-6d16-4ba8-a8be-cc959398524f"), new Guid("aeeda029-5216-47bd-a388-12a9e02c9561"), new DateTime(2019, 4, 27, 1, 47, 30, 385, DateTimeKind.Local).AddTicks(3965), new Guid("d06556a7-4186-4ad9-996f-4c991b94133b"), new Guid("934aab66-ab48-4b33-b852-df4824d27f30") },
                    { new Guid("a2270ef8-00db-4c63-915f-23ea544ccda0"), new Guid("0b84ab1d-6620-46b1-a198-78d97644fae5"), new DateTime(2022, 6, 17, 3, 49, 54, 911, DateTimeKind.Local).AddTicks(4787), new Guid("c4165cda-1264-45ee-bd27-9bd978789774"), new Guid("a13090ea-996b-47b8-be54-cde332e28ca6") },
                    { new Guid("acf0b79f-7f69-4b68-9b59-6cf9f7d7b5e7"), new Guid("82b2952a-5ce2-4d7b-b9ea-a6006360e251"), new DateTime(2018, 11, 13, 18, 38, 52, 37, DateTimeKind.Local).AddTicks(7483), new Guid("8e614d4d-9efe-4f74-8b64-428c383d212f"), new Guid("94ea4193-fda6-4d63-9aa3-eb04e2f8f85e") },
                    { new Guid("afb65139-408e-4c26-ad25-b59a6b2528b6"), new Guid("15b995b9-5376-4138-afe4-3ffd833f264d"), new DateTime(2020, 5, 11, 13, 58, 32, 627, DateTimeKind.Local).AddTicks(7030), new Guid("d06556a7-4186-4ad9-996f-4c991b94133b"), new Guid("a57cba50-dadf-4195-956f-1b491a0a83c6") },
                    { new Guid("b380699a-9a44-4153-9e3c-a6a0d318edb8"), new Guid("d55433a4-07ec-40c4-abd8-ab8451a904e0"), new DateTime(2020, 6, 25, 19, 31, 12, 420, DateTimeKind.Local).AddTicks(129), new Guid("d8e43f10-e862-4d5b-8dc3-5fd1c53ea8ab"), new Guid("5a0e7222-bf85-47d4-8efe-92b1b83ea6cb") },
                    { new Guid("b5f7e03b-b314-4f90-909e-494f6e53bcb6"), new Guid("5c3d25e4-1043-4435-86f4-133286413316"), new DateTime(2019, 6, 2, 16, 20, 31, 612, DateTimeKind.Local).AddTicks(2877), new Guid("cf5b46cc-8db2-499f-a318-78382adcd7fb"), new Guid("7ad918ca-35da-43b3-9c42-5ed807e2610a") },
                    { new Guid("bcd264ff-67e4-4c72-8bd6-a3fd98f688ab"), new Guid("5c3d25e4-1043-4435-86f4-133286413316"), new DateTime(2021, 1, 25, 14, 43, 57, 528, DateTimeKind.Local).AddTicks(1602), new Guid("cf5b46cc-8db2-499f-a318-78382adcd7fb"), new Guid("7ad918ca-35da-43b3-9c42-5ed807e2610a") },
                    { new Guid("c3db40c0-b623-4724-8f77-3d00e0d2455c"), new Guid("aeeda029-5216-47bd-a388-12a9e02c9561"), new DateTime(2023, 1, 6, 7, 37, 27, 407, DateTimeKind.Local).AddTicks(5559), new Guid("d06556a7-4186-4ad9-996f-4c991b94133b"), new Guid("934aab66-ab48-4b33-b852-df4824d27f30") },
                    { new Guid("c42445ef-39d7-4c04-b9d0-141872256507"), new Guid("f41837c8-0f26-44fe-a31e-99b4e125e44f"), new DateTime(2021, 5, 12, 4, 18, 46, 698, DateTimeKind.Local).AddTicks(8977), new Guid("d8e43f10-e862-4d5b-8dc3-5fd1c53ea8ab"), new Guid("a13090ea-996b-47b8-be54-cde332e28ca6") },
                    { new Guid("c6c68c8d-9ca8-4a02-b716-765da27e370d"), new Guid("62dcc88b-5236-4cc5-807b-1dd5905e25bb"), new DateTime(2021, 11, 21, 7, 13, 19, 128, DateTimeKind.Local).AddTicks(2356), new Guid("14a38f11-22da-451f-939c-1acde17df029"), new Guid("934aab66-ab48-4b33-b852-df4824d27f30") },
                    { new Guid("ccbcfae8-7bd8-4bcb-9b54-33e0b06989e3"), new Guid("15b995b9-5376-4138-afe4-3ffd833f264d"), new DateTime(2020, 3, 11, 14, 48, 18, 687, DateTimeKind.Local).AddTicks(1225), new Guid("d06556a7-4186-4ad9-996f-4c991b94133b"), new Guid("a57cba50-dadf-4195-956f-1b491a0a83c6") },
                    { new Guid("d10f72f5-3280-4022-9ab7-def64e9516c2"), new Guid("82b2952a-5ce2-4d7b-b9ea-a6006360e251"), new DateTime(2020, 6, 28, 0, 8, 19, 780, DateTimeKind.Local).AddTicks(9256), new Guid("8e614d4d-9efe-4f74-8b64-428c383d212f"), new Guid("94ea4193-fda6-4d63-9aa3-eb04e2f8f85e") },
                    { new Guid("d11fc23d-e8b4-4d4f-adb2-a2d1abb1ad31"), new Guid("aeeda029-5216-47bd-a388-12a9e02c9561"), new DateTime(2020, 3, 28, 15, 19, 35, 824, DateTimeKind.Local).AddTicks(5254), new Guid("d06556a7-4186-4ad9-996f-4c991b94133b"), new Guid("934aab66-ab48-4b33-b852-df4824d27f30") },
                    { new Guid("de872944-4749-48fa-bf1a-23a9d0b54c0d"), new Guid("62dcc88b-5236-4cc5-807b-1dd5905e25bb"), new DateTime(2022, 4, 7, 1, 56, 50, 612, DateTimeKind.Local).AddTicks(9548), new Guid("14a38f11-22da-451f-939c-1acde17df029"), new Guid("934aab66-ab48-4b33-b852-df4824d27f30") },
                    { new Guid("df534461-c301-4f86-8560-cae99382d33c"), new Guid("d55433a4-07ec-40c4-abd8-ab8451a904e0"), new DateTime(2023, 2, 15, 7, 40, 52, 187, DateTimeKind.Local).AddTicks(45), new Guid("d8e43f10-e862-4d5b-8dc3-5fd1c53ea8ab"), new Guid("5a0e7222-bf85-47d4-8efe-92b1b83ea6cb") },
                    { new Guid("e73406ff-ad18-46a0-a1ea-8bd6a9fc003c"), new Guid("15b995b9-5376-4138-afe4-3ffd833f264d"), new DateTime(2020, 6, 22, 18, 46, 11, 647, DateTimeKind.Local).AddTicks(5524), new Guid("d06556a7-4186-4ad9-996f-4c991b94133b"), new Guid("a57cba50-dadf-4195-956f-1b491a0a83c6") },
                    { new Guid("ef340cbe-4fd6-4601-a3fd-ac286e9844e9"), new Guid("f41837c8-0f26-44fe-a31e-99b4e125e44f"), new DateTime(2019, 5, 10, 21, 8, 1, 475, DateTimeKind.Local).AddTicks(9795), new Guid("d8e43f10-e862-4d5b-8dc3-5fd1c53ea8ab"), new Guid("a13090ea-996b-47b8-be54-cde332e28ca6") },
                    { new Guid("f8bcfd1b-3695-4596-a233-699300cdf975"), new Guid("62dcc88b-5236-4cc5-807b-1dd5905e25bb"), new DateTime(2019, 5, 3, 8, 27, 32, 477, DateTimeKind.Local).AddTicks(1637), new Guid("14a38f11-22da-451f-939c-1acde17df029"), new Guid("934aab66-ab48-4b33-b852-df4824d27f30") },
                    { new Guid("fb819706-f4e6-4bd6-8c59-7d05a19021ff"), new Guid("5c3d25e4-1043-4435-86f4-133286413316"), new DateTime(2020, 7, 27, 6, 14, 25, 108, DateTimeKind.Local).AddTicks(8405), new Guid("cf5b46cc-8db2-499f-a318-78382adcd7fb"), new Guid("7ad918ca-35da-43b3-9c42-5ed807e2610a") },
                    { new Guid("fdbf5be8-673a-4b3f-8c32-cd876abd780b"), new Guid("1fd5c6b6-dd9a-431d-86c3-e3c52d70ec55"), new DateTime(2021, 11, 4, 12, 9, 57, 524, DateTimeKind.Local).AddTicks(9068), new Guid("14a38f11-22da-451f-939c-1acde17df029"), new Guid("22599e47-150a-4d18-83d0-e1b26d68f7c8") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("006786d4-217f-4258-93f6-b9e9ebd3d17c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("021dc818-a6d2-4518-95e5-bbd382d96211"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("030e3bf3-683f-4b13-b8bf-ba305deae3ff"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("04fcf81a-cbe9-4dfa-9e49-108766d8071e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0875f759-2665-4d9c-98bb-c0011f507a86"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("098f228a-8d94-431d-9042-e99b3ddf8384"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("09a313d2-6e7c-43be-b060-217fee266b43"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("09a64576-0195-40e8-977a-a6e2401ef0fb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0b7f0bab-f700-47b1-b683-10ead29a43fd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0c62160e-d50a-4de1-87c4-cf313199a8bd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0f780098-b109-4df0-b7f7-ea17195af81e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0f801127-626e-4698-98bc-8ed59192d70b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0fea0245-db98-4e23-864e-b13f018d948b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1053af7b-c0b7-407e-b542-8ac0bf234291"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("12ab0a02-f8e2-4179-9b78-30e8f2042c69"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("12e3c0f2-01c4-4695-8a85-ee3e10901a12"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("135878b1-1967-4a37-a214-45b0a0efff67"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("13789c2c-0956-477f-b45e-c9b70170c66d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("18528092-fcff-4e46-9e46-37ce291df69a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1877fde2-7783-4766-be4e-0fc08bbc3672"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1a0cc868-3423-45dd-bab4-04857c636987"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1a3ecb93-309b-46bf-a748-6a8d4b27c2ce"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1acb7936-d959-44ab-9f4b-f81bc9fc9795"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1ad3bc8b-2213-479f-b22a-c600820c01b6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1c025304-6b92-436b-a4d0-5274079c9dfb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1cbaa9ef-a66d-4587-8692-2063a42c374d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1d42e95d-483c-4a30-8ba9-8db23ee4e565"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1e546a0e-10a6-4b91-bd81-67f56914a3e3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1ef15277-58b7-4b3c-8b25-4a8b4aad15a8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("23673e1d-86aa-4a84-af87-86b4d7dd7265"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2412da04-a25b-4946-b887-621fddc63a0a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("276ee370-c710-44a0-ae48-7c51a73604d2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2778c905-31f9-4f98-a92a-deeff26bc136"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("281d19a7-3c3f-4e5f-b074-53088a39ab07"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("29dab737-9602-414e-9f70-4c7662800379"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2a55fb17-fae1-4b5a-80ad-f3392b80c034"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2a56b0b5-f8f6-4127-acab-0aa76d3448b3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2a750fb3-47d5-4b5a-9623-8a379e58933d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2b2f7052-d9e8-4c96-b715-baedfbc61d49"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2b71c016-edb3-4a19-b64d-3d19c3e9d0a5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2b8517ad-269b-47e4-a452-eddd116082aa"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2c13c8cc-4b52-47f6-a2bb-5e0aaf973d02"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2cdd0803-a6dc-4127-beb4-a29d394a3e26"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("34670200-8228-4db7-820f-a06671c0f310"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("37c1728b-ec33-43fd-aaa8-eb40757f12f4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3943acd1-b8ae-4fb2-8ea4-0b31346f2693"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("39444374-fee2-4e70-96a3-be3c2ba51d94"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3a33da0f-fa81-43cf-b729-239e571943f5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3a565125-4ad5-4f20-ae1b-509f4ef6f96b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3bb3a5b4-e038-4169-aad5-a259b54a3eb7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3bee795b-82e4-4dda-aa95-1f58f062cfab"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3ff8457c-be43-489d-9c03-457897ba95f5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("412f64c7-f5d5-446e-b985-c70b9add6044"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("42901f69-5ad9-45ea-a6e9-4846ad9f6323"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4431237c-04c5-4100-b14e-88a240fe8228"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("443eedee-6f10-4227-a2ef-aaf9339bff63"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4554088c-0125-4e75-843e-25c546a77644"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("465fd87b-535e-4480-8a04-fbc980eb1c2b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("46820d6f-ec48-44db-b6ec-fbff9a5a37e7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("47454c02-935e-4119-84e8-563d132c6eba"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4a97aec3-a7f3-413f-a97e-5e67f5684030"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4af24a6d-6eaa-4cf1-a8c4-6f8bd3ec6b86"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4c2d2201-2996-4863-b5c3-599bad60b0cb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4ca5cd77-6195-4190-9467-b86336d19be6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4cdf313f-3d1f-4c8a-9150-b5131f0942e7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4d2bb590-62e7-406e-9830-fbc9ea9c719b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4d52189d-afbf-408b-9cef-a1f0ef884e6b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4d825081-7845-4325-8c14-8102523644ca"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4e7ce02a-2cca-4cd5-ba19-e57dbaad2956"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("523da4b8-f4e4-4487-9e1f-e7f487bd3ade"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5330dd35-73a8-468f-851e-71a8613983cd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("54f35cce-a70d-4b4e-951a-117c9543f2e9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5635c1f4-fd3a-44fc-8201-e6927c112c4d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("58ae6dec-bbfc-424f-92d0-42ed14d9e477"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5904ef22-2ec3-4806-b786-9c2e3204b54e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("597fa502-1193-4e9a-b399-5032a28c0b87"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("59ce3ce4-c694-4c1d-b513-3a74c4201fd7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6106e1e3-15a1-44ed-8845-4283f177eb3a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6142dbdd-1099-4a03-a3c1-f440092da3ee"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6156205d-c7a7-483c-bd07-0f1a1a750727"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("61b70fb0-3de4-49ca-a9c0-969db53fa434"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("629541b2-7170-4622-885c-02422921f427"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("63d8f46d-087f-446b-a5fe-08cebd3727f0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("643d1179-5fc6-4f80-a521-f4ede0be5a66"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("644893e0-eb56-4311-991f-b18119e3cc64"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("661f4f63-e8be-4442-8e7b-1aaeac761821"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("66636546-ef61-4193-ad1d-ffd7ee0adc71"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6681515a-f779-438f-8c1d-a442d8368680"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6762cfd9-f933-47bb-80d6-5fd0a9d86d03"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("688d8e05-b64b-414b-9d47-4b7213a97ab0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("69b2b826-636f-419b-9be6-26d3b7b0071c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6ada95ed-ea33-4816-bd59-6555e4a1cb3c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6e26d664-7a33-4824-a67c-e703eab2a4c5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6f671fdb-8f72-4255-98c7-ea0d18db9d62"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("709fdb99-97a2-4750-9bf1-84a2b44636dd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("753cbe1c-8f7f-449c-be6b-e1fa31a7840f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7891a965-853c-47a4-b255-01e57a16550a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("790b06d7-e943-42b3-b3e0-82f6d713407d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("79900278-e13b-4a73-b5f4-c38582e6dbeb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7a21749f-d463-47d6-bc97-45fe259bdbcb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7aa99a9e-ac84-4648-b1dc-6a32bc92bf3c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7d87e010-32c4-4760-a8d9-dc3b79d64ddc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8118415e-4215-45c2-b34a-caf7f2fb98c2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("829f41be-7a68-4b9c-b578-c833c12efff7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("85b78a08-8f57-4c5d-9668-48062c2ce551"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("87a584eb-40a9-4b53-aabd-9e37b9b76d9c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("87d8a978-07ab-4381-9964-b014d002447d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("88373a83-5b33-44c2-afdd-6c5bfbbe55a1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("89b06742-0e54-4e83-b5df-20b17b9ab606"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("92e58fa4-d186-4e2d-af8f-6b0db280bd83"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("94eb1d9a-ab0e-4886-bb31-adb3820ece4f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("94f7a4a8-2239-4f51-ad31-5bcf1cc7e44f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("950efac8-a344-437d-b93a-054700b8c185"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("95d3aff7-f4f0-4cf6-9155-ea00ed4f1e63"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("96b7359c-7834-4d25-abab-40a59c3a9d77"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("973c0185-332f-460b-b9d6-7d76d5f78b50"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("98ab048a-a085-4239-a368-01897a894f1c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("996fa36b-652c-48d4-8a63-5560f2552914"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9abcfbec-344e-41cb-877c-0c1192ae5a41"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9cc0345e-9a5a-47d9-b3ec-53094699ce45"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9e215e5a-8d98-41d0-aec9-f817abded334"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a10a65d6-279b-4953-97ff-1d27d4d36f89"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a12c53b6-7b1a-4689-98b1-4cb8ed43bbc9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a5179855-a263-437f-9f58-7f205a30a203"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a7fd2678-4da8-4fec-9883-8ab6b377b502"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ab5e5d7b-fc7d-48b2-9a23-e7ec2e6ac96a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ab7de419-e68f-4e81-98e2-bbd81400a57e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ae4e71ef-da16-4ef1-9eb5-611ad75c2400"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b02b833f-fe38-4e5b-b0a0-42eeeb975032"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b1022aea-f036-4875-a259-9cee3f35b208"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b182c552-8d1c-4205-acb1-25181a8bcf70"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b6bf4640-e6d1-405d-a6a0-892c733c6540"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b9ba1499-795d-4fe6-b70c-aae08c856525"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b9c8d766-6411-43a7-b8cd-67e7d40eb2c2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("baa86c67-c56a-4592-bf2b-6a9c7ab030ef"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("badd5ca9-2396-49ed-a682-b8b8abc3143e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("be09cfdd-d442-417b-a69d-cd69b59d03ae"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("bf07c4b4-69d2-4bae-8b36-19f9017128db"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c095aacf-7ebb-446c-81bc-71aa2f18baad"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c1659e4d-9d36-4d5c-a6a4-5c65d6626491"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c17992ca-495e-4371-a94a-d76ef7860a84"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c1e63639-c2bc-4b94-8214-21e3c5eddc67"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c4aea3bf-7f52-45be-8924-7ecf11ef387f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c71bc46d-31a7-417c-947e-4ce82995a725"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c82bbec4-7c0e-4c89-8728-c2f03e9a57f1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("caeb21f4-11e2-43de-8f8c-eb81f328a878"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cb863443-d650-412f-bc11-c9e0effee152"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cb94a2bf-14da-4c33-ba67-560178f02330"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cbd18116-f500-404e-8a3a-b6316a331fca"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cbdd7c2f-fd95-4640-ac4b-603a71076086"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cdf7a7fe-a9c3-428e-9445-ad3cb275b07c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cebfd7b8-ae72-45d6-8e5e-6f4d05c62baa"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d51436c4-c20b-406e-bec8-2891577ddf2d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d58f365e-effd-4612-82ac-b94359b59b29"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d5c6b683-85b0-488c-b8ec-796c27d4d9b4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d6c8e85f-7696-466e-9b17-fc9f4967cef9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d7d1d2ba-b253-45e2-880f-a9b19ed605df"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d8e3b9ff-538b-406a-9dc5-fe99b9f4eca6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d94a2c35-2ada-451c-a76b-705b7694b7c0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d965373c-9585-4d6b-9533-35a4a634463e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("da608b9f-fcad-47a0-b2e5-38b84d5298e3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("dc02bef1-326a-49cc-aa7c-aaad231507d9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("dc05fdd2-2a26-4c06-8ba0-22ad8982b3e7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("dd08507a-e2a6-4350-a00b-524ce6770329"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("dd2a2e89-8d76-4df0-a909-e32d8d0a847d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("de3ca515-7a43-4f7f-9202-690144130809"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("deb71043-9552-4edf-8254-d3e97e8212c3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e12f1d1c-4d16-48dd-81a8-535d9fb5c0e1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e35edf90-af35-462f-a192-4f259d7f9237"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e363dca5-f08d-4da6-88a1-5b5b5dc026e7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e3aa155f-5978-4c71-a56e-316c2be6ea31"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e3b42f63-76d6-49b1-9a11-89632f84669d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e421413f-495b-4c80-bab2-0803504626e8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e44c3d7f-e289-4173-bda9-f1e8b8660d82"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e4cf4ad8-c0c8-4200-9d9d-c956441d1bd7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e7384509-12a3-4cde-ad11-fb8135b02562"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e9c24218-70e0-4779-aa4f-5fc0cf1b4456"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ea436819-23ab-4794-b24f-53da95d9d28f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("eb6318a2-0d76-4c57-a9d9-2e41d76298ac"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ee14aaee-508e-4910-a723-30e2589092c4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("efbb4071-fd96-4ad5-a075-82fcef716dcf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f03cc9dd-a933-4f2a-805c-c2df8e8e3594"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f0991711-df08-4472-aca5-456881b74bd2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f1831fb1-0fe3-42e6-aff0-b446be6a16d1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f25b6f4e-60ed-4c6e-a7e1-005f1fb5dee3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f3a7c543-c35c-4bfb-8e19-307c04ebc53c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f55b7166-a7c2-4797-bfb8-08433074f402"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f7422cd9-9dc0-4562-a726-28ca9d8713ff"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f975b2d3-408a-4f1e-a089-081fa50c9815"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fd445249-1cb7-4267-baa3-7a2d3001acff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("03ad722c-3692-4357-af12-23dd57d71be3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("047a0534-b104-4b49-bb60-03c9027a0306"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0644f007-13b6-4f9f-b9fa-bb7dce70d4a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("15fce25d-f183-44d9-b256-0de5a531781d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("235ade12-ae38-4d45-b530-f777631e24a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("28ada937-667e-43ed-bb95-5f22551cd874"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2b912ab9-23d4-4687-84b4-6fa74d29db8e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("30565baa-dfdf-4c8d-858b-a1ab6437689d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("335c0385-7f29-4a49-8387-9674bbb5eaf0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("37817282-8153-448d-813c-a8f570f47834"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3b9e40c6-4dc2-454f-95bf-00512ac44310"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("400ba8bd-2f7a-4aa8-962f-77e7549423b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("410dcd9c-2b9e-46f2-8e78-dfcb5c5fb513"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("467f98c1-7621-4c70-87a6-f9d4a6cc1ac2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4e1f6e63-dce5-4e09-a287-0ca5fe1225d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f9255d4-0c45-46d8-ae0c-8c7733ddb003"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("535e3bff-242a-4a92-962f-e1f5b26d845a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("57e5a61a-b035-4d2d-b4cf-0f4cd4878b1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("59460549-3540-4a17-95d3-8576499fb722"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6267a42c-bfc4-4e2d-8919-83f5f83125df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6bb845c1-f3ac-45d7-a636-3ea051a67f18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6c0573fe-2576-4ee7-ad19-597b372df8a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("70bed9e0-daf9-4af7-8e53-3e2c271676ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("70ccd522-3b41-407d-bf72-faee81668a7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("77020648-17c4-4116-98b9-989f6e405942"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("77471f23-0558-4bea-8db2-897d73ab15e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("83cd4eb1-128e-4ba6-ab93-b8f69567b7a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("873ae435-d6c3-4cb2-8fc2-b8d691f5fdba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8c58f60d-b008-46f0-af08-daebf2c7ef29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8f054704-df45-4d54-905b-8302d5e9d2bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("958dc4a6-8ad8-4a23-9bd2-89bde4515842"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9b8e1dbd-dbde-4773-a759-65977122976f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9efaa266-2eae-4ac2-8ab8-759d7d0d8e37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a0ce8904-95f8-4005-abee-07fd0e25d937"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a191c40d-b13c-4d36-a024-d2ddca61f658"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a246aa01-5ba8-443d-bcd7-67e1f444b046"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a829b9be-a03b-401b-be58-084cf7c90c7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ae721f08-6109-4ab1-8ad1-c369777dfd78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b05bff7b-721a-417c-937f-4718c0918f40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b2e1b46e-146b-4f75-b177-97daa68184d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b3fcfbda-bcc0-46d5-9d80-6e83498840b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b7b4c499-146c-4480-a577-e45c97190997"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("badab562-43d1-4851-84e4-4abc3ac166d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bed1599e-925b-4132-9110-6375d3918cbd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c75e37de-d1da-48f7-ba5d-52e2c51c5618"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c8b39cc5-11c2-485c-ab97-0ca0e8b8c20d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dfe646ba-d1f3-4ceb-a563-ae6c4c909c50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("eb5b5933-f5fe-47dc-be66-e78bf43a6dd4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ec610406-2279-4310-9690-fd3473c86aee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f138307a-039f-4b82-8eda-f16f196c3ad2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f1a7e474-e6b5-4193-b651-b31d45bad174"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f9d26056-4e52-4814-a08c-960ec2ecae78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fa2bacf8-2580-4680-aa48-1ae455e436a1"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("0438aaa6-c712-4b09-ab80-3306e7b7c4c0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("05c389df-4efe-473e-8aba-1ecb6885cdf5"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("08f4973e-0a89-4cb4-aca6-01e1625dfc00"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("0e4ba060-1b61-4ecd-b845-44edfb0bf5e7"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("0fcaa747-8f66-43c4-94c7-d69cda6a263e"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("0fdf56ee-77d5-42a5-a3ba-16a5829f5c23"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1bab506d-453d-4902-8d94-5e7dae33dfd5"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1cf067be-cbd5-4e8b-8b66-f5c4cc3feeea"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("229e07bc-4ac5-49ee-b188-e0759dd9350e"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2a0ef789-300c-4ec8-90d0-7ddc6c0fa425"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2d88861c-c5ab-401f-bd10-e7139d9e2d9f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2daf7ebe-0dbf-425b-9451-98bb32dde2c4"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("333b0c29-f475-49ff-9576-56438f8a7813"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("33ecfff0-ec6f-41b6-ba27-497c8fac93a2"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3b905ec8-f3c5-4435-b5cd-b839f9f537fd"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("404f97e0-5bd9-4587-a0ae-88accdbbca44"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4472d6ea-031b-4bc7-9c46-9b0db018b6cd"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4be65de3-015c-4a61-856a-0621c1d23585"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4e43785b-5609-42d7-8c37-6e486277b18a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("524790c3-bb36-4fb3-9f36-dc3bcd2e5fa9"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("56e5e4b1-17c6-426e-b3ae-63b56367d2e6"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("5ea0e5c7-44dc-4ffe-ac1e-cd5568b3d3c7"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("66ded862-c023-472e-9072-e4cdfb2995e3"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("6c4af733-910a-4145-b710-ccdb9474fb3c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("74c2e3bb-bc5d-43a5-b0b3-3e83bafc9305"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("78c0b5d5-9ba7-4be4-b743-5c7bd83161dd"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7cb4cd7f-4e58-4a84-b5a6-42873e348009"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("85515701-dada-4ca1-9eee-db0367c0c196"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("917e36f1-b7af-408e-94f1-b2e12247cc6b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("9578c45d-1757-417f-96ce-0b918f0cc99e"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("99ebfba7-6d16-4ba8-a8be-cc959398524f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a2270ef8-00db-4c63-915f-23ea544ccda0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("acf0b79f-7f69-4b68-9b59-6cf9f7d7b5e7"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("afb65139-408e-4c26-ad25-b59a6b2528b6"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b380699a-9a44-4153-9e3c-a6a0d318edb8"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b5f7e03b-b314-4f90-909e-494f6e53bcb6"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("bcd264ff-67e4-4c72-8bd6-a3fd98f688ab"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("c3db40c0-b623-4724-8f77-3d00e0d2455c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("c42445ef-39d7-4c04-b9d0-141872256507"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("c6c68c8d-9ca8-4a02-b716-765da27e370d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("ccbcfae8-7bd8-4bcb-9b54-33e0b06989e3"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d10f72f5-3280-4022-9ab7-def64e9516c2"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d11fc23d-e8b4-4d4f-adb2-a2d1abb1ad31"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("de872944-4749-48fa-bf1a-23a9d0b54c0d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("df534461-c301-4f86-8560-cae99382d33c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("e73406ff-ad18-46a0-a1ea-8bd6a9fc003c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("ef340cbe-4fd6-4601-a3fd-ac286e9844e9"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f8bcfd1b-3695-4596-a233-699300cdf975"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("fb819706-f4e6-4bd6-8c59-7d05a19021ff"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("fdbf5be8-673a-4b3f-8c32-cd876abd780b"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("0ed7a85f-bb2d-442f-a063-d5e4c194778f"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("301c11c8-2f67-4cc9-8dac-3e0e77e5da2a"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("3f13c629-05b6-42b9-abf5-3239162e3400"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("538e2a4b-33c3-4c1a-994d-f6de641f3181"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("5f396972-e01f-40ea-b189-09321aeaf7ba"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("6f76286a-1218-4ea1-bb03-24524887ce47"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("7c811978-6b14-4671-97f4-74bdfcf34201"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("97cb1c39-1808-4ae0-bc03-5186ca615ac7"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("bd097e7f-3292-4c80-a274-d2e1f660a757"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("d1f568ee-0c7b-45ab-b33e-8a6cffbb1924"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("da180ab4-8f91-4e93-b80e-28790bd7c249"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("f9dc00d0-ee45-4fb4-a5c3-7d2deb3c8d23"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0b84ab1d-6620-46b1-a198-78d97644fae5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("15b995b9-5376-4138-afe4-3ffd833f264d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1fd5c6b6-dd9a-431d-86c3-e3c52d70ec55"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5c3d25e4-1043-4435-86f4-133286413316"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("62dcc88b-5236-4cc5-807b-1dd5905e25bb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("82b2952a-5ce2-4d7b-b9ea-a6006360e251"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("aeeda029-5216-47bd-a388-12a9e02c9561"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d55433a4-07ec-40c4-abd8-ab8451a904e0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f41837c8-0f26-44fe-a31e-99b4e125e44f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fe050eaf-ba6f-4070-a3f7-bde12f410741"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("14a38f11-22da-451f-939c-1acde17df029"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("324f406a-8e19-4a10-90f9-a63aba6f7c02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8e614d4d-9efe-4f74-8b64-428c383d212f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c4165cda-1264-45ee-bd27-9bd978789774"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cf5b46cc-8db2-499f-a318-78382adcd7fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d06556a7-4186-4ad9-996f-4c991b94133b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d8e43f10-e862-4d5b-8dc3-5fd1c53ea8ab"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("22599e47-150a-4d18-83d0-e1b26d68f7c8"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("5a0e7222-bf85-47d4-8efe-92b1b83ea6cb"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("7ad918ca-35da-43b3-9c42-5ed807e2610a"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("934aab66-ab48-4b33-b852-df4824d27f30"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("94ea4193-fda6-4d63-9aa3-eb04e2f8f85e"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("a13090ea-996b-47b8-be54-cde332e28ca6"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("a57cba50-dadf-4195-956f-1b491a0a83c6"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("d564862c-7cd5-4321-b518-dffc168ff8fc"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Sales",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CreaditCardNumber", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("01467d49-46cf-48d7-875c-64283df9d39b"), "4436293038859", "NikoMcLaughlin.Reilly70@hotmail.com", "Niko McLaughlin" },
                    { new Guid("01a2da6b-1612-4833-908a-6bf9ff7ab349"), "6304853403162626679", "RalphFeeney25@hotmail.com", "Ralph Feeney" },
                    { new Guid("0220e020-2078-470c-a3a6-fba42496867a"), "6759-9773-2628-3958", "DaveDoyle.Ferry49@yahoo.com", "Dave Doyle" },
                    { new Guid("03773fb0-5311-4be2-b071-55a3ef224ca5"), "3701-861689-94225", "MiltonCartwright_Lowe86@yahoo.com", "Milton Cartwright" },
                    { new Guid("03c40320-8741-4121-9325-badf83c1e93d"), "3531-7819-5400-7271", "BenWaelchi12@yahoo.com", "Ben Waelchi" },
                    { new Guid("0555937e-b30a-44cb-a3af-f7e0d0943de8"), "4958-0553-5316-8295", "TatumVonRueden.Wehner@yahoo.com", "Tatum VonRueden" },
                    { new Guid("05f58364-1afb-43b4-81da-0a8e6f6d1dfd"), "6466-6272-0093-2816-5249", "WilfredoSenger75@yahoo.com", "Wilfredo Senger" },
                    { new Guid("06552856-fa56-44db-bac2-0c2e43cb0b41"), "6771-8961-4786-1061", "RosaleeHaley.Emmerich@yahoo.com", "Rosalee Haley" },
                    { new Guid("0854a580-8d26-47b6-a972-c9a57dbe8e9f"), "6394-5970-2344-6111", "SophiaWill_Erdman3@yahoo.com", "Sophia Will" },
                    { new Guid("096d24e3-f759-436e-9c3b-037ee34e98a0"), "6011-6226-7501-1698-7636", "RosalindJohnston_Russel@yahoo.com", "Rosalind Johnston" },
                    { new Guid("09a39f95-ee2e-4396-a89a-34694eab61f0"), "6759-3492-4283-9197-94", "JamieBuckridge_Hickle58@gmail.com", "Jamie Buckridge" },
                    { new Guid("0b3f4ad6-72eb-4f2e-b7cc-cfc19b42300d"), "3586-5953-2383-6218", "RosannaStoltenberg_Berge@hotmail.com", "Rosanna Stoltenberg" },
                    { new Guid("0b6d33e1-15bb-48df-984d-0b5b1aae4d01"), "6771-8994-9515-3453", "EthanWeber65@gmail.com", "Ethan Weber" },
                    { new Guid("0c1c2a6a-0143-41b4-82a7-4deb6921c9c9"), "6011-3002-3747-8670", "KeaganParisian_Ebert1@hotmail.com", "Keagan Parisian" },
                    { new Guid("0c8c0736-da79-4f93-8c51-2b6c5900a288"), "6759-3632-1549-3953-64", "EnosBlock.Carroll70@gmail.com", "Enos Block" },
                    { new Guid("0d5465f8-df76-422b-9079-5ba9fafc8918"), "3529-2443-9223-6154", "UrsulaKirlin18@yahoo.com", "Ursula Kirlin" },
                    { new Guid("0e1f8c55-c3af-4ad3-a99b-a2eedb9e83e9"), "5412-2687-6660-9816", "JairoMertz.Cormier33@yahoo.com", "Jairo Mertz" },
                    { new Guid("0ee47890-118a-4a56-a940-5932c59531d2"), "5484-6168-4002-2005", "TysonBarrows93@gmail.com", "Tyson Barrows" },
                    { new Guid("1013ea64-d9f8-433c-98ca-e27ebb228a17"), "3751-684356-57152", "KennyOConnell_Auer23@gmail.com", "Kenny O'Connell" },
                    { new Guid("10bd024e-3ff4-43b8-9549-de882a0bd06a"), "677174499244015383", "KellenMarquardt_Gulgowski@yahoo.com", "Kellen Marquardt" },
                    { new Guid("12fe66e7-d5f1-4edf-bb9b-8ae2012c072c"), "6767-4210-2904-1561", "BryonMarquardt_Zemlak53@yahoo.com", "Bryon Marquardt" },
                    { new Guid("170f7904-3b8d-4bcb-b7da-1d2ee5e117c1"), "3424-891612-51774", "LaviniaPredovic.Schultz23@hotmail.com", "Lavinia Predovic" },
                    { new Guid("1781a0e1-f3e3-4665-b7a4-73b4d52540b0"), "3623-658083-3968", "VedaHarvey_Casper51@hotmail.com", "Veda Harvey" },
                    { new Guid("17a10fe8-6781-41c9-9141-c6875b0cfad3"), "3528-0255-6711-2127", "ChaseDaugherty16@gmail.com", "Chase Daugherty" },
                    { new Guid("180e7170-7a5c-4985-8c94-ee44c48a367a"), "6767-7096-9536-4971-894", "StefanErdman_Glover74@yahoo.com", "Stefan Erdman" },
                    { new Guid("1afd1fa0-b4b5-4856-adc7-9f4932fd4978"), "6767-7179-1873-6512", "WilhelmAltenwerth.Aufderhar8@hotmail.com", "Wilhelm Altenwerth" },
                    { new Guid("1b224ca1-0c00-48f4-af2e-dd0430994c11"), "4125-1043-9396-7536", "PierceCormier.Kovacek61@hotmail.com", "Pierce Cormier" },
                    { new Guid("1b58df58-9ea2-478a-949d-d13f30f12d28"), "3611-770359-3111", "DelphiaHeller_Rohan13@yahoo.com", "Delphia Heller" },
                    { new Guid("1bb4c36b-d4ae-414d-92c5-dda582f48e99"), "6759-9903-5843-1864-28", "GiovannaNicolas_Pouros@yahoo.com", "Giovanna Nicolas" },
                    { new Guid("1cb21ded-6603-4960-8ff6-4e94660af9bf"), "5018268402427377934", "ZoeyAnderson6@yahoo.com", "Zoey Anderson" },
                    { new Guid("1cbf5e9d-c15f-4112-9606-00aa79bbcddf"), "67591050955464135", "QueenieGleichner.Hettinger@yahoo.com", "Queenie Gleichner" },
                    { new Guid("1dea70a6-008b-49ca-993f-6fa6798f6a4c"), "6771-8965-5800-6545", "JarrodErdman.White@yahoo.com", "Jarrod Erdman" },
                    { new Guid("1f072cf7-a15f-4d09-93c0-ba77af34cbb5"), "5018536415844887", "AlLarson_Stamm83@hotmail.com", "Al Larson" },
                    { new Guid("1f6d49ac-0bfa-4d2f-b75e-2903194f0e8c"), "6767-5041-7502-8068", "DavionAbbott43@yahoo.com", "Davion Abbott" },
                    { new Guid("1f78217b-f138-4d85-9338-6f2d5ac278b3"), "4721561338473", "KimQuitzon_Hamill@yahoo.com", "Kim Quitzon" },
                    { new Guid("1f9b999c-4e1b-44ee-9e81-2f71442e74ef"), "3768-298031-96110", "PeggieMetz_Kuhic53@yahoo.com", "Peggie Metz" },
                    { new Guid("202a50e9-0f7b-4e66-9dfb-591628c934dd"), "5416-2741-3221-9971", "QuinnHuel.Oberbrunner@yahoo.com", "Quinn Huel" },
                    { new Guid("215f159f-ffc5-4416-ab09-29a77857a520"), "3770-078410-69388", "HardyMcKenzie42@yahoo.com", "Hardy McKenzie" },
                    { new Guid("2234ed4f-67fe-48d3-ae00-d222826fd8c4"), "6759360952322180168", "MayYost.Kemmer12@hotmail.com", "May Yost" },
                    { new Guid("23c42d30-7ee2-4b27-8a1f-bc6da470033b"), "5020218961429308", "HipolitoKris70@gmail.com", "Hipolito Kris" },
                    { new Guid("23cfc5b7-e175-4c11-b754-4339ebb13380"), "6376-3535-3575-9621", "PasqualeStamm57@hotmail.com", "Pasquale Stamm" },
                    { new Guid("246a9dd1-44a3-4723-8fce-bad06d2abbe4"), "4917120056446", "JerrodBins.Rice58@gmail.com", "Jerrod Bins" },
                    { new Guid("24e324a5-bdcf-4c4f-bb25-37ca4dd89723"), "5597-4317-6880-2857", "ElsieRenner_Farrell@yahoo.com", "Elsie Renner" },
                    { new Guid("2857ab68-db1b-4bab-bb7c-9d8a5a71cad3"), "3616-041670-9137", "FlossieHauck30@hotmail.com", "Flossie Hauck" },
                    { new Guid("2d5baa3d-764d-4fcd-a727-aa96424ce94a"), "4194-3000-7598-4767", "SidAuer.Orn@gmail.com", "Sid Auer" },
                    { new Guid("35335193-a2b7-4857-8973-009189f6d327"), "6759-5960-7098-3425-297", "KalebPollich27@yahoo.com", "Kaleb Pollich" },
                    { new Guid("3611f76f-190f-4f3c-834b-432fb8ff1b0a"), "6371-9428-9457-4772", "LillieTurcotte.Beatty@yahoo.com", "Lillie Turcotte" },
                    { new Guid("36cecce1-a3d7-4869-9848-c214bd5a0115"), "6011-5699-2002-8550", "IvoryUllrich19@gmail.com", "Ivory Ullrich" },
                    { new Guid("36effc28-46f9-44ba-863f-39fce30c030c"), "6767-8264-0336-0973-529", "NinaTromp30@gmail.com", "Nina Tromp" },
                    { new Guid("38bbd32f-9a88-47b5-878a-b7b318b636c4"), "677147353050691312", "ErnestGoyette.Hauck3@gmail.com", "Ernest Goyette" },
                    { new Guid("3ce85fce-0184-4245-9d24-42a9672ee1fb"), "3462-055490-69563", "GroverMcDermott19@gmail.com", "Grover McDermott" },
                    { new Guid("3ceb29bb-e128-4762-bcbe-4d0e4fb9a219"), "6304948729123646", "KeithCrist_Medhurst@gmail.com", "Keith Crist" },
                    { new Guid("3e2fe303-cb1e-4c93-91b9-9f159ca8cdc8"), "6391-2300-0726-8581", "JeanetteToy_Langosh@gmail.com", "Jeanette Toy" },
                    { new Guid("3f9e8d68-2f64-4a3e-ae77-e577ef9cf695"), "6767-8933-4823-6961-703", "DewittNolan37@gmail.com", "Dewitt Nolan" },
                    { new Guid("3fd3f9a1-591e-493a-ace9-d2c3d67d9e68"), "6759-3398-1593-8436-449", "DevinHackett68@yahoo.com", "Devin Hackett" },
                    { new Guid("41bc5536-d4f0-4a67-81f5-ad612ffb1374"), "6771892210160812", "UnaMueller40@gmail.com", "Una Mueller" },
                    { new Guid("43bec3ff-db9d-4e75-90be-8f46183d566f"), "3764-073746-27365", "RaulKirlin29@gmail.com", "Raul Kirlin" },
                    { new Guid("43c92f58-6192-4f65-a813-7342085081b2"), "5496-7106-0873-2024", "KirstinKuhlman_Kuhn@hotmail.com", "Kirstin Kuhlman" },
                    { new Guid("44260ab8-2d46-4350-94c4-2f9cb4d0bd3c"), "4286-4515-3236-2466", "SonnyDaugherty77@hotmail.com", "Sonny Daugherty" },
                    { new Guid("45c6037f-72a7-4576-a38b-a54e3939f29c"), "6391-5161-3744-8931", "RyderNicolas97@gmail.com", "Ryder Nicolas" },
                    { new Guid("45d10d0f-7b3c-4f3a-ab08-b6ce011ee088"), "6759-2366-7553-1115", "BraedenLind96@gmail.com", "Braeden Lind" },
                    { new Guid("4652553e-6565-4840-9c06-64dfbb86ac66"), "6767-0936-3395-9182-64", "SusanaKing72@gmail.com", "Susana King" },
                    { new Guid("48a4f8b8-050d-432b-a193-299354e25e8e"), "3695-851639-4589", "JessCarroll.Reynolds@hotmail.com", "Jess Carroll" },
                    { new Guid("49a3b063-1135-4dbe-817f-027013a7f7ad"), "3529-2811-5688-0231", "RossieYost.Becker94@yahoo.com", "Rossie Yost" },
                    { new Guid("4abafd2a-0a9c-471e-b0b4-d1a2399f8eae"), "6767-7694-6275-0340-151", "JaedenFeeney.Dare58@hotmail.com", "Jaeden Feeney" },
                    { new Guid("4c66f488-0512-4332-a81b-a754b81849cf"), "3715-252198-83979", "FloWatsica.Johns@yahoo.com", "Flo Watsica" },
                    { new Guid("519ff599-e872-46d3-8008-a8777a38a3e6"), "5410-6064-8790-3558", "SarinaPfeffer_Cremin57@gmail.com", "Sarina Pfeffer" },
                    { new Guid("521f5e67-faa3-471d-bf9a-5bf130505278"), "4565-3640-7488-2282", "RyleyGlover_Lakin@hotmail.com", "Ryley Glover" },
                    { new Guid("52b241c4-dad2-4ec7-9d25-07a892f0c247"), "6767-8503-1651-0021", "MichaleBashirian.Cummerata18@gmail.com", "Michale Bashirian" },
                    { new Guid("52fb3b38-b91c-4c9b-81c9-ecbf50df1085"), "677145913843355392", "MargarettaBechtelar_Jakubowski@yahoo.com", "Margaretta Bechtelar" },
                    { new Guid("54724408-433c-4ecc-b95a-0bf291d69f76"), "6386-2065-9477-4048", "JabariKunze.Reinger72@yahoo.com", "Jabari Kunze" },
                    { new Guid("5543ab48-d99c-4ddd-95be-4d459d382a1a"), "3453-491049-16379", "TommieRoberts_Denesik18@hotmail.com", "Tommie Roberts" },
                    { new Guid("5960bb73-27f5-4286-8840-43e2e33699c0"), "5893-8159-9560-6597", "ErvinMaggio.Tremblay@gmail.com", "Ervin Maggio" },
                    { new Guid("5a9cb0a2-2913-4492-ab5f-1670023d5f0d"), "6304478094985163", "JamalNolan.Daugherty76@yahoo.com", "Jamal Nolan" },
                    { new Guid("5bdc0df7-814e-4edd-9d10-5a2d558be949"), "6011-6208-1001-6676-0693", "TerryTrantow78@yahoo.com", "Terry Trantow" },
                    { new Guid("5c074cf8-60be-4ef1-84f7-9bbcb5b43ab8"), "677151615020862006", "BrandonWitting_Toy68@yahoo.com", "Brandon Witting" },
                    { new Guid("5c15fb5e-af56-437b-860b-d4a49609964f"), "6767-4867-5024-9535", "MertieMarvin38@yahoo.com", "Mertie Marvin" },
                    { new Guid("5c5e5079-90c7-4408-88be-621a4aa4c7a6"), "6372-8921-2693-9815", "MauriceSpinka_Rohan@yahoo.com", "Maurice Spinka" },
                    { new Guid("5d7a2787-29e3-4f7e-b715-0640011093dd"), "6011-6271-5051-6704-1178", "MaudeCronin_Schuster96@gmail.com", "Maude Cronin" },
                    { new Guid("60ccea16-3d70-4829-b73c-423e829324db"), "6706923361765339", "AriLeannon.Klein97@gmail.com", "Ari Leannon" },
                    { new Guid("6147383f-5e18-42fc-b3cf-a994bcd2b29b"), "6706879672449825", "ValentinePredovic41@yahoo.com", "Valentine Predovic" },
                    { new Guid("61a7ace5-cfac-4048-9073-80fbf6752db1"), "5448-8434-0477-2917", "KeeleyConroy8@hotmail.com", "Keeley Conroy" },
                    { new Guid("61c168ae-f40a-41a6-a63a-44f7a5260ebd"), "6377-1358-5136-8023", "MustafaCorwin2@gmail.com", "Mustafa Corwin" },
                    { new Guid("626cad4e-193f-4d2c-993c-0acdc5218f6d"), "3529-2660-5823-5956", "BenCollier8@gmail.com", "Ben Collier" },
                    { new Guid("62c5c938-bf56-4949-babd-309af06cce58"), "6767-2772-5283-9074-84", "EarnestJohnson47@gmail.com", "Earnest Johnson" },
                    { new Guid("6341ba48-b9d6-430e-a430-995caae509ff"), "6767-0806-5552-7742-649", "NoemiFeeney_Wilderman16@yahoo.com", "Noemi Feeney" },
                    { new Guid("6351b7d5-4c00-414d-ace5-4795e3703eec"), "6759-4676-5366-1157-84", "KatelynnBorer.Langworth67@gmail.com", "Katelynn Borer" },
                    { new Guid("6362084f-9fa7-45b3-b173-638442b19946"), "3543-8352-7418-2838", "BertCole69@hotmail.com", "Bert Cole" },
                    { new Guid("67757067-314d-4856-81ba-fdcf1c7e04ca"), "6767-2633-5953-5667", "BlakeStiedemann_Hauck27@yahoo.com", "Blake Stiedemann" },
                    { new Guid("692574d5-9127-4e89-9531-12016e5bfbfa"), "6767-8367-3954-7435", "MarcellusBednar_Lowe@hotmail.com", "Marcellus Bednar" },
                    { new Guid("6a4107d1-fe0d-449d-aa9a-f7a8eac1a574"), "6767-4033-7205-0407-083", "RandalBode38@gmail.com", "Randal Bode" },
                    { new Guid("6a9884a7-3e5f-4ce1-a659-03873c4e946d"), "6375-1290-2197-7328", "AhmedHeller.Armstrong46@yahoo.com", "Ahmed Heller" },
                    { new Guid("6c3d62c3-a396-4d8b-b9a2-301135789c64"), "6767-9100-5350-9808", "AllanVandervort.Predovic63@gmail.com", "Allan Vandervort" },
                    { new Guid("6d20eb6b-ec56-4419-8df9-7ec20ee38f1f"), "6771637486702031", "JohnathanWiza_Boyer@gmail.com", "Johnathan Wiza" },
                    { new Guid("6f9a56da-dcef-4118-84ee-2120e45eda99"), "5418-7959-9675-3794", "JudyHermiston_Kautzer23@hotmail.com", "Judy Hermiston" },
                    { new Guid("705f570e-e437-457d-810f-a1c0cfaa8a74"), "502080781093067034", "OletaHayes_Schmidt60@yahoo.com", "Oleta Hayes" },
                    { new Guid("7112510b-417b-4b12-87e1-7bda44e90265"), "5442-6379-9405-5592", "GaylordKing89@hotmail.com", "Gaylord King" },
                    { new Guid("7248f5ee-d65d-4f22-8402-e212e6c79781"), "6383-3343-2296-1803", "PaxtonBotsford38@yahoo.com", "Paxton Botsford" },
                    { new Guid("74698389-abd0-4ed1-ac31-b8390b03396b"), "6392-2935-6340-3512", "SterlingKessler.Howell@hotmail.com", "Sterling Kessler" },
                    { new Guid("750ee119-b47f-483a-9fca-2800e66236e6"), "6771-8992-1311-1999", "MargaretteGreen_Kuhic@yahoo.com", "Margarette Green" },
                    { new Guid("7546bc18-9032-42f1-ad54-aae9d615aed9"), "3440-949756-35564", "JamesonWilkinson.Hayes34@gmail.com", "Jameson Wilkinson" },
                    { new Guid("768d5dbb-16c5-4d63-af8c-7cb242f9e7b2"), "6759-7136-6044-7743-976", "AugustaCrona_King44@hotmail.com", "Augusta Crona" },
                    { new Guid("773b01cb-8803-42fe-8b9d-d8474f23110c"), "3638-379063-6425", "DavidKirlin_Daugherty@hotmail.com", "David Kirlin" },
                    { new Guid("7805e718-7b70-4006-92ad-6198e6fcd9b1"), "6384-9869-5513-1878", "JadaDare64@hotmail.com", "Jada Dare" },
                    { new Guid("79570e3f-116e-4f81-bdab-b32f6a92ef00"), "6771-8915-1150-9495", "LoyHeidenreich.Wintheiser27@yahoo.com", "Loy Heidenreich" },
                    { new Guid("7b46355f-780f-4f4e-9dac-b3099690bfb3"), "6011-6279-5172-8272-8250", "TremaineGleichner86@gmail.com", "Tremaine Gleichner" },
                    { new Guid("7c7df6d3-aabf-41e6-8878-649275d81412"), "6767-0003-3174-2617-93", "BenjaminThiel.Schmidt@gmail.com", "Benjamin Thiel" },
                    { new Guid("7cd5586d-b97b-49f8-a7a6-a75955555c62"), "6759-4645-7913-2778", "GarfieldWilkinson.Friesen26@yahoo.com", "Garfield Wilkinson" },
                    { new Guid("7d1b4b4a-3da3-4974-924e-c8ecec63e97d"), "6771-8909-2032-5600", "JuwanHamill_Crona@yahoo.com", "Juwan Hamill" },
                    { new Guid("7d34540e-278e-4a5f-bc95-6a37b0ac47ab"), "6771-8954-0870-0471", "MatteoFeeney.Ward@hotmail.com", "Matteo Feeney" },
                    { new Guid("7f6da968-ee50-414d-81d0-9866b482fb89"), "3791-828723-14744", "ZitaGreenfelder.Rolfson@hotmail.com", "Zita Greenfelder" },
                    { new Guid("80e68f4b-6e1e-4c62-ac36-2a9097129733"), "3647-736101-9985", "LiamHomenick.Smitham54@yahoo.com", "Liam Homenick" },
                    { new Guid("832d17fa-cade-41b5-aa5f-afa4e4023090"), "6767-3840-1111-7372-657", "JustinaStracke13@hotmail.com", "Justina Stracke" },
                    { new Guid("83301124-2a3f-4e4b-91e1-7b1178a57ada"), "3781-770259-97925", "ZoeyOlson.Wilderman8@hotmail.com", "Zoey Olson" },
                    { new Guid("8351e83a-ef6a-4c5c-b504-11ac2ec46232"), "3529-1844-7988-5996", "VidalRath_VonRueden@hotmail.com", "Vidal Rath" },
                    { new Guid("855d1caa-dacb-4373-80fa-f44c91df71aa"), "6767-5279-0550-3944", "FletcherOConnell_Wehner@hotmail.com", "Fletcher O'Connell" },
                    { new Guid("85956002-d826-4a14-a880-575bfeeb938f"), "6771-8909-0234-5022", "JohannDurgan89@gmail.com", "Johann Durgan" },
                    { new Guid("87290f46-08ed-4bb0-8339-1b4af16d663b"), "3498-494895-08549", "FlossieFisher_Kuphal@yahoo.com", "Flossie Fisher" },
                    { new Guid("88a1c601-a9ec-4b8b-8f96-144653235384"), "4615818511603", "PriceKlocko1@yahoo.com", "Price Klocko" },
                    { new Guid("92d15790-91ed-4d8f-9190-ad4ad32abc95"), "4132-5195-2856-6492", "JoesphWiza.Bayer0@hotmail.com", "Joesph Wiza" },
                    { new Guid("93e08f32-8db8-407f-9b09-b16fcc10409f"), "4419138037575", "KaciSchaefer69@hotmail.com", "Kaci Schaefer" },
                    { new Guid("95582036-86cc-4846-982e-2f47edfcfa3b"), "3421-851046-41663", "TrevorLueilwitz59@yahoo.com", "Trevor Lueilwitz" },
                    { new Guid("9860c533-5b3e-4001-b86f-ce1dec15e343"), "6383-5898-0712-0841", "MableSwaniawski.Oberbrunner@hotmail.com", "Mable Swaniawski" },
                    { new Guid("98cfb74d-6044-4f70-b6b3-d2eeef29ae92"), "3634-326326-6233", "JudahDooley26@hotmail.com", "Judah Dooley" },
                    { new Guid("99959ee5-68c5-4175-8d69-cd4021bb9cae"), "6767-8425-5202-8312-403", "HallieHarris6@gmail.com", "Hallie Harris" },
                    { new Guid("9a2bae98-463d-4be6-9b5f-658113b70ce4"), "6767-4677-5681-8017-94", "FrederikKihn_Lindgren@yahoo.com", "Frederik Kihn" },
                    { new Guid("9a421b60-33fd-4dc6-9f6a-3c3c9448baf9"), "3528-3940-5023-9304", "MonserrateTrantow39@yahoo.com", "Monserrate Trantow" },
                    { new Guid("a15e91cb-c96c-442c-9c20-03dedbbd4c62"), "4208-8836-1468-4752", "BraxtonReilly.White@gmail.com", "Braxton Reilly" },
                    { new Guid("a239a89d-86e4-4c30-896c-316577e4532b"), "6759-4319-7500-3507", "JosiahWeber64@hotmail.com", "Josiah Weber" },
                    { new Guid("a3492069-4661-444e-a979-4d9ebedcc9aa"), "6374-4703-7009-6604", "NestorLarson_Auer@gmail.com", "Nestor Larson" },
                    { new Guid("a43276d4-52fd-4ce1-926e-3ba8643f8b95"), "6304-7528-9018-5669", "LaurianeHeathcote.Runolfsdottir54@hotmail.com", "Lauriane Heathcote" },
                    { new Guid("a53fc109-d6d4-4f04-a33e-9353f605318c"), "4382425186895", "AlexandreaKoss96@gmail.com", "Alexandrea Koss" },
                    { new Guid("a6542146-831a-4fcd-ab88-5078cfe59de7"), "6304142745649350", "JadenBauch49@gmail.com", "Jaden Bauch" },
                    { new Guid("a655eb65-9c52-4412-96e7-8e6ccb7fbbb8"), "3612-414724-7510", "LudieCruickshank.OConner@yahoo.com", "Ludie Cruickshank" },
                    { new Guid("a8b1f508-4cfb-4eef-8816-6e068c7f0f4b"), "3019-428758-2782", "AlanisRau_Gibson6@gmail.com", "Alanis Rau" },
                    { new Guid("aa5958f6-8fb3-4e0f-8172-90bbb60c8259"), "6767-6449-7840-8463-65", "KodyLabadie59@hotmail.com", "Kody Labadie" },
                    { new Guid("ada39510-d6ce-49b9-9b7b-6b6c0cfbd989"), "6706257896797342521", "WilfordKuhlman.Feil51@gmail.com", "Wilford Kuhlman" },
                    { new Guid("ae3dc4d2-0faf-41f7-b702-24076c2a2e26"), "3635-578747-6809", "CarletonStoltenberg.Botsford@hotmail.com", "Carleton Stoltenberg" },
                    { new Guid("afa2c4c0-dcbd-4188-beae-c92eca602f84"), "3019-039717-9410", "ElijahSimonis_Lakin@gmail.com", "Elijah Simonis" },
                    { new Guid("b0ecdd20-9943-40d6-a6bc-c1dd07b4814e"), "6011-6253-0417-6426-2449", "JakaylaPadberg25@gmail.com", "Jakayla Padberg" },
                    { new Guid("b0eea16e-3d2d-46cd-9ccf-898c980736a8"), "6706998072060071", "IvaSchoen_Lockman56@gmail.com", "Iva Schoen" },
                    { new Guid("b4920019-d81e-462c-b7c5-56855472612f"), "6467-6234-9561-6450-2933", "HerthaAuer.Ryan66@gmail.com", "Hertha Auer" },
                    { new Guid("b5fc2f45-d44a-4a22-8dd4-931810ca9c60"), "5020-7418-3886-5552", "MagdalenaFritsch_Gorczany@yahoo.com", "Magdalena Fritsch" },
                    { new Guid("b73e65f9-0482-4cba-8731-b8ab70d1edef"), "3439-976451-64842", "ClovisBrekke.McCullough92@gmail.com", "Clovis Brekke" },
                    { new Guid("b769ffc0-75ee-4144-bbbc-095af29b6ce0"), "6384-5468-0217-5963", "DarrinHegmann_Haag24@gmail.com", "Darrin Hegmann" },
                    { new Guid("b85bf7ae-8771-4204-b286-d8423ba370fe"), "5599-8541-8299-2657", "MarcoDAmore.Murphy56@yahoo.com", "Marco D'Amore" },
                    { new Guid("b92b38f8-ba6e-43fc-bbca-206d46c606b8"), "6392-9690-7081-2556", "GarrickLindgren_Russel@hotmail.com", "Garrick Lindgren" },
                    { new Guid("bacf5967-c2ab-4692-bba5-b9f42ce8e960"), "6771-8963-4471-6043", "DovieRunte.Howell@gmail.com", "Dovie Runte" },
                    { new Guid("bc9a1e22-fc9b-4e7a-a27e-fbe74f51c756"), "6759-3592-8085-8135", "KaceyWalsh_Gibson4@yahoo.com", "Kacey Walsh" },
                    { new Guid("bdc921ad-5383-43c8-9fe2-1fc8f8af7fa1"), "6304696147964133340", "EphraimKlein.Kunde55@gmail.com", "Ephraim Klein" },
                    { new Guid("bf5a8164-380a-4a8d-b89a-11764b259c64"), "6767-6144-5259-0977", "KaylaMitchell_OConner2@yahoo.com", "Kayla Mitchell" },
                    { new Guid("c001e689-12ae-4b83-a682-c274e7341bcb"), "6759-5721-4719-2408-393", "AngelinaSchaden_Kub81@yahoo.com", "Angelina Schaden" },
                    { new Guid("c07bee53-9ce4-438f-a09e-258063dbb81b"), "6759-8464-8423-2191-022", "KyleighParisian.Pouros48@hotmail.com", "Kyleigh Parisian" },
                    { new Guid("c088a39a-bd46-4960-b29d-90ee26657286"), "6508-6211-8141-6965-9844", "ClarissaKautzer.Ernser10@gmail.com", "Clarissa Kautzer" },
                    { new Guid("c0a81c8f-163e-4cd2-a430-fe95c0fad0cb"), "4869-9030-8470-1421", "RickieOrn71@hotmail.com", "Rickie Orn" },
                    { new Guid("c2b89259-7f3a-4720-97c4-92c73c0e46c7"), "6771-8932-9378-0278", "GersonJohnston_Fisher@yahoo.com", "Gerson Johnston" },
                    { new Guid("c5a1b9c3-3fa3-496a-aec4-972cd561683f"), "6771207945143001", "HudsonFay31@gmail.com", "Hudson Fay" },
                    { new Guid("c5d0f5fa-eb28-4ce2-904b-dc065f16ba21"), "6767-0810-4984-6785", "DesireeGerlach_Moen9@hotmail.com", "Desiree Gerlach" },
                    { new Guid("c6c6bbda-27d3-4f42-af56-083cf89cd922"), "3469-902019-89410", "WhitneyJohns_Labadie@yahoo.com", "Whitney Johns" },
                    { new Guid("ca76fa80-7513-424b-a0a9-965795eac057"), "6467-0801-1651-9575", "LewMayer.Dare36@gmail.com", "Lew Mayer" },
                    { new Guid("cdc9bee5-f6bf-47fa-92c4-6e3dba0fc555"), "3528-0824-7699-4673", "LoyceWintheiser63@gmail.com", "Loyce Wintheiser" },
                    { new Guid("ce1847e0-f073-4e58-a1c6-dae233d240c2"), "4975-6127-9539-1734", "RicardoKoepp_Kemmer@yahoo.com", "Ricardo Koepp" },
                    { new Guid("cf2fd51d-5887-40ff-b60f-deedf7158b39"), "6709620400437444", "MonicaHuels.VonRueden@yahoo.com", "Monica Huels" },
                    { new Guid("d0634beb-1112-4f2c-b09c-8fbf3fca8073"), "6759-6243-7607-8207", "GwendolynLockman73@gmail.com", "Gwendolyn Lockman" },
                    { new Guid("d1a88ab2-4fbc-4fea-9b53-8e2c58676bb0"), "6759-1041-2741-1879-910", "IgnacioCormier.Cassin@yahoo.com", "Ignacio Cormier" },
                    { new Guid("d5c5a0e9-0cc7-436a-b627-31e8ae7aef27"), "6375-6053-8997-5954", "VidaConnelly88@yahoo.com", "Vida Connelly" },
                    { new Guid("d7cc593a-1077-47df-9dc9-73ffbfc546b7"), "5526-8753-8565-3315", "MyleneJohns32@yahoo.com", "Mylene Johns" },
                    { new Guid("d8771dea-8570-4aca-9b12-b8638f4003b2"), "5298-8120-9062-1036", "KileySchumm94@hotmail.com", "Kiley Schumm" },
                    { new Guid("d8c48ab3-058d-4558-973b-39a9952e7ffb"), "5262-2800-5221-5167", "NoemiHickle66@gmail.com", "Noemi Hickle" },
                    { new Guid("d9074a28-d06b-40f2-b144-bd61553446da"), "3529-5748-1655-6237", "ParisHuels_Champlin80@hotmail.com", "Paris Huels" },
                    { new Guid("da66e9d4-d2ac-45f2-8cae-c0b74e05b1db"), "4916-4465-9710-9206", "AidanKeeling.Kreiger@gmail.com", "Aidan Keeling" },
                    { new Guid("db271b02-e088-4936-993c-0099c07779da"), "3558-1650-7280-4538", "HoustonRunolfsson.Schroeder@gmail.com", "Houston Runolfsson" },
                    { new Guid("dc2d3a17-3187-4fc0-a169-a830b285347b"), "67633805627078899155", "ConcepcionJohns70@yahoo.com", "Concepcion Johns" },
                    { new Guid("dccab61e-4a1b-4468-b536-10e17b84d1f3"), "5018-3593-1302-0934", "MacTowne.Daugherty@yahoo.com", "Mac Towne" },
                    { new Guid("dcd23c7a-2bfd-4496-9f9d-e2a2dce8a43c"), "3759-284644-08003", "JaylanArmstrong16@hotmail.com", "Jaylan Armstrong" },
                    { new Guid("dd753820-bb14-4859-a83a-91a251430ff6"), "4319509015558", "ElinoreKautzer37@gmail.com", "Elinore Kautzer" },
                    { new Guid("df1594ec-d9f9-4656-bdff-ef10c53351fc"), "3015-275721-6083", "RhiannonHills.Dach28@yahoo.com", "Rhiannon Hills" },
                    { new Guid("dff1e590-79f6-4fec-bc88-a812c2548229"), "6767-8625-2067-6217", "BerneiceFriesen38@hotmail.com", "Berneice Friesen" },
                    { new Guid("e089dfb9-b8d0-44d7-aed6-c66868c4cf38"), "6767-4786-3387-7483", "EwellHagenes_Kris@yahoo.com", "Ewell Hagenes" },
                    { new Guid("e1dfd745-a9a2-4ac3-a3db-771cf10f5ed9"), "6771-8933-7451-9868", "JazminBaumbach.Fritsch@gmail.com", "Jazmin Baumbach" },
                    { new Guid("e347bdb9-ff8f-44e2-aefa-895c2f99f971"), "58939838581130249", "ValentinaWehner_Hoeger@hotmail.com", "Valentina Wehner" },
                    { new Guid("e39879f9-ed70-4786-a9a0-3e1975db476f"), "6011-3343-1718-0583", "RaleighLeannon88@hotmail.com", "Raleigh Leannon" },
                    { new Guid("eb1725b8-a044-48f6-9cfb-d3a3b0618fb2"), "6771263677648335518", "UbaldoJaskolski_Rolfson@gmail.com", "Ubaldo Jaskolski" },
                    { new Guid("eb34a885-7a88-4bed-955f-a19b425babed"), "6759-3861-6765-1770", "VaughnZiemann64@yahoo.com", "Vaughn Ziemann" },
                    { new Guid("ec4b8f28-fb72-4f17-bb21-708b1f3c0ca0"), "6384-6901-5347-1306", "KristyBauch2@gmail.com", "Kristy Bauch" },
                    { new Guid("ed75771b-7aa7-4225-bb5d-bec7d526a814"), "4229646446816", "AlbertoVonRueden.Waelchi53@gmail.com", "Alberto VonRueden" },
                    { new Guid("edcdaa56-387a-48a0-8ce9-324330bdc846"), "6759-3649-0848-0809", "HalKuhn14@yahoo.com", "Hal Kuhn" },
                    { new Guid("ef27d606-63a1-4c1c-8af8-baa946656edb"), "6370-0990-0081-7800", "LupeRatke6@gmail.com", "Lupe Ratke" },
                    { new Guid("f07cd31c-753b-46fe-a59a-7554ce729e1a"), "6706725147912345", "ConnorConroy.Hayes68@yahoo.com", "Connor Conroy" },
                    { new Guid("f21d4876-260c-4f4b-aba0-69b24c692476"), "6771-8942-2007-3761", "RoselynWalsh.Greenholt4@gmail.com", "Roselyn Walsh" },
                    { new Guid("f56be6d8-c8e3-45fd-818e-57afe31f1bbb"), "4188-7526-4781-6778", "ClevelandStoltenberg_Casper48@hotmail.com", "Cleveland Stoltenberg" },
                    { new Guid("f59a7824-fc32-403f-8e91-543f7f095f00"), "6759-6136-7419-4121", "JamesonStark_Spinka@yahoo.com", "Jameson Stark" },
                    { new Guid("f67b6c76-76ef-4298-9f72-becbe618ff8c"), "6398-1532-2782-7361", "ErvinPollich33@hotmail.com", "Ervin Pollich" },
                    { new Guid("f79c39d9-f1f0-4f91-8c0d-f603b2424740"), "4498682157278", "EvansHaag10@yahoo.com", "Evans Haag" },
                    { new Guid("f87bede5-cb9b-4311-b4ae-d0f51146a8ca"), "6767-5321-4360-2457-973", "HeavenLesch_Roob@hotmail.com", "Heaven Lesch" },
                    { new Guid("fb4cabe0-ca81-49e5-9df8-ef485a8bd426"), "3412-734310-47258", "ElroyHuel53@yahoo.com", "Elroy Huel" },
                    { new Guid("fdb32f8e-91c4-48e9-915c-b07af161de97"), "5499-7345-4259-1483", "KeenanMarquardt.Hamill@hotmail.com", "Keenan Marquardt" },
                    { new Guid("fde3878d-2cc9-4e04-8c86-a85c5dc50bd2"), "3555-6242-2543-0230", "HazelHand89@yahoo.com", "Hazel Hand" },
                    { new Guid("fe678a41-8497-4bec-8041-d81d633aff38"), "6767-9097-8449-5289-281", "MaximusBoyer_Daugherty@gmail.com", "Maximus Boyer" },
                    { new Guid("fee6d657-8fed-44a9-a94a-98bfd8656e40"), "3437-079575-54435", "JanaEbert.Kuhic67@yahoo.com", "Jana Ebert" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("01d7529c-f8ce-44ff-8a9b-86684893bcc8"), "autem", 89343.65312498578038227m, 3743 },
                    { new Guid("0d10b1a7-4afa-4664-b45a-498b639c1de1"), "et", 15157.16688939851333059m, 2099 },
                    { new Guid("0d4883a4-0042-469a-8528-d9ea25b4821b"), "deleniti", 14730.32854809393053058m, 3264 },
                    { new Guid("102210b2-be90-4d80-8f18-2d0c7df358c4"), "autem", 27986.70805163557330335m, 5695 },
                    { new Guid("121d742b-8d30-414b-9ec4-3cf6edefd552"), "animi", 93412.82067584155837179m, 8743 },
                    { new Guid("200f995b-98e6-4183-9dfc-78dd01e29bf9"), "aut", 45549.97137334997780589m, 8922 },
                    { new Guid("2177a53c-5c26-4286-ad4e-5d85d20013b4"), "dolore", 672.972912234585077324m, 1863 },
                    { new Guid("27f8b2be-dc0a-49bf-b9c9-cf7c3cc2e55b"), "exercitationem", 26394.54509059085977457m, 5011 },
                    { new Guid("2e9b544f-c9f9-45b8-8dea-8375d4752cfd"), "dolores", 79341.04154901573665478m, 8955 },
                    { new Guid("329ece97-ac04-4914-af39-1f3954ae2241"), "sed", 98322.7396613096505257m, 5776 },
                    { new Guid("364de7ea-2bf7-4278-81de-cd177a252a92"), "eveniet", 55112.26492572721585732m, 3696 },
                    { new Guid("39e11df2-dba2-4922-97cb-1f446a705743"), "pariatur", 26278.7921738404879823m, 5706 },
                    { new Guid("3e1f3fa7-ae7d-4cd7-8d65-25250f6e7da0"), "ullam", 5823.553511199862980597m, 5184 },
                    { new Guid("415b05e5-e93e-4c73-9f74-175325de5677"), "quibusdam", 84370.48617515572954006m, 3460 },
                    { new Guid("422186fd-e49e-47c1-b3e2-41bfebcecbcf"), "odit", 33619.83435235413890226m, 7205 },
                    { new Guid("4693bbfd-debd-4529-b4cb-47601e3c5973"), "vel", 61761.68312238492354201m, 2077 },
                    { new Guid("4cc3c631-6c48-4033-b354-6ada44df601a"), "nobis", 83415.71114286597485389m, 6822 },
                    { new Guid("4d17ba5b-7b5b-4078-873e-f510d9b90208"), "odio", 98161.87614980056794156m, 617 },
                    { new Guid("4da1e92a-2a57-4e19-8c57-0a850b2be088"), "esse", 41991.02758184402992026m, 1805 },
                    { new Guid("5063bce1-ef3b-45d3-8a57-c88a9500ce0f"), "error", 42216.20048719584356865m, 8675 },
                    { new Guid("5a932fee-1f53-4ea6-a5ac-cefea3649770"), "voluptate", 13956.64077990036196981m, 9405 },
                    { new Guid("5e3d36b9-cdbd-4998-86cd-b00677e0b145"), "suscipit", 63826.1473076210587531m, 9832 },
                    { new Guid("65f5da3b-714a-4dd2-b038-43407a3f4e2f"), "maiores", 41305.73119442207493603m, 4459 },
                    { new Guid("6772eb82-c522-4d95-8982-f8dfa68acbd2"), "delectus", 63084.40928845354383072m, 7142 },
                    { new Guid("6e1b0ea0-f38c-4346-9ed0-707a3eac23e2"), "voluptatum", 94347.75846987155208457m, 7198 },
                    { new Guid("72545b79-3427-452c-b719-7f24199590f6"), "beatae", 94003.0243221940200166m, 6086 },
                    { new Guid("78039435-b8f2-445f-ac9d-4f1360440ad8"), "quas", 67885.57271851767276712m, 6925 },
                    { new Guid("7c67c079-8965-4a74-9c48-4b32faaec6f0"), "veritatis", 83023.47298334776636275m, 7511 },
                    { new Guid("8059adb8-03ed-4f20-8959-e565658eeead"), "dolor", 7579.707331397350768264m, 5031 },
                    { new Guid("87b2e49d-fddf-4270-af8a-fb8b86306592"), "quo", 10851.97693524568897155m, 7309 },
                    { new Guid("8cf05902-10dd-4743-a55f-4b37a1a5c239"), "voluptas", 90453.37556202878929432m, 8884 },
                    { new Guid("919601c6-7d6d-44d9-b5be-64ea416288c4"), "ea", 96278.68228088235709116m, 2552 },
                    { new Guid("95a7b346-b58c-422a-be32-a28c64959b7c"), "deserunt", 66537.6197017467063847m, 7845 },
                    { new Guid("97a4722e-b393-433e-aab3-4783a08b157f"), "eaque", 64950.0419681899726844m, 5400 },
                    { new Guid("989da071-98e3-4778-8d54-6ed156f6ea56"), "dolorem", 17846.09681512914567439m, 9539 },
                    { new Guid("9af4dc6b-334b-4b2f-98da-7e30c8ca4531"), "enim", 50664.36406388895868602m, 1013 },
                    { new Guid("a2178599-404d-44f0-8514-2120af0c9235"), "eligendi", 39890.25736845013648467m, 5799 },
                    { new Guid("a5c870d2-ac37-4ebc-87c2-691198233de2"), "magnam", 97815.68845705406327193m, 3568 },
                    { new Guid("a6e19fe2-b594-4480-87a4-e0814353379f"), "eveniet", 96645.63682962127198451m, 5671 },
                    { new Guid("abb082b3-7481-47c4-86cb-d7b05ed999b0"), "dignissimos", 62721.82423230793360504m, 2124 },
                    { new Guid("b0f8dca5-6dc7-403d-89f3-3ee1b5a92ac1"), "tenetur", 64224.23589368264305127m, 6947 },
                    { new Guid("b7e6871a-442c-4847-991f-bc98e8b36a05"), "blanditiis", 41964.3770059773399459m, 9689 },
                    { new Guid("bab3f59d-9525-4dce-82ab-075813abb1e3"), "suscipit", 46590.36299585748672242m, 157 },
                    { new Guid("bad1e7cf-1e25-47f9-b2cd-28392cd74e44"), "voluptates", 24536.60470022248064656m, 5342 },
                    { new Guid("be515a3a-3243-4a25-9b47-eb6ac5907ffc"), "cumque", 26195.13779917739334273m, 2864 },
                    { new Guid("c15c6f42-d9c3-4047-9b7e-28570d343fb7"), "odio", 58688.23876572595127582m, 7727 },
                    { new Guid("c54e6ba9-0a80-4dcf-a3a0-238e45314556"), "dolorem", 10536.55777660368855761m, 30 },
                    { new Guid("cd3c62c8-f025-4f12-9180-7f4a70a19cf2"), "in", 64135.94121519586170816m, 2430 },
                    { new Guid("d0587c09-83f0-406f-a6df-7b68701e6810"), "minus", 24354.76422375710062849m, 8208 },
                    { new Guid("d13f3252-7bc4-47f9-8a2f-22516b90231d"), "voluptatem", 85878.30308520298079708m, 9852 },
                    { new Guid("d1eeb939-310e-4569-a593-c22f1eb4c111"), "et", 97494.95353990685851458m, 601 },
                    { new Guid("d6b0f9f8-f9c4-42c5-8389-d70ae4c0a423"), "perspiciatis", 77475.35898338278595016m, 4564 },
                    { new Guid("d8072d7d-e071-4c83-b8a7-e32ef32fc1cd"), "eos", 19709.84857402179972235m, 1904 },
                    { new Guid("dbd9c622-49ab-48ca-8f66-0f58a32fb17c"), "ea", 3802.369110106307813239m, 5688 },
                    { new Guid("e534fa05-7958-4374-8120-8c5b21229067"), "enim", 78380.29262361374696449m, 2253 },
                    { new Guid("e6594d6d-de15-4c93-a1d8-53be56cdcadd"), "sit", 72812.04617612191151056m, 522 },
                    { new Guid("ed13d2e9-0743-49e5-878a-daeb2b71fb64"), "laboriosam", 77904.35987623188818641m, 3288 },
                    { new Guid("edd6ec45-51a1-419f-8ab7-76f4b0797ed3"), "et", 57809.50906312024397129m, 348 },
                    { new Guid("f6e0b805-45b5-47b1-83c2-eb0958c30080"), "voluptatibus", 36268.13339804112619625m, 35 },
                    { new Guid("f910b7fc-6138-469d-8865-290d5c92cd6c"), "minus", 95091.24904086696668936m, 2132 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[,]
                {
                    { new Guid("0079536e-544e-40ff-8a80-22eb7a6cca68"), "dolor" },
                    { new Guid("0276be0f-814f-47a7-92b7-351367d90c29"), "iure" },
                    { new Guid("073bdd3b-ead6-436b-b61c-bf07b0941fa0"), "eum" },
                    { new Guid("3af2e467-759c-4ece-953e-0551a0afd5f1"), "facilis" },
                    { new Guid("3d329f8f-8c52-4cd1-848f-f9ba06c6c05a"), "ab" },
                    { new Guid("3d4d4fbf-13d2-49d0-a716-f12a368e7697"), "ratione" },
                    { new Guid("415cc263-1269-42c4-8797-7a7efea1b6f4"), "soluta" },
                    { new Guid("55024425-bfc7-4a67-8e92-515f67af9d16"), "sapiente" },
                    { new Guid("621c43c6-9bf2-4a08-81c6-ce6c1cf4b353"), "perferendis" },
                    { new Guid("8065cb9f-997f-4840-b55c-2d437fd040e2"), "quo" },
                    { new Guid("84c0766c-86ee-4555-a20b-6658ad05b217"), "qui" },
                    { new Guid("9fe9f3e4-fb46-4c88-a695-312bb5ad2d3e"), "nobis" },
                    { new Guid("c05aba51-74a8-4009-9522-180c6e706f5b"), "ut" },
                    { new Guid("c9e9c103-5aaf-42e2-bc00-158c52ce5b29"), "et" },
                    { new Guid("cbeb045d-18cc-40b4-b496-19cde5a2e28d"), "tempore" },
                    { new Guid("ccfbc074-5d6b-447d-879e-931424597046"), "cum" },
                    { new Guid("cd0185bc-d479-4693-b07e-adcb1e3d8589"), "iusto" },
                    { new Guid("db0424d2-137c-4e05-bbbf-3dfed30969fb"), "quidem" },
                    { new Guid("e24df6e0-57a7-4603-8fd2-a52dc234d45c"), "facere" },
                    { new Guid("fc368fc4-69e9-4418-b0d8-3f9e5f2ed43b"), "excepturi" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[,]
                {
                    { new Guid("01f75749-52f5-4e9a-8100-df63a5e51288"), new Guid("b73e65f9-0482-4cba-8731-b8ab70d1edef"), new DateTime(2021, 7, 8, 18, 40, 45, 597, DateTimeKind.Local).AddTicks(1096), new Guid("6e1b0ea0-f38c-4346-9ed0-707a3eac23e2"), new Guid("ccfbc074-5d6b-447d-879e-931424597046") },
                    { new Guid("06fa4c3a-75ed-4a83-a4ac-ac8fd63422ca"), new Guid("773b01cb-8803-42fe-8b9d-d8474f23110c"), new DateTime(2018, 8, 28, 2, 3, 25, 343, DateTimeKind.Local).AddTicks(5116), new Guid("6772eb82-c522-4d95-8982-f8dfa68acbd2"), new Guid("073bdd3b-ead6-436b-b61c-bf07b0941fa0") },
                    { new Guid("08048909-88ad-4674-afb3-aef669e594a9"), new Guid("b73e65f9-0482-4cba-8731-b8ab70d1edef"), new DateTime(2023, 1, 7, 23, 30, 46, 566, DateTimeKind.Local).AddTicks(5751), new Guid("6e1b0ea0-f38c-4346-9ed0-707a3eac23e2"), new Guid("ccfbc074-5d6b-447d-879e-931424597046") },
                    { new Guid("127855c6-a5ae-4dce-a5d9-54f29e3a659b"), new Guid("b73e65f9-0482-4cba-8731-b8ab70d1edef"), new DateTime(2022, 10, 7, 8, 38, 27, 208, DateTimeKind.Local).AddTicks(7138), new Guid("6e1b0ea0-f38c-4346-9ed0-707a3eac23e2"), new Guid("ccfbc074-5d6b-447d-879e-931424597046") },
                    { new Guid("18cf28ea-d68c-4d66-815c-e48df43283c8"), new Guid("3fd3f9a1-591e-493a-ace9-d2c3d67d9e68"), new DateTime(2021, 1, 15, 7, 57, 22, 741, DateTimeKind.Local).AddTicks(2641), new Guid("d13f3252-7bc4-47f9-8a2f-22516b90231d"), new Guid("3d329f8f-8c52-4cd1-848f-f9ba06c6c05a") },
                    { new Guid("1ce75586-2018-4733-8a0a-3efb844825fe"), new Guid("7c7df6d3-aabf-41e6-8878-649275d81412"), new DateTime(2019, 7, 1, 17, 53, 33, 394, DateTimeKind.Local).AddTicks(2760), new Guid("5e3d36b9-cdbd-4998-86cd-b00677e0b145"), new Guid("3d329f8f-8c52-4cd1-848f-f9ba06c6c05a") },
                    { new Guid("1e0e61a2-b7a9-45a7-b534-35a60def93c0"), new Guid("773b01cb-8803-42fe-8b9d-d8474f23110c"), new DateTime(2019, 4, 9, 17, 13, 17, 120, DateTimeKind.Local).AddTicks(5284), new Guid("6772eb82-c522-4d95-8982-f8dfa68acbd2"), new Guid("073bdd3b-ead6-436b-b61c-bf07b0941fa0") },
                    { new Guid("1f3f4d63-871e-4bda-a4ac-4e93167aeb88"), new Guid("3fd3f9a1-591e-493a-ace9-d2c3d67d9e68"), new DateTime(2018, 11, 5, 3, 11, 35, 136, DateTimeKind.Local).AddTicks(1239), new Guid("d13f3252-7bc4-47f9-8a2f-22516b90231d"), new Guid("3d329f8f-8c52-4cd1-848f-f9ba06c6c05a") },
                    { new Guid("3024c57f-a401-42f9-983e-29d576bebb7d"), new Guid("773b01cb-8803-42fe-8b9d-d8474f23110c"), new DateTime(2022, 2, 16, 12, 41, 6, 191, DateTimeKind.Local).AddTicks(8759), new Guid("6772eb82-c522-4d95-8982-f8dfa68acbd2"), new Guid("073bdd3b-ead6-436b-b61c-bf07b0941fa0") },
                    { new Guid("4721ae1b-42b1-419e-bd50-58d2478e129a"), new Guid("773b01cb-8803-42fe-8b9d-d8474f23110c"), new DateTime(2022, 9, 8, 6, 34, 41, 862, DateTimeKind.Local).AddTicks(2430), new Guid("6772eb82-c522-4d95-8982-f8dfa68acbd2"), new Guid("073bdd3b-ead6-436b-b61c-bf07b0941fa0") },
                    { new Guid("49708029-abf6-4894-a1ff-62e78b6aef9b"), new Guid("a655eb65-9c52-4412-96e7-8e6ccb7fbbb8"), new DateTime(2021, 2, 24, 0, 2, 47, 256, DateTimeKind.Local).AddTicks(3495), new Guid("ed13d2e9-0743-49e5-878a-daeb2b71fb64"), new Guid("3d4d4fbf-13d2-49d0-a716-f12a368e7697") },
                    { new Guid("4ad2a743-ec88-47a4-b2cd-dd77925162ba"), new Guid("b73e65f9-0482-4cba-8731-b8ab70d1edef"), new DateTime(2020, 12, 4, 0, 15, 43, 691, DateTimeKind.Local).AddTicks(8877), new Guid("6e1b0ea0-f38c-4346-9ed0-707a3eac23e2"), new Guid("ccfbc074-5d6b-447d-879e-931424597046") },
                    { new Guid("52be392a-0e90-4ee6-bdf5-19bd71b0b99f"), new Guid("7c7df6d3-aabf-41e6-8878-649275d81412"), new DateTime(2019, 11, 17, 4, 4, 48, 664, DateTimeKind.Local).AddTicks(2132), new Guid("6772eb82-c522-4d95-8982-f8dfa68acbd2"), new Guid("cd0185bc-d479-4693-b07e-adcb1e3d8589") },
                    { new Guid("5ed462d9-dc38-434b-a47b-082ea6cfc142"), new Guid("0c1c2a6a-0143-41b4-82a7-4deb6921c9c9"), new DateTime(2021, 5, 27, 23, 38, 11, 415, DateTimeKind.Local).AddTicks(6153), new Guid("87b2e49d-fddf-4270-af8a-fb8b86306592"), new Guid("415cc263-1269-42c4-8797-7a7efea1b6f4") },
                    { new Guid("61eec3ce-c991-43f7-b8fb-18ecbd3e6c57"), new Guid("b73e65f9-0482-4cba-8731-b8ab70d1edef"), new DateTime(2022, 6, 29, 8, 1, 51, 10, DateTimeKind.Local).AddTicks(9096), new Guid("6e1b0ea0-f38c-4346-9ed0-707a3eac23e2"), new Guid("ccfbc074-5d6b-447d-879e-931424597046") },
                    { new Guid("6d600aa7-6fef-4c27-aa48-e0cab3eb9062"), new Guid("692574d5-9127-4e89-9531-12016e5bfbfa"), new DateTime(2019, 2, 11, 14, 14, 21, 500, DateTimeKind.Local).AddTicks(4060), new Guid("edd6ec45-51a1-419f-8ab7-76f4b0797ed3"), new Guid("3d4d4fbf-13d2-49d0-a716-f12a368e7697") },
                    { new Guid("709b03da-fcbd-46d8-b2a1-c74ba00e806d"), new Guid("0c1c2a6a-0143-41b4-82a7-4deb6921c9c9"), new DateTime(2018, 7, 20, 23, 8, 44, 898, DateTimeKind.Local).AddTicks(3308), new Guid("87b2e49d-fddf-4270-af8a-fb8b86306592"), new Guid("415cc263-1269-42c4-8797-7a7efea1b6f4") },
                    { new Guid("70d03fb5-7366-4900-9a37-dc8a6ab45ef0"), new Guid("7c7df6d3-aabf-41e6-8878-649275d81412"), new DateTime(2019, 1, 12, 2, 22, 56, 655, DateTimeKind.Local).AddTicks(5820), new Guid("6772eb82-c522-4d95-8982-f8dfa68acbd2"), new Guid("cd0185bc-d479-4693-b07e-adcb1e3d8589") },
                    { new Guid("72bb3e9d-a5a5-4a9b-8993-3c5af06c966d"), new Guid("7c7df6d3-aabf-41e6-8878-649275d81412"), new DateTime(2022, 6, 3, 1, 7, 0, 871, DateTimeKind.Local).AddTicks(179), new Guid("5e3d36b9-cdbd-4998-86cd-b00677e0b145"), new Guid("3d329f8f-8c52-4cd1-848f-f9ba06c6c05a") },
                    { new Guid("77329b06-3e4d-4134-a6b9-7bad94c363da"), new Guid("7c7df6d3-aabf-41e6-8878-649275d81412"), new DateTime(2020, 4, 19, 8, 41, 6, 717, DateTimeKind.Local).AddTicks(466), new Guid("5e3d36b9-cdbd-4998-86cd-b00677e0b145"), new Guid("3d329f8f-8c52-4cd1-848f-f9ba06c6c05a") },
                    { new Guid("77a77b0d-6e61-466e-999e-b527a467e012"), new Guid("773b01cb-8803-42fe-8b9d-d8474f23110c"), new DateTime(2019, 12, 1, 20, 41, 52, 202, DateTimeKind.Local).AddTicks(6737), new Guid("6772eb82-c522-4d95-8982-f8dfa68acbd2"), new Guid("073bdd3b-ead6-436b-b61c-bf07b0941fa0") },
                    { new Guid("7bb1416d-6d6d-4ea7-9c6a-03d3ea812911"), new Guid("7c7df6d3-aabf-41e6-8878-649275d81412"), new DateTime(2021, 8, 10, 11, 58, 32, 412, DateTimeKind.Local).AddTicks(6575), new Guid("6772eb82-c522-4d95-8982-f8dfa68acbd2"), new Guid("cd0185bc-d479-4693-b07e-adcb1e3d8589") },
                    { new Guid("7bd7cd7e-34dd-4e4e-a7f0-97c57d08911c"), new Guid("7c7df6d3-aabf-41e6-8878-649275d81412"), new DateTime(2019, 4, 12, 6, 36, 4, 788, DateTimeKind.Local).AddTicks(5486), new Guid("6772eb82-c522-4d95-8982-f8dfa68acbd2"), new Guid("cd0185bc-d479-4693-b07e-adcb1e3d8589") },
                    { new Guid("81946acd-4fb0-4659-9f2d-e7dc59bc2ec5"), new Guid("0c1c2a6a-0143-41b4-82a7-4deb6921c9c9"), new DateTime(2021, 9, 25, 11, 3, 22, 793, DateTimeKind.Local).AddTicks(8550), new Guid("87b2e49d-fddf-4270-af8a-fb8b86306592"), new Guid("415cc263-1269-42c4-8797-7a7efea1b6f4") },
                    { new Guid("83271bb8-6dce-4750-bd41-0dccbe12902c"), new Guid("3fd3f9a1-591e-493a-ace9-d2c3d67d9e68"), new DateTime(2019, 4, 4, 10, 54, 14, 567, DateTimeKind.Local).AddTicks(2958), new Guid("d13f3252-7bc4-47f9-8a2f-22516b90231d"), new Guid("3d329f8f-8c52-4cd1-848f-f9ba06c6c05a") },
                    { new Guid("85079940-b9ca-4968-8a72-e82f6b821082"), new Guid("0c1c2a6a-0143-41b4-82a7-4deb6921c9c9"), new DateTime(2019, 3, 28, 11, 29, 2, 924, DateTimeKind.Local).AddTicks(3172), new Guid("87b2e49d-fddf-4270-af8a-fb8b86306592"), new Guid("415cc263-1269-42c4-8797-7a7efea1b6f4") },
                    { new Guid("86613e11-40ae-47ab-9046-908804451bfc"), new Guid("a655eb65-9c52-4412-96e7-8e6ccb7fbbb8"), new DateTime(2019, 3, 4, 1, 9, 6, 953, DateTimeKind.Local).AddTicks(5683), new Guid("ed13d2e9-0743-49e5-878a-daeb2b71fb64"), new Guid("3d4d4fbf-13d2-49d0-a716-f12a368e7697") },
                    { new Guid("8d21d07b-3206-4af9-853f-4b71b5119ec0"), new Guid("0b6d33e1-15bb-48df-984d-0b5b1aae4d01"), new DateTime(2019, 6, 23, 13, 7, 30, 966, DateTimeKind.Local).AddTicks(1834), new Guid("6e1b0ea0-f38c-4346-9ed0-707a3eac23e2"), new Guid("cd0185bc-d479-4693-b07e-adcb1e3d8589") },
                    { new Guid("8ed39936-36f0-4d32-ac38-85cdd2cc3dec"), new Guid("3fd3f9a1-591e-493a-ace9-d2c3d67d9e68"), new DateTime(2022, 9, 7, 20, 54, 3, 825, DateTimeKind.Local).AddTicks(2388), new Guid("d13f3252-7bc4-47f9-8a2f-22516b90231d"), new Guid("3d329f8f-8c52-4cd1-848f-f9ba06c6c05a") },
                    { new Guid("9206a601-fa76-4c7d-8829-218d3df1ced0"), new Guid("a655eb65-9c52-4412-96e7-8e6ccb7fbbb8"), new DateTime(2018, 12, 5, 3, 21, 53, 309, DateTimeKind.Local).AddTicks(2447), new Guid("ed13d2e9-0743-49e5-878a-daeb2b71fb64"), new Guid("3d4d4fbf-13d2-49d0-a716-f12a368e7697") },
                    { new Guid("9dfa53ec-07fb-4cde-90b9-feb052264886"), new Guid("a655eb65-9c52-4412-96e7-8e6ccb7fbbb8"), new DateTime(2020, 12, 29, 4, 45, 8, 289, DateTimeKind.Local).AddTicks(2242), new Guid("ed13d2e9-0743-49e5-878a-daeb2b71fb64"), new Guid("3d4d4fbf-13d2-49d0-a716-f12a368e7697") },
                    { new Guid("a464dc8d-e106-4c5c-b7d5-8f06a6d1ad2a"), new Guid("0b6d33e1-15bb-48df-984d-0b5b1aae4d01"), new DateTime(2020, 3, 28, 13, 38, 50, 829, DateTimeKind.Local).AddTicks(8933), new Guid("6e1b0ea0-f38c-4346-9ed0-707a3eac23e2"), new Guid("cd0185bc-d479-4693-b07e-adcb1e3d8589") },
                    { new Guid("a62acfbb-78ac-4f8b-a15e-a48187289a5a"), new Guid("3fd3f9a1-591e-493a-ace9-d2c3d67d9e68"), new DateTime(2019, 6, 11, 11, 18, 1, 532, DateTimeKind.Local).AddTicks(5227), new Guid("d13f3252-7bc4-47f9-8a2f-22516b90231d"), new Guid("3d329f8f-8c52-4cd1-848f-f9ba06c6c05a") },
                    { new Guid("a82831f8-1f02-4c6f-90a7-372b7e020ad7"), new Guid("692574d5-9127-4e89-9531-12016e5bfbfa"), new DateTime(2021, 5, 8, 15, 57, 20, 233, DateTimeKind.Local).AddTicks(8851), new Guid("edd6ec45-51a1-419f-8ab7-76f4b0797ed3"), new Guid("3d4d4fbf-13d2-49d0-a716-f12a368e7697") },
                    { new Guid("ae0c6ee8-12f5-4dd5-af0f-211da487f839"), new Guid("7c7df6d3-aabf-41e6-8878-649275d81412"), new DateTime(2021, 3, 19, 14, 10, 46, 294, DateTimeKind.Local).AddTicks(8023), new Guid("6772eb82-c522-4d95-8982-f8dfa68acbd2"), new Guid("cd0185bc-d479-4693-b07e-adcb1e3d8589") },
                    { new Guid("b009d909-a7c4-436f-84fd-c634d36bbf79"), new Guid("692574d5-9127-4e89-9531-12016e5bfbfa"), new DateTime(2021, 7, 27, 15, 5, 12, 353, DateTimeKind.Local).AddTicks(5489), new Guid("edd6ec45-51a1-419f-8ab7-76f4b0797ed3"), new Guid("3d4d4fbf-13d2-49d0-a716-f12a368e7697") },
                    { new Guid("b10b8c75-bf53-4e8c-ad94-3785a9665dba"), new Guid("b73e65f9-0482-4cba-8731-b8ab70d1edef"), new DateTime(2022, 2, 3, 1, 37, 39, 181, DateTimeKind.Local).AddTicks(4168), new Guid("9af4dc6b-334b-4b2f-98da-7e30c8ca4531"), new Guid("c05aba51-74a8-4009-9522-180c6e706f5b") },
                    { new Guid("b2b80c44-2c3f-49a0-aaa3-e73300e7ce6f"), new Guid("7c7df6d3-aabf-41e6-8878-649275d81412"), new DateTime(2019, 7, 8, 6, 27, 59, 788, DateTimeKind.Local).AddTicks(3247), new Guid("5e3d36b9-cdbd-4998-86cd-b00677e0b145"), new Guid("3d329f8f-8c52-4cd1-848f-f9ba06c6c05a") },
                    { new Guid("b3c1b1b5-d2b2-4344-9a2e-3856e9c3b521"), new Guid("b73e65f9-0482-4cba-8731-b8ab70d1edef"), new DateTime(2021, 9, 16, 22, 45, 56, 771, DateTimeKind.Local).AddTicks(1792), new Guid("9af4dc6b-334b-4b2f-98da-7e30c8ca4531"), new Guid("c05aba51-74a8-4009-9522-180c6e706f5b") },
                    { new Guid("b91e4864-de28-48a7-85dc-014fee58d527"), new Guid("0b6d33e1-15bb-48df-984d-0b5b1aae4d01"), new DateTime(2018, 6, 3, 3, 47, 47, 252, DateTimeKind.Local).AddTicks(3436), new Guid("6e1b0ea0-f38c-4346-9ed0-707a3eac23e2"), new Guid("cd0185bc-d479-4693-b07e-adcb1e3d8589") },
                    { new Guid("bc0cbca8-8c64-4153-bb0d-eaa0e23c35fb"), new Guid("b73e65f9-0482-4cba-8731-b8ab70d1edef"), new DateTime(2022, 8, 31, 6, 8, 22, 103, DateTimeKind.Local).AddTicks(2207), new Guid("9af4dc6b-334b-4b2f-98da-7e30c8ca4531"), new Guid("c05aba51-74a8-4009-9522-180c6e706f5b") },
                    { new Guid("c2000e73-1c53-466c-9010-e09c6454d2a0"), new Guid("a655eb65-9c52-4412-96e7-8e6ccb7fbbb8"), new DateTime(2018, 5, 31, 3, 52, 0, 934, DateTimeKind.Local).AddTicks(8488), new Guid("ed13d2e9-0743-49e5-878a-daeb2b71fb64"), new Guid("3d4d4fbf-13d2-49d0-a716-f12a368e7697") },
                    { new Guid("c9d85aec-afc4-4242-84ba-5e2e7a099f1d"), new Guid("0b6d33e1-15bb-48df-984d-0b5b1aae4d01"), new DateTime(2021, 5, 19, 4, 1, 54, 692, DateTimeKind.Local).AddTicks(3743), new Guid("6e1b0ea0-f38c-4346-9ed0-707a3eac23e2"), new Guid("cd0185bc-d479-4693-b07e-adcb1e3d8589") },
                    { new Guid("cd2dec55-0940-4b3c-8e5e-4cc794a8c1bc"), new Guid("b73e65f9-0482-4cba-8731-b8ab70d1edef"), new DateTime(2018, 4, 13, 1, 28, 48, 107, DateTimeKind.Local).AddTicks(1281), new Guid("9af4dc6b-334b-4b2f-98da-7e30c8ca4531"), new Guid("c05aba51-74a8-4009-9522-180c6e706f5b") },
                    { new Guid("de8a0fea-a91d-43c8-b96b-bead30f30dfd"), new Guid("7c7df6d3-aabf-41e6-8878-649275d81412"), new DateTime(2022, 11, 6, 11, 46, 37, 372, DateTimeKind.Local).AddTicks(3727), new Guid("5e3d36b9-cdbd-4998-86cd-b00677e0b145"), new Guid("3d329f8f-8c52-4cd1-848f-f9ba06c6c05a") },
                    { new Guid("eb480503-5f59-4336-b785-1d79a9f65593"), new Guid("692574d5-9127-4e89-9531-12016e5bfbfa"), new DateTime(2022, 9, 15, 18, 55, 57, 242, DateTimeKind.Local).AddTicks(7907), new Guid("edd6ec45-51a1-419f-8ab7-76f4b0797ed3"), new Guid("3d4d4fbf-13d2-49d0-a716-f12a368e7697") },
                    { new Guid("ec5aef00-ce9d-4414-a2c9-f0f6c77baa6b"), new Guid("692574d5-9127-4e89-9531-12016e5bfbfa"), new DateTime(2021, 8, 7, 5, 25, 30, 542, DateTimeKind.Local).AddTicks(691), new Guid("edd6ec45-51a1-419f-8ab7-76f4b0797ed3"), new Guid("3d4d4fbf-13d2-49d0-a716-f12a368e7697") },
                    { new Guid("ee64dcf5-09d2-4a5b-b200-584010dec67e"), new Guid("0c1c2a6a-0143-41b4-82a7-4deb6921c9c9"), new DateTime(2019, 1, 18, 8, 40, 39, 397, DateTimeKind.Local).AddTicks(8744), new Guid("87b2e49d-fddf-4270-af8a-fb8b86306592"), new Guid("415cc263-1269-42c4-8797-7a7efea1b6f4") },
                    { new Guid("f03ff422-6b2d-4797-a746-16e2caad209b"), new Guid("0b6d33e1-15bb-48df-984d-0b5b1aae4d01"), new DateTime(2018, 9, 1, 5, 29, 35, 84, DateTimeKind.Local).AddTicks(3085), new Guid("6e1b0ea0-f38c-4346-9ed0-707a3eac23e2"), new Guid("cd0185bc-d479-4693-b07e-adcb1e3d8589") },
                    { new Guid("f96d51a1-087d-4ce8-9d57-d286c6b559fb"), new Guid("b73e65f9-0482-4cba-8731-b8ab70d1edef"), new DateTime(2018, 11, 22, 1, 54, 49, 389, DateTimeKind.Local).AddTicks(9324), new Guid("9af4dc6b-334b-4b2f-98da-7e30c8ca4531"), new Guid("c05aba51-74a8-4009-9522-180c6e706f5b") }
                });
        }
    }
}
