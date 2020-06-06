using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using UniversalLocator.Models;

namespace UniversalLocator.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var jsonString = System.IO.File.ReadAllText("us-zip-code-latitude-and-longitude.json");
            List<PlaceWrapper> weatherForecast = JsonSerializer.Deserialize<List<PlaceWrapper>>(jsonString);

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new {
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zipcode = table.Column<int>(nullable: false),
                    Longitude = table.Column<double>(nullable: true),
                    Latitude = table.Column<double>(nullable: true)
                });

            weatherForecast.ForEach(place => {
                migrationBuilder.InsertData("Places", 
                    new string[] { "City", "State", "Zipcode", "Longitude", "Latitude" }, 
                    new object[] { place.fields.city, place.fields.state, int.Parse(place.fields.zip), place.fields.longitude, place.fields.latitude });
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
