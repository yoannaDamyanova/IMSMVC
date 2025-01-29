using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class TranslateProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb4f0e39-4f66-46fa-85e0-ed2d577d51f2", "AQAAAAIAAYagAAAAEPICCJBPerYOS/Eh7LqRgdRjYrvsC7v6NuXZWLVU1jMO+9CqTnKn8L4ex6/QH1zu0w==", "333b37b0-84e1-4d21-8bed-05055466bd36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccecb44f-f648-44cf-a5ae-4f8efc1c8ec4", "AQAAAAIAAYagAAAAECpZw34BWrDSQh9arBCG7wk+/bDNQXAa2ECTnMNrDKE+coSMn0WkbeW4XjSNNRcHTw==", "982d72d4-2290-4bc4-82db-621bafe7ee33" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Храни и напитки");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Мебели и интериор");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Електроуреди/Бяла и черна техника");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Дрехи и аксесоари");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Здраве и лична грижа");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Инструменти и железария");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Спорт и оборудване за открито");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13cc5dae-f692-4e93-9b7d-3b1e520d4e89"),
                column: "Description",
                value: "Създаден с мисъл за планетата.Грижата за природата започва от кутията на смартфона ти. Изработен с рециклирано стъкло и PET фолио и оцветен с естествени багрила, всеки смартфон е сложен в кутия, направена от рециклирана хартия и защитно фолио на хартиена основа.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b966829-79b6-4eff-8e6d-51e147f966ea"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Изчистен дизайн с фурнир от масивна дървесина. Можете да поставите леглото на разстояние от останалите мебели или с горната табла до стената. Ако имате нужда от допълнително пространство за завивки, добавете MALM кутиите за съхранение на колелца.", "IKEA MALM легло" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35970b4c-ac84-4e23-bf98-ac1785d736da"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Хрупкави картофени чипсове с леко осоляване в голям семеен пакет. Перфектни за споделяне.", "Lay's Класически картофени чипсове (Парти размер)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e861aa5-5553-456e-bd6f-4312ffc05563"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Класически прави дънки, изработени от издръжлив памук, налични в различни размери и измивания.", "LEVI'S ® Слим фит Дънки '501' в Светлосиньо" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62f797e8-e161-4d59-a29a-b1a806b45edb"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Dove Deep Moisture Nourishing Body Wash е създаден с мисъл за вашата кожа, за да осигури дълбока хидратация и трайно подхранване. С уникалната си формула, обогатена с Moisture Renew Blend, този душ-гел комбинира естествени подхранващи вещества и овлажнители на растителна основа, които проникват дълбоко в горните слоеве на кожата, за да я поддържат мека и гладка.", "Dove Deep Moisture Nourishing Body Wash 1L" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7508feee-3168-401e-84d7-9e126b394196"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Професионалният комплект инструменти BOSCH 12V включва: Акумулаторен ъглошлайф GWS 12V-76 SOLO + Акумулаторен винтоверт GSR 12V-30 SOLO, 1 батерия 4.0Ah, 1 батерия 2.0Ah, зарядно устройство, два броя дискове и чанта за инструменти.", "Bosch Безжичен бормашинен комплект (12V)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aef8b15d-c498-4ee4-a31f-ef67e1c970c7"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Емблематичната баскетболна топка с несравнимо усещане. Създаден за играчи, които знаят, че упоритата работа води до еволюция.", "Баскетболна топка Wilson Evolution" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06e4a52b-0ee1-426f-b7a2-6b009a0c1f65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34a6a3a6-393c-455f-91b4-e9035f08d386", "AQAAAAIAAYagAAAAEEyIsd0zOw9C5KNdnN6i3KqLInOPcWMJMjIgQMpYkvIXKi7PE6sJUu0xqtsIMsHQbg==", "c2f22489-ee9d-4fcf-9f6e-3e0e1b1bd302" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69b38fdd-0aba-47f5-9f2b-6c7bb549d7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8bb1122-c89c-4ae5-ace9-9d4745483efe", "AQAAAAIAAYagAAAAEJZKFOnyKOMUwe4afZ718LU8J9rtzPnRvT6dxD43IdX+BH4EkOpo8nUyht9H6shdOA==", "95f90eba-cb04-4dfc-8c00-896d6a4b4460" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Food and Beverages");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Furniture and Home Goods");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Electronics and Appliances");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Clothing and Accessories");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Health and Personal Care");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Automotive and Tools");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Sports and Outdoor Equipment");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13cc5dae-f692-4e93-9b7d-3b1e520d4e89"),
                column: "Description",
                value: "A flagship smartphone with a 6.1-inch AMOLED display, 256GB storage, and a powerful triple-camera system");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b966829-79b6-4eff-8e6d-51e147f966ea"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A modern queen-sized wooden bed frame with a minimalist design and storage drawers underneath.", "IKEA MALM Bed Frame" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35970b4c-ac84-4e23-bf98-ac1785d736da"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Crispy and lightly salted potato chips in a large family-size bag. Perfect for sharing", "Lay's Classic Potato Chips (Party Size)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e861aa5-5553-456e-bd6f-4312ffc05563"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Classic straight-leg denim jeans made from durable cotton, available in various sizes and washes.", "Levi's 501 Original Jeans" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62f797e8-e161-4d59-a29a-b1a806b45edb"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Gentle body wash with a rich lather that nourishes and moisturizes the skin.", "Dove Deep Moisture Body Wash (16 oz)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7508feee-3168-401e-84d7-9e126b394196"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Compact and lightweight cordless drill with two-speed settings, a rechargeable battery, and a carrying case.", "Bosch Cordless Drill/Driver Kit (12V)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aef8b15d-c498-4ee4-a31f-ef67e1c970c7"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "High-quality indoor basketball with a soft feel, designed for competitive play and superior grip.", "Wilson Evolution Indoor Basketball" });
        }
    }
}
