using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_System.Migrations
{
    /// <inheritdoc />
    public partial class InitDataBogus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Description", "EndDate", "Name", "Price", "StartDate" },
                values: new object[,]
                {
                    { new Guid("00384138-6c38-4ad2-9d0b-1bd69abc60ea"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2028, 3, 10, 8, 25, 38, 293, DateTimeKind.Local).AddTicks(941), "Rustic Steel Fish", 188.2747135933245250m, new DateTime(2022, 7, 12, 0, 47, 37, 268, DateTimeKind.Local).AddTicks(1396) },
                    { new Guid("037c0bf0-9754-45b6-a38a-17652ee712c7"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2028, 3, 10, 8, 25, 38, 293, DateTimeKind.Local).AddTicks(604), "Small Granite Salad", 156.8585187236390750m, new DateTime(2020, 9, 19, 15, 11, 8, 403, DateTimeKind.Local).AddTicks(6583) },
                    { new Guid("28e996f0-b7ea-4b87-9a79-b7e7aaeaf851"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2028, 3, 10, 8, 25, 37, 920, DateTimeKind.Local).AddTicks(7168), "Generic Frozen Tuna", 119.9278693440810750m, new DateTime(2021, 2, 5, 17, 24, 52, 983, DateTimeKind.Local).AddTicks(8520) },
                    { new Guid("2aff0986-32da-42b6-bd85-261a5471173e"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2028, 3, 10, 8, 25, 38, 292, DateTimeKind.Local).AddTicks(9551), "Handcrafted Steel Towels", 294.0238831290193750m, new DateTime(2020, 10, 28, 0, 27, 20, 42, DateTimeKind.Local).AddTicks(9885) },
                    { new Guid("2f19ce22-0795-4e88-96f4-aa85ffe36962"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2028, 3, 10, 8, 25, 37, 920, DateTimeKind.Local).AddTicks(7419), "Gorgeous Steel Hat", 310.6450910788529500m, new DateTime(2021, 4, 4, 20, 19, 34, 687, DateTimeKind.Local).AddTicks(7388) },
                    { new Guid("30617d92-2a2a-42b1-a57d-ccba648a5543"), null, new DateTime(2028, 3, 10, 8, 25, 38, 293, DateTimeKind.Local).AddTicks(558), "Generic Fresh Fish", 75.0674642535825887750m, new DateTime(2021, 3, 5, 1, 26, 40, 64, DateTimeKind.Local).AddTicks(7511) },
                    { new Guid("47da47dc-d519-476d-9658-e47b8be267c9"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2028, 3, 10, 8, 25, 37, 920, DateTimeKind.Local).AddTicks(7351), "Ergonomic Granite Fish", 199.0576884601252000m, new DateTime(2019, 6, 21, 6, 57, 47, 571, DateTimeKind.Local).AddTicks(9770) },
                    { new Guid("4886ba70-789c-4e9d-b0a2-b1b511265527"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2028, 3, 10, 8, 25, 37, 920, DateTimeKind.Local).AddTicks(7301), "Unbranded Wooden Ball", 235.6737433836441500m, new DateTime(2022, 7, 21, 9, 20, 28, 276, DateTimeKind.Local).AddTicks(3997) },
                    { new Guid("53b4f7f8-90d6-48ee-9aac-697f31e5c697"), null, new DateTime(2028, 3, 10, 8, 25, 37, 920, DateTimeKind.Local).AddTicks(7512), "Refined Soft Chicken", 86.64731648422364000m, new DateTime(2022, 7, 10, 22, 41, 43, 52, DateTimeKind.Local).AddTicks(3370) },
                    { new Guid("8c1d7ae2-b523-4d92-ade2-c39c29d98d9c"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2028, 3, 10, 8, 25, 38, 293, DateTimeKind.Local).AddTicks(651), "Handmade Wooden Pants", 296.0947390573977000m, new DateTime(2018, 6, 30, 0, 5, 1, 177, DateTimeKind.Local).AddTicks(9344) },
                    { new Guid("8c562929-651a-4720-b3f1-9c14d65b0bba"), null, new DateTime(2028, 3, 10, 8, 25, 38, 293, DateTimeKind.Local).AddTicks(987), "Practical Rubber Gloves", 253.4959846726688500m, new DateTime(2019, 2, 4, 10, 55, 45, 315, DateTimeKind.Local).AddTicks(958) },
                    { new Guid("b13d51d6-c7e1-4019-9ff1-ca19ebc69e74"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2028, 3, 10, 8, 25, 37, 920, DateTimeKind.Local).AddTicks(7251), "Handcrafted Granite Towels", 238.9438760608792000m, new DateTime(2018, 5, 3, 5, 6, 50, 134, DateTimeKind.Local).AddTicks(2799) },
                    { new Guid("bcc0b173-280a-4d1a-a29b-108aeb6cff68"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2028, 3, 10, 8, 25, 38, 293, DateTimeKind.Local).AddTicks(708), "Licensed Frozen Salad", 199.9926722831638500m, new DateTime(2020, 11, 14, 20, 19, 42, 790, DateTimeKind.Local).AddTicks(371) },
                    { new Guid("bd86ebbc-15df-4268-9ec9-dc6a6c579806"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2028, 3, 10, 8, 25, 38, 293, DateTimeKind.Local).AddTicks(753), "Handmade Wooden Hat", 191.6108864076939750m, new DateTime(2019, 12, 20, 11, 27, 37, 639, DateTimeKind.Local).AddTicks(6615) },
                    { new Guid("c6aabad0-e171-4cd4-bfe6-c18a75fa05c2"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2028, 3, 10, 8, 25, 37, 920, DateTimeKind.Local).AddTicks(7605), "Incredible Steel Cheese", 178.4552859418138500m, new DateTime(2018, 10, 3, 17, 0, 17, 985, DateTimeKind.Local).AddTicks(3800) },
                    { new Guid("c708c352-12c2-4a03-979b-62058e2e2858"), null, new DateTime(2028, 3, 10, 8, 25, 38, 293, DateTimeKind.Local).AddTicks(503), "Awesome Soft Bacon", 119.4349396746700500m, new DateTime(2020, 1, 26, 5, 58, 25, 835, DateTimeKind.Local).AddTicks(4802) },
                    { new Guid("da56f125-4a16-4266-9016-98fd08e906c1"), null, new DateTime(2028, 3, 10, 8, 25, 37, 920, DateTimeKind.Local).AddTicks(7555), "Generic Soft Chicken", 257.4506773928234000m, new DateTime(2018, 10, 30, 22, 50, 39, 262, DateTimeKind.Local).AddTicks(1388) },
                    { new Guid("e100f62c-b528-45b3-b54f-757a89c089ed"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2028, 3, 10, 8, 25, 38, 293, DateTimeKind.Local).AddTicks(797), "Tasty Concrete Keyboard", 91.33516294232154750m, new DateTime(2018, 11, 21, 19, 39, 22, 963, DateTimeKind.Local).AddTicks(2201) },
                    { new Guid("f5b1e826-31ad-44ad-9068-aec15291d27f"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2028, 3, 10, 8, 25, 37, 920, DateTimeKind.Local).AddTicks(7464), "Generic Steel Computer", 313.9253602774164500m, new DateTime(2018, 7, 29, 2, 8, 57, 514, DateTimeKind.Local).AddTicks(6317) },
                    { new Guid("fd846371-f4f3-4965-8073-2e397c5900e8"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2028, 3, 10, 8, 25, 37, 919, DateTimeKind.Local).AddTicks(6952), "Handmade Wooden Bike", 116.4221207418900750m, new DateTime(2020, 3, 30, 15, 45, 24, 61, DateTimeKind.Local).AddTicks(2359) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Birthday", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[,]
                {
                    { new Guid("105976e5-60f9-4d45-bc41-fcff852b944c"), null, "Claudie Gislason", "250688217", false },
                    { new Guid("10624f46-1955-489c-8a65-332a543a9217"), new DateTime(2003, 10, 27, 0, 53, 49, 500, DateTimeKind.Local).AddTicks(1017), "Genevieve Walter", "903355519", true },
                    { new Guid("360f4c40-f2f1-4e8c-9efe-f4c59e2478cf"), null, "Jovanny Reichert", "021685728", true },
                    { new Guid("3d438e36-794b-46e8-946e-23f3f678aa7c"), null, "Maximillia Tromp", "119619767", true },
                    { new Guid("489f71fb-4540-4a4a-a0be-cf1197eff1c5"), new DateTime(2006, 2, 5, 14, 34, 40, 497, DateTimeKind.Local).AddTicks(3871), "Bud Senger", "241835376", true },
                    { new Guid("4f6198a2-f481-4da4-8b14-38c936376cc9"), new DateTime(2004, 6, 26, 16, 58, 33, 191, DateTimeKind.Local).AddTicks(8427), "Colton Durgan", "188469344", true },
                    { new Guid("62f43b67-9869-40c8-9fd4-96082c319d4a"), null, "Victor Will", "992722317", false },
                    { new Guid("7d96f2c1-243b-4dcf-8663-37a01fce18a6"), new DateTime(2003, 2, 12, 7, 57, 22, 167, DateTimeKind.Local).AddTicks(6631), "Jacynthe Powlowski", "859191534", false },
                    { new Guid("8d172fdd-390f-495a-a1ca-de823e3aa8d0"), new DateTime(2004, 4, 30, 8, 56, 45, 168, DateTimeKind.Local).AddTicks(7577), "Vicente Koelpin", "305374642", true },
                    { new Guid("909ca786-e345-4fc2-a879-68103417153a"), new DateTime(2003, 4, 11, 1, 25, 24, 232, DateTimeKind.Local).AddTicks(9284), "Abbie Wilderman", "287942142", false },
                    { new Guid("a3372115-f08b-4fbc-bf6f-e8bcb51edd0c"), null, "Esteban Schuster", "925592639", true },
                    { new Guid("b0afe890-45be-4120-948b-01d0d0ca7132"), null, "Wilfredo Lind", "767394690", false },
                    { new Guid("b6b3a02f-5f0f-48ee-b9d9-28fb879b4ac0"), new DateTime(2002, 2, 21, 9, 11, 35, 521, DateTimeKind.Local).AddTicks(2246), "Gerhard Brown", "581445280", false },
                    { new Guid("bcc202a0-a93f-46cf-8e8d-5235a5f58494"), new DateTime(1996, 12, 8, 1, 56, 24, 998, DateTimeKind.Local).AddTicks(9735), "Roberta Lang", "068843862", true },
                    { new Guid("c97bf746-4fd9-4aeb-902f-114391cc8223"), new DateTime(2004, 10, 2, 4, 25, 30, 159, DateTimeKind.Local).AddTicks(2417), "Turner Zemlak", "882531240", false },
                    { new Guid("ca5ed15a-09fd-4f1f-950d-e96f1880c1a1"), null, "Annamae Mueller", "718194221", true },
                    { new Guid("d939edb6-20c9-482a-9dba-da282381e179"), new DateTime(2000, 5, 2, 5, 6, 7, 190, DateTimeKind.Local).AddTicks(1811), "Gardner Crooks", "158402245", false },
                    { new Guid("e40a911f-bc54-4fab-980d-a15649a41b9f"), new DateTime(2003, 8, 25, 18, 42, 13, 349, DateTimeKind.Local).AddTicks(5047), "Zoie Ryan", "315894535", false },
                    { new Guid("f2f94084-9d4d-4f5e-ae54-4b908e687227"), new DateTime(1999, 6, 10, 2, 45, 17, 114, DateTimeKind.Local).AddTicks(9723), "Gust Haley", "369543495", true },
                    { new Guid("fe0ae279-9c1d-483b-ac13-d495c9066925"), new DateTime(2002, 11, 23, 1, 20, 52, 278, DateTimeKind.Local).AddTicks(1000), "Trey Huel", "910401349", false }
                });

            migrationBuilder.InsertData(
                table: "Homework",
                columns: new[] { "HomeworkId", "Content", "ContentType", "CourseId", "StudentId", "SubmissionTime" },
                values: new object[,]
                {
                    { new Guid("5b2ee20f-d384-4c31-9462-b90d16e0a932"), "https://nettie.com", 1, new Guid("47da47dc-d519-476d-9658-e47b8be267c9"), new Guid("7d96f2c1-243b-4dcf-8663-37a01fce18a6"), new DateTime(2023, 4, 9, 22, 38, 8, 950, DateTimeKind.Local).AddTicks(8690) },
                    { new Guid("5f029670-9b9e-4e0a-98ef-cb846c6714e1"), "https://arnulfo.org", 2, new Guid("da56f125-4a16-4266-9016-98fd08e906c1"), new Guid("7d96f2c1-243b-4dcf-8663-37a01fce18a6"), new DateTime(2023, 3, 23, 16, 16, 4, 263, DateTimeKind.Local).AddTicks(5650) },
                    { new Guid("7c768a5f-acd9-4dde-889e-687e0b9a2073"), "https://kevon.biz", 3, new Guid("47da47dc-d519-476d-9658-e47b8be267c9"), new Guid("7d96f2c1-243b-4dcf-8663-37a01fce18a6"), new DateTime(2023, 3, 20, 7, 33, 26, 605, DateTimeKind.Local).AddTicks(643) },
                    { new Guid("7f652cec-8821-43f9-a20b-d46c99e8b81e"), "http://idella.org", 0, new Guid("da56f125-4a16-4266-9016-98fd08e906c1"), new Guid("7d96f2c1-243b-4dcf-8663-37a01fce18a6"), new DateTime(2023, 3, 25, 6, 42, 48, 925, DateTimeKind.Local).AddTicks(2337) },
                    { new Guid("9a26d35e-5b06-46b4-ac38-b3682cbb5bd1"), "http://lilla.biz", 3, new Guid("f5b1e826-31ad-44ad-9068-aec15291d27f"), new Guid("f2f94084-9d4d-4f5e-ae54-4b908e687227"), new DateTime(2023, 3, 22, 4, 39, 4, 728, DateTimeKind.Local).AddTicks(7021) },
                    { new Guid("ba2cb5a5-e808-4866-b855-a7847312642b"), "http://alejandrin.info", 4, new Guid("28e996f0-b7ea-4b87-9a79-b7e7aaeaf851"), new Guid("62f43b67-9869-40c8-9fd4-96082c319d4a"), new DateTime(2023, 4, 9, 9, 0, 27, 347, DateTimeKind.Local).AddTicks(9795) },
                    { new Guid("d9b7e0c0-fb8f-42eb-a78d-03b5d923ff3e"), "https://rafael.net", 1, new Guid("28e996f0-b7ea-4b87-9a79-b7e7aaeaf851"), new Guid("62f43b67-9869-40c8-9fd4-96082c319d4a"), new DateTime(2023, 3, 12, 7, 9, 30, 377, DateTimeKind.Local).AddTicks(8116) },
                    { new Guid("e2b44ca8-308a-4821-bb14-5835516dce45"), "https://brigitte.info", 1, new Guid("f5b1e826-31ad-44ad-9068-aec15291d27f"), new Guid("f2f94084-9d4d-4f5e-ae54-4b908e687227"), new DateTime(2023, 3, 25, 3, 47, 30, 44, DateTimeKind.Local).AddTicks(4491) }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ResourceId", "CourseId", "Name", "ResourceType", "Url" },
                values: new object[,]
                {
                    { new Guid("10f52d01-9248-44d9-b3ca-260ef748bb0b"), new Guid("53b4f7f8-90d6-48ee-9aac-697f31e5c697"), "Brakus, Friesen and Kunde", 2, "http://freda.com" },
                    { new Guid("32fc1451-c215-44e8-93ae-90e4fc4278b2"), new Guid("c6aabad0-e171-4cd4-bfe6-c18a75fa05c2"), "Kuhlman - Hagenes", 3, "http://rudy.biz" },
                    { new Guid("452ed2e4-14b8-4928-9675-76ac7133d888"), new Guid("c6aabad0-e171-4cd4-bfe6-c18a75fa05c2"), "Wehner and Sons", 2, "http://rupert.name" },
                    { new Guid("be0f845d-35bc-4305-a191-7501a8ce6288"), new Guid("2f19ce22-0795-4e88-96f4-aa85ffe36962"), "Leuschke LLC", 1, "http://nyasia.info" },
                    { new Guid("c4da5e22-7d86-481f-a12a-cc3082fffcbd"), new Guid("2f19ce22-0795-4e88-96f4-aa85ffe36962"), "Grady, Hahn and Mante", 2, "https://gianni.net" },
                    { new Guid("c517c22c-8397-4142-b28b-90606e65d5c8"), new Guid("53b4f7f8-90d6-48ee-9aac-697f31e5c697"), "Gibson - Walker", 0, "https://ardith.info" },
                    { new Guid("d0f99b73-6a3e-4fd9-9996-807451895047"), new Guid("28e996f0-b7ea-4b87-9a79-b7e7aaeaf851"), "Funk Group", 1, "http://noemy.com" },
                    { new Guid("eab12f16-26d9-422d-8491-6bac0e4102c3"), new Guid("28e996f0-b7ea-4b87-9a79-b7e7aaeaf851"), "Harvey, Reichel and O'Reilly", 3, "https://aileen.biz" }
                });

            migrationBuilder.InsertData(
                table: "StudentsCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { new Guid("2f19ce22-0795-4e88-96f4-aa85ffe36962"), new Guid("7d96f2c1-243b-4dcf-8663-37a01fce18a6") },
                    { new Guid("2f19ce22-0795-4e88-96f4-aa85ffe36962"), new Guid("b6b3a02f-5f0f-48ee-b9d9-28fb879b4ac0") },
                    { new Guid("53b4f7f8-90d6-48ee-9aac-697f31e5c697"), new Guid("ca5ed15a-09fd-4f1f-950d-e96f1880c1a1") },
                    { new Guid("da56f125-4a16-4266-9016-98fd08e906c1"), new Guid("d939edb6-20c9-482a-9dba-da282381e179") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("00384138-6c38-4ad2-9d0b-1bd69abc60ea"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("037c0bf0-9754-45b6-a38a-17652ee712c7"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("2aff0986-32da-42b6-bd85-261a5471173e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("30617d92-2a2a-42b1-a57d-ccba648a5543"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("4886ba70-789c-4e9d-b0a2-b1b511265527"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("8c1d7ae2-b523-4d92-ade2-c39c29d98d9c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("8c562929-651a-4720-b3f1-9c14d65b0bba"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("b13d51d6-c7e1-4019-9ff1-ca19ebc69e74"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("bcc0b173-280a-4d1a-a29b-108aeb6cff68"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("bd86ebbc-15df-4268-9ec9-dc6a6c579806"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("c708c352-12c2-4a03-979b-62058e2e2858"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("e100f62c-b528-45b3-b54f-757a89c089ed"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("fd846371-f4f3-4965-8073-2e397c5900e8"));

            migrationBuilder.DeleteData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: new Guid("5b2ee20f-d384-4c31-9462-b90d16e0a932"));

            migrationBuilder.DeleteData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: new Guid("5f029670-9b9e-4e0a-98ef-cb846c6714e1"));

            migrationBuilder.DeleteData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: new Guid("7c768a5f-acd9-4dde-889e-687e0b9a2073"));

            migrationBuilder.DeleteData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: new Guid("7f652cec-8821-43f9-a20b-d46c99e8b81e"));

            migrationBuilder.DeleteData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: new Guid("9a26d35e-5b06-46b4-ac38-b3682cbb5bd1"));

            migrationBuilder.DeleteData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: new Guid("ba2cb5a5-e808-4866-b855-a7847312642b"));

            migrationBuilder.DeleteData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: new Guid("d9b7e0c0-fb8f-42eb-a78d-03b5d923ff3e"));

            migrationBuilder.DeleteData(
                table: "Homework",
                keyColumn: "HomeworkId",
                keyValue: new Guid("e2b44ca8-308a-4821-bb14-5835516dce45"));

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: new Guid("10f52d01-9248-44d9-b3ca-260ef748bb0b"));

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: new Guid("32fc1451-c215-44e8-93ae-90e4fc4278b2"));

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: new Guid("452ed2e4-14b8-4928-9675-76ac7133d888"));

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: new Guid("be0f845d-35bc-4305-a191-7501a8ce6288"));

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: new Guid("c4da5e22-7d86-481f-a12a-cc3082fffcbd"));

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: new Guid("c517c22c-8397-4142-b28b-90606e65d5c8"));

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: new Guid("d0f99b73-6a3e-4fd9-9996-807451895047"));

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: new Guid("eab12f16-26d9-422d-8491-6bac0e4102c3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("105976e5-60f9-4d45-bc41-fcff852b944c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("10624f46-1955-489c-8a65-332a543a9217"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("360f4c40-f2f1-4e8c-9efe-f4c59e2478cf"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("3d438e36-794b-46e8-946e-23f3f678aa7c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("489f71fb-4540-4a4a-a0be-cf1197eff1c5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("4f6198a2-f481-4da4-8b14-38c936376cc9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("8d172fdd-390f-495a-a1ca-de823e3aa8d0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("909ca786-e345-4fc2-a879-68103417153a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("a3372115-f08b-4fbc-bf6f-e8bcb51edd0c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("b0afe890-45be-4120-948b-01d0d0ca7132"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("bcc202a0-a93f-46cf-8e8d-5235a5f58494"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("c97bf746-4fd9-4aeb-902f-114391cc8223"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("e40a911f-bc54-4fab-980d-a15649a41b9f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("fe0ae279-9c1d-483b-ac13-d495c9066925"));

            migrationBuilder.DeleteData(
                table: "StudentsCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("2f19ce22-0795-4e88-96f4-aa85ffe36962"), new Guid("7d96f2c1-243b-4dcf-8663-37a01fce18a6") });

            migrationBuilder.DeleteData(
                table: "StudentsCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("2f19ce22-0795-4e88-96f4-aa85ffe36962"), new Guid("b6b3a02f-5f0f-48ee-b9d9-28fb879b4ac0") });

            migrationBuilder.DeleteData(
                table: "StudentsCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("53b4f7f8-90d6-48ee-9aac-697f31e5c697"), new Guid("ca5ed15a-09fd-4f1f-950d-e96f1880c1a1") });

            migrationBuilder.DeleteData(
                table: "StudentsCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("da56f125-4a16-4266-9016-98fd08e906c1"), new Guid("d939edb6-20c9-482a-9dba-da282381e179") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("28e996f0-b7ea-4b87-9a79-b7e7aaeaf851"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("2f19ce22-0795-4e88-96f4-aa85ffe36962"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("47da47dc-d519-476d-9658-e47b8be267c9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("53b4f7f8-90d6-48ee-9aac-697f31e5c697"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("c6aabad0-e171-4cd4-bfe6-c18a75fa05c2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("da56f125-4a16-4266-9016-98fd08e906c1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("f5b1e826-31ad-44ad-9068-aec15291d27f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("62f43b67-9869-40c8-9fd4-96082c319d4a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("7d96f2c1-243b-4dcf-8663-37a01fce18a6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("b6b3a02f-5f0f-48ee-b9d9-28fb879b4ac0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("ca5ed15a-09fd-4f1f-950d-e96f1880c1a1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("d939edb6-20c9-482a-9dba-da282381e179"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("f2f94084-9d4d-4f5e-ae54-4b908e687227"));
        }
    }
}
