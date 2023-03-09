using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sales_db.Migrations
{
    /// <inheritdoc />
    public partial class InitData_Bogus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CreaditCardNumber", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("00373c06-4e02-4d58-9547-17996bb7c951"), "3586-2142-2393-7171", "MaddisonMetz.Miller2@yahoo.com", "Maddison Metz" },
                    { new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), "3529-2913-2235-2528", "LaurianeLedner.Hahn52@gmail.com", "Lauriane Ledner" },
                    { new Guid("0246410b-4d96-44af-82b4-ebc400b3a0cc"), "3442-521706-91689", "BlairSchamberger0@yahoo.com", "Blair Schamberger" },
                    { new Guid("04ba6a9f-696f-4d5c-9833-705bb469e2dd"), "3037-289433-4785", "CieloPouros.Schumm@hotmail.com", "Cielo Pouros" },
                    { new Guid("05f42d54-3260-4d1e-9993-023a3364253c"), "4573459341774", "TheodoraHills.Nitzsche@hotmail.com", "Theodora Hills" },
                    { new Guid("063bedc9-e7e2-4ca1-94e9-ccd504b62676"), "4102-9086-7650-2811", "AbbigailMosciski97@hotmail.com", "Abbigail Mosciski" },
                    { new Guid("071fa576-d2ec-4921-b85e-38e7597ba362"), "3017-522415-6426", "CarrollOrtiz66@yahoo.com", "Carroll Ortiz" },
                    { new Guid("083db417-09e2-4957-add4-cc572d6d68ac"), "5249-8874-7590-1096", "AldenReynolds.Harris@yahoo.com", "Alden Reynolds" },
                    { new Guid("089b8d95-39e4-4c12-9b88-c55e11ee4384"), "6767-2923-1404-0529-547", "HildegardCollier83@gmail.com", "Hildegard Collier" },
                    { new Guid("09bf205a-3cdf-422e-ad56-3309326cbab7"), "6541-6281-4893-3434-3915", "GertrudeHayes.McLaughlin86@gmail.com", "Gertrude Hayes" },
                    { new Guid("0aa736f1-f3d3-4102-8378-8852b0209540"), "3656-289194-7704", "TevinBrekke_Wisozk32@hotmail.com", "Tevin Brekke" },
                    { new Guid("0b2d6596-da4d-472c-b589-ba86fbb51228"), "4819241050599", "EldonStreich.Emmerich@yahoo.com", "Eldon Streich" },
                    { new Guid("0bc83152-1b52-4e73-9d9d-018c9df1f0b1"), "6759-9763-6522-6571", "RayBlock80@yahoo.com", "Ray Block" },
                    { new Guid("0d4f6119-3a03-4678-8ee4-03d8609f1e0f"), "6394-7405-6026-4352", "EliseLangworth57@hotmail.com", "Elise Langworth" },
                    { new Guid("0dd2b1e0-35f6-426c-a362-bdccdbdfd993"), "6476-6279-2356-8028-8698", "AlfredoLemke.Gibson83@yahoo.com", "Alfredo Lemke" },
                    { new Guid("0e9aa538-3735-4ee3-ba7f-c0276fb63e37"), "5442-3449-9705-1963", "WillardMuller.Lindgren18@yahoo.com", "Willard Muller" },
                    { new Guid("0ef56a2f-737f-4526-a3e0-2b828e1caa6a"), "6771-8920-8796-8172", "WavaFisher9@yahoo.com", "Wava Fisher" },
                    { new Guid("101502a4-814f-4fa6-91ed-3a3354fc00ee"), "3437-621828-00939", "MaxOReilly.Murphy99@gmail.com", "Max O'Reilly" },
                    { new Guid("11302c6b-ac35-40d7-9bc2-9424bb030aac"), "6759-9104-0499-4801-64", "GenevieveKshlerin.Ortiz38@hotmail.com", "Genevieve Kshlerin" },
                    { new Guid("11605186-1ba3-44eb-9e92-5ffeb515dadc"), "4235585147026", "FrancesWillms.Padberg@hotmail.com", "Frances Willms" },
                    { new Guid("11868bef-205d-45c5-965e-4d5425f07582"), "3528-1549-6470-6693", "TamaraGutmann.Rippin70@hotmail.com", "Tamara Gutmann" },
                    { new Guid("11c6e451-28ab-46cf-8208-56ea4a33d06d"), "6767-8215-0854-8760-04", "LaurianeRaynor11@yahoo.com", "Lauriane Raynor" },
                    { new Guid("14ce0167-2370-4105-b76b-40d21516cd1c"), "4454266299788", "SydnieSchaefer.Kihn16@yahoo.com", "Sydnie Schaefer" },
                    { new Guid("16f30c53-759d-4401-86d1-4b11ecdaafe1"), "5018205484669084978", "BlairBashirian86@gmail.com", "Blair Bashirian" },
                    { new Guid("16f528a5-51d6-40df-9452-5df3520ec9e3"), "5018-0385-2233-3508", "MacyWalker_Cartwright36@yahoo.com", "Macy Walker" },
                    { new Guid("17d639a6-94e2-4151-8bea-ee91b3bef90d"), "6759-7953-8690-3328-059", "EffieLuettgen.Nienow69@gmail.com", "Effie Luettgen" },
                    { new Guid("18a5a14a-4841-4579-ad61-1da0335a37fc"), "6771-8913-7727-4127", "LucienneOConnell_Hand@yahoo.com", "Lucienne O'Connell" },
                    { new Guid("19d6f951-cf4c-4c48-afc7-c2002d262888"), "5893153328911612763", "KristyToy_Wisoky88@gmail.com", "Kristy Toy" },
                    { new Guid("1a77b978-5e97-4734-b5b8-7d62493695bf"), "3615-690141-6055", "EthylHyatt14@hotmail.com", "Ethyl Hyatt" },
                    { new Guid("1bef9411-ca8b-4a5d-ac97-4e27db017776"), "5529-5753-8458-8234", "VernieHuels.Macejkovic@yahoo.com", "Vernie Huels" },
                    { new Guid("1c3c8731-b571-4c68-8945-85ea73279c26"), "6759-7610-6389-6412-53", "AbelardoCorkery_Murphy@yahoo.com", "Abelardo Corkery" },
                    { new Guid("1db2fed9-2576-4164-aea3-ffeb946a2d22"), "6373-4641-9277-5447", "SherwoodHegmann20@gmail.com", "Sherwood Hegmann" },
                    { new Guid("1e38c399-c3ab-4d3f-8b09-53a6ed83b8b3"), "3498-312192-21163", "LoisPfannerstill.Gutkowski72@yahoo.com", "Lois Pfannerstill" },
                    { new Guid("1eeb5a4f-4620-487b-abeb-3ae527c60cb4"), "6767-9587-9924-4925", "JustineWalsh.Fadel97@yahoo.com", "Justine Walsh" },
                    { new Guid("1fd8a043-ff67-475c-9058-0be9b7ce02d6"), "4568-2038-5580-0534", "CornellParker.Frami99@yahoo.com", "Cornell Parker" },
                    { new Guid("21909259-174c-4df4-a256-0362f3a50eee"), "3464-876462-43107", "ClementineKoepp_Rohan44@yahoo.com", "Clementine Koepp" },
                    { new Guid("2257a4bc-8152-4802-a0be-7128f81badb4"), "6771-8946-2589-7277", "GildaSipes_Sawayn@yahoo.com", "Gilda Sipes" },
                    { new Guid("226f91fb-3e90-4267-b29f-63e73babbde9"), "6771-8993-7378-9865", "MarjoryHettinger.Gerhold@yahoo.com", "Marjory Hettinger" },
                    { new Guid("27e17383-0dd8-44b7-adb4-c69c010e05cf"), "3728-627178-04796", "JoannyHilll65@gmail.com", "Joanny Hilll" },
                    { new Guid("28bf8cc1-e847-49e7-869d-beeea93e248b"), "6474-7254-8897-7907", "EmmyLakin.Batz@yahoo.com", "Emmy Lakin" },
                    { new Guid("294a8657-9937-4036-a447-d16850fe5782"), "3037-419648-8848", "VeldaLind_Sanford@yahoo.com", "Velda Lind" },
                    { new Guid("29760ae0-9d50-4169-98b5-e8c19bb2afbd"), "6759-8080-8919-7788-36", "HerminiaHickle_Yundt@gmail.com", "Herminia Hickle" },
                    { new Guid("298a220e-dbab-45fe-ab54-11f88fb7ed21"), "6376-8438-0583-0565", "WestonHerzog31@hotmail.com", "Weston Herzog" },
                    { new Guid("2ab8ab6e-9e85-4dcc-93b6-54fe89898925"), "50180022612762482649", "LynnWiegand_Emmerich@hotmail.com", "Lynn Wiegand" },
                    { new Guid("2acef602-341a-4206-a5b6-fb90adfeb02c"), "5421-2731-6418-5434", "LarissaBashirian.Christiansen50@yahoo.com", "Larissa Bashirian" },
                    { new Guid("2c6491d5-6880-4ea9-a3bf-7f6246681c91"), "6771-8949-4354-3868", "JenaAbbott80@gmail.com", "Jena Abbott" },
                    { new Guid("2d30fc7e-97b9-45c4-8f49-d70002001e63"), "4269-7141-3762-7794", "VictoriaDach_Mayer@gmail.com", "Victoria Dach" },
                    { new Guid("2fc1c63b-296b-464a-97e2-85bac2145887"), "6383-7931-9916-3787", "CharlottePouros_Schaden27@hotmail.com", "Charlotte Pouros" },
                    { new Guid("304330be-690b-4110-b8a8-d5388be5199d"), "5157-8208-8196-7260", "ShemarJakubowski45@gmail.com", "Shemar Jakubowski" },
                    { new Guid("30870746-1473-42b2-89db-e71b154da464"), "3033-207490-1407", "AdrainFrami_Wolff@gmail.com", "Adrain Frami" },
                    { new Guid("313e5424-d225-4502-a658-163ce40ea2b0"), "6706139044597314721", "CornellLind15@yahoo.com", "Cornell Lind" },
                    { new Guid("32a5fca3-94fd-4ef2-909b-240795610f7a"), "6767-2127-3188-8534", "VivaYost.Daniel@hotmail.com", "Viva Yost" },
                    { new Guid("332863f7-3dc3-4135-b202-6b19e9c76f7f"), "4264-9036-2001-7994", "MelanyDurgan_Kertzmann@gmail.com", "Melany Durgan" },
                    { new Guid("35c6c61a-62db-46fc-9f04-be55330567c5"), "5122-0748-3594-5699", "ClementinaRaynor_Conn46@yahoo.com", "Clementina Raynor" },
                    { new Guid("37d4b579-b66d-45a1-b8fc-302511580be4"), "6761-6015-5915-0009", "SamEmmerich.Heaney@hotmail.com", "Sam Emmerich" },
                    { new Guid("38fb8e6f-856a-404e-a8f4-37c21a039b3a"), "6767-9908-4541-9805", "LeraFritsch_VonRueden57@yahoo.com", "Lera Fritsch" },
                    { new Guid("391097ab-1125-4542-bc95-51dafc44fa63"), "677180867275033990", "JavonMoen_Quitzon@hotmail.com", "Javon Moen" },
                    { new Guid("3a3f87f2-a41a-4233-90d3-0bd0cd9c0376"), "6011-0730-5429-3858", "RozellaGoyette5@gmail.com", "Rozella Goyette" },
                    { new Guid("3b0b942f-1e75-495e-88d0-c8e1410e36e7"), "3613-964534-3298", "LanceGraham.Konopelski@hotmail.com", "Lance Graham" },
                    { new Guid("3b4328c4-d5ea-4a37-9131-0e64500e410b"), "6759-7789-6405-8456-247", "MikeNicolas89@yahoo.com", "Mike Nicolas" },
                    { new Guid("3b642cb4-5d11-465c-b026-54ff384e20ad"), "6771716953580698", "OrrinCartwright47@yahoo.com", "Orrin Cartwright" },
                    { new Guid("3b67657d-dce5-4f0b-a39d-0d003d51508c"), "3529-6961-5620-2286", "MadisynLehner.Corkery@hotmail.com", "Madisyn Lehner" },
                    { new Guid("3c84c9c6-977f-454d-a006-6cf027f882c3"), "3726-470894-22800", "DanikaHansen97@gmail.com", "Danika Hansen" },
                    { new Guid("3c8b4389-36ff-401b-be28-1d1d40d51636"), "6771-8910-4773-0482", "MarlinWisozk_Willms27@yahoo.com", "Marlin Wisozk" },
                    { new Guid("3cf08740-516b-49d2-a9ab-33881f42d9e9"), "6771-8961-5993-5738", "LaneyTurcotte_Hartmann24@yahoo.com", "Laney Turcotte" },
                    { new Guid("3d0a2fdb-7d99-4ecc-ad0a-2d9ffcbd898c"), "6759-2233-3104-0392", "JodySchmeler_Nienow42@gmail.com", "Jody Schmeler" },
                    { new Guid("3dc380de-e009-4a1a-9307-6ff44916f3c0"), "6376-6276-9977-2581", "CelestinoMedhurst.Bartell51@hotmail.com", "Celestino Medhurst" },
                    { new Guid("3e72ed4a-cfb2-487e-b643-31c37b3b1f15"), "3472-845720-06338", "RussellKutch.Wilderman72@gmail.com", "Russell Kutch" },
                    { new Guid("3e8acb3d-cf08-49e2-b1ef-211849a536d3"), "6771-8905-5933-3032", "DaphneyHintz.Bogan60@yahoo.com", "Daphney Hintz" },
                    { new Guid("3f12640c-8b74-41fc-b247-aaed49be710b"), "5305-2843-6541-4722", "RafaelaKuphal.Murray@gmail.com", "Rafaela Kuphal" },
                    { new Guid("41f993f6-6104-4a31-83e6-7dee0d09a14d"), "3529-7671-3355-2331", "JaylinSchamberger_Bergstrom81@hotmail.com", "Jaylin Schamberger" },
                    { new Guid("43470b25-1514-462a-943a-bb9007da4cea"), "6759-1369-7821-5905", "EdwardoBechtelar.Haley@gmail.com", "Edwardo Bechtelar" },
                    { new Guid("4409a542-637d-478a-8f7e-021c52191a6c"), "630401851340226112", "HaroldMcCullough39@gmail.com", "Harold McCullough" },
                    { new Guid("452b89b8-cfd2-44d4-bd5a-9182e75ab8b6"), "3799-176861-39732", "TamaraCassin_Klocko38@yahoo.com", "Tamara Cassin" },
                    { new Guid("45d20759-d0cb-4e13-8a88-f7dc27a55106"), "6759-3722-7592-5116", "SusieTreutel_Kirlin@gmail.com", "Susie Treutel" },
                    { new Guid("4604c797-5c61-44f6-aaa3-7145745745f4"), "6578-7876-8821-9022", "CiceroTurner.Trantow@gmail.com", "Cicero Turner" },
                    { new Guid("4643ab8a-9570-42c6-95f7-ffd89daa9909"), "6706646159528961", "DallinErdman_Schmeler@hotmail.com", "Dallin Erdman" },
                    { new Guid("47b796b5-0b18-44b6-bd97-1ee4230d5766"), "6304023309875169128", "DelphineHegmann_Lind@yahoo.com", "Delphine Hegmann" },
                    { new Guid("48842d5c-41aa-4b71-994b-0b77a926b283"), "6759-6963-2123-1742-895", "MaryKessler.Pouros@gmail.com", "Mary Kessler" },
                    { new Guid("491264e9-6585-4938-bb6f-52aee9adfb58"), "4533671377964", "NorwoodVandervort_Wiza2@hotmail.com", "Norwood Vandervort" },
                    { new Guid("4a28cef0-425f-4928-9444-330471c01d26"), "3528-4991-6956-8855", "NestorJohns35@yahoo.com", "Nestor Johns" },
                    { new Guid("4b8d567a-2ddc-431d-af05-b624ed0e0a19"), "3548-9936-1552-3221", "CordieMarvin.Gleichner89@hotmail.com", "Cordie Marvin" },
                    { new Guid("4ca0286b-acb2-41ec-aff8-ac729009fcfc"), "4034640099540", "PascaleFrami.MacGyver95@hotmail.com", "Pascale Frami" },
                    { new Guid("4d44d5dc-e82b-4d9e-9010-96a29e6db30d"), "5485-0382-9131-6621", "ArleneGleason.Boyer96@gmail.com", "Arlene Gleason" },
                    { new Guid("4d84a65a-1422-4ea0-b457-74f32ee2b4a0"), "5104-8968-7957-0997", "GarnetDaugherty52@gmail.com", "Garnet Daugherty" },
                    { new Guid("4dba79f0-1e09-435f-8118-7d44d97ca44f"), "5038-8561-9511-9359", "ShainaWatsica.Carter@yahoo.com", "Shaina Watsica" },
                    { new Guid("4dc1770e-1ae0-45d9-9cb5-7382e43bca8c"), "3041-977412-2754", "AdriannaJohnson88@yahoo.com", "Adrianna Johnson" },
                    { new Guid("4e0ecf7e-4fa0-447e-9aaf-96ede014dbc1"), "3788-623322-04962", "DanteMcGlynn60@hotmail.com", "Dante McGlynn" },
                    { new Guid("4e4b9cd2-2119-4a17-a90c-a0780869008d"), "5486-6563-1160-8732", "TinaEmard50@hotmail.com", "Tina Emard" },
                    { new Guid("4f2517a6-675b-40d7-bbc4-293d794a15be"), "4788105356501", "LeoTreutel81@hotmail.com", "Leo Treutel" },
                    { new Guid("4f673abc-99d6-4762-93f9-7fe5fc15ebc7"), "6759-6498-9518-9995", "GiovaniBednar_Friesen71@yahoo.com", "Giovani Bednar" },
                    { new Guid("50814a7d-2032-4948-a0cd-8fb5be80abbd"), "3654-278796-3395", "LuciusLakin.Gusikowski@yahoo.com", "Lucius Lakin" },
                    { new Guid("543b0114-a800-4aa2-a603-31381e4d1090"), "6771-8901-8171-2629", "GladyceSchultz41@yahoo.com", "Gladyce Schultz" },
                    { new Guid("5623f896-434c-4881-b4e1-7bb1f383ccab"), "6461-6291-1241-0283-3045", "TiannaProhaska_Pollich@gmail.com", "Tianna Prohaska" },
                    { new Guid("586ea4de-61ae-4680-904d-3f38626dd4f4"), "5145-4721-1692-8991", "VitaBreitenberg_Fisher8@gmail.com", "Vita Breitenberg" },
                    { new Guid("5a475a0a-817f-4903-80a9-03844df45abc"), "58938494423936208254", "KailynCrona_Fahey@hotmail.com", "Kailyn Crona" },
                    { new Guid("5a4e1636-fc23-460a-b940-19f85569903b"), "3528-8971-1594-3884", "MarilyneBrekke_Johnston35@yahoo.com", "Marilyne Brekke" },
                    { new Guid("5a76e354-f54a-4de1-bb7f-b5c83009bd14"), "5475-5109-0348-5780", "StevieBradtke88@yahoo.com", "Stevie Bradtke" },
                    { new Guid("5c25c2eb-377c-4e18-8d1c-0c71f8014116"), "4247954077718", "FreemanHoppe_Rath@yahoo.com", "Freeman Hoppe" },
                    { new Guid("5c54ec39-0658-4b0c-b87f-f28261c82d8a"), "6771-8921-4670-9617", "DaytonSmith25@gmail.com", "Dayton Smith" },
                    { new Guid("5cea64c0-2733-4d46-8447-43cf7d211606"), "6706324742404294", "LitzySchowalter42@hotmail.com", "Litzy Schowalter" },
                    { new Guid("5d61cc14-4acc-49c6-953c-a06ede85d68e"), "6379-2071-0044-8027", "AnnabelWindler.Kuhn@hotmail.com", "Annabel Windler" },
                    { new Guid("5e6f2ce2-5b8d-4f57-b617-7c488cc86e04"), "4388-6895-4115-5309", "DarrylSatterfield.Osinski@yahoo.com", "Darryl Satterfield" },
                    { new Guid("5ea7515d-02b5-4ecf-8f4d-b3b4da1ee261"), "6371-2351-0991-6783", "BerneiceBahringer_Mills28@hotmail.com", "Berneice Bahringer" },
                    { new Guid("5f119466-d2ab-48a2-879a-281ed32381b7"), "3660-323824-1516", "MathewCronin.Stokes@gmail.com", "Mathew Cronin" },
                    { new Guid("5f2c4c29-5783-4d51-8519-a58a0c521953"), "6759-1394-9601-9759", "CotyJones17@yahoo.com", "Coty Jones" },
                    { new Guid("612a39a6-edba-46d1-919f-c2dc914ec303"), "3530-7686-0923-6836", "CelestinoKihn71@gmail.com", "Celestino Kihn" },
                    { new Guid("625544e8-3799-45f7-af8d-0880df358a1a"), "6011-3242-8021-0228", "GageKilback54@yahoo.com", "Gage Kilback" },
                    { new Guid("62ba5ad0-8b90-412a-ab28-960964512520"), "6759-3122-6941-2862-343", "KatarinaDenesik51@yahoo.com", "Katarina Denesik" },
                    { new Guid("6306f65d-a823-4e59-a3a4-c8079746d1db"), "6771-8963-8004-3765", "FelixWill.Effertz18@gmail.com", "Felix Will" },
                    { new Guid("6598672c-d41d-4b28-bfc4-c8e5d984de3d"), "6706948965256278", "SkylaHirthe71@gmail.com", "Skyla Hirthe" },
                    { new Guid("66d2b104-0c29-4884-b7f4-343863796a42"), "6767-0342-2292-1628", "AmosBorer.Pagac@yahoo.com", "Amos Borer" },
                    { new Guid("67e99788-a630-42eb-8e20-1e08fa9b9e05"), "4394934423578", "CheyanneRomaguera37@hotmail.com", "Cheyanne Romaguera" },
                    { new Guid("6861e4a3-845b-4b0d-82d4-eba107d13973"), "5020-4723-5330-2009", "CandaceLueilwitz_Hodkiewicz61@hotmail.com", "Candace Lueilwitz" },
                    { new Guid("6c19a64d-7798-4cb4-aa65-b49fc9ca8640"), "6388-7433-6532-1276", "LinnieHowell_Hegmann42@gmail.com", "Linnie Howell" },
                    { new Guid("6c4743b4-4b93-440f-a17f-1a65921abed6"), "670941952033050596", "MyraAufderhar70@yahoo.com", "Myra Aufderhar" },
                    { new Guid("6e8c4b98-e32d-49d7-9643-bf3bdc87833f"), "6399-9334-5156-6283", "JanyRuecker_Rippin@gmail.com", "Jany Ruecker" },
                    { new Guid("6f21d5e9-14f1-4d14-b2d5-34aa2d634bf2"), "6392-2108-8137-9018", "GonzaloStrosin_Grant@hotmail.com", "Gonzalo Strosin" },
                    { new Guid("709c587c-2fe7-4461-9c6c-e2bde6259435"), "67595224616135881", "MorganWehner_Romaguera75@hotmail.com", "Morgan Wehner" },
                    { new Guid("7135cfea-d206-44ef-ab4b-0ea6bce0a8de"), "6706272942083451", "MyrticeBogan33@hotmail.com", "Myrtice Bogan" },
                    { new Guid("715bb6ae-d8d5-4f15-85f5-ce7b578db90f"), "3772-359572-19246", "DejaRunolfsson.Glover@hotmail.com", "Deja Runolfsson" },
                    { new Guid("7200f080-f18d-476c-aa59-b2525bb35397"), "3529-5934-5647-5292", "ChristyOHara90@yahoo.com", "Christy O'Hara" },
                    { new Guid("72279ce1-90e9-4991-bf78-5a44c7141215"), "6011-1899-3369-9634", "NathanHarber.Jones57@hotmail.com", "Nathan Harber" },
                    { new Guid("73bf2996-d8cf-47ea-821f-acc4148ff045"), "6759-4762-6459-5580", "JaydeBosco_Reinger@gmail.com", "Jayde Bosco" },
                    { new Guid("761f62ca-9fa1-44af-8922-908019991893"), "6304759472020248", "DaronErdman36@hotmail.com", "Daron Erdman" },
                    { new Guid("79306a12-a866-4d72-b627-836388db6708"), "6370-7213-4913-0443", "DaynaGreen_Shields@yahoo.com", "Dayna Green" },
                    { new Guid("7aea5ab1-7e4f-46f5-90c8-376f7fd8d4cf"), "6011-8056-1281-8001", "KelvinBahringer_Hessel@yahoo.com", "Kelvin Bahringer" },
                    { new Guid("7d34acbb-b10c-4e4d-9655-c2e154225db3"), "3588-7952-6855-7187", "JalonBecker_Schuster@gmail.com", "Jalon Becker" },
                    { new Guid("7e4035a3-17a0-4090-af1e-29fee1430604"), "6706070795272368883", "LloydStamm35@hotmail.com", "Lloyd Stamm" },
                    { new Guid("7e914d1f-5ed7-4d95-92e8-2090ceddb918"), "3774-458884-37276", "BridieKeebler99@yahoo.com", "Bridie Keebler" },
                    { new Guid("7edfe933-43a3-4eba-a6f8-a7cd2a6d679a"), "6501-6202-9830-6179-2694", "CathrynOKeefe.Gutkowski@yahoo.com", "Cathryn O'Keefe" },
                    { new Guid("7fee85e3-195e-4d55-a8d3-88a3de43075a"), "6767-2817-7366-4552-06", "PearlineFahey70@hotmail.com", "Pearline Fahey" },
                    { new Guid("8023ab03-5f7c-4e05-918b-99a1dd63523e"), "6767-1163-1380-5636", "BartholomeWitting77@hotmail.com", "Bartholome Witting" },
                    { new Guid("8094f472-bbbf-410f-85cd-e10af91427a2"), "5482-9869-3537-7966", "MarilyneVolkman.Johns@gmail.com", "Marilyne Volkman" },
                    { new Guid("80cf3ca7-a975-4695-b5fb-918dae6ed791"), "5361-1420-9180-3686", "RoyLegros9@hotmail.com", "Roy Legros" },
                    { new Guid("8153bc36-e19a-41bb-8fc9-cc16e582e12a"), "6759-7800-2227-2857", "IleneCarter91@gmail.com", "Ilene Carter" },
                    { new Guid("82f7c26d-445a-4d98-bf7a-a8869c0ac9d8"), "3570-4674-3296-9538", "CordiaBogan26@gmail.com", "Cordia Bogan" },
                    { new Guid("838fc902-cac8-4661-baae-090e4444d771"), "6759762506394738", "DarylOReilly_Williamson@hotmail.com", "Daryl O'Reilly" },
                    { new Guid("860b9c0d-4d09-4cb2-bccf-af7dbbc57614"), "6594-6295-3691-5228-1076", "KipBahringer.Collins@hotmail.com", "Kip Bahringer" },
                    { new Guid("874b4d3a-8370-47d5-8139-8a570d0aa011"), "4548-0461-7593-9432", "CarlieNolan_Wehner65@gmail.com", "Carlie Nolan" },
                    { new Guid("892c7f49-c3a9-4da2-9b4c-dbe18ad11bae"), "3452-009185-79863", "BlairOlson36@gmail.com", "Blair Olson" },
                    { new Guid("8981bd9b-e4db-4959-b7ac-e4b2e4c50db1"), "3052-044262-7155", "DarrickFahey_Lakin@gmail.com", "Darrick Fahey" },
                    { new Guid("8a08ac00-a89a-4372-bd9f-a8323a10bfa9"), "6759-8267-6533-6272-51", "JustineRath.Harris@yahoo.com", "Justine Rath" },
                    { new Guid("8a1ce844-2965-4163-b386-2b63a4f58851"), "67628716746080157648", "AndreaneRogahn33@gmail.com", "Andreane Rogahn" },
                    { new Guid("8a37250e-e49a-41cb-bbbd-77801ee7465b"), "6706424245043702393", "KaceyPfannerstill96@gmail.com", "Kacey Pfannerstill" },
                    { new Guid("8a629f77-cd54-4a19-bf4f-1ca7aa5bde6c"), "67596380214930114560", "CamdenMaggio_Greenfelder@yahoo.com", "Camden Maggio" },
                    { new Guid("8b291089-c9ff-4386-bf52-991fceca8aee"), "3529-5301-3680-3576", "KeanuErnser_Wuckert13@yahoo.com", "Keanu Ernser" },
                    { new Guid("8b359242-c3a3-4892-825c-50100d445cc4"), "6392-9826-9667-5687", "VerlieAuer_Dietrich49@gmail.com", "Verlie Auer" },
                    { new Guid("8bc49753-24c6-42a3-b343-92963e56528f"), "6448-7026-1105-2125", "ArvelDeckow46@gmail.com", "Arvel Deckow" },
                    { new Guid("8c645dd8-3d6e-46b3-b6f8-c5a3741275ab"), "5038-4116-0749-4196", "MosesBrakus.Hintz41@gmail.com", "Moses Brakus" },
                    { new Guid("8ded2b63-cd3d-49a8-ace9-1a9059cbbb5b"), "3036-751274-4803", "DanSchuster_Howell76@yahoo.com", "Dan Schuster" },
                    { new Guid("8dfba9c2-6fb3-41b5-82bd-199955600771"), "6370-1235-8896-2281", "KasandraAufderhar.Harber80@hotmail.com", "Kasandra Aufderhar" },
                    { new Guid("8ecba903-2fb7-492c-8e04-efc7c9092978"), "4022-8060-1801-0989", "MontanaOConner.Farrell@gmail.com", "Montana O'Conner" },
                    { new Guid("90e92391-b9e2-4087-abae-f0d2135208d3"), "6767-8121-0578-1288", "DarrellDoyle_Schamberger88@yahoo.com", "Darrell Doyle" },
                    { new Guid("90efb1a7-9fda-4881-8f46-a3db8eb8b4c0"), "6304465909403466", "NataliaTrantow23@yahoo.com", "Natalia Trantow" },
                    { new Guid("91387b1c-01af-488b-869b-a02dd69a397d"), "6759-0476-5133-0418", "CiaraHuels63@gmail.com", "Ciara Huels" },
                    { new Guid("9161dfd9-7b40-4b82-9e2d-54acea626727"), "3545-7899-0035-7223", "AmieRohan85@hotmail.com", "Amie Rohan" },
                    { new Guid("92cf116b-37b4-4969-9c96-0ab057c28b9e"), "6771-8937-7303-9054", "VernieFisher41@gmail.com", "Vernie Fisher" },
                    { new Guid("92fb9af4-125d-4001-b7d1-bb6fca29af9e"), "6771-8914-5780-4231", "ShaniyaMarks.Stracke@gmail.com", "Shaniya Marks" },
                    { new Guid("930f40d2-a2d6-4268-9edf-3b57280139e0"), "6706346399794706346", "CaleCarter.Stamm@hotmail.com", "Cale Carter" },
                    { new Guid("934f2ef5-2300-4401-b20d-1c2f173fac66"), "6759-6042-4824-1791-730", "FredPadberg.Steuber@hotmail.com", "Fred Padberg" },
                    { new Guid("94449fd1-29d1-4bae-ae96-f701497d956a"), "3748-836143-22540", "PerryJohnson24@hotmail.com", "Perry Johnson" },
                    { new Guid("96986915-7327-45be-beae-1e855daf0cee"), "3528-6507-1009-2155", "LeraGoyette41@yahoo.com", "Lera Goyette" },
                    { new Guid("96a4cb3a-1df6-4fee-91c2-34d23e34c565"), "6767-1995-0259-9457-938", "AlvenaMorissette_Gorczany@yahoo.com", "Alvena Morissette" },
                    { new Guid("976268ea-42d3-4fab-b043-521ab3f13b99"), "6394-4136-3954-0885", "EthaEmmerich.Doyle@yahoo.com", "Etha Emmerich" },
                    { new Guid("97727f47-63b6-461c-8fa5-29df8b6d7fbc"), "4452835466540", "MableWolff.Watsica@hotmail.com", "Mable Wolff" },
                    { new Guid("981496d5-b4e2-438c-bb35-eb72d105f034"), "6444-7774-3483-9985", "SalvatoreGraham.Kling@yahoo.com", "Salvatore Graham" },
                    { new Guid("997f2580-ba31-47d3-bb5d-d918a844e539"), "6391-0185-9314-5671", "VanessaWyman38@yahoo.com", "Vanessa Wyman" },
                    { new Guid("99af15d7-9207-4092-b6f8-d26de05d54b7"), "3773-174717-09678", "AraStreich52@gmail.com", "Ara Streich" },
                    { new Guid("9aaa03ce-12dd-4260-82df-4ff4ebf35e70"), "3529-0978-4212-9225", "AmeliaSimonis_Boyle69@gmail.com", "Amelia Simonis" },
                    { new Guid("9b1a7970-043a-4451-98b2-9aa334b9b573"), "6372-0689-1746-3774", "IdellaConsidine.Ebert@gmail.com", "Idella Considine" },
                    { new Guid("9c1aca97-812a-4ac9-9d22-cdfb090b7892"), "6399-6726-6237-9132", "KaleighSchuppe41@gmail.com", "Kaleigh Schuppe" },
                    { new Guid("9ca43921-d48f-401c-942d-f64ac8eb5017"), "3037-987518-3131", "JudyStehr_Thompson@gmail.com", "Judy Stehr" },
                    { new Guid("9cbd8b7d-2535-4949-9f01-57608feb9857"), "6011-6222-8388-3240-1265", "AntoninaTremblay.Leffler@yahoo.com", "Antonina Tremblay" },
                    { new Guid("9cc46072-3731-478d-a421-43bd26bb24c2"), "3017-401551-7193", "JoanneMarvin95@hotmail.com", "Joanne Marvin" },
                    { new Guid("9d7bf66d-da11-4ef3-a267-baa226a0a451"), "6558-3475-2668-5712", "TiaraParisian18@hotmail.com", "Tiara Parisian" },
                    { new Guid("9ee4eeb0-6f90-4fc7-b97a-5369f799b515"), "3759-998336-77339", "JaidaBeahan71@gmail.com", "Jaida Beahan" },
                    { new Guid("9ef678b8-7a80-4c8e-99c9-f3b82de4e62b"), "6771091068991608917", "JacklynCorwin_Hamill@gmail.com", "Jacklyn Corwin" },
                    { new Guid("a0cf03a8-e043-44d4-85ac-0a5ad46479a8"), "3704-896369-78816", "IcieCarroll15@yahoo.com", "Icie Carroll" },
                    { new Guid("a279d282-45bb-4577-ad07-d02770bbf8aa"), "6759-9184-8919-9094-42", "ArdithGutmann4@gmail.com", "Ardith Gutmann" },
                    { new Guid("a2c6dd43-693a-4740-9694-1d0a146a48fd"), "6505-0645-9458-9155", "JefferyGottlieb95@hotmail.com", "Jeffery Gottlieb" },
                    { new Guid("a322667b-cf5c-4292-b5c0-f19f6b71e172"), "6011-6265-9702-5837-0761", "AugustusHilll_Crooks@gmail.com", "Augustus Hilll" },
                    { new Guid("a4051b07-7780-48eb-b674-b0fea252ba43"), "6392-1448-3872-2329", "ZettaSwift.Schuster@hotmail.com", "Zetta Swift" },
                    { new Guid("a4ac028f-e8f4-468b-83a1-c7d256c9b72b"), "6392-4737-1082-8601", "NehaReichel.Wisozk22@yahoo.com", "Neha Reichel" },
                    { new Guid("a4f1819b-cf5c-457a-b423-ac1885a47a72"), "6474-0583-5182-7383", "ReeseHudson92@gmail.com", "Reese Hudson" },
                    { new Guid("a53544d6-4362-4dd8-971d-a44ef67506d9"), "3779-416156-99121", "HallieGraham92@yahoo.com", "Hallie Graham" },
                    { new Guid("a5933513-0701-4fb0-8cc1-aad15a694526"), "5038-8086-0177-1224", "FilibertoRatke_Yost30@yahoo.com", "Filiberto Ratke" },
                    { new Guid("a64cfc3a-f1bf-4099-a403-4272b730d212"), "6457-0101-3506-7571", "JaleelStracke90@yahoo.com", "Jaleel Stracke" },
                    { new Guid("a70e2d36-4fe9-418a-be27-0beaabfe0569"), "6767-3021-9834-1333-560", "OthaPurdy_Bailey@yahoo.com", "Otha Purdy" },
                    { new Guid("a7a0ba7a-6bfd-4e13-9a46-e21bbbfeac05"), "3758-452110-57562", "AlvahBoyle65@hotmail.com", "Alvah Boyle" },
                    { new Guid("a7f7b1f6-4097-4154-b36f-6d2ba7195879"), "6706445940515399", "KrystalBahringer_McDermott@yahoo.com", "Krystal Bahringer" },
                    { new Guid("a93b628a-1214-40e5-bdec-72c7705c440d"), "3446-840055-28845", "RyderWeber.Lubowitz76@gmail.com", "Ryder Weber" },
                    { new Guid("a9d6efef-456d-4b7a-bdf0-0a34ea80fb8a"), "3528-0738-4436-7148", "ElyssaKertzmann46@hotmail.com", "Elyssa Kertzmann" },
                    { new Guid("aa519cdc-d7d7-4fa3-a18b-3ddd3df9cd9b"), "4685-9154-7726-6038", "BufordToy74@yahoo.com", "Buford Toy" },
                    { new Guid("ab5b0421-6888-4aa9-8592-fa30a8499631"), "6767-8645-2876-0531-17", "MaximillianCole65@gmail.com", "Maximillian Cole" },
                    { new Guid("ab8c8d0b-3a5a-46b4-a314-ca8e39adf3db"), "6771591798620672", "DonnyBernier.Altenwerth@gmail.com", "Donny Bernier" },
                    { new Guid("acfe314c-6956-4a41-bcf2-22de2e940bb7"), "4982-3923-4856-4746", "AntoniettaHoeger.Lind@gmail.com", "Antonietta Hoeger" },
                    { new Guid("ad0489cc-a03b-4022-a604-795caaa7aeda"), "3753-148735-37171", "BarrettNader.Jakubowski@yahoo.com", "Barrett Nader" },
                    { new Guid("ad4c7128-a7d3-473c-8ec7-2a4881ed3da5"), "3557-4981-6647-5670", "AnastacioMorissette13@hotmail.com", "Anastacio Morissette" },
                    { new Guid("adaee3b7-5a3d-47d9-ac36-0ee0b69b6689"), "501897504289118345", "CaitlynRoob_Mann69@hotmail.com", "Caitlyn Roob" },
                    { new Guid("add6146a-f6a5-4e91-8f8a-c770310ba9fd"), "6759-1194-5289-8350-281", "WillardMcCullough_Heller@yahoo.com", "Willard McCullough" },
                    { new Guid("ae9ece20-8ffb-4e66-9c41-fee16d043e18"), "3529-7932-4979-5085", "AmosDicki.White@gmail.com", "Amos Dicki" },
                    { new Guid("aef60cbb-b544-447e-b60e-9ddc9557dbce"), "6304141028733337", "JeromyMarks_Lockman90@gmail.com", "Jeromy Marks" },
                    { new Guid("afa579ad-7b70-49cc-870d-d2edad106536"), "6767-8288-8907-0946", "ZacharyPfannerstill7@gmail.com", "Zachary Pfannerstill" },
                    { new Guid("b00a45d3-a191-4b88-87a6-0664462624b2"), "5038-2537-7490-2860", "KimberlyMacejkovic9@hotmail.com", "Kimberly Macejkovic" },
                    { new Guid("b0194f0a-9bb7-4cb1-9f60-6a6412e3457e"), "6759-9725-0225-3431-15", "ElainaKshlerin.Greenfelder@hotmail.com", "Elaina Kshlerin" },
                    { new Guid("b02de585-06a9-4e31-9367-c9c70a981d33"), "6767-3528-6932-1138", "ZettaVandervort_Schowalter@hotmail.com", "Zetta Vandervort" },
                    { new Guid("b17362e4-c5ca-42fc-8d0b-c54939bfb2d0"), "6767-3943-0919-8001-55", "MiguelSpinka.Mayert90@yahoo.com", "Miguel Spinka" },
                    { new Guid("b19f23bf-ef36-4b56-be76-65f691e344a5"), "4275439561659", "ClaudeKuvalis_Bahringer@hotmail.com", "Claude Kuvalis" },
                    { new Guid("b2b37e2b-e611-4cf6-898a-974bacd3be35"), "6767-1051-2513-5944", "KielMorar.Koss95@yahoo.com", "Kiel Morar" },
                    { new Guid("b2da9b51-a60a-4214-bc40-e3e20b8f4bb4"), "67635167471446727534", "MarvinJaskolski.Mohr@gmail.com", "Marvin Jaskolski" },
                    { new Guid("b37e93b3-4dd6-4e62-8c1b-f6921bce2458"), "6767-2368-3240-4801-359", "TravonRosenbaum.DuBuque59@hotmail.com", "Travon Rosenbaum" },
                    { new Guid("b4054f78-88d1-4cf9-a20c-53ac2b40c6d5"), "6767-2882-8223-1050", "EthaPagac.Kozey98@hotmail.com", "Etha Pagac" },
                    { new Guid("b4552f58-2d57-4e89-b3e9-68234090f84e"), "630484597148806908", "EraAbshire_Walter@gmail.com", "Era Abshire" },
                    { new Guid("b97a715e-f53f-4aad-97b8-423c36d90521"), "6398-5187-1790-4328", "BusterMertz_Breitenberg68@yahoo.com", "Buster Mertz" },
                    { new Guid("b982941d-b76c-43b3-87fa-0b037a7390f3"), "4430823825380", "BryonJakubowski.King34@hotmail.com", "Bryon Jakubowski" },
                    { new Guid("b9904365-c49c-4c80-8ace-9b7381cf82c3"), "4980102553798", "MiguelBarrows.Leffler49@yahoo.com", "Miguel Barrows" },
                    { new Guid("baebb6af-a215-45ee-a56f-8874b8589745"), "6771-8992-7964-3885", "EnidDurgan.Harber87@hotmail.com", "Enid Durgan" },
                    { new Guid("bb1d8b6c-0b99-49b9-92d0-b93825fa1d85"), "6767-6136-7479-7779-39", "KeshaunFeil.Kulas60@yahoo.com", "Keshaun Feil" },
                    { new Guid("bc698c5c-5f41-47a0-b3ee-72a5e70251e5"), "5441-2080-6521-2123", "ZulaDietrich78@gmail.com", "Zula Dietrich" },
                    { new Guid("bdaa5241-8229-4028-998a-2f66dd64dc3d"), "3528-0498-1411-0023", "WaltonDonnelly.Schinner83@gmail.com", "Walton Donnelly" },
                    { new Guid("bdecfd56-4525-4411-93d7-6cd21c6df38f"), "6595-6208-0272-6617-3549", "AimeeDonnelly_OKon@hotmail.com", "Aimee Donnelly" },
                    { new Guid("be36c0e2-8ae4-42e7-a0ec-760fb75dd03d"), "4544426853373", "JaylonShanahan_Greenfelder95@hotmail.com", "Jaylon Shanahan" },
                    { new Guid("bf3863f4-35e6-479d-b42a-572d8ee8595e"), "6759-4909-4940-2243-166", "LaishaMcLaughlin.Nader@yahoo.com", "Laisha McLaughlin" },
                    { new Guid("c05ae179-3239-49f9-8f89-5449dbd6ddea"), "6759-5157-8176-8943-61", "AmaniMayer69@gmail.com", "Amani Mayer" },
                    { new Guid("c2f4ddf8-eff6-413d-a1e9-133753dae671"), "6767-1777-5151-1290-36", "RahsaanWalker_Collier3@hotmail.com", "Rahsaan Walker" },
                    { new Guid("c6ec473f-1328-44d7-99c8-ff8b2240cdad"), "5465-5823-9138-0577", "BennieSteuber_Williamson@hotmail.com", "Bennie Steuber" },
                    { new Guid("c77df024-d263-4cf0-8587-1e007b3f3d88"), "6767-5785-4020-7499-596", "AlvertaWalsh.Kessler@hotmail.com", "Alverta Walsh" },
                    { new Guid("c78646a8-4496-4809-92c4-515097bcdf6b"), "5424-9493-9566-9430", "SethWisozk.Carter@hotmail.com", "Seth Wisozk" },
                    { new Guid("c78d8e53-5ee8-40b3-b850-333ee55b407c"), "6011-6228-9946-2179-1962", "AntoniettaCarter.Smitham@hotmail.com", "Antonietta Carter" },
                    { new Guid("c7b9ad78-1a20-4d41-88d4-c9ed6be916e1"), "6370-0977-7284-5967", "WillardWard37@hotmail.com", "Willard Ward" },
                    { new Guid("c7dc4c14-68e2-4ab7-8dd7-95e8a890272e"), "3702-553978-85163", "DamarisOsinski.Kirlin@yahoo.com", "Damaris Osinski" },
                    { new Guid("c8a1a514-d3ea-4718-9616-b7c471de0821"), "6573-6292-6898-7926-0907", "ConcepcionHermiston73@yahoo.com", "Concepcion Hermiston" },
                    { new Guid("c9e32bf1-4bde-42e7-8556-8e6a688eb23a"), "6759-4322-1436-1052", "PerryStreich_Farrell@hotmail.com", "Perry Streich" },
                    { new Guid("cb18a9be-ad75-40bf-8571-ffa9a83c20d6"), "6761-8095-9703-3786", "HassanWalter33@hotmail.com", "Hassan Walter" },
                    { new Guid("cb4b48e2-a134-4f56-86aa-754ce2c8e764"), "670991790963513137", "DevanMcLaughlin.Gaylord7@hotmail.com", "Devan McLaughlin" },
                    { new Guid("cb6e4c12-7182-45d6-aa14-bfa9548f58c7"), "6759-7054-1856-8412-198", "MaximilianKihn_Hackett61@yahoo.com", "Maximilian Kihn" },
                    { new Guid("cc285fbc-99ae-42bd-ab7d-2f15fc4aad31"), "6771-8984-1498-7512", "AdeleAbernathy_Haley25@yahoo.com", "Adele Abernathy" },
                    { new Guid("cd2c96a9-920d-475e-9468-c06decb4a2d2"), "3691-053591-8161", "MurrayStanton.Ward0@gmail.com", "Murray Stanton" },
                    { new Guid("cf8397f5-605a-4203-b714-c545339f2d3f"), "5893775992047876259", "DahliaHeaney1@hotmail.com", "Dahlia Heaney" },
                    { new Guid("cf84380c-2070-454e-a96b-aff6ab90a5a2"), "3548-5626-4118-7101", "StephonKerluke72@gmail.com", "Stephon Kerluke" },
                    { new Guid("d057de0d-38f7-4fc1-847b-e463eecba9d7"), "6709245808504635", "DorotheaTillman.Lesch@yahoo.com", "Dorothea Tillman" },
                    { new Guid("d05bb8cd-15c4-49fd-be32-1de4ba9d1b79"), "3641-452394-2507", "EladioDouglas90@yahoo.com", "Eladio Douglas" },
                    { new Guid("d0c93df0-94ba-43d4-9d2a-e3c73e43d3b5"), "5018-4557-7373-3618", "ChazSchmidt.OHara14@hotmail.com", "Chaz Schmidt" },
                    { new Guid("d138e71f-25de-4e43-901b-9836238dde40"), "6771-8972-9647-8590", "TellyKiehn78@yahoo.com", "Telly Kiehn" },
                    { new Guid("d162a50e-f969-426b-a0db-4daff944c570"), "6398-2821-6715-9111", "BrittanyBode_Hirthe@hotmail.com", "Brittany Bode" },
                    { new Guid("d1cdb36c-7dec-414c-8e9e-d2977cc4ebee"), "6767-8792-8193-4272-81", "ChristianaHaley_Shields@gmail.com", "Christiana Haley" },
                    { new Guid("d379f767-38d0-4503-964c-17e0c7a8e0e1"), "6011-0867-0953-3320", "PatsyMiller.Cartwright@gmail.com", "Patsy Miller" },
                    { new Guid("d4cec878-838f-4b15-abcd-4aee59d4d716"), "5038-1858-7480-1941", "HildegardHermiston.Rowe@yahoo.com", "Hildegard Hermiston" },
                    { new Guid("d4d9683d-0aa7-4340-97d8-32f2ac3f2116"), "5893371617617737", "WillTromp.Blick@yahoo.com", "Will Tromp" },
                    { new Guid("d4ecc6e4-d312-44e6-acdf-d77fe40a0307"), "630415265689174839", "GertrudeHamill.Dickinson@gmail.com", "Gertrude Hamill" },
                    { new Guid("d60b7b16-aaac-4a12-9fc1-117cf4648ed9"), "6391-7134-9498-6377", "AnnetteChamplin.Bergstrom80@hotmail.com", "Annette Champlin" },
                    { new Guid("d683cc1b-399b-478e-9a40-a9f4c3a4ded9"), "4530-2387-1438-9746", "KathleenKrajcik.Wyman81@gmail.com", "Kathleen Krajcik" },
                    { new Guid("d7f5c695-60da-4386-b4d2-7d54800fb111"), "5020-6023-8913-1424", "JasminHilll_Yundt73@yahoo.com", "Jasmin Hilll" },
                    { new Guid("dbd0cc8c-1de6-40a2-bdde-afd30b73991d"), "4241176631360", "WinfieldStark.Kiehn31@hotmail.com", "Winfield Stark" },
                    { new Guid("dc5f680d-d700-4b85-b29c-53b360ea7b5d"), "3757-396194-48293", "EusebioSchulist72@hotmail.com", "Eusebio Schulist" },
                    { new Guid("dc80305b-99b7-4065-9e60-3d2e4179992d"), "3752-809249-77544", "AlfordDickens_Bradtke28@hotmail.com", "Alford Dickens" },
                    { new Guid("de84146c-ad45-4de1-98c2-44e06e5d3d1b"), "4313869597057", "OttoCollier53@gmail.com", "Otto Collier" },
                    { new Guid("e0aa11ee-7315-4927-ba55-a80abebdb53b"), "6767-3010-7415-8025", "MerlinMueller.Hilpert97@yahoo.com", "Merlin Mueller" },
                    { new Guid("e1720543-6fdb-46b2-8136-a85b1b0d653a"), "3529-9790-8900-1078", "AlizaZemlak.Hermann@hotmail.com", "Aliza Zemlak" },
                    { new Guid("e3175ccd-17ec-497b-a62b-5e3190a5f4db"), "6759-1839-5564-1232", "ShaniyaRunolfsdottir_Hintz15@gmail.com", "Shaniya Runolfsdottir" },
                    { new Guid("e318eaaf-b3bf-4296-820a-4b1f3f5f18aa"), "4895513701200", "LoraineKemmer22@yahoo.com", "Loraine Kemmer" },
                    { new Guid("e432b26e-b841-41d5-bae7-4c92a110d46d"), "6378-1123-8457-9631", "RobbGulgowski_Spencer@gmail.com", "Robb Gulgowski" },
                    { new Guid("e5821424-1d7d-414e-bb66-a29211cd7a3a"), "3006-324723-4133", "BrendanJast_Hyatt@gmail.com", "Brendan Jast" },
                    { new Guid("e5bf91cb-58f9-4d16-a06b-e6ebeec86a14"), "4496315152948", "NoemieSawayn.Parisian@hotmail.com", "Noemie Sawayn" },
                    { new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), "4906179856947", "JarrodJohns39@gmail.com", "Jarrod Johns" },
                    { new Guid("e76ecc40-807f-49ec-9fea-0c2a490c3c2e"), "5285-2476-5827-5229", "ElfriedaJerde.Ryan@yahoo.com", "Elfrieda Jerde" },
                    { new Guid("e7eb0d45-a9c5-41cc-980e-cc1e3a2c95eb"), "6771227040562079", "MichelHuels.Bins6@gmail.com", "Michel Huels" },
                    { new Guid("e97d257f-bf6b-4611-a7f5-e4ae64c6ad62"), "3438-627763-68630", "EffieHeidenreich10@hotmail.com", "Effie Heidenreich" },
                    { new Guid("ea81d272-071b-43ef-8026-0caa4252049d"), "6767-1499-7727-7180", "ToyHamill_Schroeder50@yahoo.com", "Toy Hamill" },
                    { new Guid("ea9742ba-fd08-4f20-bcce-09a423a953a6"), "3689-649468-6115", "EnriqueHaag42@gmail.com", "Enrique Haag" },
                    { new Guid("eb7f9df3-a7b7-48c3-a2d7-52fb61635269"), "6767-9407-9670-9974-78", "MarcelinoThiel_Heidenreich@yahoo.com", "Marcelino Thiel" },
                    { new Guid("eb878efd-252a-44a0-8cbd-4483957b7126"), "6387-4951-0393-4842", "ZionLowe.Wiegand9@hotmail.com", "Zion Lowe" },
                    { new Guid("ec2411c6-c2db-43ae-bfda-475224e7fd87"), "5534-1156-0701-8181", "HendersonHodkiewicz.Crona@gmail.com", "Henderson Hodkiewicz" },
                    { new Guid("ed6c9aff-d305-48a5-82f0-4249c28a5a0f"), "6771390917198995", "KadenMiller.Daniel@yahoo.com", "Kaden Miller" },
                    { new Guid("ed8d9fc6-63bc-41cb-be62-b4b2819c5a41"), "6771-8945-8309-1392", "DennisRobel.Funk65@gmail.com", "Dennis Robel" },
                    { new Guid("ef864a63-d7cc-4fff-b36b-541425bbeb87"), "6304262621621818", "StefanieCarter_Hettinger36@hotmail.com", "Stefanie Carter" },
                    { new Guid("f1a1c775-37f4-4749-9b82-ee85728ca066"), "6382-1083-8986-2463", "WardHeaney19@yahoo.com", "Ward Heaney" },
                    { new Guid("f2a80af9-dadf-41e0-b334-a7d635156bbf"), "4745-0596-5627-5417", "FurmanNolan50@hotmail.com", "Furman Nolan" },
                    { new Guid("f2b1b9ce-9414-4aca-b32e-debbb04df920"), "6759-9181-6684-3317-749", "GregorioStiedemann_Fahey@gmail.com", "Gregorio Stiedemann" },
                    { new Guid("f31eb920-0f0b-44ca-848e-6727f08249a1"), "3400-872216-15442", "DarleneWatsica.Schneider@hotmail.com", "Darlene Watsica" },
                    { new Guid("f3e602ed-9619-4699-9b35-295165099839"), "6767-2605-8119-8170-096", "MartinHeller_Swaniawski91@gmail.com", "Martin Heller" },
                    { new Guid("f4a6f90b-8fa9-472c-9ac2-3dd425ab5b53"), "6487-6227-1727-3061-0334", "QuentinToy_Wilkinson40@gmail.com", "Quentin Toy" },
                    { new Guid("f4c095bf-9527-4722-8938-9573140e2e43"), "4741902828388", "OralBernier_Hyatt@yahoo.com", "Oral Bernier" },
                    { new Guid("f4cac37c-f4e1-4370-a5fc-bb67e78b22be"), "6762136075323321594", "GerhardPowlowski.Dickinson31@gmail.com", "Gerhard Powlowski" },
                    { new Guid("f5d1128e-bd1f-4bdd-b0b8-e0989384492e"), "3616-515281-0700", "ChanelleHettinger.Wilderman73@yahoo.com", "Chanelle Hettinger" },
                    { new Guid("f64f6eae-b5ff-4f94-a09e-0858eab94236"), "6767-8250-5512-2027-274", "LetitiaMcKenzie_Rogahn@hotmail.com", "Letitia McKenzie" },
                    { new Guid("f6b545ed-5e58-4adb-a5d7-5ea9774c671a"), "6706093714366910", "TrevaDenesik.Daugherty@gmail.com", "Treva Denesik" },
                    { new Guid("f7bcd955-ccbf-4286-8c07-fc7940dcbcc3"), "3529-2247-8619-4094", "FrancesLittle52@hotmail.com", "Frances Little" },
                    { new Guid("f8cfb4c0-d45a-41dd-9db7-d0ddf8f00222"), "6759-0125-2960-0286-883", "DeltaConroy63@hotmail.com", "Delta Conroy" },
                    { new Guid("f99cf6c2-bb0d-485d-b880-d4e63bd69044"), "3529-1005-0174-9190", "RickeyFisher_Mayert5@hotmail.com", "Rickey Fisher" },
                    { new Guid("fae85c92-f85b-470f-8fc0-5fe6de486ea0"), "6771-8920-4570-4198", "GideonSchuppe_Howell@yahoo.com", "Gideon Schuppe" },
                    { new Guid("faeffa2d-dafa-4405-9509-4a82d65d7383"), "5018-7840-9312-6694", "IsidroDach_Stamm@gmail.com", "Isidro Dach" },
                    { new Guid("fb1f55ac-3dd9-41af-8edb-d4ef091e8727"), "3714-977494-05030", "MadonnaMarquardt.Rempel66@gmail.com", "Madonna Marquardt" },
                    { new Guid("fc002c5b-2658-4b15-9b15-8eabb861b8eb"), "6759-6232-6315-9195", "AlvinaRussel_Herman@gmail.com", "Alvina Russel" },
                    { new Guid("fc429def-e6b6-4359-82b0-bdb4f6af6995"), "3798-724928-76003", "MaryamRoberts_Kreiger@yahoo.com", "Maryam Roberts" },
                    { new Guid("fd9bbb27-cc2c-451c-b3f3-19b247ffbeb4"), "5479-4885-7062-1316", "AlejandraFisher_Borer@gmail.com", "Alejandra Fisher" },
                    { new Guid("fdf3439d-fec8-40af-8f3b-ca45c0f7c3ba"), "670689560220179098", "CalebRowe55@hotmail.com", "Caleb Rowe" },
                    { new Guid("fee0e8e9-9abc-42f4-8649-4295a3a42ee0"), "6706857108064806", "NelleMcCullough.VonRueden@gmail.com", "Nelle McCullough" },
                    { new Guid("ff2863f2-8f09-47a6-a01e-416ca71c7d3e"), "6767-3523-8240-0619-08", "MagnoliaWolf.Torp83@hotmail.com", "Magnolia Wolf" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("00ae8ab2-551d-4165-b705-056b80b8ec07"), "dolorem", 38122.14104553387724252m, 8327 },
                    { new Guid("013bc638-3922-4a45-a5ed-eee902ad3d32"), "animi", 1752.373328280373180912m, 624 },
                    { new Guid("02666dfb-4f2a-4b74-863d-03a539febf82"), "laudantium", 7125.659253209999063264m, 899 },
                    { new Guid("03eff380-419a-4d7b-8557-62e8975580ca"), "quaerat", 50784.10487531921027748m, 6776 },
                    { new Guid("0bc5aa7f-11e3-4f53-9d4f-0833d8f5b7fd"), "corrupti", 98987.23346683991581379m, 7958 },
                    { new Guid("0cc30948-4285-49f7-bbb1-d5e59d4dc676"), "itaque", 64720.9624691884313999m, 9943 },
                    { new Guid("0f366117-3708-464c-a360-6bf0c8a4a4b7"), "iste", 94254.28081677756757895m, 3385 },
                    { new Guid("10cc2e40-fc93-401a-ba19-7acd728710af"), "incidunt", 74996.43422032080598737m, 4660 },
                    { new Guid("183ea002-b003-430b-83e3-5c7310bb9599"), "beatae", 56980.39681099592635822m, 3740 },
                    { new Guid("1a4918fb-7f31-4314-9a38-a897e604f672"), "culpa", 35641.0499492498616591m, 1373 },
                    { new Guid("1ab78ed3-216a-44a1-bb6a-0daa37f6a353"), "quidem", 73148.02480381183351882m, 6908 },
                    { new Guid("1d20f579-8e4b-45b6-b558-e6cdbb12f930"), "qui", 35066.22503668323755917m, 1642 },
                    { new Guid("21008cd3-c241-4701-b0b4-3d455755a602"), "labore", 53744.73915168419126502m, 1386 },
                    { new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), "voluptas", 4460.369243154791704676m, 9114 },
                    { new Guid("23d1768b-4f7a-4571-b5c4-ec4622a57fa7"), "dolores", 70396.12453842902695644m, 5002 },
                    { new Guid("28fe5968-83fd-46cf-ad8d-d43091403014"), "qui", 71575.76851759808436118m, 9610 },
                    { new Guid("2c87c429-b687-4696-bcd0-7b0e6a968661"), "delectus", 17263.01594627887861322m, 4473 },
                    { new Guid("320eee41-7832-4d18-9ef0-7888b3afaeb5"), "deserunt", 48012.19797392085563313m, 4756 },
                    { new Guid("3249956f-60b7-4970-9ca6-de681d2ae9cf"), "omnis", 83993.74596852413191022m, 7705 },
                    { new Guid("35c51a64-2724-4738-b543-6cc85e8c8b05"), "sit", 21560.15546815834702249m, 452 },
                    { new Guid("36d2f49a-3bbc-4da8-9922-9fc128a19a5c"), "quidem", 76023.55254779555954616m, 2519 },
                    { new Guid("386e8542-8536-45eb-a51a-3900f8db79a2"), "accusamus", 74839.52155564076432839m, 7880 },
                    { new Guid("38af6c1b-60af-4634-8c22-7d66ecd87887"), "nobis", 70578.94756185281032239m, 3713 },
                    { new Guid("3a12acfb-bcd2-445e-a610-d9c6a8c3c3d7"), "dolore", 97433.6518377313514436m, 2972 },
                    { new Guid("409c864c-9989-4089-b488-b87d2c0d9933"), "consequatur", 74302.0502170346661257m, 6853 },
                    { new Guid("43eea13e-8bca-4aed-b74f-83ef9a3bd24b"), "ut", 23913.58183721818765018m, 2133 },
                    { new Guid("4577c43d-0029-4d02-8611-8a115da71e80"), "voluptates", 14370.23253163120534883m, 3037 },
                    { new Guid("482604c0-71bb-4b63-a835-cb505f83231c"), "possimus", 82122.47691390291121078m, 4478 },
                    { new Guid("49efe4e0-2598-4253-8e28-13aa1355b441"), "ratione", 52024.34243612933633564m, 2445 },
                    { new Guid("4aa491ff-7177-4c86-8204-9c9da29d9979"), "repudiandae", 31303.08374321250219164m, 7187 },
                    { new Guid("4bd8aa05-938b-4c93-9af2-a2964f3342f8"), "eveniet", 10434.03401196442093716m, 3577 },
                    { new Guid("4daa55b1-8c1f-4aba-9888-9b3eefa01e65"), "omnis", 44014.69629057247555572m, 9114 },
                    { new Guid("4df396a5-e951-4871-a4d7-94ca24ea9edf"), "ratione", 92804.71844853231241539m, 9585 },
                    { new Guid("4efc17ba-6851-4a49-8494-a9fb9406264a"), "odit", 67388.87231184172231353m, 8105 },
                    { new Guid("54623980-f15f-47eb-87af-67f780c49754"), "sed", 57900.86818495993686096m, 6647 },
                    { new Guid("558a4bec-3fa6-4e00-b900-bca8afe789c2"), "sapiente", 3414.569771577286821134m, 5735 },
                    { new Guid("58658c9d-423a-4930-8ff8-e666dba6386c"), "vero", 58954.22766413214257978m, 8882 },
                    { new Guid("5c61f97e-1701-47dc-8742-9aa2cb04ce43"), "reprehenderit", 86533.39334761324542606m, 9601 },
                    { new Guid("5d1b337e-c7ff-4a45-a120-e1a53734d31b"), "et", 66428.84797533352324m, 7067 },
                    { new Guid("64c0f454-9c6a-4c41-8559-3931127ef833"), "est", 61421.86582434817061737m, 1042 },
                    { new Guid("657fc828-462b-45de-8281-6339f50f3d4a"), "nemo", 47228.31743948662960623m, 3828 },
                    { new Guid("68a02d54-6900-492d-8dde-599d11304e7d"), "minima", 56872.47681154893873026m, 508 },
                    { new Guid("6a153bd7-716e-4382-acc8-cb092f0fc41b"), "aut", 13408.53571811501468927m, 9598 },
                    { new Guid("71c5bae5-2cca-439b-86c1-805612205647"), "eos", 71943.85514626945342803m, 7487 },
                    { new Guid("74d117b3-2827-4c4d-8ef9-89de1a0e8d4b"), "quidem", 8049.157476641225799486m, 2747 },
                    { new Guid("795302ec-26d9-435c-a283-29d4e19eec52"), "deserunt", 33640.1023591171559629m, 3600 },
                    { new Guid("79abe60b-45b9-41a1-a74b-6869b5d9ad4d"), "et", 22764.25235246695707519m, 7911 },
                    { new Guid("7bb2f6f5-dda2-490b-a066-354e5e58361e"), "illum", 86336.43595527313128094m, 6787 },
                    { new Guid("7c29f4cf-4546-4535-9b0b-ef82b6cc57fd"), "ea", 30530.37308518681419223m, 5042 },
                    { new Guid("7c6533ac-3e1d-487f-bbc3-62b98c7fc7d8"), "maxime", 77114.73731173701218905m, 3031 },
                    { new Guid("7f8a102c-3ffa-4b72-ae85-c5a76505f640"), "alias", 85017.31931640926667677m, 9204 },
                    { new Guid("8005b4e9-f8e9-427a-a055-a4b1a5548f58"), "aliquam", 34321.15016110168836347m, 7925 },
                    { new Guid("8252ec2a-9853-43bc-92a4-eb66d6a6c150"), "voluptates", 92615.38057440117026036m, 2754 },
                    { new Guid("83ac8196-0126-4512-a2c5-5384f0669c17"), "ipsa", 70657.53986378231269174m, 1024 },
                    { new Guid("853290ec-d3f6-4e00-8c1a-a48f5a0e8e23"), "dolores", 87532.97983616327226862m, 890 },
                    { new Guid("857814db-30bc-4efb-9bda-7b70788835aa"), "qui", 30052.07013047326119547m, 8749 },
                    { new Guid("858355f1-c18a-4874-9e41-ab684bfc936a"), "occaecati", 68599.20204438776434543m, 3776 },
                    { new Guid("89366499-029a-4f8a-a4cb-9b0096df8882"), "quibusdam", 58712.26194940612825166m, 5782 },
                    { new Guid("8a43b274-0d45-4f18-9e41-9d572650a477"), "sequi", 70553.28060459474077016m, 2492 },
                    { new Guid("8b484b0f-e761-4b28-bcdf-1efa4e0ca725"), "quo", 73716.10070069065994194m, 363 },
                    { new Guid("8c8e4af7-5665-41da-8ee1-9bbf1c9ab202"), "in", 92385.5009616846297973m, 8684 },
                    { new Guid("9da24f28-7322-4cbb-8a0a-8e494662a7e3"), "voluptatibus", 87250.26772142931894359m, 3040 },
                    { new Guid("9e1350d9-0e3d-4910-b630-256f4f479d1f"), "pariatur", 60031.56003043081432333m, 6401 },
                    { new Guid("a4b81067-94cc-49b8-8cd6-2981bd54a3d4"), "aut", 60385.35890468317850682m, 2244 },
                    { new Guid("a795cdce-aac4-41e4-85d4-f57a4d68faa4"), "nihil", 62265.38635744497731186m, 828 },
                    { new Guid("a91b7e35-affd-43dd-adf3-12c8757201b6"), "consectetur", 38024.89378434933789351m, 8642 },
                    { new Guid("ad1ea74b-1133-401f-aeb6-91fb82e57e9d"), "quos", 91559.99650766026858656m, 9297 },
                    { new Guid("af444ce0-8f98-4a85-84b4-fb6f4c6438d7"), "ipsa", 99229.95164147685264794m, 7851 },
                    { new Guid("b01d1026-6ad9-4e90-bb89-4ffd486a3dee"), "ad", 55685.00462299308753242m, 7474 },
                    { new Guid("b7028e6c-d93f-49e1-a4cc-7d819d66cf4a"), "rem", 773.3553100886575604209m, 4625 },
                    { new Guid("b8956161-0915-4567-9590-f92a1fbed67c"), "quia", 83000.07876853100325396m, 3309 },
                    { new Guid("b9bcd671-d8ef-4e49-838c-6beb119f62f2"), "dolor", 2490.330747347473597929m, 8540 },
                    { new Guid("bfdf6627-c5e2-41bf-97c0-e400f8ddcca5"), "soluta", 71851.03815716388315966m, 5357 },
                    { new Guid("c9075353-6480-4dd7-83f4-4b673765b374"), "corrupti", 66686.43133388798572701m, 1840 },
                    { new Guid("cb9b7478-afa0-4a8e-9ec3-fdbda129b183"), "amet", 24314.3645467895107765m, 8349 },
                    { new Guid("cbaccb98-b545-4b10-b6b8-4c02c04a2f40"), "doloremque", 84549.62437067341201544m, 92 },
                    { new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), "et", 14682.48586696564360659m, 3671 },
                    { new Guid("cf4d630e-121c-4240-8896-f496cd4731ff"), "et", 65800.97111136006926395m, 9703 },
                    { new Guid("cf8873e1-a2ef-42c8-a5dd-c4c3e2bb5955"), "nesciunt", 31684.193637419384839m, 1612 },
                    { new Guid("d04f10f9-8f62-4bec-859b-a7e750e50428"), "et", 96201.03537320811596194m, 1861 },
                    { new Guid("d06e51d5-ec3b-4308-9988-4b64b9063528"), "commodi", 83530.64277483388347629m, 4104 },
                    { new Guid("d3a12e33-6d40-4dd4-93e4-cf8a70aed034"), "nisi", 88036.90460860551405244m, 5973 },
                    { new Guid("d5071c14-31d4-4b90-b8b2-625b84f50478"), "ipsum", 18379.36417167287647939m, 2143 },
                    { new Guid("da07d7f8-6e16-452c-9a1b-9dd5f9ec3e62"), "explicabo", 32759.56706753979855129m, 2146 },
                    { new Guid("dad1173a-e7af-43cf-a60b-df255d0ae96b"), "reprehenderit", 32008.73409024223314156m, 9045 },
                    { new Guid("dc9f2767-bf91-45c5-b488-8de4e042eae0"), "itaque", 38661.67592008894823225m, 1619 },
                    { new Guid("e6719eba-2243-4eb3-9b5f-a06405c46b35"), "eveniet", 67734.57249170755171172m, 8772 },
                    { new Guid("e77eac57-2531-4b73-8377-912950b0f69e"), "quis", 9234.813943483025944925m, 6137 },
                    { new Guid("e8a174cb-65b7-40e3-9053-036123260f87"), "neque", 85069.22982240532061098m, 9916 },
                    { new Guid("e920a850-8155-4d64-8aca-9ff656b9ad00"), "autem", 30075.36447018222344489m, 9215 },
                    { new Guid("eb0a4078-948d-4488-bc48-ae7a5d397db7"), "adipisci", 78681.79763994832615368m, 446 },
                    { new Guid("f0447f2c-e34a-4009-bc39-fc0777819ca5"), "neque", 64071.663191841730371m, 454 },
                    { new Guid("f375e8f7-5ec9-4cc5-b39b-55a66dcf6d9c"), "quasi", 19706.43509552210405466m, 1546 },
                    { new Guid("f3f534e5-a401-46b2-b9da-6594c147a075"), "consectetur", 73454.90658845822402999m, 4729 },
                    { new Guid("f598c18a-7c6c-422e-8ad3-0f859c83caf8"), "reprehenderit", 41825.21040998268929245m, 5221 },
                    { new Guid("f9b7df7c-88e9-4bdd-a7a4-22ef8309c9a5"), "provident", 5771.37648006041675191m, 146 },
                    { new Guid("fdc734a7-4e5f-489f-90c4-ca81c1f2218e"), "quod", 94207.74322390926752372m, 373 },
                    { new Guid("fdce191a-66e0-44eb-941d-f66f7ed697c4"), "fugiat", 58134.95126418815651194m, 4512 },
                    { new Guid("fe3d3337-e762-41ab-ad3b-0df4359a03bd"), "dolore", 32992.36108948886950494m, 5026 },
                    { new Guid("ff691c13-976a-4fc4-9023-6f2e98866e1a"), "neque", 91912.29708425834242494m, 1699 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[,]
                {
                    { new Guid("07ff37d9-c017-4785-8f02-91cf373b9bb8"), "id" },
                    { new Guid("21e2d819-f50d-427b-87e9-5e3af85d5fa2"), "nobis" },
                    { new Guid("285b2dba-ec21-4d69-8e29-bd7cb2098b87"), "explicabo" },
                    { new Guid("2d2894f8-5239-4065-8ab5-6671554d1243"), "sit" },
                    { new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd"), "praesentium" },
                    { new Guid("34bf8621-29c9-4449-afb2-14e6bb137370"), "numquam" },
                    { new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61"), "vitae" },
                    { new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b"), "ea" },
                    { new Guid("4d192f92-ad4f-41de-ab5d-1d8daaa79af1"), "officiis" },
                    { new Guid("666c85e6-de13-4149-88db-9084c01e3bb2"), "ut" },
                    { new Guid("72b29e5e-d0aa-452d-8875-9895ca4095a7"), "molestiae" },
                    { new Guid("79bf5306-406d-4cd2-a5c8-8b33122125d3"), "voluptatem" },
                    { new Guid("81e6f268-e679-4563-8dbf-6b16193d769a"), "veniam" },
                    { new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f"), "sit" },
                    { new Guid("92d11367-2610-4694-8de6-b68926918aef"), "dolorem" },
                    { new Guid("948c69b1-ea9c-40e4-9468-fddf67fea795"), "cumque" },
                    { new Guid("94b496f6-f020-4fb6-b4f3-17ef5d6bbed6"), "amet" },
                    { new Guid("97fdbbd6-4b14-4972-821e-6ad645791d71"), "velit" },
                    { new Guid("9a46cf1f-1a6e-4f76-a56c-ab6bd00274f6"), "eveniet" },
                    { new Guid("a020f341-4ef8-421a-adf1-840e62c5c593"), "saepe" },
                    { new Guid("a7b82c28-fae9-40be-ace8-c110285ff23d"), "natus" },
                    { new Guid("a7dc9e6c-d2bc-4ea4-9a61-af8ea65f5b0d"), "quasi" },
                    { new Guid("d333f141-b417-463e-9561-a675c062453c"), "nobis" },
                    { new Guid("e068b748-dff4-482e-84f3-394957affb5b"), "minima" },
                    { new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf"), "est" },
                    { new Guid("e732ebd3-9d68-4919-99b1-bacaf283ea5a"), "sint" },
                    { new Guid("e740f243-8c1b-4cd0-af1e-eab8411830f2"), "magnam" },
                    { new Guid("ea118175-296c-4869-a7bd-109332145d60"), "ratione" },
                    { new Guid("f37fde46-1469-4cf6-b52b-133a237a04ad"), "quisquam" },
                    { new Guid("fd9ba93c-26ea-4614-bbd8-0ed54229ea1f"), "eos" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[,]
                {
                    { new Guid("03610b5b-4037-4054-a84f-ecadc7b1a664"), new Guid("b00a45d3-a191-4b88-87a6-0664462624b2"), new DateTime(2019, 7, 18, 11, 22, 39, 787, DateTimeKind.Local).AddTicks(3827), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("97fdbbd6-4b14-4972-821e-6ad645791d71") },
                    { new Guid("06341fb1-3907-4eb3-9473-96cb7cf0e720"), new Guid("fb1f55ac-3dd9-41af-8edb-d4ef091e8727"), new DateTime(2022, 6, 15, 1, 30, 24, 657, DateTimeKind.Local).AddTicks(9081), new Guid("853290ec-d3f6-4e00-8c1a-a48f5a0e8e23"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("06dbe4f7-00ed-47a2-aba6-8dda11d20406"), new Guid("96a4cb3a-1df6-4fee-91c2-34d23e34c565"), new DateTime(2022, 9, 16, 7, 46, 4, 255, DateTimeKind.Local).AddTicks(2667), new Guid("23d1768b-4f7a-4571-b5c4-ec4622a57fa7"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("0901bd36-88ad-4faf-a977-b41b97865f2e"), new Guid("2257a4bc-8152-4802-a0be-7128f81badb4"), new DateTime(2019, 11, 23, 9, 46, 31, 46, DateTimeKind.Local).AddTicks(5257), new Guid("d06e51d5-ec3b-4308-9988-4b64b9063528"), new Guid("e740f243-8c1b-4cd0-af1e-eab8411830f2") },
                    { new Guid("0d34cd69-99b2-43e3-83a1-b3071a843962"), new Guid("7e914d1f-5ed7-4d95-92e8-2090ceddb918"), new DateTime(2020, 4, 25, 19, 29, 26, 763, DateTimeKind.Local).AddTicks(1201), new Guid("03eff380-419a-4d7b-8557-62e8975580ca"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("0f92b457-fcba-4d2e-aea6-67167bb24da5"), new Guid("625544e8-3799-45f7-af8d-0880df358a1a"), new DateTime(2018, 4, 29, 3, 58, 36, 898, DateTimeKind.Local).AddTicks(1912), new Guid("79abe60b-45b9-41a1-a74b-6869b5d9ad4d"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("0ffe4824-e2d8-4d75-b362-411d34c2fb33"), new Guid("fb1f55ac-3dd9-41af-8edb-d4ef091e8727"), new DateTime(2021, 3, 22, 16, 54, 18, 980, DateTimeKind.Local).AddTicks(4514), new Guid("853290ec-d3f6-4e00-8c1a-a48f5a0e8e23"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("10873ad6-9598-40f2-adf6-f6da7f977e92"), new Guid("b2b37e2b-e611-4cf6-898a-974bacd3be35"), new DateTime(2018, 3, 15, 13, 30, 29, 948, DateTimeKind.Local).AddTicks(744), new Guid("795302ec-26d9-435c-a283-29d4e19eec52"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("14486f88-f410-414d-a093-b5ac5feb951d"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2022, 6, 2, 20, 7, 18, 852, DateTimeKind.Local).AddTicks(7307), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("79bf5306-406d-4cd2-a5c8-8b33122125d3") },
                    { new Guid("18415bfe-eb7c-4dbc-a20e-8bd84eb22897"), new Guid("b2b37e2b-e611-4cf6-898a-974bacd3be35"), new DateTime(2020, 1, 24, 12, 0, 47, 76, DateTimeKind.Local).AddTicks(1789), new Guid("795302ec-26d9-435c-a283-29d4e19eec52"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("1da7e659-a1b2-4a0e-9dff-25cc292f223b"), new Guid("fb1f55ac-3dd9-41af-8edb-d4ef091e8727"), new DateTime(2021, 1, 18, 4, 56, 14, 893, DateTimeKind.Local).AddTicks(1347), new Guid("853290ec-d3f6-4e00-8c1a-a48f5a0e8e23"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("1e1dff3b-0bf6-4222-83af-4b7580b9d708"), new Guid("625544e8-3799-45f7-af8d-0880df358a1a"), new DateTime(2018, 7, 4, 19, 31, 56, 642, DateTimeKind.Local).AddTicks(6933), new Guid("79abe60b-45b9-41a1-a74b-6869b5d9ad4d"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("1e2220d5-0952-4300-bef8-eee196b1def1"), new Guid("3d0a2fdb-7d99-4ecc-ad0a-2d9ffcbd898c"), new DateTime(2020, 5, 15, 12, 54, 49, 445, DateTimeKind.Local).AddTicks(3606), new Guid("3a12acfb-bcd2-445e-a610-d9c6a8c3c3d7"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("1e6392b8-e2bf-4ece-815e-c3cd26c71030"), new Guid("dbd0cc8c-1de6-40a2-bdde-afd30b73991d"), new DateTime(2018, 8, 6, 23, 57, 25, 13, DateTimeKind.Local).AddTicks(9223), new Guid("f375e8f7-5ec9-4cc5-b39b-55a66dcf6d9c"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("1e9f8a21-cd77-4f58-9e2f-b9ba5386bbd7"), new Guid("dbd0cc8c-1de6-40a2-bdde-afd30b73991d"), new DateTime(2020, 12, 18, 6, 32, 45, 343, DateTimeKind.Local).AddTicks(5072), new Guid("f375e8f7-5ec9-4cc5-b39b-55a66dcf6d9c"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("1efa2558-56de-490b-a979-db0646905bcc"), new Guid("dbd0cc8c-1de6-40a2-bdde-afd30b73991d"), new DateTime(2018, 5, 3, 13, 33, 9, 831, DateTimeKind.Local).AddTicks(4248), new Guid("f375e8f7-5ec9-4cc5-b39b-55a66dcf6d9c"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("1fcb99dd-3a7f-4342-a5c2-6fbe46e39031"), new Guid("d05bb8cd-15c4-49fd-be32-1de4ba9d1b79"), new DateTime(2020, 9, 2, 0, 4, 42, 938, DateTimeKind.Local).AddTicks(100), new Guid("35c51a64-2724-4738-b543-6cc85e8c8b05"), new Guid("94b496f6-f020-4fb6-b4f3-17ef5d6bbed6") },
                    { new Guid("20e70963-6e60-423b-b75b-230297267e90"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2019, 12, 15, 16, 2, 39, 92, DateTimeKind.Local).AddTicks(1943), new Guid("5c61f97e-1701-47dc-8742-9aa2cb04ce43"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("2100cbc7-4112-4d12-83c4-060bdb5d62f9"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2022, 4, 13, 6, 36, 54, 515, DateTimeKind.Local).AddTicks(7842), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("79bf5306-406d-4cd2-a5c8-8b33122125d3") },
                    { new Guid("22035a9a-b4f8-4bbc-89f4-50c2449431e7"), new Guid("d05bb8cd-15c4-49fd-be32-1de4ba9d1b79"), new DateTime(2021, 12, 9, 12, 32, 35, 10, DateTimeKind.Local).AddTicks(800), new Guid("35c51a64-2724-4738-b543-6cc85e8c8b05"), new Guid("94b496f6-f020-4fb6-b4f3-17ef5d6bbed6") },
                    { new Guid("223b1207-f6c8-483f-b0ba-f6d0f3118632"), new Guid("66d2b104-0c29-4884-b7f4-343863796a42"), new DateTime(2019, 5, 9, 5, 36, 43, 157, DateTimeKind.Local).AddTicks(8334), new Guid("dad1173a-e7af-43cf-a60b-df255d0ae96b"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("239103b3-048e-43c1-bde9-84be6771479b"), new Guid("aef60cbb-b544-447e-b60e-9ddc9557dbce"), new DateTime(2020, 8, 18, 9, 42, 45, 361, DateTimeKind.Local).AddTicks(291), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("2531cea6-8652-4ab1-af36-0092c4f38055"), new Guid("2257a4bc-8152-4802-a0be-7128f81badb4"), new DateTime(2019, 2, 15, 18, 26, 19, 717, DateTimeKind.Local).AddTicks(6768), new Guid("d06e51d5-ec3b-4308-9988-4b64b9063528"), new Guid("e740f243-8c1b-4cd0-af1e-eab8411830f2") },
                    { new Guid("25a593a2-5276-4ad0-9faf-32c57a0332ee"), new Guid("4d84a65a-1422-4ea0-b457-74f32ee2b4a0"), new DateTime(2018, 9, 22, 15, 49, 40, 894, DateTimeKind.Local).AddTicks(2902), new Guid("4efc17ba-6851-4a49-8494-a9fb9406264a"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("260135f4-47e6-479d-8c35-cf3fd5f7b3d4"), new Guid("d05bb8cd-15c4-49fd-be32-1de4ba9d1b79"), new DateTime(2019, 6, 6, 10, 11, 45, 651, DateTimeKind.Local).AddTicks(9238), new Guid("35c51a64-2724-4738-b543-6cc85e8c8b05"), new Guid("94b496f6-f020-4fb6-b4f3-17ef5d6bbed6") },
                    { new Guid("277177d2-f85b-483f-bfea-23757f67b30f"), new Guid("6e8c4b98-e32d-49d7-9643-bf3bdc87833f"), new DateTime(2021, 9, 13, 10, 56, 54, 39, DateTimeKind.Local).AddTicks(949), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("e732ebd3-9d68-4919-99b1-bacaf283ea5a") },
                    { new Guid("2872cd68-49de-4ef9-b333-0b3d4a73c04e"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2019, 6, 24, 22, 36, 11, 338, DateTimeKind.Local).AddTicks(3712), new Guid("e920a850-8155-4d64-8aca-9ff656b9ad00"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("288b014d-3ff5-456a-b886-c031e20a80f3"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2022, 4, 26, 14, 33, 14, 990, DateTimeKind.Local).AddTicks(8859), new Guid("5c61f97e-1701-47dc-8742-9aa2cb04ce43"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("29633528-42e6-4d87-85ad-2e854dbf5aa5"), new Guid("d05bb8cd-15c4-49fd-be32-1de4ba9d1b79"), new DateTime(2019, 10, 23, 5, 23, 59, 271, DateTimeKind.Local).AddTicks(9826), new Guid("35c51a64-2724-4738-b543-6cc85e8c8b05"), new Guid("94b496f6-f020-4fb6-b4f3-17ef5d6bbed6") },
                    { new Guid("2bbabd20-6f1e-4d65-972b-b1ab1a1d3e39"), new Guid("3d0a2fdb-7d99-4ecc-ad0a-2d9ffcbd898c"), new DateTime(2020, 4, 3, 0, 32, 50, 20, DateTimeKind.Local).AddTicks(6614), new Guid("3a12acfb-bcd2-445e-a610-d9c6a8c3c3d7"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("2c03df5c-63b9-4442-8a1a-4a68b1d71e09"), new Guid("625544e8-3799-45f7-af8d-0880df358a1a"), new DateTime(2019, 10, 11, 4, 50, 10, 832, DateTimeKind.Local).AddTicks(7209), new Guid("79abe60b-45b9-41a1-a74b-6869b5d9ad4d"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("2c67e7b9-1920-43e7-bda2-0d11e0b63259"), new Guid("2257a4bc-8152-4802-a0be-7128f81badb4"), new DateTime(2019, 9, 19, 13, 14, 18, 980, DateTimeKind.Local).AddTicks(888), new Guid("d06e51d5-ec3b-4308-9988-4b64b9063528"), new Guid("e740f243-8c1b-4cd0-af1e-eab8411830f2") },
                    { new Guid("2c8af3da-c2b7-453d-b8fd-877061f7fdea"), new Guid("6861e4a3-845b-4b0d-82d4-eba107d13973"), new DateTime(2022, 1, 6, 4, 25, 25, 504, DateTimeKind.Local).AddTicks(2347), new Guid("d3a12e33-6d40-4dd4-93e4-cf8a70aed034"), new Guid("4d192f92-ad4f-41de-ab5d-1d8daaa79af1") },
                    { new Guid("2dd0c0d3-4945-4c8f-9374-702f4a8269c2"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2021, 3, 9, 5, 21, 52, 478, DateTimeKind.Local).AddTicks(233), new Guid("e920a850-8155-4d64-8aca-9ff656b9ad00"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("2e67efd8-7de7-4f7c-854f-6014de76d6ee"), new Guid("6e8c4b98-e32d-49d7-9643-bf3bdc87833f"), new DateTime(2021, 6, 30, 12, 57, 49, 211, DateTimeKind.Local).AddTicks(1380), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("e732ebd3-9d68-4919-99b1-bacaf283ea5a") },
                    { new Guid("30bba423-ffaa-4ecf-b28d-5364012ce97f"), new Guid("625544e8-3799-45f7-af8d-0880df358a1a"), new DateTime(2020, 4, 10, 15, 10, 59, 123, DateTimeKind.Local).AddTicks(8380), new Guid("79abe60b-45b9-41a1-a74b-6869b5d9ad4d"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("32bbcd8f-5d57-43e7-889f-b1fe5902b7f0"), new Guid("4d84a65a-1422-4ea0-b457-74f32ee2b4a0"), new DateTime(2021, 6, 17, 11, 48, 26, 605, DateTimeKind.Local).AddTicks(2369), new Guid("4efc17ba-6851-4a49-8494-a9fb9406264a"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("32e525c2-087b-44be-b744-9aed266f71d6"), new Guid("4d84a65a-1422-4ea0-b457-74f32ee2b4a0"), new DateTime(2021, 10, 29, 16, 6, 54, 854, DateTimeKind.Local).AddTicks(9230), new Guid("4efc17ba-6851-4a49-8494-a9fb9406264a"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("3470445d-e2cc-4b61-9cd1-dfe391b4dfc1"), new Guid("96a4cb3a-1df6-4fee-91c2-34d23e34c565"), new DateTime(2021, 7, 6, 20, 9, 9, 961, DateTimeKind.Local).AddTicks(308), new Guid("23d1768b-4f7a-4571-b5c4-ec4622a57fa7"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("35c8f351-ded4-4dea-9e8d-eafbbeed4f3e"), new Guid("66d2b104-0c29-4884-b7f4-343863796a42"), new DateTime(2019, 8, 19, 12, 15, 9, 187, DateTimeKind.Local).AddTicks(2898), new Guid("dad1173a-e7af-43cf-a60b-df255d0ae96b"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("3867c00a-64b9-4216-92b1-7e4579599cbe"), new Guid("72279ce1-90e9-4991-bf78-5a44c7141215"), new DateTime(2018, 4, 13, 19, 47, 9, 102, DateTimeKind.Local).AddTicks(9337), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("3979f845-ca7b-4cec-95c0-770dc676f5fd"), new Guid("b2b37e2b-e611-4cf6-898a-974bacd3be35"), new DateTime(2019, 1, 20, 21, 15, 42, 639, DateTimeKind.Local).AddTicks(8357), new Guid("795302ec-26d9-435c-a283-29d4e19eec52"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("3a6e4d9e-8087-4bd8-bdfc-1266a040afbf"), new Guid("7e914d1f-5ed7-4d95-92e8-2090ceddb918"), new DateTime(2021, 4, 22, 17, 35, 19, 59, DateTimeKind.Local).AddTicks(1279), new Guid("03eff380-419a-4d7b-8557-62e8975580ca"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("3b33e90e-4c76-46c0-afdf-a7b5d6e385c1"), new Guid("96a4cb3a-1df6-4fee-91c2-34d23e34c565"), new DateTime(2019, 5, 17, 19, 47, 53, 950, DateTimeKind.Local).AddTicks(9169), new Guid("23d1768b-4f7a-4571-b5c4-ec4622a57fa7"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("3be2017d-aed1-4918-a87c-491470ba1eb5"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2019, 8, 14, 3, 14, 40, 952, DateTimeKind.Local).AddTicks(433), new Guid("5c61f97e-1701-47dc-8742-9aa2cb04ce43"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("3d145f44-f358-4e02-962e-a1e666656062"), new Guid("7e914d1f-5ed7-4d95-92e8-2090ceddb918"), new DateTime(2022, 2, 12, 5, 6, 52, 132, DateTimeKind.Local).AddTicks(1058), new Guid("03eff380-419a-4d7b-8557-62e8975580ca"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("3ee0e2c1-e022-4615-97f4-d9854ba578ea"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2020, 5, 14, 11, 25, 18, 344, DateTimeKind.Local).AddTicks(2141), new Guid("e920a850-8155-4d64-8aca-9ff656b9ad00"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("4031b05d-8328-4d1d-a87a-de460a34f908"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2023, 1, 11, 16, 3, 48, 499, DateTimeKind.Local).AddTicks(9654), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("79bf5306-406d-4cd2-a5c8-8b33122125d3") },
                    { new Guid("4392e70c-1857-45e1-b970-b08a1c8de70f"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2022, 4, 8, 14, 12, 18, 200, DateTimeKind.Local).AddTicks(4158), new Guid("5c61f97e-1701-47dc-8742-9aa2cb04ce43"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("43b62ec8-799d-404f-aaab-2d5c31eb3a04"), new Guid("fb1f55ac-3dd9-41af-8edb-d4ef091e8727"), new DateTime(2022, 12, 5, 15, 53, 20, 928, DateTimeKind.Local).AddTicks(2473), new Guid("853290ec-d3f6-4e00-8c1a-a48f5a0e8e23"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("43e12c47-cbb5-4a81-83ee-e176ea8304e7"), new Guid("7e914d1f-5ed7-4d95-92e8-2090ceddb918"), new DateTime(2020, 8, 22, 12, 27, 54, 214, DateTimeKind.Local).AddTicks(6986), new Guid("03eff380-419a-4d7b-8557-62e8975580ca"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("46c62a13-06bd-43d2-a012-35fa81c2aae3"), new Guid("6e8c4b98-e32d-49d7-9643-bf3bdc87833f"), new DateTime(2020, 12, 7, 12, 5, 11, 193, DateTimeKind.Local).AddTicks(3674), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("e732ebd3-9d68-4919-99b1-bacaf283ea5a") },
                    { new Guid("470f3a95-bab3-4e8f-9f4b-03287ca2647b"), new Guid("3d0a2fdb-7d99-4ecc-ad0a-2d9ffcbd898c"), new DateTime(2023, 2, 11, 3, 0, 48, 257, DateTimeKind.Local).AddTicks(3421), new Guid("3a12acfb-bcd2-445e-a610-d9c6a8c3c3d7"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("475077e6-9460-46d1-8076-df3878de95b8"), new Guid("b00a45d3-a191-4b88-87a6-0664462624b2"), new DateTime(2018, 11, 5, 6, 6, 15, 31, DateTimeKind.Local).AddTicks(6375), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("97fdbbd6-4b14-4972-821e-6ad645791d71") },
                    { new Guid("48f24b73-178b-4e39-833f-416f15843a16"), new Guid("6861e4a3-845b-4b0d-82d4-eba107d13973"), new DateTime(2021, 1, 8, 1, 46, 10, 623, DateTimeKind.Local).AddTicks(8005), new Guid("d3a12e33-6d40-4dd4-93e4-cf8a70aed034"), new Guid("4d192f92-ad4f-41de-ab5d-1d8daaa79af1") },
                    { new Guid("4992e8ab-77bc-445e-8b68-d13f63a293f1"), new Guid("b00a45d3-a191-4b88-87a6-0664462624b2"), new DateTime(2020, 4, 6, 8, 50, 12, 446, DateTimeKind.Local).AddTicks(794), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("97fdbbd6-4b14-4972-821e-6ad645791d71") },
                    { new Guid("4ca78002-ef29-49f0-b189-fcbeaa0e0212"), new Guid("72279ce1-90e9-4991-bf78-5a44c7141215"), new DateTime(2022, 3, 9, 16, 11, 8, 107, DateTimeKind.Local).AddTicks(5560), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("4d34014a-a460-46ba-b90e-0f0d41ad0fb7"), new Guid("4d84a65a-1422-4ea0-b457-74f32ee2b4a0"), new DateTime(2021, 11, 29, 21, 45, 33, 990, DateTimeKind.Local).AddTicks(8112), new Guid("4efc17ba-6851-4a49-8494-a9fb9406264a"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("4e0b028b-0bc8-48d0-a1b5-0b61ba1362bd"), new Guid("6e8c4b98-e32d-49d7-9643-bf3bdc87833f"), new DateTime(2019, 7, 24, 23, 33, 45, 901, DateTimeKind.Local).AddTicks(5730), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("e732ebd3-9d68-4919-99b1-bacaf283ea5a") },
                    { new Guid("4f83ec94-1f3d-45cd-9057-6ed527ac41fd"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2022, 4, 7, 7, 26, 47, 164, DateTimeKind.Local).AddTicks(9385), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("79bf5306-406d-4cd2-a5c8-8b33122125d3") },
                    { new Guid("4fc835ce-37fe-4f88-a8ba-d2f7c848b713"), new Guid("3d0a2fdb-7d99-4ecc-ad0a-2d9ffcbd898c"), new DateTime(2022, 12, 22, 17, 30, 47, 986, DateTimeKind.Local).AddTicks(6097), new Guid("3a12acfb-bcd2-445e-a610-d9c6a8c3c3d7"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("4ff3b8ca-649d-4eaa-a9f8-77068015f4b8"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2018, 12, 7, 22, 39, 45, 339, DateTimeKind.Local).AddTicks(4346), new Guid("43eea13e-8bca-4aed-b74f-83ef9a3bd24b"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("516743eb-8a80-4b7d-b3bf-203afee1cd41"), new Guid("6861e4a3-845b-4b0d-82d4-eba107d13973"), new DateTime(2021, 5, 17, 5, 11, 54, 747, DateTimeKind.Local).AddTicks(2283), new Guid("d3a12e33-6d40-4dd4-93e4-cf8a70aed034"), new Guid("4d192f92-ad4f-41de-ab5d-1d8daaa79af1") },
                    { new Guid("518d7bd2-e24d-463c-b95d-94abf9af34f8"), new Guid("b00a45d3-a191-4b88-87a6-0664462624b2"), new DateTime(2022, 7, 22, 2, 52, 36, 528, DateTimeKind.Local).AddTicks(3498), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("97fdbbd6-4b14-4972-821e-6ad645791d71") },
                    { new Guid("559c5b2c-3178-4bfc-be20-94adc96e4207"), new Guid("6861e4a3-845b-4b0d-82d4-eba107d13973"), new DateTime(2021, 12, 31, 10, 10, 22, 846, DateTimeKind.Local).AddTicks(6325), new Guid("d3a12e33-6d40-4dd4-93e4-cf8a70aed034"), new Guid("4d192f92-ad4f-41de-ab5d-1d8daaa79af1") },
                    { new Guid("57ed5cbe-f389-46ac-935f-b3d9037cd273"), new Guid("625544e8-3799-45f7-af8d-0880df358a1a"), new DateTime(2020, 7, 27, 21, 34, 33, 249, DateTimeKind.Local).AddTicks(2326), new Guid("79abe60b-45b9-41a1-a74b-6869b5d9ad4d"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("58990a7c-afb0-4bb2-9047-47ecd1a3f1e8"), new Guid("dbd0cc8c-1de6-40a2-bdde-afd30b73991d"), new DateTime(2018, 7, 19, 3, 12, 38, 853, DateTimeKind.Local).AddTicks(2287), new Guid("f375e8f7-5ec9-4cc5-b39b-55a66dcf6d9c"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("593f2365-e4f0-4e24-9017-64bc46fb7482"), new Guid("b2b37e2b-e611-4cf6-898a-974bacd3be35"), new DateTime(2021, 5, 22, 10, 19, 56, 882, DateTimeKind.Local).AddTicks(4335), new Guid("795302ec-26d9-435c-a283-29d4e19eec52"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("59c68637-381a-43f8-a086-04bba7ff2aee"), new Guid("66d2b104-0c29-4884-b7f4-343863796a42"), new DateTime(2020, 6, 25, 17, 17, 13, 43, DateTimeKind.Local).AddTicks(9705), new Guid("dad1173a-e7af-43cf-a60b-df255d0ae96b"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("5a5ef7e1-bf84-4969-a7c6-4fa39f86d06a"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2022, 1, 6, 12, 55, 47, 563, DateTimeKind.Local).AddTicks(4124), new Guid("43eea13e-8bca-4aed-b74f-83ef9a3bd24b"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("5ae397a6-493b-43e9-a86e-75fa74db348a"), new Guid("2257a4bc-8152-4802-a0be-7128f81badb4"), new DateTime(2018, 12, 5, 2, 20, 43, 155, DateTimeKind.Local).AddTicks(8892), new Guid("d06e51d5-ec3b-4308-9988-4b64b9063528"), new Guid("e740f243-8c1b-4cd0-af1e-eab8411830f2") },
                    { new Guid("5aee3eb0-b031-467b-b8e0-73bac5d3c5e2"), new Guid("72279ce1-90e9-4991-bf78-5a44c7141215"), new DateTime(2018, 7, 30, 2, 50, 10, 599, DateTimeKind.Local).AddTicks(477), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("5fd74558-bc49-4bf5-9aa1-76241450b7e5"), new Guid("2257a4bc-8152-4802-a0be-7128f81badb4"), new DateTime(2021, 5, 24, 3, 38, 1, 972, DateTimeKind.Local).AddTicks(1702), new Guid("d06e51d5-ec3b-4308-9988-4b64b9063528"), new Guid("e740f243-8c1b-4cd0-af1e-eab8411830f2") },
                    { new Guid("5fe14e48-65bf-4669-a065-87e11392af75"), new Guid("7e914d1f-5ed7-4d95-92e8-2090ceddb918"), new DateTime(2019, 11, 13, 3, 39, 38, 600, DateTimeKind.Local).AddTicks(953), new Guid("03eff380-419a-4d7b-8557-62e8975580ca"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("605037ab-6d07-43cd-ad1e-c24b0792448b"), new Guid("66d2b104-0c29-4884-b7f4-343863796a42"), new DateTime(2021, 12, 31, 11, 49, 14, 434, DateTimeKind.Local).AddTicks(1242), new Guid("dad1173a-e7af-43cf-a60b-df255d0ae96b"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("62466825-570c-4902-95e2-a4d1bba22a6f"), new Guid("d05bb8cd-15c4-49fd-be32-1de4ba9d1b79"), new DateTime(2019, 6, 16, 13, 56, 52, 502, DateTimeKind.Local).AddTicks(6333), new Guid("35c51a64-2724-4738-b543-6cc85e8c8b05"), new Guid("94b496f6-f020-4fb6-b4f3-17ef5d6bbed6") },
                    { new Guid("62eb0a74-6011-4e62-9456-528f8c95a310"), new Guid("6861e4a3-845b-4b0d-82d4-eba107d13973"), new DateTime(2018, 4, 11, 17, 52, 38, 926, DateTimeKind.Local).AddTicks(8815), new Guid("d3a12e33-6d40-4dd4-93e4-cf8a70aed034"), new Guid("4d192f92-ad4f-41de-ab5d-1d8daaa79af1") },
                    { new Guid("63132a41-0bf5-458d-b714-85ae34da6cd1"), new Guid("d05bb8cd-15c4-49fd-be32-1de4ba9d1b79"), new DateTime(2022, 3, 22, 1, 30, 22, 746, DateTimeKind.Local).AddTicks(6162), new Guid("35c51a64-2724-4738-b543-6cc85e8c8b05"), new Guid("94b496f6-f020-4fb6-b4f3-17ef5d6bbed6") },
                    { new Guid("63a73ffc-c5ee-4b78-9285-f30d4558d894"), new Guid("3d0a2fdb-7d99-4ecc-ad0a-2d9ffcbd898c"), new DateTime(2019, 6, 16, 5, 55, 0, 900, DateTimeKind.Local).AddTicks(2766), new Guid("3a12acfb-bcd2-445e-a610-d9c6a8c3c3d7"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("676763b8-71e6-455e-ba8a-17883af44284"), new Guid("96a4cb3a-1df6-4fee-91c2-34d23e34c565"), new DateTime(2018, 8, 27, 20, 14, 46, 228, DateTimeKind.Local).AddTicks(2514), new Guid("23d1768b-4f7a-4571-b5c4-ec4622a57fa7"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("67bfdb63-fad8-49da-82d8-06c5777b4cb7"), new Guid("7e914d1f-5ed7-4d95-92e8-2090ceddb918"), new DateTime(2021, 3, 14, 16, 6, 19, 666, DateTimeKind.Local).AddTicks(6769), new Guid("03eff380-419a-4d7b-8557-62e8975580ca"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("68fd54d5-ce8c-4761-a0d5-fca7ea7ec835"), new Guid("b2b37e2b-e611-4cf6-898a-974bacd3be35"), new DateTime(2018, 3, 10, 1, 59, 6, 318, DateTimeKind.Local).AddTicks(648), new Guid("795302ec-26d9-435c-a283-29d4e19eec52"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("6aae2034-5b43-4979-9825-9f5f05bd387d"), new Guid("dbd0cc8c-1de6-40a2-bdde-afd30b73991d"), new DateTime(2018, 9, 14, 0, 49, 53, 248, DateTimeKind.Local).AddTicks(135), new Guid("f375e8f7-5ec9-4cc5-b39b-55a66dcf6d9c"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("6bc95627-a96e-4e51-8982-b31796cf0187"), new Guid("7e914d1f-5ed7-4d95-92e8-2090ceddb918"), new DateTime(2022, 10, 16, 9, 29, 29, 30, DateTimeKind.Local).AddTicks(4421), new Guid("03eff380-419a-4d7b-8557-62e8975580ca"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("6d6e579c-a756-4aa5-8632-43cadc8c4ca6"), new Guid("96a4cb3a-1df6-4fee-91c2-34d23e34c565"), new DateTime(2023, 1, 23, 5, 50, 59, 511, DateTimeKind.Local).AddTicks(7637), new Guid("23d1768b-4f7a-4571-b5c4-ec4622a57fa7"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("6fde8654-9e68-4809-9b6b-550f78b12de8"), new Guid("dbd0cc8c-1de6-40a2-bdde-afd30b73991d"), new DateTime(2019, 3, 1, 13, 46, 9, 719, DateTimeKind.Local).AddTicks(6760), new Guid("f375e8f7-5ec9-4cc5-b39b-55a66dcf6d9c"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("70c619d4-ac4c-4d7c-ba8e-3b25371c3dd0"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2022, 2, 19, 12, 49, 41, 635, DateTimeKind.Local).AddTicks(5260), new Guid("e920a850-8155-4d64-8aca-9ff656b9ad00"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("7172b6ab-2aae-451a-8175-d0233432b9c0"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2019, 8, 24, 3, 3, 36, 253, DateTimeKind.Local).AddTicks(2469), new Guid("43eea13e-8bca-4aed-b74f-83ef9a3bd24b"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("7191816f-7ebd-4263-bc3d-4fa5b9f283dd"), new Guid("6e8c4b98-e32d-49d7-9643-bf3bdc87833f"), new DateTime(2019, 3, 7, 9, 7, 32, 119, DateTimeKind.Local).AddTicks(3809), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("e732ebd3-9d68-4919-99b1-bacaf283ea5a") },
                    { new Guid("729502d0-1e14-4aed-998d-7cf82b733382"), new Guid("625544e8-3799-45f7-af8d-0880df358a1a"), new DateTime(2023, 2, 10, 22, 52, 37, 317, DateTimeKind.Local).AddTicks(1928), new Guid("79abe60b-45b9-41a1-a74b-6869b5d9ad4d"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("7321cd60-d602-4bcd-8537-1fd9072aa40c"), new Guid("4d84a65a-1422-4ea0-b457-74f32ee2b4a0"), new DateTime(2019, 3, 19, 14, 56, 5, 753, DateTimeKind.Local).AddTicks(4155), new Guid("4efc17ba-6851-4a49-8494-a9fb9406264a"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("7638a834-b4fa-4572-8127-730524bb2dd8"), new Guid("7e914d1f-5ed7-4d95-92e8-2090ceddb918"), new DateTime(2022, 5, 8, 21, 38, 12, 63, DateTimeKind.Local).AddTicks(1783), new Guid("03eff380-419a-4d7b-8557-62e8975580ca"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("77b5019a-a4f0-471a-b810-798e7af263ce"), new Guid("96a4cb3a-1df6-4fee-91c2-34d23e34c565"), new DateTime(2019, 10, 23, 7, 57, 31, 645, DateTimeKind.Local).AddTicks(4839), new Guid("23d1768b-4f7a-4571-b5c4-ec4622a57fa7"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("77e544dd-ff0e-4176-8b3d-006055a202b8"), new Guid("4d84a65a-1422-4ea0-b457-74f32ee2b4a0"), new DateTime(2018, 10, 3, 19, 2, 51, 440, DateTimeKind.Local).AddTicks(5497), new Guid("4efc17ba-6851-4a49-8494-a9fb9406264a"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("79f72a4f-acbf-4739-9688-0a9f75142eb0"), new Guid("625544e8-3799-45f7-af8d-0880df358a1a"), new DateTime(2020, 7, 25, 1, 26, 51, 135, DateTimeKind.Local).AddTicks(5052), new Guid("79abe60b-45b9-41a1-a74b-6869b5d9ad4d"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("7b3afb15-4aa1-4d92-bb35-53fbc58c037c"), new Guid("aef60cbb-b544-447e-b60e-9ddc9557dbce"), new DateTime(2021, 9, 20, 20, 20, 21, 966, DateTimeKind.Local).AddTicks(2593), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("7c051533-fc73-4330-a378-3230804af154"), new Guid("2257a4bc-8152-4802-a0be-7128f81badb4"), new DateTime(2020, 2, 19, 18, 40, 1, 649, DateTimeKind.Local).AddTicks(4294), new Guid("d06e51d5-ec3b-4308-9988-4b64b9063528"), new Guid("e740f243-8c1b-4cd0-af1e-eab8411830f2") },
                    { new Guid("7db84709-d843-4f95-9dae-d545f6e6338b"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2022, 2, 16, 10, 41, 57, 892, DateTimeKind.Local).AddTicks(4650), new Guid("5c61f97e-1701-47dc-8742-9aa2cb04ce43"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("7e4ca17d-97ba-414f-a35e-5e8062192529"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2020, 5, 15, 19, 13, 5, 305, DateTimeKind.Local).AddTicks(5613), new Guid("43eea13e-8bca-4aed-b74f-83ef9a3bd24b"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("7e5d02de-6c40-42a1-bf7d-56912d44c069"), new Guid("b2b37e2b-e611-4cf6-898a-974bacd3be35"), new DateTime(2022, 7, 31, 22, 15, 30, 956, DateTimeKind.Local).AddTicks(9984), new Guid("795302ec-26d9-435c-a283-29d4e19eec52"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("7ea98337-9034-42d8-aa2f-08ec09dd617f"), new Guid("72279ce1-90e9-4991-bf78-5a44c7141215"), new DateTime(2019, 3, 26, 5, 21, 49, 916, DateTimeKind.Local).AddTicks(114), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("80e6d0ee-6f43-4453-be73-43a2f049b195"), new Guid("d05bb8cd-15c4-49fd-be32-1de4ba9d1b79"), new DateTime(2020, 4, 18, 12, 58, 28, 197, DateTimeKind.Local).AddTicks(8497), new Guid("35c51a64-2724-4738-b543-6cc85e8c8b05"), new Guid("94b496f6-f020-4fb6-b4f3-17ef5d6bbed6") },
                    { new Guid("85327d77-a82f-4779-a63c-8f6904acc952"), new Guid("b2b37e2b-e611-4cf6-898a-974bacd3be35"), new DateTime(2020, 12, 18, 6, 30, 59, 459, DateTimeKind.Local).AddTicks(2487), new Guid("795302ec-26d9-435c-a283-29d4e19eec52"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("872901fe-3067-409e-9dd7-3f3fa8c10679"), new Guid("2257a4bc-8152-4802-a0be-7128f81badb4"), new DateTime(2019, 6, 14, 18, 7, 4, 371, DateTimeKind.Local).AddTicks(3754), new Guid("d06e51d5-ec3b-4308-9988-4b64b9063528"), new Guid("e740f243-8c1b-4cd0-af1e-eab8411830f2") },
                    { new Guid("88015284-1318-4afc-9cc2-744e09e33228"), new Guid("4d84a65a-1422-4ea0-b457-74f32ee2b4a0"), new DateTime(2018, 7, 5, 19, 3, 38, 126, DateTimeKind.Local).AddTicks(8157), new Guid("4efc17ba-6851-4a49-8494-a9fb9406264a"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("895e5c87-0f28-446e-a25f-24776ee4b353"), new Guid("66d2b104-0c29-4884-b7f4-343863796a42"), new DateTime(2019, 11, 16, 20, 6, 8, 294, DateTimeKind.Local).AddTicks(3257), new Guid("dad1173a-e7af-43cf-a60b-df255d0ae96b"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("8d3f117b-4ec7-4fec-a2de-792093a07571"), new Guid("fb1f55ac-3dd9-41af-8edb-d4ef091e8727"), new DateTime(2018, 10, 4, 16, 58, 27, 780, DateTimeKind.Local).AddTicks(665), new Guid("853290ec-d3f6-4e00-8c1a-a48f5a0e8e23"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("8e72be32-e43e-401d-a828-55b09ebc8780"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2019, 5, 26, 4, 36, 13, 998, DateTimeKind.Local).AddTicks(6757), new Guid("5c61f97e-1701-47dc-8742-9aa2cb04ce43"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("8fadf2cb-3d3e-47a6-b81e-b682bef12f9f"), new Guid("4d84a65a-1422-4ea0-b457-74f32ee2b4a0"), new DateTime(2018, 4, 14, 7, 9, 29, 541, DateTimeKind.Local).AddTicks(5810), new Guid("4efc17ba-6851-4a49-8494-a9fb9406264a"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("90403417-a6d2-439b-b163-78d18d43acd2"), new Guid("b00a45d3-a191-4b88-87a6-0664462624b2"), new DateTime(2021, 7, 16, 21, 57, 11, 799, DateTimeKind.Local).AddTicks(7001), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("97fdbbd6-4b14-4972-821e-6ad645791d71") },
                    { new Guid("914cac02-d120-49d7-8cd7-a99f4c752d25"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2019, 12, 11, 22, 21, 31, 235, DateTimeKind.Local).AddTicks(986), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("79bf5306-406d-4cd2-a5c8-8b33122125d3") },
                    { new Guid("919d8927-96f7-4c46-bb8d-950123c723b3"), new Guid("b00a45d3-a191-4b88-87a6-0664462624b2"), new DateTime(2018, 8, 5, 21, 40, 9, 879, DateTimeKind.Local).AddTicks(1890), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("97fdbbd6-4b14-4972-821e-6ad645791d71") },
                    { new Guid("91cfa02e-61d9-455a-a53b-597bdaeaa28d"), new Guid("b2b37e2b-e611-4cf6-898a-974bacd3be35"), new DateTime(2022, 5, 5, 13, 59, 26, 268, DateTimeKind.Local).AddTicks(6979), new Guid("795302ec-26d9-435c-a283-29d4e19eec52"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("91db988b-04c0-4d54-9fdf-d4944f113e70"), new Guid("b00a45d3-a191-4b88-87a6-0664462624b2"), new DateTime(2022, 5, 20, 18, 19, 39, 28, DateTimeKind.Local).AddTicks(6412), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("97fdbbd6-4b14-4972-821e-6ad645791d71") },
                    { new Guid("924783eb-a7bf-473a-99d2-9e36525cbf50"), new Guid("7e914d1f-5ed7-4d95-92e8-2090ceddb918"), new DateTime(2020, 5, 30, 0, 15, 44, 105, DateTimeKind.Local).AddTicks(6030), new Guid("03eff380-419a-4d7b-8557-62e8975580ca"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("9313bd6f-08d6-40a0-bec3-12b90a0a35f5"), new Guid("b00a45d3-a191-4b88-87a6-0664462624b2"), new DateTime(2020, 9, 6, 9, 48, 51, 92, DateTimeKind.Local).AddTicks(6616), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("97fdbbd6-4b14-4972-821e-6ad645791d71") },
                    { new Guid("93c40b44-278f-4018-bf24-22952d3d6b45"), new Guid("3d0a2fdb-7d99-4ecc-ad0a-2d9ffcbd898c"), new DateTime(2022, 3, 5, 4, 0, 53, 353, DateTimeKind.Local).AddTicks(3103), new Guid("3a12acfb-bcd2-445e-a610-d9c6a8c3c3d7"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("948cdc75-4cd5-4aa8-a538-80550f4e5cf3"), new Guid("6e8c4b98-e32d-49d7-9643-bf3bdc87833f"), new DateTime(2021, 12, 3, 13, 18, 36, 197, DateTimeKind.Local).AddTicks(4597), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("e732ebd3-9d68-4919-99b1-bacaf283ea5a") },
                    { new Guid("963e95bd-797a-4943-aa6b-a936a1704991"), new Guid("fb1f55ac-3dd9-41af-8edb-d4ef091e8727"), new DateTime(2018, 7, 13, 18, 21, 25, 740, DateTimeKind.Local).AddTicks(393), new Guid("853290ec-d3f6-4e00-8c1a-a48f5a0e8e23"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("97d9c753-7047-491c-b75c-f756c7585621"), new Guid("72279ce1-90e9-4991-bf78-5a44c7141215"), new DateTime(2020, 2, 26, 22, 39, 45, 233, DateTimeKind.Local).AddTicks(5281), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("98e4dded-b603-49e2-8b09-5b5db9500bfc"), new Guid("6861e4a3-845b-4b0d-82d4-eba107d13973"), new DateTime(2023, 1, 1, 23, 15, 27, 578, DateTimeKind.Local).AddTicks(8080), new Guid("d3a12e33-6d40-4dd4-93e4-cf8a70aed034"), new Guid("4d192f92-ad4f-41de-ab5d-1d8daaa79af1") },
                    { new Guid("9d6bead2-b602-408e-9271-49950527d96a"), new Guid("b2b37e2b-e611-4cf6-898a-974bacd3be35"), new DateTime(2018, 5, 9, 14, 54, 41, 116, DateTimeKind.Local).AddTicks(7109), new Guid("795302ec-26d9-435c-a283-29d4e19eec52"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("9e217dbd-ceae-4517-8ef2-3e7fdefa5293"), new Guid("aef60cbb-b544-447e-b60e-9ddc9557dbce"), new DateTime(2022, 5, 26, 16, 32, 19, 776, DateTimeKind.Local).AddTicks(4045), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("a1be0d78-b866-4a13-8c4e-9f9d02cee163"), new Guid("fb1f55ac-3dd9-41af-8edb-d4ef091e8727"), new DateTime(2021, 9, 3, 5, 15, 4, 734, DateTimeKind.Local).AddTicks(4115), new Guid("853290ec-d3f6-4e00-8c1a-a48f5a0e8e23"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("a2232aae-56df-4dc3-934f-fab1d7ec2e0c"), new Guid("4d84a65a-1422-4ea0-b457-74f32ee2b4a0"), new DateTime(2022, 1, 28, 9, 40, 34, 49, DateTimeKind.Local).AddTicks(5332), new Guid("4efc17ba-6851-4a49-8494-a9fb9406264a"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("a22abd5e-aba8-4616-8962-e6b3fb4d73e0"), new Guid("66d2b104-0c29-4884-b7f4-343863796a42"), new DateTime(2021, 2, 9, 1, 57, 36, 459, DateTimeKind.Local).AddTicks(1931), new Guid("dad1173a-e7af-43cf-a60b-df255d0ae96b"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("a2b6fd02-1c7e-4062-8da1-4d73154ef6f8"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2019, 9, 15, 21, 35, 42, 965, DateTimeKind.Local).AddTicks(8347), new Guid("5c61f97e-1701-47dc-8742-9aa2cb04ce43"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("a396308b-8b77-479a-9c1f-5b9e61879a68"), new Guid("6e8c4b98-e32d-49d7-9643-bf3bdc87833f"), new DateTime(2022, 7, 20, 20, 20, 33, 981, DateTimeKind.Local).AddTicks(4306), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("e732ebd3-9d68-4919-99b1-bacaf283ea5a") },
                    { new Guid("a3c24839-c566-48e9-9ca1-33f649b2e42a"), new Guid("3d0a2fdb-7d99-4ecc-ad0a-2d9ffcbd898c"), new DateTime(2019, 12, 8, 12, 12, 47, 895, DateTimeKind.Local).AddTicks(8081), new Guid("3a12acfb-bcd2-445e-a610-d9c6a8c3c3d7"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("a4b6935f-b7f8-41fd-962b-ff6ef54f6227"), new Guid("96a4cb3a-1df6-4fee-91c2-34d23e34c565"), new DateTime(2021, 1, 10, 5, 53, 6, 200, DateTimeKind.Local).AddTicks(3511), new Guid("23d1768b-4f7a-4571-b5c4-ec4622a57fa7"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("a5716aa9-7ee2-4b90-b15b-6e334eea7c93"), new Guid("d05bb8cd-15c4-49fd-be32-1de4ba9d1b79"), new DateTime(2023, 1, 13, 20, 11, 42, 239, DateTimeKind.Local).AddTicks(9685), new Guid("35c51a64-2724-4738-b543-6cc85e8c8b05"), new Guid("94b496f6-f020-4fb6-b4f3-17ef5d6bbed6") },
                    { new Guid("a762b75d-21a6-407e-a35c-7d6e654559c3"), new Guid("4d84a65a-1422-4ea0-b457-74f32ee2b4a0"), new DateTime(2021, 6, 9, 5, 25, 46, 110, DateTimeKind.Local).AddTicks(8263), new Guid("4efc17ba-6851-4a49-8494-a9fb9406264a"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("a7b67079-fad9-45df-8727-a3fd76b80bc4"), new Guid("66d2b104-0c29-4884-b7f4-343863796a42"), new DateTime(2021, 4, 8, 20, 37, 20, 261, DateTimeKind.Local).AddTicks(3382), new Guid("dad1173a-e7af-43cf-a60b-df255d0ae96b"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("a8af5b6c-0087-4c67-8d94-e14a88348077"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2019, 2, 16, 14, 11, 16, 950, DateTimeKind.Local).AddTicks(3102), new Guid("43eea13e-8bca-4aed-b74f-83ef9a3bd24b"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("a8e2ee20-4e77-4d99-9592-90365a8ac383"), new Guid("dbd0cc8c-1de6-40a2-bdde-afd30b73991d"), new DateTime(2020, 12, 25, 22, 56, 1, 538, DateTimeKind.Local).AddTicks(9159), new Guid("f375e8f7-5ec9-4cc5-b39b-55a66dcf6d9c"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("a90775eb-7298-410f-9092-910cb0729c28"), new Guid("dbd0cc8c-1de6-40a2-bdde-afd30b73991d"), new DateTime(2021, 8, 27, 12, 30, 21, 212, DateTimeKind.Local).AddTicks(9550), new Guid("f375e8f7-5ec9-4cc5-b39b-55a66dcf6d9c"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("aabfb3b4-d525-4dab-b423-ba83cc709a6f"), new Guid("aef60cbb-b544-447e-b60e-9ddc9557dbce"), new DateTime(2019, 7, 7, 10, 17, 21, 337, DateTimeKind.Local).AddTicks(5403), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("aad9dd62-44ea-47d3-b4b3-2865243e027f"), new Guid("6e8c4b98-e32d-49d7-9643-bf3bdc87833f"), new DateTime(2022, 8, 17, 16, 30, 13, 857, DateTimeKind.Local).AddTicks(5529), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("e732ebd3-9d68-4919-99b1-bacaf283ea5a") },
                    { new Guid("ab7a7e55-a0df-4a0b-aec8-f4c6f81d357a"), new Guid("d05bb8cd-15c4-49fd-be32-1de4ba9d1b79"), new DateTime(2020, 2, 14, 19, 52, 43, 724, DateTimeKind.Local).AddTicks(440), new Guid("35c51a64-2724-4738-b543-6cc85e8c8b05"), new Guid("94b496f6-f020-4fb6-b4f3-17ef5d6bbed6") },
                    { new Guid("acfaed50-1b7d-4e17-a80d-74110e1b5b6f"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2021, 12, 30, 7, 3, 58, 267, DateTimeKind.Local).AddTicks(3418), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("79bf5306-406d-4cd2-a5c8-8b33122125d3") },
                    { new Guid("adb8304c-5ddf-4c04-b193-950e25528710"), new Guid("625544e8-3799-45f7-af8d-0880df358a1a"), new DateTime(2022, 8, 4, 0, 44, 29, 810, DateTimeKind.Local).AddTicks(1917), new Guid("79abe60b-45b9-41a1-a74b-6869b5d9ad4d"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("add0e35f-625f-47af-9dee-04887175c4c5"), new Guid("7e914d1f-5ed7-4d95-92e8-2090ceddb918"), new DateTime(2018, 7, 2, 7, 1, 45, 145, DateTimeKind.Local).AddTicks(4813), new Guid("03eff380-419a-4d7b-8557-62e8975580ca"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("adee9413-1906-46fe-a48f-387ab8dfc0e0"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2021, 12, 18, 0, 1, 13, 143, DateTimeKind.Local).AddTicks(3150), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("79bf5306-406d-4cd2-a5c8-8b33122125d3") },
                    { new Guid("ae3a448c-f6af-48b1-97b9-e3e47595c340"), new Guid("66d2b104-0c29-4884-b7f4-343863796a42"), new DateTime(2020, 7, 14, 20, 14, 59, 938, DateTimeKind.Local).AddTicks(5371), new Guid("dad1173a-e7af-43cf-a60b-df255d0ae96b"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("aed27351-81c7-481a-895b-a055e05d8d87"), new Guid("3d0a2fdb-7d99-4ecc-ad0a-2d9ffcbd898c"), new DateTime(2018, 5, 12, 20, 50, 18, 969, DateTimeKind.Local).AddTicks(3813), new Guid("3a12acfb-bcd2-445e-a610-d9c6a8c3c3d7"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("b03c48b9-c950-465a-816b-c6d4ed44587c"), new Guid("d05bb8cd-15c4-49fd-be32-1de4ba9d1b79"), new DateTime(2018, 5, 3, 7, 3, 29, 926, DateTimeKind.Local).AddTicks(2714), new Guid("35c51a64-2724-4738-b543-6cc85e8c8b05"), new Guid("94b496f6-f020-4fb6-b4f3-17ef5d6bbed6") },
                    { new Guid("b12af50d-18d2-40d7-92fd-ef4512ffc04b"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2022, 4, 1, 23, 6, 5, 670, DateTimeKind.Local).AddTicks(1325), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("79bf5306-406d-4cd2-a5c8-8b33122125d3") },
                    { new Guid("b3060bf1-89db-49eb-b020-db800b393b1a"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2020, 8, 27, 4, 15, 3, 966, DateTimeKind.Local).AddTicks(9793), new Guid("e920a850-8155-4d64-8aca-9ff656b9ad00"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("b42bb8c1-0240-460e-8350-b0be1b4e26cf"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2021, 3, 13, 14, 47, 58, 655, DateTimeKind.Local).AddTicks(4338), new Guid("5c61f97e-1701-47dc-8742-9aa2cb04ce43"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("b560cf3d-2d2d-42b9-b069-4b5ec5fc7c8f"), new Guid("aef60cbb-b544-447e-b60e-9ddc9557dbce"), new DateTime(2020, 10, 3, 12, 29, 1, 681, DateTimeKind.Local).AddTicks(6849), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("b66d71a2-5587-4259-b130-d3cb8cadd564"), new Guid("aef60cbb-b544-447e-b60e-9ddc9557dbce"), new DateTime(2022, 10, 12, 2, 7, 36, 49, DateTimeKind.Local).AddTicks(9882), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("b6bb6efc-de64-4495-aa8f-4f0f76c700af"), new Guid("aef60cbb-b544-447e-b60e-9ddc9557dbce"), new DateTime(2020, 12, 30, 10, 58, 21, 653, DateTimeKind.Local).AddTicks(8752), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("b806df84-b1d1-4660-9170-70803ea05a2c"), new Guid("6e8c4b98-e32d-49d7-9643-bf3bdc87833f"), new DateTime(2018, 12, 18, 23, 32, 31, 117, DateTimeKind.Local).AddTicks(7675), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("e732ebd3-9d68-4919-99b1-bacaf283ea5a") },
                    { new Guid("bbd30480-795b-4a4a-836b-d771aefd4deb"), new Guid("6861e4a3-845b-4b0d-82d4-eba107d13973"), new DateTime(2021, 2, 23, 23, 41, 27, 237, DateTimeKind.Local).AddTicks(6410), new Guid("d3a12e33-6d40-4dd4-93e4-cf8a70aed034"), new Guid("4d192f92-ad4f-41de-ab5d-1d8daaa79af1") },
                    { new Guid("bdb1cd4d-dded-4dca-82ee-53e7e2d560a9"), new Guid("dbd0cc8c-1de6-40a2-bdde-afd30b73991d"), new DateTime(2018, 9, 13, 12, 3, 38, 257, DateTimeKind.Local).AddTicks(7241), new Guid("f375e8f7-5ec9-4cc5-b39b-55a66dcf6d9c"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("bf5da25f-c4e0-416d-a110-de08c7918e02"), new Guid("aef60cbb-b544-447e-b60e-9ddc9557dbce"), new DateTime(2018, 4, 23, 16, 52, 18, 255, DateTimeKind.Local).AddTicks(3640), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("c1d4f26b-3a84-45fb-b1eb-779e41b9e5ca"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2020, 8, 31, 11, 51, 14, 394, DateTimeKind.Local).AddTicks(2715), new Guid("e920a850-8155-4d64-8aca-9ff656b9ad00"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("c6a5aaec-3e35-47af-9a54-087ba1f47892"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2018, 11, 24, 1, 8, 38, 803, DateTimeKind.Local).AddTicks(765), new Guid("43eea13e-8bca-4aed-b74f-83ef9a3bd24b"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("c6f5c201-a498-4d7b-b216-6b6f78b0b3fa"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2018, 12, 22, 7, 17, 21, 175, DateTimeKind.Local).AddTicks(1295), new Guid("e920a850-8155-4d64-8aca-9ff656b9ad00"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("c7a41ae1-3c15-4900-94a9-02721f869e03"), new Guid("dbd0cc8c-1de6-40a2-bdde-afd30b73991d"), new DateTime(2022, 2, 8, 6, 29, 27, 162, DateTimeKind.Local).AddTicks(8870), new Guid("f375e8f7-5ec9-4cc5-b39b-55a66dcf6d9c"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("c8be608c-cf79-43cd-8f62-8f15616848b4"), new Guid("6861e4a3-845b-4b0d-82d4-eba107d13973"), new DateTime(2022, 6, 13, 5, 7, 14, 667, DateTimeKind.Local).AddTicks(4773), new Guid("d3a12e33-6d40-4dd4-93e4-cf8a70aed034"), new Guid("4d192f92-ad4f-41de-ab5d-1d8daaa79af1") },
                    { new Guid("cabae128-d284-4915-a74a-2ed60aff9ad8"), new Guid("72279ce1-90e9-4991-bf78-5a44c7141215"), new DateTime(2018, 12, 4, 18, 32, 39, 862, DateTimeKind.Local).AddTicks(1607), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("cba4c791-8d90-4d12-b2e9-0a60dbc7a882"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2019, 10, 19, 21, 49, 11, 306, DateTimeKind.Local).AddTicks(8184), new Guid("43eea13e-8bca-4aed-b74f-83ef9a3bd24b"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("ccb9a02e-0284-44af-add8-db7edfca32c4"), new Guid("66d2b104-0c29-4884-b7f4-343863796a42"), new DateTime(2021, 10, 11, 5, 12, 49, 152, DateTimeKind.Local).AddTicks(9779), new Guid("dad1173a-e7af-43cf-a60b-df255d0ae96b"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("cd01a67e-57b4-437f-a729-a095086c1027"), new Guid("2257a4bc-8152-4802-a0be-7128f81badb4"), new DateTime(2020, 5, 29, 13, 2, 5, 404, DateTimeKind.Local).AddTicks(8671), new Guid("d06e51d5-ec3b-4308-9988-4b64b9063528"), new Guid("e740f243-8c1b-4cd0-af1e-eab8411830f2") },
                    { new Guid("d0ae5c49-1261-4f2a-99dd-01b8a26c50c3"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2018, 4, 22, 3, 5, 13, 59, DateTimeKind.Local).AddTicks(5927), new Guid("43eea13e-8bca-4aed-b74f-83ef9a3bd24b"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("d1a66c6d-1cf3-4d26-9a99-c33d9d634bfe"), new Guid("96a4cb3a-1df6-4fee-91c2-34d23e34c565"), new DateTime(2019, 9, 12, 19, 26, 51, 458, DateTimeKind.Local).AddTicks(4556), new Guid("23d1768b-4f7a-4571-b5c4-ec4622a57fa7"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("d1e90832-987d-45e5-be06-22219597fe2f"), new Guid("3d0a2fdb-7d99-4ecc-ad0a-2d9ffcbd898c"), new DateTime(2023, 1, 22, 2, 12, 35, 195, DateTimeKind.Local).AddTicks(9929), new Guid("3a12acfb-bcd2-445e-a610-d9c6a8c3c3d7"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("d3a43c9a-3a1f-4bc7-9c9b-e0bef5ac84b7"), new Guid("2257a4bc-8152-4802-a0be-7128f81badb4"), new DateTime(2018, 12, 9, 6, 38, 30, 816, DateTimeKind.Local).AddTicks(6716), new Guid("d06e51d5-ec3b-4308-9988-4b64b9063528"), new Guid("e740f243-8c1b-4cd0-af1e-eab8411830f2") },
                    { new Guid("d5a669fa-f03b-443b-90dc-54f38c1e4ef6"), new Guid("b2b37e2b-e611-4cf6-898a-974bacd3be35"), new DateTime(2021, 3, 22, 6, 52, 43, 652, DateTimeKind.Local).AddTicks(3154), new Guid("795302ec-26d9-435c-a283-29d4e19eec52"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("d71837a4-6918-4adf-b375-478eff4b487d"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2022, 6, 19, 20, 0, 10, 154, DateTimeKind.Local).AddTicks(5204), new Guid("e920a850-8155-4d64-8aca-9ff656b9ad00"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("d75698b4-b980-417c-9c00-c865fe1c0920"), new Guid("72279ce1-90e9-4991-bf78-5a44c7141215"), new DateTime(2021, 4, 7, 8, 52, 33, 805, DateTimeKind.Local).AddTicks(1922), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("d7d179e3-2bc9-4e83-b1f8-836a47b9b9f6"), new Guid("625544e8-3799-45f7-af8d-0880df358a1a"), new DateTime(2020, 11, 20, 23, 45, 10, 434, DateTimeKind.Local).AddTicks(7743), new Guid("79abe60b-45b9-41a1-a74b-6869b5d9ad4d"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("d90c6622-657e-4c21-bdd7-ded91f12809c"), new Guid("fb1f55ac-3dd9-41af-8edb-d4ef091e8727"), new DateTime(2023, 1, 27, 22, 25, 47, 479, DateTimeKind.Local).AddTicks(9111), new Guid("853290ec-d3f6-4e00-8c1a-a48f5a0e8e23"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("d998827b-d6e6-400c-8a7e-efe03d304069"), new Guid("96a4cb3a-1df6-4fee-91c2-34d23e34c565"), new DateTime(2022, 1, 12, 10, 16, 12, 645, DateTimeKind.Local).AddTicks(8174), new Guid("23d1768b-4f7a-4571-b5c4-ec4622a57fa7"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("da494c09-ad65-4aef-8ca0-716fa32095d4"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2020, 8, 3, 19, 39, 31, 948, DateTimeKind.Local).AddTicks(8712), new Guid("43eea13e-8bca-4aed-b74f-83ef9a3bd24b"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("db29446a-7d54-4595-b77a-b1baa5a1dc5a"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2019, 12, 3, 20, 17, 43, 715, DateTimeKind.Local).AddTicks(4746), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("79bf5306-406d-4cd2-a5c8-8b33122125d3") },
                    { new Guid("dc82566a-82bb-4e54-9f21-9ba4c4c6f4a6"), new Guid("72279ce1-90e9-4991-bf78-5a44c7141215"), new DateTime(2019, 7, 9, 3, 56, 22, 306, DateTimeKind.Local).AddTicks(8877), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("de84ba60-7d90-45f3-82e7-da320cad1357"), new Guid("b00a45d3-a191-4b88-87a6-0664462624b2"), new DateTime(2019, 9, 2, 14, 55, 7, 550, DateTimeKind.Local).AddTicks(7975), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("97fdbbd6-4b14-4972-821e-6ad645791d71") },
                    { new Guid("e080b155-8426-4051-bf24-111cbfc5a4e2"), new Guid("aef60cbb-b544-447e-b60e-9ddc9557dbce"), new DateTime(2018, 7, 23, 11, 0, 17, 946, DateTimeKind.Local).AddTicks(5966), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("e241bb44-4886-4bc6-9e8c-10a7bb23beda"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2022, 7, 10, 14, 58, 39, 271, DateTimeKind.Local).AddTicks(715), new Guid("43eea13e-8bca-4aed-b74f-83ef9a3bd24b"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("e391e7c8-d41a-41ab-837f-709e90b70281"), new Guid("aef60cbb-b544-447e-b60e-9ddc9557dbce"), new DateTime(2021, 11, 1, 18, 29, 17, 493, DateTimeKind.Local).AddTicks(2221), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("a020f341-4ef8-421a-adf1-840e62c5c593") },
                    { new Guid("e42eb151-703f-4e19-880f-89121f336ebe"), new Guid("6861e4a3-845b-4b0d-82d4-eba107d13973"), new DateTime(2019, 4, 24, 16, 19, 30, 565, DateTimeKind.Local).AddTicks(8597), new Guid("d3a12e33-6d40-4dd4-93e4-cf8a70aed034"), new Guid("4d192f92-ad4f-41de-ab5d-1d8daaa79af1") },
                    { new Guid("e617df12-ec95-444b-95e1-fe8094fee542"), new Guid("66d2b104-0c29-4884-b7f4-343863796a42"), new DateTime(2023, 1, 20, 11, 54, 17, 368, DateTimeKind.Local).AddTicks(5518), new Guid("dad1173a-e7af-43cf-a60b-df255d0ae96b"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("e6fd0df5-92bb-482f-afc2-7594c098b534"), new Guid("6861e4a3-845b-4b0d-82d4-eba107d13973"), new DateTime(2019, 5, 20, 10, 41, 47, 702, DateTimeKind.Local).AddTicks(9502), new Guid("d3a12e33-6d40-4dd4-93e4-cf8a70aed034"), new Guid("4d192f92-ad4f-41de-ab5d-1d8daaa79af1") },
                    { new Guid("e8275a88-79cf-4423-95f0-c9fd8465c792"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2021, 9, 21, 6, 5, 11, 420, DateTimeKind.Local).AddTicks(1712), new Guid("e920a850-8155-4d64-8aca-9ff656b9ad00"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("e9c516c1-c2b2-4605-b2cd-511fd309bb6e"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2018, 8, 2, 15, 48, 37, 364, DateTimeKind.Local).AddTicks(5771), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("79bf5306-406d-4cd2-a5c8-8b33122125d3") },
                    { new Guid("eb05b455-83f5-4740-ae21-15b998b66aa5"), new Guid("3d0a2fdb-7d99-4ecc-ad0a-2d9ffcbd898c"), new DateTime(2021, 3, 4, 14, 45, 3, 921, DateTimeKind.Local).AddTicks(1394), new Guid("3a12acfb-bcd2-445e-a610-d9c6a8c3c3d7"), new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf") },
                    { new Guid("ee3fb07a-2884-4fcb-9416-bb26d9c93452"), new Guid("2257a4bc-8152-4802-a0be-7128f81badb4"), new DateTime(2019, 9, 14, 3, 21, 28, 612, DateTimeKind.Local).AddTicks(4775), new Guid("d06e51d5-ec3b-4308-9988-4b64b9063528"), new Guid("e740f243-8c1b-4cd0-af1e-eab8411830f2") },
                    { new Guid("ef0c61f1-3bbe-40f8-a3f9-17a2747aef20"), new Guid("96a4cb3a-1df6-4fee-91c2-34d23e34c565"), new DateTime(2021, 4, 3, 8, 42, 51, 846, DateTimeKind.Local).AddTicks(6762), new Guid("23d1768b-4f7a-4571-b5c4-ec4622a57fa7"), new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61") },
                    { new Guid("ef65836c-1b47-48ac-8ec4-14bc4400fbb3"), new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"), new DateTime(2021, 1, 25, 14, 30, 24, 597, DateTimeKind.Local).AddTicks(6181), new Guid("e920a850-8155-4d64-8aca-9ff656b9ad00"), new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f") },
                    { new Guid("f05d1fb9-bb19-4efd-aa96-c8a281af7947"), new Guid("fb1f55ac-3dd9-41af-8edb-d4ef091e8727"), new DateTime(2018, 12, 30, 1, 54, 9, 623, DateTimeKind.Local).AddTicks(752), new Guid("853290ec-d3f6-4e00-8c1a-a48f5a0e8e23"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("f0c35027-9c76-4475-9db8-566b63f7a757"), new Guid("72279ce1-90e9-4991-bf78-5a44c7141215"), new DateTime(2018, 5, 29, 14, 30, 22, 933, DateTimeKind.Local).AddTicks(5853), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("f187506d-4663-4fc1-ae0a-9792d62b32ca"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2018, 3, 31, 12, 19, 15, 405, DateTimeKind.Local).AddTicks(8393), new Guid("5c61f97e-1701-47dc-8742-9aa2cb04ce43"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("f1fcd2af-a1f7-4346-bc7e-76efb3c8a94b"), new Guid("625544e8-3799-45f7-af8d-0880df358a1a"), new DateTime(2022, 7, 8, 4, 24, 45, 410, DateTimeKind.Local).AddTicks(5364), new Guid("79abe60b-45b9-41a1-a74b-6869b5d9ad4d"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("f38df2b4-28c9-48d9-a513-d5fd0212782b"), new Guid("fb1f55ac-3dd9-41af-8edb-d4ef091e8727"), new DateTime(2022, 11, 20, 7, 30, 47, 900, DateTimeKind.Local).AddTicks(3029), new Guid("853290ec-d3f6-4e00-8c1a-a48f5a0e8e23"), new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b") },
                    { new Guid("f615f429-e0c1-4dc4-87b8-3a23f37e9bd9"), new Guid("016a5946-853a-4499-959b-8b5179a88bfa"), new DateTime(2022, 7, 17, 14, 24, 18, 735, DateTimeKind.Local).AddTicks(6201), new Guid("5c61f97e-1701-47dc-8742-9aa2cb04ce43"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("f7037e37-779d-428e-9eef-20c5fecba69f"), new Guid("b00a45d3-a191-4b88-87a6-0664462624b2"), new DateTime(2021, 7, 7, 8, 11, 43, 118, DateTimeKind.Local).AddTicks(8552), new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"), new Guid("97fdbbd6-4b14-4972-821e-6ad645791d71") },
                    { new Guid("f713de81-a98d-4f27-9e6b-31ccd73d6bb9"), new Guid("72279ce1-90e9-4991-bf78-5a44c7141215"), new DateTime(2022, 3, 6, 7, 23, 33, 92, DateTimeKind.Local).AddTicks(4518), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd") },
                    { new Guid("fca1a99d-47fb-4173-a6de-e1679ca219f8"), new Guid("6e8c4b98-e32d-49d7-9643-bf3bdc87833f"), new DateTime(2018, 7, 11, 19, 12, 57, 69, DateTimeKind.Local).AddTicks(9708), new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"), new Guid("e732ebd3-9d68-4919-99b1-bacaf283ea5a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("00373c06-4e02-4d58-9547-17996bb7c951"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0246410b-4d96-44af-82b4-ebc400b3a0cc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("04ba6a9f-696f-4d5c-9833-705bb469e2dd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("05f42d54-3260-4d1e-9993-023a3364253c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("063bedc9-e7e2-4ca1-94e9-ccd504b62676"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("071fa576-d2ec-4921-b85e-38e7597ba362"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("083db417-09e2-4957-add4-cc572d6d68ac"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("089b8d95-39e4-4c12-9b88-c55e11ee4384"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("09bf205a-3cdf-422e-ad56-3309326cbab7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0aa736f1-f3d3-4102-8378-8852b0209540"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0b2d6596-da4d-472c-b589-ba86fbb51228"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0bc83152-1b52-4e73-9d9d-018c9df1f0b1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0d4f6119-3a03-4678-8ee4-03d8609f1e0f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0dd2b1e0-35f6-426c-a362-bdccdbdfd993"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0e9aa538-3735-4ee3-ba7f-c0276fb63e37"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0ef56a2f-737f-4526-a3e0-2b828e1caa6a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("101502a4-814f-4fa6-91ed-3a3354fc00ee"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("11302c6b-ac35-40d7-9bc2-9424bb030aac"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("11605186-1ba3-44eb-9e92-5ffeb515dadc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("11868bef-205d-45c5-965e-4d5425f07582"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("11c6e451-28ab-46cf-8208-56ea4a33d06d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("14ce0167-2370-4105-b76b-40d21516cd1c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("16f30c53-759d-4401-86d1-4b11ecdaafe1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("16f528a5-51d6-40df-9452-5df3520ec9e3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("17d639a6-94e2-4151-8bea-ee91b3bef90d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("18a5a14a-4841-4579-ad61-1da0335a37fc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("19d6f951-cf4c-4c48-afc7-c2002d262888"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1a77b978-5e97-4734-b5b8-7d62493695bf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1bef9411-ca8b-4a5d-ac97-4e27db017776"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1c3c8731-b571-4c68-8945-85ea73279c26"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1db2fed9-2576-4164-aea3-ffeb946a2d22"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1e38c399-c3ab-4d3f-8b09-53a6ed83b8b3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1eeb5a4f-4620-487b-abeb-3ae527c60cb4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1fd8a043-ff67-475c-9058-0be9b7ce02d6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("21909259-174c-4df4-a256-0362f3a50eee"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("226f91fb-3e90-4267-b29f-63e73babbde9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("27e17383-0dd8-44b7-adb4-c69c010e05cf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("28bf8cc1-e847-49e7-869d-beeea93e248b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("294a8657-9937-4036-a447-d16850fe5782"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("29760ae0-9d50-4169-98b5-e8c19bb2afbd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("298a220e-dbab-45fe-ab54-11f88fb7ed21"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2ab8ab6e-9e85-4dcc-93b6-54fe89898925"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2acef602-341a-4206-a5b6-fb90adfeb02c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2c6491d5-6880-4ea9-a3bf-7f6246681c91"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2d30fc7e-97b9-45c4-8f49-d70002001e63"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2fc1c63b-296b-464a-97e2-85bac2145887"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("304330be-690b-4110-b8a8-d5388be5199d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("30870746-1473-42b2-89db-e71b154da464"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("313e5424-d225-4502-a658-163ce40ea2b0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("32a5fca3-94fd-4ef2-909b-240795610f7a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("332863f7-3dc3-4135-b202-6b19e9c76f7f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("35c6c61a-62db-46fc-9f04-be55330567c5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("37d4b579-b66d-45a1-b8fc-302511580be4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("38fb8e6f-856a-404e-a8f4-37c21a039b3a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("391097ab-1125-4542-bc95-51dafc44fa63"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3a3f87f2-a41a-4233-90d3-0bd0cd9c0376"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3b0b942f-1e75-495e-88d0-c8e1410e36e7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3b4328c4-d5ea-4a37-9131-0e64500e410b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3b642cb4-5d11-465c-b026-54ff384e20ad"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3b67657d-dce5-4f0b-a39d-0d003d51508c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3c84c9c6-977f-454d-a006-6cf027f882c3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3c8b4389-36ff-401b-be28-1d1d40d51636"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3cf08740-516b-49d2-a9ab-33881f42d9e9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3dc380de-e009-4a1a-9307-6ff44916f3c0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3e72ed4a-cfb2-487e-b643-31c37b3b1f15"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3e8acb3d-cf08-49e2-b1ef-211849a536d3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3f12640c-8b74-41fc-b247-aaed49be710b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("41f993f6-6104-4a31-83e6-7dee0d09a14d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("43470b25-1514-462a-943a-bb9007da4cea"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4409a542-637d-478a-8f7e-021c52191a6c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("452b89b8-cfd2-44d4-bd5a-9182e75ab8b6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("45d20759-d0cb-4e13-8a88-f7dc27a55106"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4604c797-5c61-44f6-aaa3-7145745745f4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4643ab8a-9570-42c6-95f7-ffd89daa9909"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("47b796b5-0b18-44b6-bd97-1ee4230d5766"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("48842d5c-41aa-4b71-994b-0b77a926b283"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("491264e9-6585-4938-bb6f-52aee9adfb58"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4a28cef0-425f-4928-9444-330471c01d26"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4b8d567a-2ddc-431d-af05-b624ed0e0a19"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4ca0286b-acb2-41ec-aff8-ac729009fcfc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4d44d5dc-e82b-4d9e-9010-96a29e6db30d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4dba79f0-1e09-435f-8118-7d44d97ca44f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4dc1770e-1ae0-45d9-9cb5-7382e43bca8c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4e0ecf7e-4fa0-447e-9aaf-96ede014dbc1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4e4b9cd2-2119-4a17-a90c-a0780869008d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4f2517a6-675b-40d7-bbc4-293d794a15be"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4f673abc-99d6-4762-93f9-7fe5fc15ebc7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("50814a7d-2032-4948-a0cd-8fb5be80abbd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("543b0114-a800-4aa2-a603-31381e4d1090"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5623f896-434c-4881-b4e1-7bb1f383ccab"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("586ea4de-61ae-4680-904d-3f38626dd4f4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5a475a0a-817f-4903-80a9-03844df45abc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5a4e1636-fc23-460a-b940-19f85569903b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5a76e354-f54a-4de1-bb7f-b5c83009bd14"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5c25c2eb-377c-4e18-8d1c-0c71f8014116"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5c54ec39-0658-4b0c-b87f-f28261c82d8a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5cea64c0-2733-4d46-8447-43cf7d211606"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5d61cc14-4acc-49c6-953c-a06ede85d68e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5e6f2ce2-5b8d-4f57-b617-7c488cc86e04"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5ea7515d-02b5-4ecf-8f4d-b3b4da1ee261"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5f119466-d2ab-48a2-879a-281ed32381b7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5f2c4c29-5783-4d51-8519-a58a0c521953"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("612a39a6-edba-46d1-919f-c2dc914ec303"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("62ba5ad0-8b90-412a-ab28-960964512520"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6306f65d-a823-4e59-a3a4-c8079746d1db"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6598672c-d41d-4b28-bfc4-c8e5d984de3d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("67e99788-a630-42eb-8e20-1e08fa9b9e05"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6c19a64d-7798-4cb4-aa65-b49fc9ca8640"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6c4743b4-4b93-440f-a17f-1a65921abed6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6f21d5e9-14f1-4d14-b2d5-34aa2d634bf2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("709c587c-2fe7-4461-9c6c-e2bde6259435"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7135cfea-d206-44ef-ab4b-0ea6bce0a8de"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("715bb6ae-d8d5-4f15-85f5-ce7b578db90f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7200f080-f18d-476c-aa59-b2525bb35397"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("73bf2996-d8cf-47ea-821f-acc4148ff045"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("761f62ca-9fa1-44af-8922-908019991893"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("79306a12-a866-4d72-b627-836388db6708"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7aea5ab1-7e4f-46f5-90c8-376f7fd8d4cf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7d34acbb-b10c-4e4d-9655-c2e154225db3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7e4035a3-17a0-4090-af1e-29fee1430604"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7edfe933-43a3-4eba-a6f8-a7cd2a6d679a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7fee85e3-195e-4d55-a8d3-88a3de43075a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8023ab03-5f7c-4e05-918b-99a1dd63523e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8094f472-bbbf-410f-85cd-e10af91427a2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("80cf3ca7-a975-4695-b5fb-918dae6ed791"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8153bc36-e19a-41bb-8fc9-cc16e582e12a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("82f7c26d-445a-4d98-bf7a-a8869c0ac9d8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("838fc902-cac8-4661-baae-090e4444d771"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("860b9c0d-4d09-4cb2-bccf-af7dbbc57614"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("874b4d3a-8370-47d5-8139-8a570d0aa011"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("892c7f49-c3a9-4da2-9b4c-dbe18ad11bae"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8981bd9b-e4db-4959-b7ac-e4b2e4c50db1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8a08ac00-a89a-4372-bd9f-a8323a10bfa9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8a1ce844-2965-4163-b386-2b63a4f58851"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8a37250e-e49a-41cb-bbbd-77801ee7465b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8a629f77-cd54-4a19-bf4f-1ca7aa5bde6c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8b291089-c9ff-4386-bf52-991fceca8aee"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8b359242-c3a3-4892-825c-50100d445cc4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8bc49753-24c6-42a3-b343-92963e56528f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8c645dd8-3d6e-46b3-b6f8-c5a3741275ab"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8ded2b63-cd3d-49a8-ace9-1a9059cbbb5b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8dfba9c2-6fb3-41b5-82bd-199955600771"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8ecba903-2fb7-492c-8e04-efc7c9092978"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("90e92391-b9e2-4087-abae-f0d2135208d3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("90efb1a7-9fda-4881-8f46-a3db8eb8b4c0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("91387b1c-01af-488b-869b-a02dd69a397d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9161dfd9-7b40-4b82-9e2d-54acea626727"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("92cf116b-37b4-4969-9c96-0ab057c28b9e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("92fb9af4-125d-4001-b7d1-bb6fca29af9e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("930f40d2-a2d6-4268-9edf-3b57280139e0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("934f2ef5-2300-4401-b20d-1c2f173fac66"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("94449fd1-29d1-4bae-ae96-f701497d956a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("96986915-7327-45be-beae-1e855daf0cee"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("976268ea-42d3-4fab-b043-521ab3f13b99"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("97727f47-63b6-461c-8fa5-29df8b6d7fbc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("981496d5-b4e2-438c-bb35-eb72d105f034"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("997f2580-ba31-47d3-bb5d-d918a844e539"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("99af15d7-9207-4092-b6f8-d26de05d54b7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9aaa03ce-12dd-4260-82df-4ff4ebf35e70"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9b1a7970-043a-4451-98b2-9aa334b9b573"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9c1aca97-812a-4ac9-9d22-cdfb090b7892"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9ca43921-d48f-401c-942d-f64ac8eb5017"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9cbd8b7d-2535-4949-9f01-57608feb9857"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9cc46072-3731-478d-a421-43bd26bb24c2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9d7bf66d-da11-4ef3-a267-baa226a0a451"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9ee4eeb0-6f90-4fc7-b97a-5369f799b515"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9ef678b8-7a80-4c8e-99c9-f3b82de4e62b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a0cf03a8-e043-44d4-85ac-0a5ad46479a8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a279d282-45bb-4577-ad07-d02770bbf8aa"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a2c6dd43-693a-4740-9694-1d0a146a48fd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a322667b-cf5c-4292-b5c0-f19f6b71e172"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a4051b07-7780-48eb-b674-b0fea252ba43"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a4ac028f-e8f4-468b-83a1-c7d256c9b72b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a4f1819b-cf5c-457a-b423-ac1885a47a72"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a53544d6-4362-4dd8-971d-a44ef67506d9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a5933513-0701-4fb0-8cc1-aad15a694526"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a64cfc3a-f1bf-4099-a403-4272b730d212"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a70e2d36-4fe9-418a-be27-0beaabfe0569"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a7a0ba7a-6bfd-4e13-9a46-e21bbbfeac05"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a7f7b1f6-4097-4154-b36f-6d2ba7195879"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a93b628a-1214-40e5-bdec-72c7705c440d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a9d6efef-456d-4b7a-bdf0-0a34ea80fb8a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("aa519cdc-d7d7-4fa3-a18b-3ddd3df9cd9b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ab5b0421-6888-4aa9-8592-fa30a8499631"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ab8c8d0b-3a5a-46b4-a314-ca8e39adf3db"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("acfe314c-6956-4a41-bcf2-22de2e940bb7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ad0489cc-a03b-4022-a604-795caaa7aeda"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ad4c7128-a7d3-473c-8ec7-2a4881ed3da5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("adaee3b7-5a3d-47d9-ac36-0ee0b69b6689"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("add6146a-f6a5-4e91-8f8a-c770310ba9fd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ae9ece20-8ffb-4e66-9c41-fee16d043e18"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("afa579ad-7b70-49cc-870d-d2edad106536"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b0194f0a-9bb7-4cb1-9f60-6a6412e3457e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b02de585-06a9-4e31-9367-c9c70a981d33"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b17362e4-c5ca-42fc-8d0b-c54939bfb2d0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b19f23bf-ef36-4b56-be76-65f691e344a5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b2da9b51-a60a-4214-bc40-e3e20b8f4bb4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b37e93b3-4dd6-4e62-8c1b-f6921bce2458"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b4054f78-88d1-4cf9-a20c-53ac2b40c6d5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b4552f58-2d57-4e89-b3e9-68234090f84e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b97a715e-f53f-4aad-97b8-423c36d90521"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b982941d-b76c-43b3-87fa-0b037a7390f3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b9904365-c49c-4c80-8ace-9b7381cf82c3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("baebb6af-a215-45ee-a56f-8874b8589745"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("bb1d8b6c-0b99-49b9-92d0-b93825fa1d85"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("bc698c5c-5f41-47a0-b3ee-72a5e70251e5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("bdaa5241-8229-4028-998a-2f66dd64dc3d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("bdecfd56-4525-4411-93d7-6cd21c6df38f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("be36c0e2-8ae4-42e7-a0ec-760fb75dd03d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("bf3863f4-35e6-479d-b42a-572d8ee8595e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c05ae179-3239-49f9-8f89-5449dbd6ddea"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c2f4ddf8-eff6-413d-a1e9-133753dae671"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c6ec473f-1328-44d7-99c8-ff8b2240cdad"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c77df024-d263-4cf0-8587-1e007b3f3d88"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c78646a8-4496-4809-92c4-515097bcdf6b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c78d8e53-5ee8-40b3-b850-333ee55b407c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c7b9ad78-1a20-4d41-88d4-c9ed6be916e1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c7dc4c14-68e2-4ab7-8dd7-95e8a890272e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c8a1a514-d3ea-4718-9616-b7c471de0821"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c9e32bf1-4bde-42e7-8556-8e6a688eb23a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cb18a9be-ad75-40bf-8571-ffa9a83c20d6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cb4b48e2-a134-4f56-86aa-754ce2c8e764"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cb6e4c12-7182-45d6-aa14-bfa9548f58c7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cc285fbc-99ae-42bd-ab7d-2f15fc4aad31"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cd2c96a9-920d-475e-9468-c06decb4a2d2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cf8397f5-605a-4203-b714-c545339f2d3f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cf84380c-2070-454e-a96b-aff6ab90a5a2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d057de0d-38f7-4fc1-847b-e463eecba9d7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d0c93df0-94ba-43d4-9d2a-e3c73e43d3b5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d138e71f-25de-4e43-901b-9836238dde40"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d162a50e-f969-426b-a0db-4daff944c570"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d1cdb36c-7dec-414c-8e9e-d2977cc4ebee"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d379f767-38d0-4503-964c-17e0c7a8e0e1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d4cec878-838f-4b15-abcd-4aee59d4d716"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d4d9683d-0aa7-4340-97d8-32f2ac3f2116"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d4ecc6e4-d312-44e6-acdf-d77fe40a0307"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d60b7b16-aaac-4a12-9fc1-117cf4648ed9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d683cc1b-399b-478e-9a40-a9f4c3a4ded9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d7f5c695-60da-4386-b4d2-7d54800fb111"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("dc5f680d-d700-4b85-b29c-53b360ea7b5d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("dc80305b-99b7-4065-9e60-3d2e4179992d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("de84146c-ad45-4de1-98c2-44e06e5d3d1b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e0aa11ee-7315-4927-ba55-a80abebdb53b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e1720543-6fdb-46b2-8136-a85b1b0d653a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e3175ccd-17ec-497b-a62b-5e3190a5f4db"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e318eaaf-b3bf-4296-820a-4b1f3f5f18aa"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e432b26e-b841-41d5-bae7-4c92a110d46d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e5821424-1d7d-414e-bb66-a29211cd7a3a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e5bf91cb-58f9-4d16-a06b-e6ebeec86a14"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e76ecc40-807f-49ec-9fea-0c2a490c3c2e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e7eb0d45-a9c5-41cc-980e-cc1e3a2c95eb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e97d257f-bf6b-4611-a7f5-e4ae64c6ad62"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ea81d272-071b-43ef-8026-0caa4252049d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ea9742ba-fd08-4f20-bcce-09a423a953a6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("eb7f9df3-a7b7-48c3-a2d7-52fb61635269"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("eb878efd-252a-44a0-8cbd-4483957b7126"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ec2411c6-c2db-43ae-bfda-475224e7fd87"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ed6c9aff-d305-48a5-82f0-4249c28a5a0f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ed8d9fc6-63bc-41cb-be62-b4b2819c5a41"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ef864a63-d7cc-4fff-b36b-541425bbeb87"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f1a1c775-37f4-4749-9b82-ee85728ca066"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f2a80af9-dadf-41e0-b334-a7d635156bbf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f2b1b9ce-9414-4aca-b32e-debbb04df920"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f31eb920-0f0b-44ca-848e-6727f08249a1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f3e602ed-9619-4699-9b35-295165099839"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f4a6f90b-8fa9-472c-9ac2-3dd425ab5b53"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f4c095bf-9527-4722-8938-9573140e2e43"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f4cac37c-f4e1-4370-a5fc-bb67e78b22be"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f5d1128e-bd1f-4bdd-b0b8-e0989384492e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f64f6eae-b5ff-4f94-a09e-0858eab94236"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f6b545ed-5e58-4adb-a5d7-5ea9774c671a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f7bcd955-ccbf-4286-8c07-fc7940dcbcc3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f8cfb4c0-d45a-41dd-9db7-d0ddf8f00222"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f99cf6c2-bb0d-485d-b880-d4e63bd69044"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fae85c92-f85b-470f-8fc0-5fe6de486ea0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("faeffa2d-dafa-4405-9509-4a82d65d7383"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fc002c5b-2658-4b15-9b15-8eabb861b8eb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fc429def-e6b6-4359-82b0-bdb4f6af6995"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fd9bbb27-cc2c-451c-b3f3-19b247ffbeb4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fdf3439d-fec8-40af-8f3b-ca45c0f7c3ba"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fee0e8e9-9abc-42f4-8649-4295a3a42ee0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ff2863f2-8f09-47a6-a01e-416ca71c7d3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("00ae8ab2-551d-4165-b705-056b80b8ec07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("013bc638-3922-4a45-a5ed-eee902ad3d32"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("02666dfb-4f2a-4b74-863d-03a539febf82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0bc5aa7f-11e3-4f53-9d4f-0833d8f5b7fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0cc30948-4285-49f7-bbb1-d5e59d4dc676"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0f366117-3708-464c-a360-6bf0c8a4a4b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("10cc2e40-fc93-401a-ba19-7acd728710af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("183ea002-b003-430b-83e3-5c7310bb9599"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1a4918fb-7f31-4314-9a38-a897e604f672"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1ab78ed3-216a-44a1-bb6a-0daa37f6a353"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1d20f579-8e4b-45b6-b558-e6cdbb12f930"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("21008cd3-c241-4701-b0b4-3d455755a602"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("28fe5968-83fd-46cf-ad8d-d43091403014"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2c87c429-b687-4696-bcd0-7b0e6a968661"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("320eee41-7832-4d18-9ef0-7888b3afaeb5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3249956f-60b7-4970-9ca6-de681d2ae9cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("36d2f49a-3bbc-4da8-9922-9fc128a19a5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("386e8542-8536-45eb-a51a-3900f8db79a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("38af6c1b-60af-4634-8c22-7d66ecd87887"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("409c864c-9989-4089-b488-b87d2c0d9933"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4577c43d-0029-4d02-8611-8a115da71e80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("482604c0-71bb-4b63-a835-cb505f83231c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("49efe4e0-2598-4253-8e28-13aa1355b441"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4aa491ff-7177-4c86-8204-9c9da29d9979"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4bd8aa05-938b-4c93-9af2-a2964f3342f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4daa55b1-8c1f-4aba-9888-9b3eefa01e65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4df396a5-e951-4871-a4d7-94ca24ea9edf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("54623980-f15f-47eb-87af-67f780c49754"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("558a4bec-3fa6-4e00-b900-bca8afe789c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("58658c9d-423a-4930-8ff8-e666dba6386c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d1b337e-c7ff-4a45-a120-e1a53734d31b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("64c0f454-9c6a-4c41-8559-3931127ef833"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("657fc828-462b-45de-8281-6339f50f3d4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("68a02d54-6900-492d-8dde-599d11304e7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6a153bd7-716e-4382-acc8-cb092f0fc41b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("71c5bae5-2cca-439b-86c1-805612205647"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("74d117b3-2827-4c4d-8ef9-89de1a0e8d4b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7bb2f6f5-dda2-490b-a066-354e5e58361e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7c29f4cf-4546-4535-9b0b-ef82b6cc57fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7c6533ac-3e1d-487f-bbc3-62b98c7fc7d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7f8a102c-3ffa-4b72-ae85-c5a76505f640"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8005b4e9-f8e9-427a-a055-a4b1a5548f58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8252ec2a-9853-43bc-92a4-eb66d6a6c150"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("83ac8196-0126-4512-a2c5-5384f0669c17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("857814db-30bc-4efb-9bda-7b70788835aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("858355f1-c18a-4874-9e41-ab684bfc936a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("89366499-029a-4f8a-a4cb-9b0096df8882"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8a43b274-0d45-4f18-9e41-9d572650a477"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8b484b0f-e761-4b28-bcdf-1efa4e0ca725"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8c8e4af7-5665-41da-8ee1-9bbf1c9ab202"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9da24f28-7322-4cbb-8a0a-8e494662a7e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9e1350d9-0e3d-4910-b630-256f4f479d1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a4b81067-94cc-49b8-8cd6-2981bd54a3d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a795cdce-aac4-41e4-85d4-f57a4d68faa4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a91b7e35-affd-43dd-adf3-12c8757201b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ad1ea74b-1133-401f-aeb6-91fb82e57e9d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af444ce0-8f98-4a85-84b4-fb6f4c6438d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b01d1026-6ad9-4e90-bb89-4ffd486a3dee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b7028e6c-d93f-49e1-a4cc-7d819d66cf4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b8956161-0915-4567-9590-f92a1fbed67c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9bcd671-d8ef-4e49-838c-6beb119f62f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bfdf6627-c5e2-41bf-97c0-e400f8ddcca5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9075353-6480-4dd7-83f4-4b673765b374"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cb9b7478-afa0-4a8e-9ec3-fdbda129b183"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cbaccb98-b545-4b10-b6b8-4c02c04a2f40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cf4d630e-121c-4240-8896-f496cd4731ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cf8873e1-a2ef-42c8-a5dd-c4c3e2bb5955"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d04f10f9-8f62-4bec-859b-a7e750e50428"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d5071c14-31d4-4b90-b8b2-625b84f50478"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("da07d7f8-6e16-452c-9a1b-9dd5f9ec3e62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dc9f2767-bf91-45c5-b488-8de4e042eae0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e6719eba-2243-4eb3-9b5f-a06405c46b35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e77eac57-2531-4b73-8377-912950b0f69e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8a174cb-65b7-40e3-9053-036123260f87"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("eb0a4078-948d-4488-bc48-ae7a5d397db7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f0447f2c-e34a-4009-bc39-fc0777819ca5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f3f534e5-a401-46b2-b9da-6594c147a075"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f598c18a-7c6c-422e-8ad3-0f859c83caf8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f9b7df7c-88e9-4bdd-a7a4-22ef8309c9a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fdc734a7-4e5f-489f-90c4-ca81c1f2218e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fdce191a-66e0-44eb-941d-f66f7ed697c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fe3d3337-e762-41ab-ad3b-0df4359a03bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ff691c13-976a-4fc4-9023-6f2e98866e1a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("03610b5b-4037-4054-a84f-ecadc7b1a664"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("06341fb1-3907-4eb3-9473-96cb7cf0e720"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("06dbe4f7-00ed-47a2-aba6-8dda11d20406"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("0901bd36-88ad-4faf-a977-b41b97865f2e"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("0d34cd69-99b2-43e3-83a1-b3071a843962"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("0f92b457-fcba-4d2e-aea6-67167bb24da5"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("0ffe4824-e2d8-4d75-b362-411d34c2fb33"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("10873ad6-9598-40f2-adf6-f6da7f977e92"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("14486f88-f410-414d-a093-b5ac5feb951d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("18415bfe-eb7c-4dbc-a20e-8bd84eb22897"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1da7e659-a1b2-4a0e-9dff-25cc292f223b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1e1dff3b-0bf6-4222-83af-4b7580b9d708"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1e2220d5-0952-4300-bef8-eee196b1def1"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1e6392b8-e2bf-4ece-815e-c3cd26c71030"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1e9f8a21-cd77-4f58-9e2f-b9ba5386bbd7"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1efa2558-56de-490b-a979-db0646905bcc"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1fcb99dd-3a7f-4342-a5c2-6fbe46e39031"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("20e70963-6e60-423b-b75b-230297267e90"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2100cbc7-4112-4d12-83c4-060bdb5d62f9"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("22035a9a-b4f8-4bbc-89f4-50c2449431e7"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("223b1207-f6c8-483f-b0ba-f6d0f3118632"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("239103b3-048e-43c1-bde9-84be6771479b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2531cea6-8652-4ab1-af36-0092c4f38055"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("25a593a2-5276-4ad0-9faf-32c57a0332ee"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("260135f4-47e6-479d-8c35-cf3fd5f7b3d4"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("277177d2-f85b-483f-bfea-23757f67b30f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2872cd68-49de-4ef9-b333-0b3d4a73c04e"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("288b014d-3ff5-456a-b886-c031e20a80f3"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("29633528-42e6-4d87-85ad-2e854dbf5aa5"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2bbabd20-6f1e-4d65-972b-b1ab1a1d3e39"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2c03df5c-63b9-4442-8a1a-4a68b1d71e09"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2c67e7b9-1920-43e7-bda2-0d11e0b63259"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2c8af3da-c2b7-453d-b8fd-877061f7fdea"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2dd0c0d3-4945-4c8f-9374-702f4a8269c2"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2e67efd8-7de7-4f7c-854f-6014de76d6ee"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("30bba423-ffaa-4ecf-b28d-5364012ce97f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("32bbcd8f-5d57-43e7-889f-b1fe5902b7f0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("32e525c2-087b-44be-b744-9aed266f71d6"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3470445d-e2cc-4b61-9cd1-dfe391b4dfc1"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("35c8f351-ded4-4dea-9e8d-eafbbeed4f3e"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3867c00a-64b9-4216-92b1-7e4579599cbe"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3979f845-ca7b-4cec-95c0-770dc676f5fd"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3a6e4d9e-8087-4bd8-bdfc-1266a040afbf"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3b33e90e-4c76-46c0-afdf-a7b5d6e385c1"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3be2017d-aed1-4918-a87c-491470ba1eb5"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3d145f44-f358-4e02-962e-a1e666656062"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3ee0e2c1-e022-4615-97f4-d9854ba578ea"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4031b05d-8328-4d1d-a87a-de460a34f908"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4392e70c-1857-45e1-b970-b08a1c8de70f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("43b62ec8-799d-404f-aaab-2d5c31eb3a04"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("43e12c47-cbb5-4a81-83ee-e176ea8304e7"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("46c62a13-06bd-43d2-a012-35fa81c2aae3"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("470f3a95-bab3-4e8f-9f4b-03287ca2647b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("475077e6-9460-46d1-8076-df3878de95b8"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("48f24b73-178b-4e39-833f-416f15843a16"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4992e8ab-77bc-445e-8b68-d13f63a293f1"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4ca78002-ef29-49f0-b189-fcbeaa0e0212"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4d34014a-a460-46ba-b90e-0f0d41ad0fb7"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4e0b028b-0bc8-48d0-a1b5-0b61ba1362bd"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4f83ec94-1f3d-45cd-9057-6ed527ac41fd"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4fc835ce-37fe-4f88-a8ba-d2f7c848b713"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4ff3b8ca-649d-4eaa-a9f8-77068015f4b8"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("516743eb-8a80-4b7d-b3bf-203afee1cd41"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("518d7bd2-e24d-463c-b95d-94abf9af34f8"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("559c5b2c-3178-4bfc-be20-94adc96e4207"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("57ed5cbe-f389-46ac-935f-b3d9037cd273"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("58990a7c-afb0-4bb2-9047-47ecd1a3f1e8"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("593f2365-e4f0-4e24-9017-64bc46fb7482"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("59c68637-381a-43f8-a086-04bba7ff2aee"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("5a5ef7e1-bf84-4969-a7c6-4fa39f86d06a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("5ae397a6-493b-43e9-a86e-75fa74db348a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("5aee3eb0-b031-467b-b8e0-73bac5d3c5e2"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("5fd74558-bc49-4bf5-9aa1-76241450b7e5"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("5fe14e48-65bf-4669-a065-87e11392af75"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("605037ab-6d07-43cd-ad1e-c24b0792448b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("62466825-570c-4902-95e2-a4d1bba22a6f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("62eb0a74-6011-4e62-9456-528f8c95a310"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("63132a41-0bf5-458d-b714-85ae34da6cd1"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("63a73ffc-c5ee-4b78-9285-f30d4558d894"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("676763b8-71e6-455e-ba8a-17883af44284"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("67bfdb63-fad8-49da-82d8-06c5777b4cb7"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("68fd54d5-ce8c-4761-a0d5-fca7ea7ec835"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("6aae2034-5b43-4979-9825-9f5f05bd387d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("6bc95627-a96e-4e51-8982-b31796cf0187"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("6d6e579c-a756-4aa5-8632-43cadc8c4ca6"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("6fde8654-9e68-4809-9b6b-550f78b12de8"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("70c619d4-ac4c-4d7c-ba8e-3b25371c3dd0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7172b6ab-2aae-451a-8175-d0233432b9c0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7191816f-7ebd-4263-bc3d-4fa5b9f283dd"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("729502d0-1e14-4aed-998d-7cf82b733382"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7321cd60-d602-4bcd-8537-1fd9072aa40c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7638a834-b4fa-4572-8127-730524bb2dd8"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("77b5019a-a4f0-471a-b810-798e7af263ce"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("77e544dd-ff0e-4176-8b3d-006055a202b8"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("79f72a4f-acbf-4739-9688-0a9f75142eb0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7b3afb15-4aa1-4d92-bb35-53fbc58c037c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7c051533-fc73-4330-a378-3230804af154"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7db84709-d843-4f95-9dae-d545f6e6338b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7e4ca17d-97ba-414f-a35e-5e8062192529"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7e5d02de-6c40-42a1-bf7d-56912d44c069"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7ea98337-9034-42d8-aa2f-08ec09dd617f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("80e6d0ee-6f43-4453-be73-43a2f049b195"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("85327d77-a82f-4779-a63c-8f6904acc952"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("872901fe-3067-409e-9dd7-3f3fa8c10679"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("88015284-1318-4afc-9cc2-744e09e33228"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("895e5c87-0f28-446e-a25f-24776ee4b353"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("8d3f117b-4ec7-4fec-a2de-792093a07571"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("8e72be32-e43e-401d-a828-55b09ebc8780"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("8fadf2cb-3d3e-47a6-b81e-b682bef12f9f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("90403417-a6d2-439b-b163-78d18d43acd2"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("914cac02-d120-49d7-8cd7-a99f4c752d25"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("919d8927-96f7-4c46-bb8d-950123c723b3"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("91cfa02e-61d9-455a-a53b-597bdaeaa28d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("91db988b-04c0-4d54-9fdf-d4944f113e70"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("924783eb-a7bf-473a-99d2-9e36525cbf50"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("9313bd6f-08d6-40a0-bec3-12b90a0a35f5"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("93c40b44-278f-4018-bf24-22952d3d6b45"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("948cdc75-4cd5-4aa8-a538-80550f4e5cf3"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("963e95bd-797a-4943-aa6b-a936a1704991"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("97d9c753-7047-491c-b75c-f756c7585621"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("98e4dded-b603-49e2-8b09-5b5db9500bfc"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("9d6bead2-b602-408e-9271-49950527d96a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("9e217dbd-ceae-4517-8ef2-3e7fdefa5293"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a1be0d78-b866-4a13-8c4e-9f9d02cee163"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a2232aae-56df-4dc3-934f-fab1d7ec2e0c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a22abd5e-aba8-4616-8962-e6b3fb4d73e0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a2b6fd02-1c7e-4062-8da1-4d73154ef6f8"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a396308b-8b77-479a-9c1f-5b9e61879a68"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a3c24839-c566-48e9-9ca1-33f649b2e42a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a4b6935f-b7f8-41fd-962b-ff6ef54f6227"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a5716aa9-7ee2-4b90-b15b-6e334eea7c93"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a762b75d-21a6-407e-a35c-7d6e654559c3"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a7b67079-fad9-45df-8727-a3fd76b80bc4"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a8af5b6c-0087-4c67-8d94-e14a88348077"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a8e2ee20-4e77-4d99-9592-90365a8ac383"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a90775eb-7298-410f-9092-910cb0729c28"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("aabfb3b4-d525-4dab-b423-ba83cc709a6f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("aad9dd62-44ea-47d3-b4b3-2865243e027f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("ab7a7e55-a0df-4a0b-aec8-f4c6f81d357a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("acfaed50-1b7d-4e17-a80d-74110e1b5b6f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("adb8304c-5ddf-4c04-b193-950e25528710"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("add0e35f-625f-47af-9dee-04887175c4c5"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("adee9413-1906-46fe-a48f-387ab8dfc0e0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("ae3a448c-f6af-48b1-97b9-e3e47595c340"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("aed27351-81c7-481a-895b-a055e05d8d87"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b03c48b9-c950-465a-816b-c6d4ed44587c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b12af50d-18d2-40d7-92fd-ef4512ffc04b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b3060bf1-89db-49eb-b020-db800b393b1a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b42bb8c1-0240-460e-8350-b0be1b4e26cf"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b560cf3d-2d2d-42b9-b069-4b5ec5fc7c8f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b66d71a2-5587-4259-b130-d3cb8cadd564"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b6bb6efc-de64-4495-aa8f-4f0f76c700af"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b806df84-b1d1-4660-9170-70803ea05a2c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("bbd30480-795b-4a4a-836b-d771aefd4deb"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("bdb1cd4d-dded-4dca-82ee-53e7e2d560a9"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("bf5da25f-c4e0-416d-a110-de08c7918e02"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("c1d4f26b-3a84-45fb-b1eb-779e41b9e5ca"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("c6a5aaec-3e35-47af-9a54-087ba1f47892"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("c6f5c201-a498-4d7b-b216-6b6f78b0b3fa"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("c7a41ae1-3c15-4900-94a9-02721f869e03"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("c8be608c-cf79-43cd-8f62-8f15616848b4"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("cabae128-d284-4915-a74a-2ed60aff9ad8"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("cba4c791-8d90-4d12-b2e9-0a60dbc7a882"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("ccb9a02e-0284-44af-add8-db7edfca32c4"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("cd01a67e-57b4-437f-a729-a095086c1027"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d0ae5c49-1261-4f2a-99dd-01b8a26c50c3"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d1a66c6d-1cf3-4d26-9a99-c33d9d634bfe"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d1e90832-987d-45e5-be06-22219597fe2f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d3a43c9a-3a1f-4bc7-9c9b-e0bef5ac84b7"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d5a669fa-f03b-443b-90dc-54f38c1e4ef6"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d71837a4-6918-4adf-b375-478eff4b487d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d75698b4-b980-417c-9c00-c865fe1c0920"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d7d179e3-2bc9-4e83-b1f8-836a47b9b9f6"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d90c6622-657e-4c21-bdd7-ded91f12809c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d998827b-d6e6-400c-8a7e-efe03d304069"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("da494c09-ad65-4aef-8ca0-716fa32095d4"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("db29446a-7d54-4595-b77a-b1baa5a1dc5a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("dc82566a-82bb-4e54-9f21-9ba4c4c6f4a6"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("de84ba60-7d90-45f3-82e7-da320cad1357"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("e080b155-8426-4051-bf24-111cbfc5a4e2"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("e241bb44-4886-4bc6-9e8c-10a7bb23beda"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("e391e7c8-d41a-41ab-837f-709e90b70281"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("e42eb151-703f-4e19-880f-89121f336ebe"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("e617df12-ec95-444b-95e1-fe8094fee542"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("e6fd0df5-92bb-482f-afc2-7594c098b534"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("e8275a88-79cf-4423-95f0-c9fd8465c792"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("e9c516c1-c2b2-4605-b2cd-511fd309bb6e"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("eb05b455-83f5-4740-ae21-15b998b66aa5"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("ee3fb07a-2884-4fcb-9416-bb26d9c93452"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("ef0c61f1-3bbe-40f8-a3f9-17a2747aef20"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("ef65836c-1b47-48ac-8ec4-14bc4400fbb3"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f05d1fb9-bb19-4efd-aa96-c8a281af7947"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f0c35027-9c76-4475-9db8-566b63f7a757"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f187506d-4663-4fc1-ae0a-9792d62b32ca"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f1fcd2af-a1f7-4346-bc7e-76efb3c8a94b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f38df2b4-28c9-48d9-a513-d5fd0212782b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f615f429-e0c1-4dc4-87b8-3a23f37e9bd9"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f7037e37-779d-428e-9eef-20c5fecba69f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f713de81-a98d-4f27-9e6b-31ccd73d6bb9"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("fca1a99d-47fb-4173-a6de-e1679ca219f8"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("07ff37d9-c017-4785-8f02-91cf373b9bb8"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("21e2d819-f50d-427b-87e9-5e3af85d5fa2"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("285b2dba-ec21-4d69-8e29-bd7cb2098b87"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("2d2894f8-5239-4065-8ab5-6671554d1243"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("34bf8621-29c9-4449-afb2-14e6bb137370"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("666c85e6-de13-4149-88db-9084c01e3bb2"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("72b29e5e-d0aa-452d-8875-9895ca4095a7"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("81e6f268-e679-4563-8dbf-6b16193d769a"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("92d11367-2610-4694-8de6-b68926918aef"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("948c69b1-ea9c-40e4-9468-fddf67fea795"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("9a46cf1f-1a6e-4f76-a56c-ab6bd00274f6"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("a7b82c28-fae9-40be-ace8-c110285ff23d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("a7dc9e6c-d2bc-4ea4-9a61-af8ea65f5b0d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("d333f141-b417-463e-9561-a675c062453c"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("e068b748-dff4-482e-84f3-394957affb5b"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("ea118175-296c-4869-a7bd-109332145d60"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("f37fde46-1469-4cf6-b52b-133a237a04ad"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("fd9ba93c-26ea-4614-bbd8-0ed54229ea1f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("016a5946-853a-4499-959b-8b5179a88bfa"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2257a4bc-8152-4802-a0be-7128f81badb4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3d0a2fdb-7d99-4ecc-ad0a-2d9ffcbd898c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4d84a65a-1422-4ea0-b457-74f32ee2b4a0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("625544e8-3799-45f7-af8d-0880df358a1a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("66d2b104-0c29-4884-b7f4-343863796a42"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6861e4a3-845b-4b0d-82d4-eba107d13973"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6e8c4b98-e32d-49d7-9643-bf3bdc87833f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("72279ce1-90e9-4991-bf78-5a44c7141215"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7e914d1f-5ed7-4d95-92e8-2090ceddb918"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("96a4cb3a-1df6-4fee-91c2-34d23e34c565"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("aef60cbb-b544-447e-b60e-9ddc9557dbce"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b00a45d3-a191-4b88-87a6-0664462624b2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b2b37e2b-e611-4cf6-898a-974bacd3be35"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d05bb8cd-15c4-49fd-be32-1de4ba9d1b79"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("dbd0cc8c-1de6-40a2-bdde-afd30b73991d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e5d973de-4310-44d0-be6e-13b12120bd7d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fb1f55ac-3dd9-41af-8edb-d4ef091e8727"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("03eff380-419a-4d7b-8557-62e8975580ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2137556f-4768-41f2-98e2-25a6d39cb415"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("23d1768b-4f7a-4571-b5c4-ec4622a57fa7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("35c51a64-2724-4738-b543-6cc85e8c8b05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3a12acfb-bcd2-445e-a610-d9c6a8c3c3d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("43eea13e-8bca-4aed-b74f-83ef9a3bd24b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4efc17ba-6851-4a49-8494-a9fb9406264a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5c61f97e-1701-47dc-8742-9aa2cb04ce43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("795302ec-26d9-435c-a283-29d4e19eec52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("79abe60b-45b9-41a1-a74b-6869b5d9ad4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("853290ec-d3f6-4e00-8c1a-a48f5a0e8e23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cf42d463-ae9e-4589-b8c5-1d259f28759e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d06e51d5-ec3b-4308-9988-4b64b9063528"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d3a12e33-6d40-4dd4-93e4-cf8a70aed034"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dad1173a-e7af-43cf-a60b-df255d0ae96b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e920a850-8155-4d64-8aca-9ff656b9ad00"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f375e8f7-5ec9-4cc5-b39b-55a66dcf6d9c"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("323c57a2-5d94-4d8a-a02b-bf54d4d15cbd"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("3b759ecb-6d37-43b6-ae32-8c4d1faacf61"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("434e3f0a-3753-4db1-8fe1-f947b389ec4b"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("4d192f92-ad4f-41de-ab5d-1d8daaa79af1"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("79bf5306-406d-4cd2-a5c8-8b33122125d3"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("8b829f50-e314-4f31-b691-6bbc6c427b7f"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("94b496f6-f020-4fb6-b4f3-17ef5d6bbed6"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("97fdbbd6-4b14-4972-821e-6ad645791d71"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("a020f341-4ef8-421a-adf1-840e62c5c593"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("e2470176-3b8e-4c8d-ae75-dda7ad36d0bf"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("e732ebd3-9d68-4919-99b1-bacaf283ea5a"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("e740f243-8c1b-4cd0-af1e-eab8411830f2"));
        }
    }
}
