using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BillsPaymentSystem.App.Migrations
{
    /// <inheritdoc />
    public partial class AddInitBogusData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "BankAccountId", "Balance", "BankName", "SWIFT_Code" },
                values: new object[,]
                {
                    { new Guid("00e7a70a-bd3e-46b9-861d-1380d77ddf96"), 8499013.4463625195000000m, "Hartmann - Macejkovic", "6891461529490" },
                    { new Guid("01d15201-400b-4ee1-8102-7acac9d7bd18"), 5472431.6496299955000000m, "Ruecker, King and Heller", "6987784557873" },
                    { new Guid("03e422ca-680a-4541-800c-988f7d0cc3d8"), 8193707.028035715000000m, "Kovacek, Roberts and Cronin", "4785660993430" },
                    { new Guid("081bc379-8ed1-4aea-859d-465fa7cca68a"), 5166554.590354360000000m, "Pollich Inc", "0346477707036" },
                    { new Guid("0d6e4c57-efdb-4112-9005-f1d7b6322a7f"), 6078244.152414405000000m, "Koepp - Harris", "9210704402609" },
                    { new Guid("0dd13631-c4c5-4459-93b5-7a39e1777c13"), 1651459.3898722690000000m, "Anderson LLC", "1793529998505" },
                    { new Guid("0ee60daf-99f2-42bf-9bb1-eed88ca25699"), 3748556.5100827140000000m, "Tromp, Koelpin and Hills", "3599098075283" },
                    { new Guid("0fe3786b-53c6-45ce-9cc9-2355c822789b"), 5926589.8930009015000000m, "Christiansen - Hartmann", "6824105789950" },
                    { new Guid("11ce80c7-ea8a-4db3-9792-0f64f361e266"), 4482401.2465625545000000m, "Cartwright Inc", "4996553758252" },
                    { new Guid("1cd41421-b9c2-4a51-aeb2-ad63da40b0a9"), 7146134.7942230190000000m, "Cummerata Inc", "6799207451169" },
                    { new Guid("26f8ea71-e61b-45a4-86a0-ac6c79fd74f3"), 9508908.4415843495000000m, "Quitzon and Sons", "9118994809316" },
                    { new Guid("2bc7b32a-36a2-4427-8ab1-14898bfd619d"), 9081419.2837195070000000m, "Gutkowski and Sons", "4496031627327" },
                    { new Guid("2d2edd9a-3e07-4aa2-80ba-faae20a20dab"), 9270437.9373034960000000m, "MacGyver - Bruen", "3377666333931" },
                    { new Guid("378726cc-f974-4475-afe4-92afe0cbbd58"), 6453750.775241140000000m, "Abbott - Hills", "3829541110385" },
                    { new Guid("4040073c-988b-4d03-b9b1-e6a9afc104ca"), 4734752.4007296495000000m, "Morissette, Emmerich and Harber", "9151282843425" },
                    { new Guid("40a60257-6787-4784-9c8c-73906f8f33e8"), 1515610.2452857660000000m, "Schmitt, Kuhn and Wolf", "7904217621603" },
                    { new Guid("412bc6af-6e56-451b-941f-8fdbbe34ddb4"), 9895272.2317338420000000m, "Schneider Inc", "0412802835849" },
                    { new Guid("42cb6b96-72a2-4c7a-a345-a6537575fd56"), 3947379.0215619410000000m, "Reilly Group", "8461250565602" },
                    { new Guid("430b4a8d-42d3-4c05-b312-8a32331dc3fe"), 2216630.1212519665000000m, "Denesik, Lubowitz and Considine", "1976049995562" },
                    { new Guid("4373d3c4-1234-472a-ad61-5e858239afe3"), 5746312.92385360000000m, "Gusikowski, Bernhard and Deckow", "9322937318180" },
                    { new Guid("43e8a91d-3288-4732-91ca-4b0d305888ca"), 8703024.1947800410000000m, "Metz Inc", "2806815641951" },
                    { new Guid("4789085c-d9d5-4bed-8b15-ae7143607e31"), 9593137.0944316560000000m, "Gulgowski - Schiller", "8204545333933" },
                    { new Guid("48c513e1-eb2b-405c-9b29-5589dab79647"), 6398210.6347295345000000m, "O'Keefe - Kub", "0076409085771" },
                    { new Guid("4e7435d9-66fd-4341-b7cc-9aa80a0e615c"), 3916783.2091530580000000m, "Kreiger LLC", "8420281543294" },
                    { new Guid("531ee085-220b-4e36-9c22-103c82e74daf"), 6712951.9154037155000000m, "Stoltenberg - Becker", "4779252577191" },
                    { new Guid("5fd9425f-0171-489c-8b8f-5368b5608f9a"), 5297124.4983385495000000m, "Goldner - O'Connell", "3393363701569" },
                    { new Guid("63c803bf-629e-43ee-983c-1418cf77e31a"), 7653713.9024431085000000m, "Gibson, Lebsack and Dickens", "9350993042015" },
                    { new Guid("64625a7a-d65e-4fbb-9295-290198548d72"), 8151843.2615100925000000m, "Schumm - Walker", "5919291250481" },
                    { new Guid("658845ae-0f66-45bb-94b1-338d7cf68443"), 6589846.8573403670000000m, "Dach, McClure and Dooley", "5058434831061" },
                    { new Guid("66cca60c-0aea-4d73-a516-5b1c40a8b624"), 1404422.87154714765000000m, "Botsford LLC", "5407052805846" },
                    { new Guid("674f8267-cbcf-495e-83c9-3f27b95f91d3"), 9390895.3880424310000000m, "Cruickshank and Sons", "6302382921619" },
                    { new Guid("6981b720-7323-4eec-8858-afadbade71e5"), 2213809.9490026705000000m, "Schneider, Harvey and Ruecker", "8035909073673" },
                    { new Guid("6dc5bfa9-ddbb-4565-b41f-e6435475a283"), 5282638.4422969585000000m, "Bruen - Kilback", "9691252254443" },
                    { new Guid("6f6714da-4b47-4710-a226-398567b05654"), 651395.28609215815000000m, "Jacobs - Kihn", "8095040063360" },
                    { new Guid("73c7dde0-6869-4e9c-b8ed-b849c433f046"), 2654299.6682082385000000m, "Feeney - Lemke", "2781360551118" },
                    { new Guid("76c444f4-ee43-41f0-93ae-3fb8eecb0d48"), 7908485.8268814490000000m, "Pagac, Franecki and Russel", "6271062617152" },
                    { new Guid("7849c595-2ed6-45f6-a271-275f9fe63ab6"), 8638841.3605644070000000m, "Simonis - Collier", "8638825278025" },
                    { new Guid("7870b425-0000-46de-bf4d-6a2c6822f22a"), 8165351.1971088980000000m, "Erdman - Gottlieb", "0326010690506" },
                    { new Guid("78d7d057-49eb-4005-8d6d-dad8860c6f7f"), 1123704.91326848135000000m, "Konopelski - Cummerata", "7110153051880" },
                    { new Guid("790f67b0-114e-42ef-91c6-e7557f96c04b"), 2632811.2198884860000000m, "Green, Schulist and Harris", "5481941886345" },
                    { new Guid("7b88feba-334d-4287-8225-c06b61bf08cc"), 2281493.4648881105000000m, "Kessler, Murray and Hickle", "7867516884684" },
                    { new Guid("7c0086b7-892f-4ce6-9443-84c21de7c280"), 2380816.9723782915000000m, "Keeling and Sons", "6888632167483" },
                    { new Guid("7c2105a9-416f-4cef-94aa-ac7e2c4c1b69"), 9360625.5232984975000000m, "Conroy - Ryan", "8663669644576" },
                    { new Guid("82430c7d-48fe-4bea-abee-e40b46be9ab9"), 7412920.8925303180000000m, "McLaughlin - Marquardt", "6002415819295" },
                    { new Guid("83666ac4-32be-41c8-b48e-7e43c4b4774c"), 559252.388935148360000000m, "Lindgren Group", "7074012937350" },
                    { new Guid("8c039e94-417b-4193-b7fc-54f80f42c948"), 9154863.7648461135000000m, "Stanton, Feil and Rohan", "1943019045381" },
                    { new Guid("8dd0451d-abc4-4df7-bab5-6fd3d2450bf4"), 9623254.3571548420000000m, "Cassin Inc", "4740051905621" },
                    { new Guid("8e793ea7-d9f1-404d-ad80-a89a14f23964"), 7098903.5477527705000000m, "Roberts, Jakubowski and White", "1194645084439" },
                    { new Guid("8f8f6d25-5781-44c1-80f8-be6ad813733e"), 1527330.4288161110000000m, "Mann, O'Keefe and Rath", "6427395735753" },
                    { new Guid("913dea16-6cca-48bf-90dd-7fa24f755a8d"), 3252868.721183870000000m, "Wiza - Hansen", "9871104628626" },
                    { new Guid("92522d06-f1e1-415e-b7bd-d5145f84e4e2"), 5002696.269553475000000m, "Strosin, Gulgowski and Pouros", "8003778707272" },
                    { new Guid("9402b6e8-1b33-48fc-af77-b2127a018373"), 3154389.4198867605000000m, "Ullrich, Kshlerin and Kertzmann", "5592395041546" },
                    { new Guid("9533d33b-e634-46fb-988a-cce0ba7ecf97"), 5517952.2624477265000000m, "Hills - Effertz", "5306990028457" },
                    { new Guid("9560cd3b-57af-427c-a475-95cd232321c9"), 6254779.1334320145000000m, "Keeling Inc", "2102104429904" },
                    { new Guid("972af4b8-a601-4bde-b84b-b678ca456528"), 5497599.8331646590000000m, "Sauer - Kuhn", "6125450502400" },
                    { new Guid("9e18711a-75ba-48e6-8e41-b97f914d53b3"), 7848463.1803710510000000m, "Langworth - Gislason", "6746842642070" },
                    { new Guid("9eac5a1d-0aaa-4413-b2a0-70d397f430c6"), 7395216.8862660030000000m, "Hettinger - Rohan", "5856650587027" },
                    { new Guid("9fc3c343-388b-40ed-82ba-2ef104bf1387"), 5931615.8914071060000000m, "Shields, Altenwerth and Rice", "2642706090794" },
                    { new Guid("9fd14637-c8d0-46a1-a4fe-0a7acb5dc243"), 6179716.7173817825000000m, "Stehr - Zboncak", "0495647905564" },
                    { new Guid("a1ab0ed6-ab42-4250-b6e8-66b083aa3481"), 3366788.1535133515000000m, "Hansen Inc", "0457678379608" },
                    { new Guid("a285c8be-92e7-4683-8839-152c25f41f84"), 8927335.7321078375000000m, "Wilderman and Sons", "7012668120528" },
                    { new Guid("a55a9254-a56d-4131-84d7-8a37f63f9c20"), 8397741.2521140985000000m, "Bednar, Aufderhar and Corwin", "0305821303607" },
                    { new Guid("a5b328fe-61bc-449c-8bfe-c1198164aeee"), 2582698.349529865000000m, "Becker, Labadie and Cronin", "6177358539040" },
                    { new Guid("aa3e0f9e-7b06-4c00-a71c-607939905724"), 2311073.3489555605000000m, "Ryan - Wehner", "0676460887668" },
                    { new Guid("ab13be98-948e-48ef-9e00-6420df0771a8"), 567333.904818305940000000m, "Lesch Group", "4935330400762" },
                    { new Guid("ac01859a-06f1-482a-a5ce-70de7be7b74f"), 4497689.3274605575000000m, "Gutkowski - Kemmer", "3057324485546" },
                    { new Guid("acd58c61-8d92-4d32-aa31-7b2743c4764c"), 2600438.6178107330000000m, "Turner - Schoen", "2243713592648" },
                    { new Guid("ae45e985-678c-4357-ade1-a6cdb325aa1e"), 8156960.2386846670000000m, "Carter, Schroeder and Harber", "2680870160127" },
                    { new Guid("affbd67a-4023-4572-87e9-0e23572e1610"), 2551371.1750101855000000m, "Fay, Wuckert and Morar", "4147430800124" },
                    { new Guid("b8a3fdd9-626d-485c-b64a-0c752f3353a1"), 2802252.9815428055000000m, "Ziemann LLC", "3801870176065" },
                    { new Guid("b8c5d7f5-e1ce-44e5-84b5-b0e0887b4620"), 7809390.5335522570000000m, "Osinski, Casper and Koch", "6840015042626" },
                    { new Guid("b924df80-cac2-48dc-8fb1-ae14ec12e3c8"), 3295010.3806516390000000m, "Cormier Inc", "3597089912814" },
                    { new Guid("bc2b2eb6-aad6-46fb-809d-859f005927c7"), 3283177.111189995000000m, "Feest and Sons", "4619393154809" },
                    { new Guid("bc2e694c-0099-4b80-97e6-3c974323af22"), 6903962.6738065120000000m, "Cole and Sons", "8232464545069" },
                    { new Guid("bd60acd5-cd49-454c-bbe2-85fe778f5231"), 6610904.7042655810000000m, "Abshire Group", "6303518791281" },
                    { new Guid("be34fc95-9ec6-43cb-9e6f-71b9fd5cda6b"), 5064003.3975801715000000m, "Schumm - Koss", "7201486493659" },
                    { new Guid("c0705231-bc8c-47d4-9ebd-4601c19b613e"), 4452128.5685871740000000m, "Carter and Sons", "5531933937194" },
                    { new Guid("c1e45f04-4924-467f-9739-0a8abcce303c"), 2335041.5320860720000000m, "Wilkinson, Labadie and Dibbert", "7229759032947" },
                    { new Guid("c476dc74-f894-4cce-8098-5c23cc4409c4"), 2722185.375537035000000m, "Pagac and Sons", "0543838286210" },
                    { new Guid("c5e06ade-5abe-4531-9fb3-859dd718120e"), 9995719.9781500045000000m, "Schmitt - Dach", "2619445726406" },
                    { new Guid("d0c3ad32-7c6f-4517-8830-8efe49a547f1"), 8252204.2367896420000000m, "Hackett - Hintz", "7432475054319" },
                    { new Guid("d2a141a6-851b-49ab-9f43-d52ea0685a80"), 3209897.7059494395000000m, "Mohr LLC", "9332044488249" },
                    { new Guid("d2c344a0-9ec6-4d10-9226-0bbebf397358"), 1381569.25951014280000000m, "Koch LLC", "8276936867495" },
                    { new Guid("d5389cef-6940-4001-a524-6c9916220866"), 8245520.0685102465000000m, "Sipes LLC", "5588435921169" },
                    { new Guid("d90371e5-138e-47b8-9baf-f98404198c98"), 3407682.2268796155000000m, "Metz, Connelly and Connelly", "4878105313815" },
                    { new Guid("dab134e6-c8b2-4be7-8f7f-f80ce751ce14"), 6579867.5990344510000000m, "Reinger, Thompson and Harris", "2546363041567" },
                    { new Guid("daf22b48-ff8b-4a7e-8912-af105184c93d"), 5131828.0121819625000000m, "Rath Inc", "2953251149272" },
                    { new Guid("db719239-2c21-43ee-bf82-3c882e42e40e"), 3634603.6722696585000000m, "Cormier, Kovacek and Lubowitz", "6566162384920" },
                    { new Guid("dce9becb-b137-4622-97fe-44ef41157d42"), 4961451.1409683760000000m, "Vandervort - Heller", "8393789769209" },
                    { new Guid("dcf06a17-2238-41df-a408-60f8e5224799"), 1058549.10257722025000000m, "Auer - Macejkovic", "2007713222802" },
                    { new Guid("de46a09f-396d-42e8-8ede-876cdd77540d"), 7650259.4019948640000000m, "Turcotte - Olson", "9987191815198" },
                    { new Guid("e041c86c-aba9-498e-a7a4-f92cf4e02169"), 8110535.069468835000000m, "Fadel Inc", "4550281457698" },
                    { new Guid("e141fd37-26e8-49a6-814a-aa64294b4e01"), 2917328.2415447635000000m, "Gleason Group", "5642410771207" },
                    { new Guid("e44a6288-e2c2-4f19-8ae3-1d92c53d61fc"), 1285149.48086840995000000m, "Legros - Durgan", "0009587713266" },
                    { new Guid("e7c930d4-91f9-4fac-abc4-357478f042e5"), 6948349.3428803040000000m, "Cronin, Bradtke and Kozey", "9515349882305" },
                    { new Guid("efc629d5-a594-4c77-a1f8-0355f13b2a1a"), 3436222.5567878940000000m, "Hettinger - Johnson", "0312000934316" },
                    { new Guid("f0f396b9-69ce-450a-83fb-d3a7995bf0ad"), 1800684.6758023845000000m, "Vandervort, Waters and Daniel", "9913202721714" },
                    { new Guid("f5c86921-1887-4016-a74d-bbe11a51053d"), 5587020.2639794620000000m, "Stroman, Pagac and Wuckert", "9021001131082" },
                    { new Guid("fdd1480c-1882-4775-b938-bcbd84a9d241"), 4025592.760182580000000m, "Hessel and Sons", "0695927476405" },
                    { new Guid("ff69d252-ed07-4b03-b4cc-311fb3dce3c7"), 3230069.9914569235000000m, "Buckridge, Schmeler and Runolfsdottir", "7804953685450" }
                });

            migrationBuilder.InsertData(
                table: "CreditCards",
                columns: new[] { "CreditCardId", "ExpirationDate", "Limit", "MoneyOwed" },
                values: new object[,]
                {
                    { new Guid("00a53bf1-7e01-4c0c-b0e4-a178ec5d7943"), new DateTime(2031, 12, 30, 16, 38, 25, 528, DateTimeKind.Local).AddTicks(1718), 2910.0307173822100000m, 4158.5297189808050000m },
                    { new Guid("01fff532-1f50-4300-8681-21cd71087245"), new DateTime(2031, 5, 5, 5, 38, 46, 181, DateTimeKind.Local).AddTicks(2865), 3763.5122958208900000m, 3294.5047762055550000m },
                    { new Guid("07233cd5-3b8e-4c67-9b9d-b3708c07d7cc"), new DateTime(2031, 2, 5, 5, 33, 43, 895, DateTimeKind.Local).AddTicks(3128), 3220.724183288450000m, 259.94875075021150000m },
                    { new Guid("0d65cc7c-0fd1-470d-83a7-fac4d4fad336"), new DateTime(2026, 9, 27, 18, 22, 43, 138, DateTimeKind.Local).AddTicks(1471), 3698.59850965650000m, 1975.7065355348050000m },
                    { new Guid("0e8bcb0e-977e-412a-84cf-7e24815c55ba"), new DateTime(2031, 1, 9, 18, 35, 27, 924, DateTimeKind.Local).AddTicks(9243), 2961.997824911050000m, 497.44683906864550000m },
                    { new Guid("0eb8a94e-08fb-4406-aba3-2f7dd90cb45c"), new DateTime(2028, 1, 26, 1, 5, 2, 882, DateTimeKind.Local).AddTicks(7312), 310.92510456811350000m, 1158.364625093350000m },
                    { new Guid("0ed150fe-384e-4d8a-ac7c-47ef03c2a13a"), new DateTime(2024, 4, 15, 17, 6, 27, 287, DateTimeKind.Local).AddTicks(7247), 4791.8803588014400000m, 2037.2137623282750000m },
                    { new Guid("15c49606-706f-4003-94d4-b2c762996f99"), new DateTime(2032, 9, 22, 16, 51, 52, 449, DateTimeKind.Local).AddTicks(9109), 1438.2566152834550000m, 2418.8414135819450000m },
                    { new Guid("17ae01d4-430a-4eca-a837-a02af69e9d05"), new DateTime(2030, 6, 2, 7, 34, 56, 676, DateTimeKind.Local).AddTicks(1045), 626.0313184511050000m, 419.27499772866450000m },
                    { new Guid("188cee33-a456-49e0-b1fc-a01287bb50ef"), new DateTime(2023, 12, 12, 7, 45, 21, 624, DateTimeKind.Local).AddTicks(2583), 2170.6254201997450000m, 1081.5981352488200000m },
                    { new Guid("194f7826-39d2-47ae-a0b6-40e56255a23a"), new DateTime(2029, 7, 12, 4, 13, 13, 510, DateTimeKind.Local).AddTicks(4558), 2106.1240377461750000m, 645.0343369221750000m },
                    { new Guid("1f3f851a-6944-4fad-aea1-a616cfb6a8dd"), new DateTime(2029, 12, 26, 6, 48, 19, 222, DateTimeKind.Local).AddTicks(1543), 4864.243484220600000m, 1474.8273078211900000m },
                    { new Guid("217b269d-10f2-45e8-be66-1487090d30ec"), new DateTime(2024, 6, 9, 20, 45, 3, 81, DateTimeKind.Local).AddTicks(8900), 4864.7388204867650000m, 749.5755860777800000m },
                    { new Guid("258e205a-63ab-4b2e-a531-53b7cdfbf94d"), new DateTime(2025, 11, 21, 20, 0, 24, 313, DateTimeKind.Local).AddTicks(8792), 1170.2075000662450000m, 3817.5457534026050000m },
                    { new Guid("29b5b6e9-be52-4fe8-a0a7-adb3afccbe23"), new DateTime(2024, 5, 11, 16, 10, 40, 451, DateTimeKind.Local).AddTicks(7152), 42.035059655837750000m, 4110.3126749991450000m },
                    { new Guid("2bc75354-b0fb-4712-9629-886d2e78e1e2"), new DateTime(2028, 6, 30, 18, 44, 14, 955, DateTimeKind.Local).AddTicks(5087), 1513.4978127591750000m, 1942.5683922798800000m },
                    { new Guid("2eaf337c-d319-49d2-ab1c-7b6f409340a6"), new DateTime(2030, 11, 20, 23, 17, 23, 858, DateTimeKind.Local).AddTicks(7373), 2550.9634324084300000m, 3712.2850047509650000m },
                    { new Guid("2f28587b-af7c-46ee-9ad0-a705eb158792"), new DateTime(2024, 3, 26, 15, 20, 38, 938, DateTimeKind.Local).AddTicks(2158), 3268.4925681439100000m, 404.94567559172950000m },
                    { new Guid("302d9514-f416-42f4-aa88-73dc3dadf314"), new DateTime(2024, 9, 29, 5, 57, 28, 81, DateTimeKind.Local).AddTicks(7024), 4399.1809071409800000m, 4179.7452075558550000m },
                    { new Guid("3161b9b4-130e-419c-a715-09fbcde630d4"), new DateTime(2032, 2, 5, 4, 33, 22, 196, DateTimeKind.Local).AddTicks(825), 865.5735639530900000m, 2575.1471800370250000m },
                    { new Guid("3580e22a-e449-4443-ac78-332ce32b13da"), new DateTime(2029, 12, 6, 19, 4, 22, 88, DateTimeKind.Local).AddTicks(8218), 4298.1118622161200000m, 3738.1939036208900000m },
                    { new Guid("38d27970-5ceb-4cb6-80ab-432f7648d7ef"), new DateTime(2027, 7, 22, 18, 27, 33, 204, DateTimeKind.Local).AddTicks(3122), 1632.1124919860400000m, 3142.0145629832550000m },
                    { new Guid("39f95441-187e-4c5b-bd2f-9ea1b82dc207"), new DateTime(2025, 7, 31, 6, 43, 47, 729, DateTimeKind.Local).AddTicks(7575), 94.30140127344450000m, 521.7343164892950000m },
                    { new Guid("3b10f03c-296c-410b-bb29-ba8b3cee774f"), new DateTime(2024, 11, 15, 17, 56, 28, 181, DateTimeKind.Local).AddTicks(1586), 3251.8779150067450000m, 1175.0849150549250000m },
                    { new Guid("44fbad09-7f11-4e17-bd04-709373d35f78"), new DateTime(2024, 10, 2, 10, 0, 24, 378, DateTimeKind.Local).AddTicks(2992), 252.00437549597900000m, 4087.5494436028250000m },
                    { new Guid("4544303e-b6f0-4b7f-8488-e742b183f312"), new DateTime(2030, 9, 3, 7, 33, 52, 922, DateTimeKind.Local).AddTicks(2919), 1323.7346573188600000m, 2720.8946534170150000m },
                    { new Guid("460984e6-c9cb-439d-a7b4-1a1833205fdb"), new DateTime(2028, 2, 18, 2, 41, 12, 438, DateTimeKind.Local).AddTicks(6766), 3308.2915872740250000m, 4085.9898294187600000m },
                    { new Guid("4b7b7585-08c4-4f7b-836d-e3737de42be0"), new DateTime(2031, 7, 4, 16, 46, 11, 392, DateTimeKind.Local).AddTicks(5537), 2302.2769424661450000m, 2678.4304000666100000m },
                    { new Guid("4b92cbf8-8e83-476c-a7b8-149215727cfe"), new DateTime(2029, 1, 22, 9, 57, 38, 897, DateTimeKind.Local).AddTicks(3689), 3530.6697213500800000m, 999.9641126566150000m },
                    { new Guid("4c5366c1-0cdb-4da7-abde-7d83f12ce8f8"), new DateTime(2032, 9, 10, 14, 34, 37, 385, DateTimeKind.Local).AddTicks(6618), 2413.0104307787850000m, 2576.8455595044800000m },
                    { new Guid("4ed53c09-d9f2-4294-bed6-b8bcf42f415e"), new DateTime(2026, 3, 6, 21, 15, 7, 228, DateTimeKind.Local).AddTicks(1855), 3160.8632591463100000m, 24.727673095615850000m },
                    { new Guid("50c7c866-56cc-4dcd-b4ff-6af245d1c796"), new DateTime(2025, 7, 8, 3, 36, 33, 920, DateTimeKind.Local).AddTicks(395), 3145.5893700833950000m, 3126.7357036600850000m },
                    { new Guid("56495f98-f65b-4101-b660-146627448d82"), new DateTime(2032, 2, 18, 18, 47, 31, 603, DateTimeKind.Local).AddTicks(506), 3699.3116909266300000m, 1662.3319412566450000m },
                    { new Guid("58f864b9-55f2-4347-b43b-e387fb36d799"), new DateTime(2032, 4, 8, 14, 33, 45, 88, DateTimeKind.Local).AddTicks(7984), 4521.9599656194400000m, 3244.8021002743800000m },
                    { new Guid("5ca4616c-3cc4-4b58-816b-243b65fb0a30"), new DateTime(2027, 2, 16, 21, 4, 10, 979, DateTimeKind.Local).AddTicks(5952), 3455.8462872783900000m, 2215.7087615964050000m },
                    { new Guid("5ffee86b-6091-462f-8862-8c56b01c008a"), new DateTime(2023, 9, 5, 2, 7, 55, 462, DateTimeKind.Local).AddTicks(9392), 377.45030197934050000m, 4802.4339815984300000m },
                    { new Guid("63924d62-7756-4365-ae52-c59ea681cdac"), new DateTime(2025, 6, 25, 19, 44, 39, 493, DateTimeKind.Local).AddTicks(9232), 3590.9964056709600000m, 597.7602540017350000m },
                    { new Guid("63c1280d-6a7d-4f63-9556-fd529a32b666"), new DateTime(2031, 11, 21, 7, 34, 52, 606, DateTimeKind.Local).AddTicks(1555), 2523.8225916774100000m, 848.6566032069600000m },
                    { new Guid("6b80c853-1ba7-481a-8c3a-7fdc337e88de"), new DateTime(2028, 5, 31, 22, 6, 10, 836, DateTimeKind.Local).AddTicks(3483), 2318.8477364622850000m, 2018.6607350200300000m },
                    { new Guid("6cf8cdc0-7047-46a7-84e5-c34130599d57"), new DateTime(2031, 10, 28, 16, 51, 29, 48, DateTimeKind.Local).AddTicks(6325), 1653.9360039133950000m, 2476.5036864453300000m },
                    { new Guid("6d6d477d-3d8c-4c98-9bc8-620b0691189c"), new DateTime(2031, 3, 25, 22, 58, 36, 742, DateTimeKind.Local).AddTicks(185), 2758.919607089900000m, 1083.4886407940350000m },
                    { new Guid("6e3c81c1-4eb4-4806-9c4b-11e61b524c68"), new DateTime(2030, 12, 27, 19, 4, 59, 606, DateTimeKind.Local).AddTicks(8757), 472.86560985052850000m, 1010.9286383600050000m },
                    { new Guid("6e87f659-305d-4904-b24f-fa5323b3374a"), new DateTime(2026, 6, 30, 18, 2, 52, 714, DateTimeKind.Local).AddTicks(2305), 1397.6678379387450000m, 1278.3035950751750000m },
                    { new Guid("7030e86a-5668-4965-bdae-de646fefff44"), new DateTime(2024, 12, 6, 18, 17, 3, 945, DateTimeKind.Local).AddTicks(5089), 1527.682503647950000m, 1095.205958370650000m },
                    { new Guid("7294ed11-7f80-445a-89e7-784cd2adcca8"), new DateTime(2028, 12, 27, 14, 57, 18, 114, DateTimeKind.Local).AddTicks(7788), 1057.960129708850000m, 3873.3062795732100000m },
                    { new Guid("7488a810-f089-4daf-983c-1b2c484001d8"), new DateTime(2026, 5, 21, 22, 32, 48, 26, DateTimeKind.Local).AddTicks(4434), 3482.2822384253900000m, 2091.0407893475750000m },
                    { new Guid("74c54c2a-0353-4988-937d-fb9a243232b6"), new DateTime(2026, 12, 31, 4, 6, 47, 373, DateTimeKind.Local).AddTicks(3286), 3374.0200949256150000m, 3442.8030095256350000m },
                    { new Guid("76901b47-dc29-4dc8-9692-f59ed3456928"), new DateTime(2033, 2, 2, 9, 27, 57, 463, DateTimeKind.Local).AddTicks(6708), 871.7138421068600000m, 2627.7332131933400000m },
                    { new Guid("77891612-d471-4579-b757-8fef08795f3c"), new DateTime(2033, 3, 1, 19, 18, 36, 911, DateTimeKind.Local).AddTicks(9555), 1443.5469732564150000m, 1229.1755254291250000m },
                    { new Guid("77a0f66e-014d-4fa9-957a-1f8c2d886449"), new DateTime(2027, 3, 6, 6, 45, 53, 896, DateTimeKind.Local).AddTicks(9460), 3965.0396765432850000m, 4136.0128704535550000m },
                    { new Guid("82f0e282-2d22-4198-9f2a-44b0cbd56be7"), new DateTime(2032, 10, 29, 18, 43, 27, 634, DateTimeKind.Local).AddTicks(3830), 2342.9311629809800000m, 54.33389362552950000m },
                    { new Guid("831a54e5-6a38-4c67-98e1-bf98f2f08fb5"), new DateTime(2029, 8, 16, 14, 20, 54, 777, DateTimeKind.Local).AddTicks(8207), 3585.7563677736350000m, 1739.7706526567800000m },
                    { new Guid("88711e9d-8a60-4b42-9b2f-38c5b8c993fd"), new DateTime(2030, 3, 27, 23, 53, 35, 802, DateTimeKind.Local).AddTicks(5362), 2062.2153634185750000m, 675.9564421078250000m },
                    { new Guid("89045c53-7eb0-4d89-a0f7-4bc8d9f0454e"), new DateTime(2025, 1, 15, 10, 0, 26, 518, DateTimeKind.Local).AddTicks(546), 2118.2001629726700000m, 3577.78203148750000m },
                    { new Guid("8dd80532-044a-47e5-920c-dcdcc7b9823f"), new DateTime(2030, 10, 2, 17, 14, 8, 371, DateTimeKind.Local).AddTicks(5677), 3203.1679899065600000m, 3802.5230858902100000m },
                    { new Guid("930f3d0c-eea3-4366-abce-7a50639f3ae5"), new DateTime(2033, 1, 17, 16, 12, 7, 779, DateTimeKind.Local).AddTicks(1399), 3622.0058935083900000m, 2666.8742049016900000m },
                    { new Guid("94528bad-d843-4795-a540-c8bf8cbebb1a"), new DateTime(2025, 7, 19, 16, 12, 48, 517, DateTimeKind.Local).AddTicks(3460), 262.01253400291950000m, 4280.9322128052350000m },
                    { new Guid("95357556-e799-436f-8fac-36893aa9528f"), new DateTime(2024, 12, 21, 14, 9, 37, 546, DateTimeKind.Local).AddTicks(1323), 772.7807407653200000m, 4534.992753511850000m },
                    { new Guid("95bd1398-fa49-49fa-95b6-8e743408a060"), new DateTime(2028, 4, 7, 3, 41, 23, 129, DateTimeKind.Local).AddTicks(9329), 577.6278613328900000m, 3005.0239818090450000m },
                    { new Guid("96386d96-98f2-4c7f-98a0-e8116cae38fc"), new DateTime(2033, 1, 12, 10, 37, 28, 209, DateTimeKind.Local).AddTicks(5600), 3083.615068935950000m, 4650.7250526493450000m },
                    { new Guid("9811c176-fe91-4ebc-a546-b7a8cb37dfd7"), new DateTime(2032, 2, 5, 15, 3, 36, 904, DateTimeKind.Local).AddTicks(3833), 2303.6176038945850000m, 1743.2711334609600000m },
                    { new Guid("a02b3012-0d27-4449-bd77-663e4942e5ce"), new DateTime(2028, 12, 14, 21, 46, 12, 6, DateTimeKind.Local).AddTicks(565), 4560.1544744449400000m, 4614.4947450259650000m },
                    { new Guid("a2f890f4-5239-4bbf-bbb2-ab14a18cb56a"), new DateTime(2024, 6, 18, 22, 3, 49, 470, DateTimeKind.Local).AddTicks(9531), 4071.558723179250000m, 4691.887545207800000m },
                    { new Guid("a3bacd6f-f0d5-430e-b6d0-d275c0c78b79"), new DateTime(2027, 10, 27, 2, 33, 59, 166, DateTimeKind.Local).AddTicks(8670), 4730.65120022250000m, 763.0286153328800000m },
                    { new Guid("a6600da0-4bcb-46fe-af87-552f98f34e56"), new DateTime(2027, 3, 6, 6, 45, 18, 464, DateTimeKind.Local).AddTicks(1402), 3602.4011451196050000m, 1350.9809167564150000m },
                    { new Guid("a74c2ae7-bdd7-4ea8-97d4-630888a6376b"), new DateTime(2028, 1, 29, 12, 34, 24, 26, DateTimeKind.Local).AddTicks(2821), 1328.0830913707100000m, 1254.9567978460050000m },
                    { new Guid("a845a15a-e265-4f2d-b63e-9ff7c07ab064"), new DateTime(2024, 5, 29, 12, 27, 59, 22, DateTimeKind.Local).AddTicks(1832), 2299.3467917277200000m, 2044.502285933950000m },
                    { new Guid("a869e6ac-360a-4933-b9eb-333ba2f6284a"), new DateTime(2029, 11, 18, 3, 33, 1, 445, DateTimeKind.Local).AddTicks(4937), 523.7066814607700000m, 4255.5595546987150000m },
                    { new Guid("a9c10389-42db-4cab-9900-9be4fd440855"), new DateTime(2030, 6, 14, 7, 12, 53, 556, DateTimeKind.Local).AddTicks(1860), 2142.0306219694200000m, 217.17811626833300000m },
                    { new Guid("abc8af87-0e99-4f3f-ab63-258123df947e"), new DateTime(2025, 1, 27, 3, 34, 49, 378, DateTimeKind.Local).AddTicks(4299), 4356.6756685918600000m, 4171.2739063741550000m },
                    { new Guid("ae4a51a9-585d-4aa3-bd59-f5c4dad596d9"), new DateTime(2028, 5, 3, 23, 7, 52, 754, DateTimeKind.Local).AddTicks(7899), 2074.3888121640450000m, 2957.6601755704800000m },
                    { new Guid("afdaa989-e9bf-4d36-b0e8-98a4e12b1327"), new DateTime(2032, 12, 1, 23, 1, 24, 681, DateTimeKind.Local).AddTicks(6441), 3216.6361394725950000m, 2559.6854677199150000m },
                    { new Guid("b11b4ec0-5e70-4654-8cca-7d6a609c99f6"), new DateTime(2031, 6, 4, 4, 45, 35, 516, DateTimeKind.Local).AddTicks(9774), 4383.5062795023850000m, 4764.8416169354750000m },
                    { new Guid("b22b3acb-8c3b-4a11-a5ee-f6b25ce7e1d8"), new DateTime(2029, 6, 23, 18, 12, 3, 362, DateTimeKind.Local).AddTicks(9485), 24.055099338914900000m, 4917.3924739964250000m },
                    { new Guid("b272aa9c-c3ff-4f1e-be7e-dcbcadf851e4"), new DateTime(2023, 8, 1, 13, 28, 7, 916, DateTimeKind.Local).AddTicks(896), 2388.3502122392400000m, 3721.8849383416050000m },
                    { new Guid("b4993ce5-56d6-4d43-839e-2698c20833d3"), new DateTime(2031, 1, 27, 8, 55, 50, 154, DateTimeKind.Local).AddTicks(1617), 1943.8095527110950000m, 2858.8104792671700000m },
                    { new Guid("b5a7a14d-044d-449b-b0a6-83eca9c9579a"), new DateTime(2029, 5, 21, 6, 11, 56, 732, DateTimeKind.Local).AddTicks(7026), 2888.0471029269850000m, 221.43375921389950000m },
                    { new Guid("b8ca5802-4c2c-47f0-86c5-3172910bbd09"), new DateTime(2026, 8, 20, 12, 42, 30, 791, DateTimeKind.Local).AddTicks(2802), 4962.4061886303700000m, 94.96585522379150000m },
                    { new Guid("c3cbde84-70f6-4a82-b02d-21175c58d8ca"), new DateTime(2031, 4, 22, 21, 40, 55, 801, DateTimeKind.Local).AddTicks(7674), 3138.6134711212350000m, 1974.0107896765050000m },
                    { new Guid("c64f26f0-5953-491c-b740-4352d2238e47"), new DateTime(2030, 7, 20, 4, 47, 40, 916, DateTimeKind.Local).AddTicks(6559), 2406.5200623404150000m, 3097.0476870008300000m },
                    { new Guid("ca977612-b0d1-47e9-b7b2-f8d856e343d5"), new DateTime(2023, 8, 28, 3, 39, 14, 695, DateTimeKind.Local).AddTicks(1331), 4391.1681681503450000m, 1287.2761910855350000m },
                    { new Guid("cc12dc46-b403-4be3-90f0-388f3fd17476"), new DateTime(2024, 10, 20, 23, 52, 53, 751, DateTimeKind.Local).AddTicks(6089), 269.47923063838750000m, 1522.8895585433700000m },
                    { new Guid("cec39a06-dc0b-4407-9886-77f9f42699dc"), new DateTime(2030, 1, 20, 17, 43, 8, 818, DateTimeKind.Local).AddTicks(2094), 4770.4984338254950000m, 1070.8786012239900000m },
                    { new Guid("d07ede48-aca0-4e75-8845-e2a88a74c41f"), new DateTime(2029, 2, 3, 23, 59, 41, 367, DateTimeKind.Local).AddTicks(1991), 2528.3020394525700000m, 905.456119999550000m },
                    { new Guid("d3115ad6-eaf1-430c-9177-f7539792c524"), new DateTime(2024, 11, 2, 0, 53, 10, 834, DateTimeKind.Local).AddTicks(8061), 443.30585791458650000m, 4409.1017803152900000m },
                    { new Guid("d671263a-e0ce-4d0e-a7d7-70657a82add1"), new DateTime(2028, 9, 18, 2, 5, 36, 27, DateTimeKind.Local).AddTicks(782), 3794.0511448251100000m, 2167.2120590072100000m },
                    { new Guid("dedef8f0-d336-44f9-ac26-5b8f1e36c709"), new DateTime(2027, 8, 21, 12, 46, 10, 630, DateTimeKind.Local).AddTicks(7601), 2008.3692991218250000m, 1092.4344694729950000m },
                    { new Guid("e440172f-1e2f-4eff-a3c3-0ed17701301d"), new DateTime(2024, 12, 30, 1, 9, 9, 538, DateTimeKind.Local).AddTicks(1872), 1430.72551685700000m, 3056.5853583446300000m },
                    { new Guid("e70a3aea-eee4-4639-add0-03dbf9b97d7a"), new DateTime(2028, 5, 5, 22, 34, 6, 928, DateTimeKind.Local).AddTicks(4851), 4030.8375190492850000m, 2243.9270760459550000m },
                    { new Guid("e80a6c31-a69f-4a7a-9a52-c92e8347d20a"), new DateTime(2025, 2, 13, 4, 45, 23, 220, DateTimeKind.Local).AddTicks(2270), 4088.839300916650000m, 2389.7799728313600000m },
                    { new Guid("ea9156d9-5f8d-449c-bab3-e76613427ba2"), new DateTime(2024, 5, 9, 10, 10, 27, 989, DateTimeKind.Local).AddTicks(4471), 1591.0716822759350000m, 4064.3277227637300000m },
                    { new Guid("ed781948-ad02-43ce-9f03-01eccd17b957"), new DateTime(2026, 5, 16, 3, 18, 48, 274, DateTimeKind.Local).AddTicks(5459), 494.99021723810100000m, 3237.3114474888900000m },
                    { new Guid("ee6de192-1e66-44a1-b31e-224bae960152"), new DateTime(2024, 5, 5, 20, 10, 55, 41, DateTimeKind.Local).AddTicks(5626), 2521.7328806196900000m, 3263.1276918494350000m },
                    { new Guid("f1e84a30-0cb0-4efb-a01f-dc053b593474"), new DateTime(2032, 12, 3, 10, 3, 29, 389, DateTimeKind.Local).AddTicks(6944), 3999.0761169525800000m, 1277.6946146970100000m },
                    { new Guid("f26579a7-1132-4d8f-b048-64098364f594"), new DateTime(2030, 9, 9, 9, 22, 57, 790, DateTimeKind.Local).AddTicks(7346), 4791.633284447250000m, 3402.3577558694650000m },
                    { new Guid("f71f2d50-49b9-42a2-a64a-b249853c2176"), new DateTime(2026, 11, 12, 22, 28, 28, 347, DateTimeKind.Local).AddTicks(2758), 163.55847404423550000m, 3093.38103935650000m },
                    { new Guid("f9c518f5-3794-46ed-be45-4486dc0b9fda"), new DateTime(2023, 10, 30, 11, 31, 37, 546, DateTimeKind.Local).AddTicks(8199), 4978.2319701935700000m, 4534.494426601650000m },
                    { new Guid("fad3c95d-8151-4df4-a58a-d2a93981e884"), new DateTime(2025, 10, 24, 4, 0, 54, 147, DateTimeKind.Local).AddTicks(5003), 2775.5280062229250000m, 1786.963081226850000m },
                    { new Guid("fdccc7f5-a8b0-4d6f-893e-8848d2cf0f91"), new DateTime(2025, 4, 7, 17, 25, 12, 985, DateTimeKind.Local).AddTicks(9170), 924.1952477657100000m, 4054.5303796531750000m },
                    { new Guid("fde14f72-38ff-4151-9fdf-45dcce770a1c"), new DateTime(2028, 5, 26, 0, 18, 49, 335, DateTimeKind.Local).AddTicks(9353), 1462.8585281412050000m, 331.96986502676900000m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirtsName", "LastName", "Password" },
                values: new object[,]
                {
                    { new Guid("00f95528-2bc0-4d1d-94ea-fc2c032829b9"), "Minerva.Muller@yahoo.com", "Nelda", "Daugherty", "J4SCv11Qld" },
                    { new Guid("012c7c9f-4925-49d9-af46-ecf1e5b748cc"), "Aylin15@gmail.com", "Davin", "Renner", "nr8JazgMuV" },
                    { new Guid("04ea0cf3-75fd-4f30-b737-bbc2f0f7c64f"), "Dominic_Hegmann@hotmail.com", "Julie", "Bogisich", "yBti_s5rpY" },
                    { new Guid("052e3646-b176-4e0f-8885-be7a2e62a99b"), "Reggie14@hotmail.com", "Morton", "Halvorson", "0hG5U1IOyX" },
                    { new Guid("0b79f5b6-45f6-4974-a977-4104c039ef4f"), "Carmel18@hotmail.com", "Julianne", "Johnson", "F9IcZCBbSG" },
                    { new Guid("12b688e8-96ec-4ef8-bbb3-139a86fd6ae1"), "Vernice_Strosin21@hotmail.com", "Kennedi", "Lubowitz", "G2wYSs_xk1" },
                    { new Guid("134b2d91-b638-4f52-9666-93bc2af600ae"), "Kadin_Daniel8@gmail.com", "Newton", "Cummings", "Ppk_GJ9TTv" },
                    { new Guid("134b7900-a6ac-4bee-8612-68afc55b38a1"), "Toy24@hotmail.com", "Erna", "Considine", "wieI3gVljm" },
                    { new Guid("16ed4de6-1791-437f-8399-a893fb6496f5"), "Judah.Gerhold51@yahoo.com", "Kattie", "Kling", "rcbfE8gucw" },
                    { new Guid("18f95b50-42df-4c78-b151-7cdffb7bba74"), "Trey_Lang63@yahoo.com", "Leora", "Bahringer", "dUrMHSPHQi" },
                    { new Guid("1a0dbbf2-9ce0-4ffd-a3b7-0ccb7dad0afb"), "Evalyn.Kozey40@hotmail.com", "Bell", "Breitenberg", "s91dYDPNI2" },
                    { new Guid("1ad25d13-7fc8-4cba-8eb0-0d3a4912fa2d"), "Rosalind35@gmail.com", "Jermain", "Gaylord", "RcY7cDalUk" },
                    { new Guid("1b061a9e-67e4-48f1-a4c6-e32dc82656e8"), "Rosina_Volkman@hotmail.com", "Elena", "Hartmann", "_wWc1a1gqz" },
                    { new Guid("1d5abcbd-8607-42c0-bd60-6233cdd5e50c"), "Miracle19@yahoo.com", "Isaiah", "Ward", "ygXGsGhiHd" },
                    { new Guid("1df739a7-dbb6-4a1c-b5be-14b4e2e580b0"), "Doris3@hotmail.com", "Kobe", "Rodriguez", "agLYsNbRuV" },
                    { new Guid("222d2743-d1b0-4f29-b6b8-94fbbd48837c"), "Chyna_Luettgen50@gmail.com", "Ellen", "Bogisich", "X6EzZ2ZQXi" },
                    { new Guid("22ad31e3-ceec-45ba-8fcd-ce96649829c8"), "Brice.Carter60@yahoo.com", "Murphy", "Frami", "qPxWebSGFj" },
                    { new Guid("297f113a-b7b6-48c8-acff-599567a70b38"), "Carolyne_Hayes@hotmail.com", "Steve", "Hessel", "0fYbi0zAqO" },
                    { new Guid("2d57693d-8fec-4935-8641-5c2f0fb13cfc"), "Jeremie.Douglas11@hotmail.com", "Jayme", "Kuphal", "uAW4Zj_7UK" },
                    { new Guid("2eda824d-6420-40b8-a9d2-e7610fe7b70f"), "Jarvis.Macejkovic91@yahoo.com", "Alejandrin", "Dicki", "rblixmLLFg" },
                    { new Guid("30593b74-c63f-4fa8-a32d-1e1979ad51f3"), "Lorenza_Hackett@hotmail.com", "Karl", "Bauch", "3IjkXgJVNa" },
                    { new Guid("34614d96-5892-422e-8509-86a7a491a9b6"), "Nikita.Trantow@hotmail.com", "Brice", "Hayes", "YlkpUdkI2X" },
                    { new Guid("34f1e808-1624-42c0-8065-fb22136d7aac"), "Pearl_Beer@gmail.com", "Berta", "Strosin", "KdivmLlHLI" },
                    { new Guid("382ef7c5-97f0-4947-b704-046713adff53"), "Judd_Schinner@hotmail.com", "Raymond", "Greenfelder", "o4xybFCHeI" },
                    { new Guid("3a100e1d-c825-4ea0-ba70-848b448c7971"), "Torey_Mosciski@yahoo.com", "Cornelius", "Grady", "riDKTY_D44" },
                    { new Guid("3a37113b-0edf-4813-9fb2-43b41da13420"), "Chloe24@yahoo.com", "Josh", "Hackett", "nRgn8UmADx" },
                    { new Guid("3f770ade-b80a-42fd-8217-8bd51cb949df"), "Eula.Bradtke63@gmail.com", "Nathanial", "Reichert", "2QUAqDPNIn" },
                    { new Guid("408255a1-8a98-4212-b833-6cea91c3adc1"), "Columbus_Braun86@hotmail.com", "Kurt", "Dickinson", "GlhKHdbMuB" },
                    { new Guid("43ac12b9-c2aa-4adb-a6d5-1bf420724095"), "Breana_Koelpin5@gmail.com", "Pauline", "Dickens", "xojmlRBqzw" },
                    { new Guid("4754c28d-4ce8-4f45-9b41-0e7f9be1b221"), "Samir79@gmail.com", "Lambert", "Runte", "2xSc4awMl4" },
                    { new Guid("4895e34b-2590-4e8a-9702-55efe8c4f405"), "Ewald_Barton81@gmail.com", "Winifred", "Hane", "zlNkZfpLTu" },
                    { new Guid("4928e71c-8dbc-4b2e-aa69-e4b4e7e018a9"), "Hazel.Anderson26@gmail.com", "Lorenzo", "Corwin", "gLKD2y44z4" },
                    { new Guid("4a0bb6cd-0317-468c-a6a7-8ed68a16041a"), "Albina46@gmail.com", "Lorenz", "Schaefer", "a4Us4l8Ru2" },
                    { new Guid("4a663f82-f610-4e24-88ec-f514a444ad19"), "Terrence.Davis38@hotmail.com", "Sydni", "Stamm", "GBwYav9CJk" },
                    { new Guid("4be22dd4-d880-4c31-a48d-0d820b87a12c"), "Cassie.Stanton@gmail.com", "Gabriella", "Kuhn", "KLvvvKGxHq" },
                    { new Guid("4c641700-e9a7-4350-9c3e-0d88ac84723e"), "Jade_Schuppe@yahoo.com", "Carmelo", "Hodkiewicz", "br0JZVxygx" },
                    { new Guid("504c725f-a51c-4468-97eb-6d2a3b05aae6"), "Laverne_McGlynn@gmail.com", "Alysa", "Barrows", "lSWOYU3Taf" },
                    { new Guid("586ad721-0025-4ab1-b183-68caa6a690e6"), "Antoinette3@hotmail.com", "Camylle", "Douglas", "oSs5ezgRcI" },
                    { new Guid("58c3e0db-b0d0-48eb-8e24-15f343354470"), "Lurline.VonRueden40@gmail.com", "Salvador", "Dibbert", "wXYla31cv9" },
                    { new Guid("58c910f1-ecac-4d20-9de5-bb9940165c54"), "Furman.Berge41@yahoo.com", "Geraldine", "Rodriguez", "wkoQvOH9Ue" },
                    { new Guid("5978dcd8-df1a-4812-9938-fe44330164b7"), "Dario.Blanda47@hotmail.com", "Marcellus", "Gottlieb", "hCud4UZ6sR" },
                    { new Guid("59db8d1a-32cc-4ff4-a2f4-5eb212d52b51"), "Hassie.Weber69@yahoo.com", "Curtis", "Herman", "OT94eAityv" },
                    { new Guid("5a7eecb7-83c4-4a45-b2f0-38c0f1ae5e77"), "Veda_Moen99@gmail.com", "Leland", "Lueilwitz", "JRkF97VOAI" },
                    { new Guid("5fe1746d-1474-419f-b8b8-40447beba716"), "Jasmin91@gmail.com", "Adeline", "Heaney", "h05EU7t8L5" },
                    { new Guid("631b33c5-b8fa-4489-a965-0fa804bda3b0"), "Kaci_Robel20@hotmail.com", "Velma", "Koepp", "OrhiOrg651" },
                    { new Guid("67ffb668-9a79-4178-a270-dba0d17a1db4"), "Jett_Lang50@gmail.com", "Leanne", "Walsh", "In0Ft00GZh" },
                    { new Guid("6a07efb1-18e2-4be9-99eb-c20fe5b70f77"), "Monty_Beatty80@hotmail.com", "Brendon", "Hauck", "KdMuiWZQjd" },
                    { new Guid("6f7c14ec-5b47-48aa-a8e0-9f8bca98362c"), "Bonnie.Hayes0@yahoo.com", "Keshawn", "Altenwerth", "rMg6ylmc4R" },
                    { new Guid("6fb15e4d-8377-43ff-9829-754468008a7b"), "Constantin38@gmail.com", "Waldo", "Strosin", "WM6ooi9SSW" },
                    { new Guid("70439e90-ac1c-4f54-bf5a-b396497e29d6"), "Tara.Lang86@yahoo.com", "Louvenia", "Orn", "5mzj0R9tGB" },
                    { new Guid("72ad5bf5-0682-47fd-bf09-d8eeb3613458"), "Elisabeth_Homenick@hotmail.com", "Herminio", "Morar", "3pvFkPUvnp" },
                    { new Guid("743a9f2b-7180-4e31-9a1e-574f0398c114"), "Freda_Daugherty@hotmail.com", "Magdalena", "Wehner", "8ZFYxFF0mp" },
                    { new Guid("7865b117-3bf8-4448-bb13-f8513fe193db"), "Alisa.Wyman@hotmail.com", "Maegan", "Hodkiewicz", "VOccdD7mP6" },
                    { new Guid("7c95e110-6ec6-4e60-adb8-0f58c19e88c8"), "Rusty.Keeling@hotmail.com", "Santos", "Gerlach", "GnRQIKWds0" },
                    { new Guid("84420a86-2c63-4747-99f2-21ea536db21f"), "Carlo19@hotmail.com", "Raphael", "Little", "Qx5Jyt8nCZ" },
                    { new Guid("85db497c-f341-45a6-bee7-c434ccf16ac7"), "Layne.Gleason@hotmail.com", "Leora", "Carroll", "y6EPWxaT8H" },
                    { new Guid("8661ada9-481a-426b-91ad-0b4f959557b6"), "Emma_Paucek61@gmail.com", "Alysa", "Cruickshank", "3_JNxnUeLk" },
                    { new Guid("87312bdb-ad9b-4579-a2be-2c486d003019"), "Francis2@gmail.com", "Zoila", "Emard", "cOopbcS5kU" },
                    { new Guid("88e7b816-7752-4b76-acf4-5611f1a42b44"), "Maude86@yahoo.com", "Shad", "Powlowski", "jpPsWD88jc" },
                    { new Guid("89a26576-e97a-4170-ad60-cce5f06291f5"), "Flavio6@yahoo.com", "Barton", "Robel", "4Yu6IzjWVn" },
                    { new Guid("8e029fc5-7214-40b9-a322-5a78839a1335"), "Marjorie43@hotmail.com", "Brain", "Mraz", "76efRLjlUU" },
                    { new Guid("8f0901ed-daa5-4184-bc65-87e872d53e53"), "Nicholaus.Pagac0@hotmail.com", "Jamar", "Nikolaus", "_EAbJXzt6z" },
                    { new Guid("8f813401-845a-40d8-974b-61254ea875ab"), "Adell19@gmail.com", "Maryse", "Barton", "XwMs8pcvoL" },
                    { new Guid("8fe9c044-306c-44bd-99f8-c1c1a8db079a"), "Ima_Feest34@yahoo.com", "Liam", "Moore", "lmXK0GM7kI" },
                    { new Guid("9142af88-46a9-43cf-95b5-ea15741b3745"), "Jayda19@hotmail.com", "Amber", "Runolfsson", "dnxRSrjqWk" },
                    { new Guid("97c8b27f-9ba4-478e-9fac-88aacf1ff658"), "Lawrence.McDermott79@yahoo.com", "Larry", "Koelpin", "x7fQ9VuK8B" },
                    { new Guid("98f4d349-1f2c-4cd2-9b25-a2e4a639bfce"), "Madyson_Hills@hotmail.com", "Mathias", "Torp", "hjQETAIIXz" },
                    { new Guid("9a242c28-382d-46a6-a44b-26ed7d05ac87"), "Ophelia_Mitchell@gmail.com", "Retha", "Weber", "Nb2pHi1ZNX" },
                    { new Guid("9d9b6a6f-7a88-4d45-8054-f021dc7ec404"), "Reina91@hotmail.com", "Iliana", "Altenwerth", "d6QUqZ6el9" },
                    { new Guid("a19edb59-115f-453b-9e65-932cb29ac89d"), "Violet_Boyer89@gmail.com", "Serenity", "Mante", "XEC4BOL2Br" },
                    { new Guid("a31009ed-6d90-4b53-b814-61b212f38d54"), "Jane97@hotmail.com", "Halle", "Jacobson", "xXOQgONUH8" },
                    { new Guid("a543f6f9-fb23-49c3-86e8-eb268c8ea98c"), "Kyler_Kessler@gmail.com", "Daphnee", "Ziemann", "bFWvFTSJY5" },
                    { new Guid("aa97c67c-f752-46df-95fc-bbf84ad0e775"), "Jillian6@hotmail.com", "Sadie", "Padberg", "vT7aVLfoxp" },
                    { new Guid("b38901d6-bc73-4775-a8c1-94518b70d780"), "Roderick57@hotmail.com", "Gabrielle", "Lynch", "ZiryacVNm8" },
                    { new Guid("b3924085-4857-473e-9ce0-f6bb2727b269"), "Ayla49@gmail.com", "Jaden", "Gutkowski", "kRE2wecGde" },
                    { new Guid("bcf66a5f-ae74-4b13-bfc6-27e4856dcd08"), "Annie3@hotmail.com", "Mac", "White", "8RoRxJz_lG" },
                    { new Guid("bd3c3f1a-01ef-4fa2-bd1b-f18105140db6"), "Landen.Monahan@hotmail.com", "Blaze", "Reinger", "frYhlyglks" },
                    { new Guid("c8c0bef5-fb2a-47e1-8fc9-c3d8bc86f8c8"), "Jennifer_Bogan28@gmail.com", "Miguel", "Bauch", "gtRmKGowhU" },
                    { new Guid("cf155f5d-605a-4ca1-9733-af0a810037e1"), "Oleta_Ullrich26@hotmail.com", "Taryn", "Roberts", "txtdvUPggd" },
                    { new Guid("d1a17cef-ed20-4c3d-a53f-2dbb87c4b6e6"), "Niko42@gmail.com", "Giuseppe", "Wolf", "OBrfLgdkNB" },
                    { new Guid("d31aaa8d-07c0-4869-9103-a4f6f98c1dab"), "Maritza.Pfeffer98@hotmail.com", "Wyatt", "Bergstrom", "zkONLiKhze" },
                    { new Guid("d8598fea-b564-468a-9838-a0b91687e110"), "Catalina_Stiedemann@hotmail.com", "Ceasar", "Collier", "aVGnYQo8bM" },
                    { new Guid("df4e51ea-e773-4771-a826-2f1b6f84965d"), "Alessandro.Mertz89@yahoo.com", "Javonte", "Stark", "ERZXUw2jxq" },
                    { new Guid("e074c35c-a06a-4d31-a44f-02158d7c262e"), "Shanny16@gmail.com", "Daisy", "Skiles", "sJNAl_gwWN" },
                    { new Guid("e3b2513c-daeb-4f1a-af88-144836e7da92"), "Alan_Bechtelar@yahoo.com", "Woodrow", "Metz", "6tSofsJS5x" },
                    { new Guid("e3b4a95e-9244-4172-b13d-06de1b38c5ec"), "Wilfredo_Lemke@gmail.com", "Beulah", "Spinka", "VfNDpukzdr" },
                    { new Guid("e4b591b9-51aa-46f6-923c-f416d9bd6923"), "Abbey.Altenwerth@yahoo.com", "Madie", "Wilderman", "XTjj4396ji" },
                    { new Guid("e86bc86c-9b7b-45a7-853f-247e9a6d958a"), "Lavern31@hotmail.com", "Cordell", "Littel", "SbCNaDMMry" },
                    { new Guid("ec12043d-b285-4868-a73c-74f7e6524f1b"), "Angela31@gmail.com", "Rossie", "Parisian", "MPXI5sAxhQ" },
                    { new Guid("edecdf54-2cff-4164-afcf-6cf7229a551d"), "Arturo_Leffler86@hotmail.com", "Seth", "Hegmann", "HyYVzqIfCj" },
                    { new Guid("ef84209c-eff9-4a62-a730-9338d8fd3a17"), "Yesenia_Kub27@yahoo.com", "Abigail", "Bosco", "mqZl7uLtMD" },
                    { new Guid("eff0bb7c-1359-453c-b2de-1b71465a198b"), "Marco34@hotmail.com", "Maymie", "Connelly", "dEx5DeLtTX" },
                    { new Guid("f0521a43-1cc3-498e-a7d3-cdb0cdf1aa32"), "Burdette.Abernathy79@hotmail.com", "Demetrius", "Bailey", "aJvi_5Vbt5" },
                    { new Guid("f7cf4b3f-b579-4fe9-ae5b-9789cb07a426"), "Hannah_Walter@yahoo.com", "Odell", "West", "etdPzJjO6I" },
                    { new Guid("f86532d0-ab6a-4a41-8195-effb331f5297"), "Holly_Bogan0@yahoo.com", "Penelope", "Yost", "ydw5EFg0tE" },
                    { new Guid("fb891a63-90bd-4865-8533-8e147d6db11d"), "Alec_Witting42@yahoo.com", "Genoveva", "Cormier", "SxZynN5mqF" },
                    { new Guid("fd2eed96-0775-49ba-8afb-0bb3d5f4f730"), "Dianna_Hudson61@yahoo.com", "Keyshawn", "Gleason", "iqCzQldkAo" },
                    { new Guid("fd5c3633-73e8-486a-870a-55f9a276ec87"), "Maegan.Graham@gmail.com", "Cayla", "MacGyver", "yWZPvddSfn" },
                    { new Guid("ff1ad749-1627-4917-ab87-363cf09c16df"), "Theo23@hotmail.com", "Adrienne", "Kautzer", "dmfwFYSBMX" },
                    { new Guid("ffba3112-edc7-4a20-aac9-4de5f45644e0"), "Marcella20@hotmail.com", "Jaylen", "Legros", "lyFf0FoSjO" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "BankAccountId", "CreditCardId", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("109c564d-6ace-4a72-8236-40b1d5b2059e"), new Guid("c1e45f04-4924-467f-9739-0a8abcce303c"), null, 1, new Guid("1a0dbbf2-9ce0-4ffd-a3b7-0ccb7dad0afb") },
                    { new Guid("16c1241f-4537-4ab6-b175-39d9cfd331b9"), new Guid("790f67b0-114e-42ef-91c6-e7557f96c04b"), null, 1, new Guid("052e3646-b176-4e0f-8885-be7a2e62a99b") },
                    { new Guid("1b4880cb-e801-441f-bc5f-b3ab091cf0ca"), new Guid("4373d3c4-1234-472a-ad61-5e858239afe3"), null, 1, new Guid("4c641700-e9a7-4350-9c3e-0d88ac84723e") },
                    { new Guid("27d1ebd7-3623-4b65-861f-1c46ea310bd9"), new Guid("8e793ea7-d9f1-404d-ad80-a89a14f23964"), null, 1, new Guid("9d9b6a6f-7a88-4d45-8054-f021dc7ec404") },
                    { new Guid("32a0e351-da8f-4282-94c8-edd7dab29543"), null, new Guid("7488a810-f089-4daf-983c-1b2c484001d8"), 0, new Guid("12b688e8-96ec-4ef8-bbb3-139a86fd6ae1") },
                    { new Guid("4428cdf1-4ecf-47b3-ad9d-afa7e064525d"), new Guid("00e7a70a-bd3e-46b9-861d-1380d77ddf96"), null, 0, new Guid("7c95e110-6ec6-4e60-adb8-0f58c19e88c8") },
                    { new Guid("49bf1315-6a4b-48c7-9487-0dae563b1913"), null, new Guid("a02b3012-0d27-4449-bd77-663e4942e5ce"), 0, new Guid("3a100e1d-c825-4ea0-ba70-848b448c7971") },
                    { new Guid("519076fa-edb5-48e0-8a10-6f391c1059cf"), null, new Guid("38d27970-5ceb-4cb6-80ab-432f7648d7ef"), 1, new Guid("34f1e808-1624-42c0-8065-fb22136d7aac") },
                    { new Guid("5a95b0d6-8616-472b-98cb-308d042f8319"), null, new Guid("c64f26f0-5953-491c-b740-4352d2238e47"), 1, new Guid("89a26576-e97a-4170-ad60-cce5f06291f5") },
                    { new Guid("61fa76d5-30d3-49b0-b020-ba6444a831e5"), null, new Guid("63924d62-7756-4365-ae52-c59ea681cdac"), 0, new Guid("ffba3112-edc7-4a20-aac9-4de5f45644e0") },
                    { new Guid("648d0edd-5a05-487b-a2b0-a4f7f3388cc9"), null, new Guid("a2f890f4-5239-4bbf-bbb2-ab14a18cb56a"), 1, new Guid("87312bdb-ad9b-4579-a2be-2c486d003019") },
                    { new Guid("6b6024ee-2912-4399-96a3-7ac064065bc4"), new Guid("378726cc-f974-4475-afe4-92afe0cbbd58"), null, 0, new Guid("df4e51ea-e773-4771-a826-2f1b6f84965d") },
                    { new Guid("6e52bddb-0809-46a8-bbb0-83ee2003786d"), new Guid("efc629d5-a594-4c77-a1f8-0355f13b2a1a"), null, 0, new Guid("e3b4a95e-9244-4172-b13d-06de1b38c5ec") },
                    { new Guid("7b03d6a9-2763-471c-b883-893d79cc5c86"), null, new Guid("56495f98-f65b-4101-b660-146627448d82"), 1, new Guid("6a07efb1-18e2-4be9-99eb-c20fe5b70f77") },
                    { new Guid("8059308e-2a45-4d5d-ab10-2b12da229a74"), new Guid("e141fd37-26e8-49a6-814a-aa64294b4e01"), null, 1, new Guid("2d57693d-8fec-4935-8641-5c2f0fb13cfc") },
                    { new Guid("8413646d-7822-4db8-85a1-9c56d1eba7a8"), null, new Guid("dedef8f0-d336-44f9-ac26-5b8f1e36c709"), 0, new Guid("382ef7c5-97f0-4947-b704-046713adff53") },
                    { new Guid("850a3fd1-aba8-4149-ada2-5eb2c63f2b90"), new Guid("c0705231-bc8c-47d4-9ebd-4601c19b613e"), null, 0, new Guid("8f0901ed-daa5-4184-bc65-87e872d53e53") },
                    { new Guid("ac73b145-9afa-4c84-acbd-130235c0f4e4"), null, new Guid("ee6de192-1e66-44a1-b31e-224bae960152"), 0, new Guid("bcf66a5f-ae74-4b13-bfc6-27e4856dcd08") },
                    { new Guid("b6493ac9-ab3d-475c-acb4-3f440e53a7fb"), null, new Guid("d671263a-e0ce-4d0e-a7d7-70657a82add1"), 1, new Guid("43ac12b9-c2aa-4adb-a6d5-1bf420724095") },
                    { new Guid("cf26de26-b732-4968-9d03-b53452852d4a"), null, new Guid("d3115ad6-eaf1-430c-9177-f7539792c524"), 0, new Guid("4928e71c-8dbc-4b2e-aa69-e4b4e7e018a9") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("01d15201-400b-4ee1-8102-7acac9d7bd18"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("03e422ca-680a-4541-800c-988f7d0cc3d8"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("081bc379-8ed1-4aea-859d-465fa7cca68a"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0d6e4c57-efdb-4112-9005-f1d7b6322a7f"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0dd13631-c4c5-4459-93b5-7a39e1777c13"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0ee60daf-99f2-42bf-9bb1-eed88ca25699"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0fe3786b-53c6-45ce-9cc9-2355c822789b"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("11ce80c7-ea8a-4db3-9792-0f64f361e266"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("1cd41421-b9c2-4a51-aeb2-ad63da40b0a9"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("26f8ea71-e61b-45a4-86a0-ac6c79fd74f3"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("2bc7b32a-36a2-4427-8ab1-14898bfd619d"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("2d2edd9a-3e07-4aa2-80ba-faae20a20dab"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("4040073c-988b-4d03-b9b1-e6a9afc104ca"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("40a60257-6787-4784-9c8c-73906f8f33e8"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("412bc6af-6e56-451b-941f-8fdbbe34ddb4"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("42cb6b96-72a2-4c7a-a345-a6537575fd56"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("430b4a8d-42d3-4c05-b312-8a32331dc3fe"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("43e8a91d-3288-4732-91ca-4b0d305888ca"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("4789085c-d9d5-4bed-8b15-ae7143607e31"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("48c513e1-eb2b-405c-9b29-5589dab79647"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("4e7435d9-66fd-4341-b7cc-9aa80a0e615c"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("531ee085-220b-4e36-9c22-103c82e74daf"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("5fd9425f-0171-489c-8b8f-5368b5608f9a"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("63c803bf-629e-43ee-983c-1418cf77e31a"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("64625a7a-d65e-4fbb-9295-290198548d72"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("658845ae-0f66-45bb-94b1-338d7cf68443"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("66cca60c-0aea-4d73-a516-5b1c40a8b624"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("674f8267-cbcf-495e-83c9-3f27b95f91d3"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("6981b720-7323-4eec-8858-afadbade71e5"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("6dc5bfa9-ddbb-4565-b41f-e6435475a283"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("6f6714da-4b47-4710-a226-398567b05654"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("73c7dde0-6869-4e9c-b8ed-b849c433f046"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("76c444f4-ee43-41f0-93ae-3fb8eecb0d48"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("7849c595-2ed6-45f6-a271-275f9fe63ab6"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("7870b425-0000-46de-bf4d-6a2c6822f22a"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("78d7d057-49eb-4005-8d6d-dad8860c6f7f"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("7b88feba-334d-4287-8225-c06b61bf08cc"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("7c0086b7-892f-4ce6-9443-84c21de7c280"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("7c2105a9-416f-4cef-94aa-ac7e2c4c1b69"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("82430c7d-48fe-4bea-abee-e40b46be9ab9"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("83666ac4-32be-41c8-b48e-7e43c4b4774c"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8c039e94-417b-4193-b7fc-54f80f42c948"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8dd0451d-abc4-4df7-bab5-6fd3d2450bf4"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8f8f6d25-5781-44c1-80f8-be6ad813733e"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("913dea16-6cca-48bf-90dd-7fa24f755a8d"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("92522d06-f1e1-415e-b7bd-d5145f84e4e2"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("9402b6e8-1b33-48fc-af77-b2127a018373"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("9533d33b-e634-46fb-988a-cce0ba7ecf97"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("9560cd3b-57af-427c-a475-95cd232321c9"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("972af4b8-a601-4bde-b84b-b678ca456528"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("9e18711a-75ba-48e6-8e41-b97f914d53b3"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("9eac5a1d-0aaa-4413-b2a0-70d397f430c6"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("9fc3c343-388b-40ed-82ba-2ef104bf1387"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("9fd14637-c8d0-46a1-a4fe-0a7acb5dc243"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("a1ab0ed6-ab42-4250-b6e8-66b083aa3481"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("a285c8be-92e7-4683-8839-152c25f41f84"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("a55a9254-a56d-4131-84d7-8a37f63f9c20"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("a5b328fe-61bc-449c-8bfe-c1198164aeee"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("aa3e0f9e-7b06-4c00-a71c-607939905724"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("ab13be98-948e-48ef-9e00-6420df0771a8"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("ac01859a-06f1-482a-a5ce-70de7be7b74f"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("acd58c61-8d92-4d32-aa31-7b2743c4764c"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("ae45e985-678c-4357-ade1-a6cdb325aa1e"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("affbd67a-4023-4572-87e9-0e23572e1610"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("b8a3fdd9-626d-485c-b64a-0c752f3353a1"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("b8c5d7f5-e1ce-44e5-84b5-b0e0887b4620"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("b924df80-cac2-48dc-8fb1-ae14ec12e3c8"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("bc2b2eb6-aad6-46fb-809d-859f005927c7"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("bc2e694c-0099-4b80-97e6-3c974323af22"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("bd60acd5-cd49-454c-bbe2-85fe778f5231"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("be34fc95-9ec6-43cb-9e6f-71b9fd5cda6b"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c476dc74-f894-4cce-8098-5c23cc4409c4"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c5e06ade-5abe-4531-9fb3-859dd718120e"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d0c3ad32-7c6f-4517-8830-8efe49a547f1"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2a141a6-851b-49ab-9f43-d52ea0685a80"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2c344a0-9ec6-4d10-9226-0bbebf397358"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d5389cef-6940-4001-a524-6c9916220866"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d90371e5-138e-47b8-9baf-f98404198c98"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("dab134e6-c8b2-4be7-8f7f-f80ce751ce14"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("daf22b48-ff8b-4a7e-8912-af105184c93d"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("db719239-2c21-43ee-bf82-3c882e42e40e"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("dce9becb-b137-4622-97fe-44ef41157d42"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("dcf06a17-2238-41df-a408-60f8e5224799"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("de46a09f-396d-42e8-8ede-876cdd77540d"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("e041c86c-aba9-498e-a7a4-f92cf4e02169"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("e44a6288-e2c2-4f19-8ae3-1d92c53d61fc"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("e7c930d4-91f9-4fac-abc4-357478f042e5"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f0f396b9-69ce-450a-83fb-d3a7995bf0ad"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f5c86921-1887-4016-a74d-bbe11a51053d"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("fdd1480c-1882-4775-b938-bcbd84a9d241"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("ff69d252-ed07-4b03-b4cc-311fb3dce3c7"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("00a53bf1-7e01-4c0c-b0e4-a178ec5d7943"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("01fff532-1f50-4300-8681-21cd71087245"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("07233cd5-3b8e-4c67-9b9d-b3708c07d7cc"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("0d65cc7c-0fd1-470d-83a7-fac4d4fad336"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("0e8bcb0e-977e-412a-84cf-7e24815c55ba"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("0eb8a94e-08fb-4406-aba3-2f7dd90cb45c"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("0ed150fe-384e-4d8a-ac7c-47ef03c2a13a"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("15c49606-706f-4003-94d4-b2c762996f99"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("17ae01d4-430a-4eca-a837-a02af69e9d05"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("188cee33-a456-49e0-b1fc-a01287bb50ef"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("194f7826-39d2-47ae-a0b6-40e56255a23a"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("1f3f851a-6944-4fad-aea1-a616cfb6a8dd"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("217b269d-10f2-45e8-be66-1487090d30ec"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("258e205a-63ab-4b2e-a531-53b7cdfbf94d"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("29b5b6e9-be52-4fe8-a0a7-adb3afccbe23"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("2bc75354-b0fb-4712-9629-886d2e78e1e2"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("2eaf337c-d319-49d2-ab1c-7b6f409340a6"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("2f28587b-af7c-46ee-9ad0-a705eb158792"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("302d9514-f416-42f4-aa88-73dc3dadf314"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("3161b9b4-130e-419c-a715-09fbcde630d4"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("3580e22a-e449-4443-ac78-332ce32b13da"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("39f95441-187e-4c5b-bd2f-9ea1b82dc207"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("3b10f03c-296c-410b-bb29-ba8b3cee774f"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("44fbad09-7f11-4e17-bd04-709373d35f78"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("4544303e-b6f0-4b7f-8488-e742b183f312"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("460984e6-c9cb-439d-a7b4-1a1833205fdb"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("4b7b7585-08c4-4f7b-836d-e3737de42be0"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("4b92cbf8-8e83-476c-a7b8-149215727cfe"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("4c5366c1-0cdb-4da7-abde-7d83f12ce8f8"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("4ed53c09-d9f2-4294-bed6-b8bcf42f415e"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("50c7c866-56cc-4dcd-b4ff-6af245d1c796"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("58f864b9-55f2-4347-b43b-e387fb36d799"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("5ca4616c-3cc4-4b58-816b-243b65fb0a30"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("5ffee86b-6091-462f-8862-8c56b01c008a"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("63c1280d-6a7d-4f63-9556-fd529a32b666"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("6b80c853-1ba7-481a-8c3a-7fdc337e88de"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("6cf8cdc0-7047-46a7-84e5-c34130599d57"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("6d6d477d-3d8c-4c98-9bc8-620b0691189c"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("6e3c81c1-4eb4-4806-9c4b-11e61b524c68"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("6e87f659-305d-4904-b24f-fa5323b3374a"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("7030e86a-5668-4965-bdae-de646fefff44"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("7294ed11-7f80-445a-89e7-784cd2adcca8"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("74c54c2a-0353-4988-937d-fb9a243232b6"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("76901b47-dc29-4dc8-9692-f59ed3456928"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("77891612-d471-4579-b757-8fef08795f3c"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("77a0f66e-014d-4fa9-957a-1f8c2d886449"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("82f0e282-2d22-4198-9f2a-44b0cbd56be7"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("831a54e5-6a38-4c67-98e1-bf98f2f08fb5"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("88711e9d-8a60-4b42-9b2f-38c5b8c993fd"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("89045c53-7eb0-4d89-a0f7-4bc8d9f0454e"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("8dd80532-044a-47e5-920c-dcdcc7b9823f"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("930f3d0c-eea3-4366-abce-7a50639f3ae5"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("94528bad-d843-4795-a540-c8bf8cbebb1a"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("95357556-e799-436f-8fac-36893aa9528f"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("95bd1398-fa49-49fa-95b6-8e743408a060"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("96386d96-98f2-4c7f-98a0-e8116cae38fc"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("9811c176-fe91-4ebc-a546-b7a8cb37dfd7"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("a3bacd6f-f0d5-430e-b6d0-d275c0c78b79"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("a6600da0-4bcb-46fe-af87-552f98f34e56"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("a74c2ae7-bdd7-4ea8-97d4-630888a6376b"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("a845a15a-e265-4f2d-b63e-9ff7c07ab064"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("a869e6ac-360a-4933-b9eb-333ba2f6284a"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("a9c10389-42db-4cab-9900-9be4fd440855"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("abc8af87-0e99-4f3f-ab63-258123df947e"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("ae4a51a9-585d-4aa3-bd59-f5c4dad596d9"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("afdaa989-e9bf-4d36-b0e8-98a4e12b1327"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("b11b4ec0-5e70-4654-8cca-7d6a609c99f6"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("b22b3acb-8c3b-4a11-a5ee-f6b25ce7e1d8"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("b272aa9c-c3ff-4f1e-be7e-dcbcadf851e4"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("b4993ce5-56d6-4d43-839e-2698c20833d3"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("b5a7a14d-044d-449b-b0a6-83eca9c9579a"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("b8ca5802-4c2c-47f0-86c5-3172910bbd09"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("c3cbde84-70f6-4a82-b02d-21175c58d8ca"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("ca977612-b0d1-47e9-b7b2-f8d856e343d5"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("cc12dc46-b403-4be3-90f0-388f3fd17476"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("cec39a06-dc0b-4407-9886-77f9f42699dc"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("d07ede48-aca0-4e75-8845-e2a88a74c41f"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("e440172f-1e2f-4eff-a3c3-0ed17701301d"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("e70a3aea-eee4-4639-add0-03dbf9b97d7a"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("e80a6c31-a69f-4a7a-9a52-c92e8347d20a"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("ea9156d9-5f8d-449c-bab3-e76613427ba2"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("ed781948-ad02-43ce-9f03-01eccd17b957"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("f1e84a30-0cb0-4efb-a01f-dc053b593474"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("f26579a7-1132-4d8f-b048-64098364f594"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("f71f2d50-49b9-42a2-a64a-b249853c2176"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("f9c518f5-3794-46ed-be45-4486dc0b9fda"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("fad3c95d-8151-4df4-a58a-d2a93981e884"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("fdccc7f5-a8b0-4d6f-893e-8848d2cf0f91"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("fde14f72-38ff-4151-9fdf-45dcce770a1c"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("109c564d-6ace-4a72-8236-40b1d5b2059e"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("16c1241f-4537-4ab6-b175-39d9cfd331b9"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("1b4880cb-e801-441f-bc5f-b3ab091cf0ca"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("27d1ebd7-3623-4b65-861f-1c46ea310bd9"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("32a0e351-da8f-4282-94c8-edd7dab29543"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("4428cdf1-4ecf-47b3-ad9d-afa7e064525d"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("49bf1315-6a4b-48c7-9487-0dae563b1913"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("519076fa-edb5-48e0-8a10-6f391c1059cf"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("5a95b0d6-8616-472b-98cb-308d042f8319"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("61fa76d5-30d3-49b0-b020-ba6444a831e5"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("648d0edd-5a05-487b-a2b0-a4f7f3388cc9"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("6b6024ee-2912-4399-96a3-7ac064065bc4"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("6e52bddb-0809-46a8-bbb0-83ee2003786d"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("7b03d6a9-2763-471c-b883-893d79cc5c86"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("8059308e-2a45-4d5d-ab10-2b12da229a74"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("8413646d-7822-4db8-85a1-9c56d1eba7a8"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("850a3fd1-aba8-4149-ada2-5eb2c63f2b90"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("ac73b145-9afa-4c84-acbd-130235c0f4e4"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("b6493ac9-ab3d-475c-acb4-3f440e53a7fb"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("cf26de26-b732-4968-9d03-b53452852d4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("00f95528-2bc0-4d1d-94ea-fc2c032829b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("012c7c9f-4925-49d9-af46-ecf1e5b748cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("04ea0cf3-75fd-4f30-b737-bbc2f0f7c64f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("0b79f5b6-45f6-4974-a977-4104c039ef4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("134b2d91-b638-4f52-9666-93bc2af600ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("134b7900-a6ac-4bee-8612-68afc55b38a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("16ed4de6-1791-437f-8399-a893fb6496f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("18f95b50-42df-4c78-b151-7cdffb7bba74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("1ad25d13-7fc8-4cba-8eb0-0d3a4912fa2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("1b061a9e-67e4-48f1-a4c6-e32dc82656e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("1d5abcbd-8607-42c0-bd60-6233cdd5e50c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("1df739a7-dbb6-4a1c-b5be-14b4e2e580b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("222d2743-d1b0-4f29-b6b8-94fbbd48837c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("22ad31e3-ceec-45ba-8fcd-ce96649829c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("297f113a-b7b6-48c8-acff-599567a70b38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("2eda824d-6420-40b8-a9d2-e7610fe7b70f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("30593b74-c63f-4fa8-a32d-1e1979ad51f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("34614d96-5892-422e-8509-86a7a491a9b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("3a37113b-0edf-4813-9fb2-43b41da13420"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("3f770ade-b80a-42fd-8217-8bd51cb949df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("408255a1-8a98-4212-b833-6cea91c3adc1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("4754c28d-4ce8-4f45-9b41-0e7f9be1b221"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("4895e34b-2590-4e8a-9702-55efe8c4f405"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("4a0bb6cd-0317-468c-a6a7-8ed68a16041a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("4a663f82-f610-4e24-88ec-f514a444ad19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("4be22dd4-d880-4c31-a48d-0d820b87a12c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("504c725f-a51c-4468-97eb-6d2a3b05aae6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("586ad721-0025-4ab1-b183-68caa6a690e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("58c3e0db-b0d0-48eb-8e24-15f343354470"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("58c910f1-ecac-4d20-9de5-bb9940165c54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("5978dcd8-df1a-4812-9938-fe44330164b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("59db8d1a-32cc-4ff4-a2f4-5eb212d52b51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("5a7eecb7-83c4-4a45-b2f0-38c0f1ae5e77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("5fe1746d-1474-419f-b8b8-40447beba716"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("631b33c5-b8fa-4489-a965-0fa804bda3b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("67ffb668-9a79-4178-a270-dba0d17a1db4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("6f7c14ec-5b47-48aa-a8e0-9f8bca98362c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("6fb15e4d-8377-43ff-9829-754468008a7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("70439e90-ac1c-4f54-bf5a-b396497e29d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("72ad5bf5-0682-47fd-bf09-d8eeb3613458"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("743a9f2b-7180-4e31-9a1e-574f0398c114"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7865b117-3bf8-4448-bb13-f8513fe193db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("84420a86-2c63-4747-99f2-21ea536db21f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("85db497c-f341-45a6-bee7-c434ccf16ac7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8661ada9-481a-426b-91ad-0b4f959557b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("88e7b816-7752-4b76-acf4-5611f1a42b44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8e029fc5-7214-40b9-a322-5a78839a1335"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8f813401-845a-40d8-974b-61254ea875ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8fe9c044-306c-44bd-99f8-c1c1a8db079a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("9142af88-46a9-43cf-95b5-ea15741b3745"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("97c8b27f-9ba4-478e-9fac-88aacf1ff658"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("98f4d349-1f2c-4cd2-9b25-a2e4a639bfce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("9a242c28-382d-46a6-a44b-26ed7d05ac87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a19edb59-115f-453b-9e65-932cb29ac89d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a31009ed-6d90-4b53-b814-61b212f38d54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a543f6f9-fb23-49c3-86e8-eb268c8ea98c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("aa97c67c-f752-46df-95fc-bbf84ad0e775"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b38901d6-bc73-4775-a8c1-94518b70d780"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b3924085-4857-473e-9ce0-f6bb2727b269"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("bd3c3f1a-01ef-4fa2-bd1b-f18105140db6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("c8c0bef5-fb2a-47e1-8fc9-c3d8bc86f8c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("cf155f5d-605a-4ca1-9733-af0a810037e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("d1a17cef-ed20-4c3d-a53f-2dbb87c4b6e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("d31aaa8d-07c0-4869-9103-a4f6f98c1dab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("d8598fea-b564-468a-9838-a0b91687e110"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e074c35c-a06a-4d31-a44f-02158d7c262e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e3b2513c-daeb-4f1a-af88-144836e7da92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e4b591b9-51aa-46f6-923c-f416d9bd6923"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e86bc86c-9b7b-45a7-853f-247e9a6d958a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("ec12043d-b285-4868-a73c-74f7e6524f1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("edecdf54-2cff-4164-afcf-6cf7229a551d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("ef84209c-eff9-4a62-a730-9338d8fd3a17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("eff0bb7c-1359-453c-b2de-1b71465a198b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("f0521a43-1cc3-498e-a7d3-cdb0cdf1aa32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("f7cf4b3f-b579-4fe9-ae5b-9789cb07a426"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("f86532d0-ab6a-4a41-8195-effb331f5297"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("fb891a63-90bd-4865-8533-8e147d6db11d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("fd2eed96-0775-49ba-8afb-0bb3d5f4f730"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("fd5c3633-73e8-486a-870a-55f9a276ec87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("ff1ad749-1627-4917-ab87-363cf09c16df"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("00e7a70a-bd3e-46b9-861d-1380d77ddf96"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("378726cc-f974-4475-afe4-92afe0cbbd58"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("4373d3c4-1234-472a-ad61-5e858239afe3"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("790f67b0-114e-42ef-91c6-e7557f96c04b"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8e793ea7-d9f1-404d-ad80-a89a14f23964"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c0705231-bc8c-47d4-9ebd-4601c19b613e"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c1e45f04-4924-467f-9739-0a8abcce303c"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("e141fd37-26e8-49a6-814a-aa64294b4e01"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("efc629d5-a594-4c77-a1f8-0355f13b2a1a"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("38d27970-5ceb-4cb6-80ab-432f7648d7ef"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("56495f98-f65b-4101-b660-146627448d82"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("63924d62-7756-4365-ae52-c59ea681cdac"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("7488a810-f089-4daf-983c-1b2c484001d8"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("a02b3012-0d27-4449-bd77-663e4942e5ce"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("a2f890f4-5239-4bbf-bbb2-ab14a18cb56a"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("c64f26f0-5953-491c-b740-4352d2238e47"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("d3115ad6-eaf1-430c-9177-f7539792c524"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("d671263a-e0ce-4d0e-a7d7-70657a82add1"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("dedef8f0-d336-44f9-ac26-5b8f1e36c709"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CreditCardId",
                keyValue: new Guid("ee6de192-1e66-44a1-b31e-224bae960152"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("052e3646-b176-4e0f-8885-be7a2e62a99b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("12b688e8-96ec-4ef8-bbb3-139a86fd6ae1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("1a0dbbf2-9ce0-4ffd-a3b7-0ccb7dad0afb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("2d57693d-8fec-4935-8641-5c2f0fb13cfc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("34f1e808-1624-42c0-8065-fb22136d7aac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("382ef7c5-97f0-4947-b704-046713adff53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("3a100e1d-c825-4ea0-ba70-848b448c7971"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("43ac12b9-c2aa-4adb-a6d5-1bf420724095"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("4928e71c-8dbc-4b2e-aa69-e4b4e7e018a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("4c641700-e9a7-4350-9c3e-0d88ac84723e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("6a07efb1-18e2-4be9-99eb-c20fe5b70f77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7c95e110-6ec6-4e60-adb8-0f58c19e88c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("87312bdb-ad9b-4579-a2be-2c486d003019"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("89a26576-e97a-4170-ad60-cce5f06291f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8f0901ed-daa5-4184-bc65-87e872d53e53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("9d9b6a6f-7a88-4d45-8054-f021dc7ec404"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("bcf66a5f-ae74-4b13-bfc6-27e4856dcd08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("df4e51ea-e773-4771-a826-2f1b6f84965d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e3b4a95e-9244-4172-b13d-06de1b38c5ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("ffba3112-edc7-4a20-aac9-4de5f45644e0"));
        }
    }
}
