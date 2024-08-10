using System; 
using Microsoft.EntityFrameworkCore; 
using Microsoft.Extensions.DependencyInjection; 
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections;
using System.ComponentModel.Design.Serialization;
using CarRental;
using Buyers;
// using MainP;
// using Data_base;
using Car_Fleet = CarRental.Car_Fleet;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRentalApp.Data;



namespace CarRentalApp.Data
{
  class Program
  {
    public static class Fleet_global
    {
      public static Car_Fleet? fleet { get; set; }
    }
    public static void Main()
    {
      Console.WriteLine("Hello");
      using (var context = new CarRentalContext())
      {
        var res1 = new Reservation()
        {
          day_1 = new DateTime(2024, 11, 11),
          day_n = new DateTime(2024, 11, 14)
        };
        var res2 = new Reservation()
        {
          day_1 = new DateTime(2024, 11, 11),
          day_n = new DateTime(2024, 11, 12)
        };
        var res3 = new Reservation()
        {
          day_1 = new DateTime(2024, 11, 12),
          day_n = new DateTime(2024, 11, 15)
        };
        var res4 = new Reservation()
        {
          day_1 = new DateTime(2024, 11, 13),
          day_n = new DateTime(2024, 11, 19)
        };
        var res5 = new Reservation()
        {
          day_1 = new DateTime(2024, 11, 15),
          day_n = new DateTime(2024, 11, 29)
        };
        var res6 = new Reservation()
        {
          day_1 = new DateTime(2024, 11, 15),
          day_n = new DateTime(2024, 11, 18)
        };
        var res7 = new Reservation()
        {
          day_1 = new DateTime(2024, 11, 15),
          day_n = new DateTime(2024, 12, 7)
        };
        var res8 = new Reservation()
        {
          day_1 = new DateTime(2024, 11, 18),
          day_n = new DateTime(2024, 12, 16)
        };
        var res9 = new Reservation()
        {
          day_1 = new DateTime(2024, 11, 24),
          day_n = new DateTime(2024, 11, 29)
        };
        var res10 = new Reservation()
        {
          day_1 = new DateTime(2024, 12, 3),
          day_n = new DateTime(2024, 12, 5)
        };
        var res11 = new Reservation()
        {
          day_1 = new DateTime(2024, 12, 6),
          day_n = new DateTime(2024, 12, 14)
        };
        var res12 = new Reservation()
        {
          day_1 = new DateTime(2024, 12, 9),
          day_n = new DateTime(2024, 12, 30)
        };
        var res13 = new Reservation()
        {
          day_1 = new DateTime(2024, 12, 16),
          day_n = new DateTime(2024, 12, 27)
        };
        var res14 = new Reservation()
        {
          day_1 = new DateTime(2024, 12, 18),
          day_n = new DateTime(2024, 12, 24)
        };
        var res15 = new Reservation()
        {
          day_1 = new DateTime(2024, 12, 19),
          day_n = new DateTime(2024, 12, 20)
        };
        var res16 = new Reservation()
        {
          day_1 = new DateTime(2024, 12, 21),
          day_n = new DateTime(2024, 12, 29)
        };
        var res17 = new Reservation()
        {
          day_1 = new DateTime(2024, 12, 22),
          day_n = new DateTime(2024, 11, 7)
        };
        var res18 = new Reservation()
        {
          day_1 = new DateTime(2024, 12, 22),
          day_n = new DateTime(2024, 12, 9)
        };
        var res19 = new Reservation()
        {
          day_1 = new DateTime(2024, 1, 2),
          day_n = new DateTime(2024, 1, 8)
        };
        var res20 = new Reservation()
        {
          day_1 = new DateTime(2024, 1, 2),
          day_n = new DateTime(2024, 1, 13)
        };
        var res21 = new Reservation()
        {
          day_1 = new DateTime(2024, 1, 2),
          day_n = new DateTime(2024, 1, 15)
        };
        var res22 = new Reservation()
        {
          day_1 = new DateTime(2024, 1, 5),
          day_n = new DateTime(2024, 1, 7)
        };
        var res23 = new Reservation()
        {
          day_1 = new DateTime(2024, 1, 6),
          day_n = new DateTime(2024, 1, 10)
        };
        var res24 = new Reservation()
        {
          day_1 = new DateTime(2024, 1, 8),
          day_n = new DateTime(2024, 1, 12)
        };
        var res25 = new Reservation()
        {
          day_1 = new DateTime(2024, 1, 11),
          day_n = new DateTime(2024, 1, 12)
        };
        var res26 = new Reservation()
        {
          day_1 = new DateTime(2024, 1, 18),
          day_n = new DateTime(2024, 1, 29)
        };
        var res27 = new Reservation()
        {
          day_1 = new DateTime(2024, 1, 22),
          day_n = new DateTime(2024, 1, 26)
        };
        var res28 = new Reservation()
        {
          day_1 = new DateTime(2024, 1, 28),
          day_n = new DateTime(2024, 2, 3)
        };
        var res29 = new Reservation()
        {
          day_1 = new DateTime(2024, 1, 30),
          day_n = new DateTime(2024, 2, 8)
        };
        var res30 = new Reservation()
        {
          day_1 = new DateTime(2024, 1, 30),
          day_n = new DateTime(2024, 2, 18)
        };
        var res31 = new Reservation()
        {
          day_1 = new DateTime(2024, 2, 4),
          day_n = new DateTime(2024, 3, 2)
        };
        var res32 = new Reservation()
        {
          day_1 = new DateTime(2024, 2, 9),
          day_n = new DateTime(2024, 2, 13)
        };
        var res33 = new Reservation()
        {
          day_1 = new DateTime(2024, 2, 12),
          day_n = new DateTime(2024, 2, 18)
        };
        var res34 = new Reservation()
        {
          day_1 = new DateTime(2024, 2, 12),
          day_n = new DateTime(2024, 2, 24)
        };
        var res35 = new Reservation()
        {
          day_1 = new DateTime(2024, 2, 18),
          day_n = new DateTime(2024, 2, 22)
        };
        var res36 = new Reservation()
        {
          day_1 = new DateTime(2024, 2, 20),
          day_n = new DateTime(2024, 2, 27)
        };
        var res37 = new Reservation()
        {
          day_1 = new DateTime(2024, 2, 23),
          day_n = new DateTime(2024, 2, 28)
        };
        var res38 = new Reservation()
        {
          day_1 = new DateTime(2024, 2, 26),
          day_n = new DateTime(2024, 3, 4)
        };
        var res39 = new Reservation()
        {
          day_1 = new DateTime(2024, 2, 29),
          day_n = new DateTime(2024, 2, 9)
        };
        var res40 = new Reservation()
        {
          day_1 = new DateTime(2024, 3, 1),
          day_n = new DateTime(2024, 3, 3)
        };
        var res41 = new Reservation()
        {
          day_1 = new DateTime(2024, 3, 1),
          day_n = new DateTime(2024, 3, 7)
        };
        var res42 = new Reservation()
        {
          day_1 = new DateTime(2024, 3, 4),
          day_n = new DateTime(2024, 3, 8)
        };
        var res43 = new Reservation()
        {
          day_1 = new DateTime(2024, 3, 12),
          day_n = new DateTime(2024, 3, 25)
        };
        var res44 = new Reservation()
        {
          day_1 = new DateTime(2024, 3, 13),
          day_n = new DateTime(2024, 4, 10)
        };
        var res45 = new Reservation()
        {
          day_1 = new DateTime(2024, 3, 13),
          day_n = new DateTime(2024, 3, 30)
        };
        var res46 = new Reservation()
        {
          day_1 = new DateTime(2024, 3, 17),
          day_n = new DateTime(2024, 3, 23)
        };
        var res47 = new Reservation()
        {
          day_1 = new DateTime(2024, 3, 23),
          day_n = new DateTime(2024, 4, 16)
        };
        var res48 = new Reservation()
        {
          day_1 = new DateTime(2024, 3, 25),
          day_n = new DateTime(2024, 3, 29)
        };
        var res49 = new Reservation()
        {
          day_1 = new DateTime(2024, 3, 28),
          day_n = new DateTime(2024, 3, 29)
        };
        var res50 = new Reservation()
        {
          day_1 = new DateTime(2024, 3, 30),
          day_n = new DateTime(2024, 4, 20)
        };
        var res51 = new Reservation()
        {
          day_1 = new DateTime(2024, 4, 1),
          day_n = new DateTime(2024, 4, 3)
        };
        var res52 = new Reservation()
        {
          day_1 = new DateTime(2024, 4, 2),
          day_n = new DateTime(2024, 4, 4)
        };
        var res53 = new Reservation()
        {
          day_1 = new DateTime(2024, 4, 5),
          day_n = new DateTime(2024, 4, 14)
        };
        var res54 = new Reservation()
        {
          day_1 = new DateTime(2024, 4, 12),
          day_n = new DateTime(2024, 4, 29)
        };
        var res55 = new Reservation()
        {
          day_1 = new DateTime(2024, 4, 13),
          day_n = new DateTime(2024, 4, 27)
        };
        var res56 = new Reservation()
        {
          day_1 = new DateTime(2024, 4, 15),
          day_n = new DateTime(2024, 4, 30)
        };
        var res57 = new Reservation()
        {
          day_1 = new DateTime(2024, 4, 15),
          day_n = new DateTime(2024, 4, 30)
        };
        var res58 = new Reservation()
        {
          day_1 = new DateTime(2024, 4, 19),
          day_n = new DateTime(2024, 4, 21)
        };
        var res59 = new Reservation()
        {
          day_1 = new DateTime(2024, 4, 20),
          day_n = new DateTime(2024, 4, 23)
        };
        var res60 = new Reservation()
        {
          day_1 = new DateTime(2024, 4, 27),
          day_n = new DateTime(2024, 4, 30)
        };
        var res61 = new Reservation()
        {
          day_1 = new DateTime(2024, 4, 30),
          day_n = new DateTime(2024, 5, 2)
        };
        var res62 = new Reservation()
        {
          day_1 = new DateTime(2024, 5, 2),
          day_n = new DateTime(2024, 5, 3)
        };
        var res63 = new Reservation()
        {
          day_1 = new DateTime(2024, 5, 5),
          day_n = new DateTime(2024, 5, 8)
        };
        var res64 = new Reservation()
        {
          day_1 = new DateTime(2024, 5, 9),
          day_n = new DateTime(2024, 5, 18)
        };
        var res65 = new Reservation()
        {
          day_1 = new DateTime(2024, 5, 13),
          day_n = new DateTime(2024, 5, 28)
        };
        var res66 = new Reservation()
        {
          day_1 = new DateTime(2024, 5, 13),
          day_n = new DateTime(2024, 5, 28)
        };
        var res67 = new Reservation()
        {
          day_1 = new DateTime(2024, 5, 16),
          day_n = new DateTime(2024, 5, 29)
        };
        var res68 = new Reservation()
        {
          day_1 = new DateTime(2024, 5, 19),
          day_n = new DateTime(2024, 6, 16)
        };
        var res69 = new Reservation()
        {
          day_1 = new DateTime(2024, 5, 24),
          day_n = new DateTime(2024, 5, 29)
        };
        var res70 = new Reservation()
        {
          day_1 = new DateTime(2024, 5, 29),
          day_n = new DateTime(2024, 6, 15)
        };

        context.Reservations.Add(res1);
        context.Reservations.Add(res2);
        context.Reservations.Add(res3);
        context.Reservations.Add(res4);
        context.Reservations.Add(res5);
        context.Reservations.Add(res1);
        context.Reservations.Add(res1);
        context.Reservations.Add(res1);
        context.Reservations.Add(res9);
        context.Reservations.Add(res10);
        context.Reservations.Add(res11);
        context.Reservations.Add(res12);
        context.Reservations.Add(res13);
        context.Reservations.Add(res14);
        context.Reservations.Add(res15);
        context.Reservations.Add(res16);
        context.Reservations.Add(res17);
        context.Reservations.Add(res18);
        context.Reservations.Add(res19);
        context.Reservations.Add(res20);
        context.Reservations.Add(res21);
        context.Reservations.Add(res22);
        context.Reservations.Add(res23);
        context.Reservations.Add(res24);
        context.Reservations.Add(res25);
        context.Reservations.Add(res26);
        context.Reservations.Add(res27);
        context.Reservations.Add(res28);
        context.Reservations.Add(res29);
        context.Reservations.Add(res30);
        context.Reservations.Add(res31);
        context.Reservations.Add(res32);
        context.Reservations.Add(res33);
        context.Reservations.Add(res34);
        context.Reservations.Add(res35);
        context.Reservations.Add(res36);
        context.Reservations.Add(res37);
        context.Reservations.Add(res38);
        context.Reservations.Add(res39);
        context.Reservations.Add(res40);
        context.Reservations.Add(res41);
        context.Reservations.Add(res42);
        context.Reservations.Add(res43);
        context.Reservations.Add(res44);
        context.Reservations.Add(res45);
        context.Reservations.Add(res46);
        context.Reservations.Add(res47);
        context.Reservations.Add(res48);
        context.Reservations.Add(res49);
        context.Reservations.Add(res50);
        context.Reservations.Add(res51);
        context.Reservations.Add(res52);
        context.Reservations.Add(res53);
        context.Reservations.Add(res54);
        context.Reservations.Add(res55);
        context.Reservations.Add(res56);
        context.Reservations.Add(res57);
        context.Reservations.Add(res58);
        context.Reservations.Add(res59);
        context.Reservations.Add(res60);
        context.Reservations.Add(res61);
        context.Reservations.Add(res62);
        context.Reservations.Add(res63);
        context.Reservations.Add(res64);
        context.Reservations.Add(res65);
        context.Reservations.Add(res66);
        context.Reservations.Add(res67);
        context.Reservations.Add(res68);
        context.Reservations.Add(res69);
        context.Reservations.Add(res70);


        // firma model culoare an_fabricatie pret_zi km is_for_sale pret_vanzare quality_class reservations propulsion
        var car1 = new Car()
        {
          id = "PO911R", nr_inmatriculare = "MAL11BU", firma = "Porsche", model = "911 Carrera", culoare = "Frozenberrymetallic",
          an_fabricatie = 2022, pret_zi = 1200, km = 3418, is_for_sale = false, pret_vanzare = 0, quality_class = 1,
          reservations = {res1, res17, res23, res41, res61, res68}, propulsion = "G"
        };
        var car2 = new Car()
        {
          id = "PO911T4GTS", nr_inmatriculare = "TAN1104", firma = "Porsche", model = "911 Targa 4 GTS", culoare = "Cremewhite",
          an_fabricatie = 2021, pret_zi = 1250, km = 2313, is_for_sale = false, pret_vanzare = 0, quality_class = 1,
          reservations = {res2, res4, res9, res34, res47, res53, res56, res64, res70}, propulsion = "G"
        };
        var car3 = new Car()
        {
          id = "POCCO", nr_inmatriculare = "U826HD99", firma = "Porsche", model = "Cayenne Coupé", culoare = "Basaltblackemtallic",
          an_fabricatie = 2024, pret_zi = 2500, km = 140, is_for_sale = false, pret_vanzare = 0, quality_class = 1,
          reservations = {res1, res7, res8, res16, res23, res44, res52, res53, res56, res67, res69, res70}, propulsion = "E"
        };
        var car4 = new Car()
        {
          id = "RRV", nr_inmatriculare = "12RAN86", firma = "Land Rover", model = "Range Rover Velar", culoare = "Hakuba Silver",
          an_fabricatie = 2024, pret_zi = 2650, km = 846, is_for_sale = false, pret_vanzare = 0, quality_class = 1,
          reservations = {res3, res4, res9, res14, res15, res40, res42, res48, res49}, propulsion = "H"
        };
        var car5 = new Car()
        {
          id = "F296GTS", nr_inmatriculare = "MA4UH7", firma = "Ferrari", model = "296 GTS", culoare = "Rosso Imola",
          an_fabricatie = 2023, pret_zi = 3150, km = 7351, is_for_sale = false, pret_vanzare = 0, quality_class = 1,
          reservations = {res6, res9, res11, res21, res31, res32, res33, res63, res64, res65}, propulsion = "H"
        };
        var car6 = new Car()
        {
          id = "FDSP3", nr_inmatriculare = "PROJ3CT", firma = "Ferrari", model = "Daytona SP3", culoare = "Rosso Scuderia",
          an_fabricatie = 2024, pret_zi = 4510, km = 102, is_for_sale = false, pret_vanzare = 0, quality_class = 1,
          reservations = {res7, res8, res10, res16, res18, res34, res37, res43, res56, res58, res66, res67}, propulsion = "E"
        };
        var car7 = new Car()
        {
          id = "PE1", nr_inmatriculare = "JD726RU", firma = "Porsche", model = "Panamera Executive", culoare = "Speedyellow",
          an_fabricatie = 2019, pret_zi = 960, km = 13972, is_for_sale = true, pret_vanzare = 95000, quality_class = 1,
          reservations = {res12, res13, res23, res24, res25, res59, res61, res62}, propulsion = "H"
        };
        var car8 = new Car()
        {
          id = "LHES", nr_inmatriculare = "LAM8236B", firma = "Lamborghini", model = "Huracan Evo Spyder", culoare = "Verde Selvans",
          an_fabricatie = 2024, pret_zi = 6700, km = 97, is_for_sale = false, pret_vanzare = 0, quality_class = 1,
          reservations = {res5, res26, res28, res35, res45, res53, res55, res64}, propulsion = "E"
        };
        var car9 = new Car()
        {
          id = "MGC0", nr_inmatriculare = "JDY86H7", firma = "Mercedes", model = "G Class", culoare = "Black Magnetite",
          an_fabricatie = 2020, pret_zi = 1500, km = 8462, is_for_sale = true, pret_vanzare = 85000, quality_class = 1,
          reservations = {res6, res7, res18, res23, res24, res36, res37, res38, res54, res58, res63, res66}, propulsion = "H"
        };
        var car10 = new Car()
        {
          id = "AMDB12V", nr_inmatriculare = "BCGT85V", firma = "Aston Martini", model = "DB12 Volante", culoare = "Valour",
          an_fabricatie = 2023, pret_zi = 5860, km = 1057, is_for_sale = false, pret_vanzare = 0, quality_class = 1,
          reservations = {res3, res6, res14, res21, res28, res35, res42, res49, res56, res63, res70}, propulsion = "H"
        };
        var car11 = new Car()
        {
          id = "AA6", nr_inmatriculare = "A937N49", firma = "Audi", model = "A6", culoare = "Madeira Brown",
          an_fabricatie = 2017, pret_zi = 650, km = 23846, is_for_sale = true, pret_vanzare = 35780, quality_class = 2,
          reservations = {res19, res20, res22, res23, res27, res28, res29, res30, res39}, propulsion = "E"
        };
        var car12 = new Car()
        {
          id = "CXT6", nr_inmatriculare = "ZV98J37", firma = "Cadillac", model = "XT6", culoare = "Emerald Lake Metallic",
          an_fabricatie = 2018, pret_zi = 380, km = 16739, is_for_sale = true, pret_vanzare = 31520, quality_class = 2,
          reservations = {res17, res28, res31, res40, res46, res50, res51, res57, res60, res62, res65, res68}, propulsion = "H"
        };
        var car13 = new Car()
        {
          id = "BiX1", nr_inmatriculare = "MS83K17", firma = "BMW", model = "iX1", culoare = "Phytonic Blue",
          an_fabricatie = 2020, pret_zi = 870, km = 9273, is_for_sale = true, pret_vanzare = 29800, quality_class = 2,
          reservations = {res3, res6, res14, res25, res45, res57, res60}, propulsion = "G"
        };
        var car14 = new Car()
        {
          id = "AZDX", nr_inmatriculare = "PR976CT", firma = "Acura", model = "ZDX", culoare = "Snowfall Pearl",
          an_fabricatie = 2023, pret_zi = 950, km = 3513, is_for_sale = false, pret_vanzare = 0, quality_class = 2,
          reservations = {res4, res16, res32, res64, res68, res69, res70}, propulsion = "E"
        };
        var car15 = new Car()
        {
          id = "TMX", nr_inmatriculare = "S8K9P2", firma = "Tesla", model = "Model X", culoare = "Pearl White Multi-Coat",
          an_fabricatie = 2021, pret_zi = 550, km = 8562, is_for_sale = true, pret_vanzare = 10000, quality_class = 2,
          reservations = {res5, res11, res38, res51, res56, res63, res70}, propulsion = "E" 
        };
        context.Cars.Add(car1);
        context.Cars.Add(car2);
        context.Cars.Add(car3);
        context.Cars.Add(car4);
        context.Cars.Add(car5);
        context.Cars.Add(car6);
        context.Cars.Add(car7);
        context.Cars.Add(car8);
        context.Cars.Add(car9);
        context.Cars.Add(car10);
        context.Cars.Add(car11);
        context.Cars.Add(car12);
        context.Cars.Add(car13);
        context.Cars.Add(car14);
        context.Cars.Add(car15);

        var only_available_fleet = new Car_Fleet()
        {
          id_unic = 888,
          car = { car1, car2, car3, car4, car5, car6, car7, car8, car9, car10, car11, car12, car13, car14, car15 }
        };
        context.Car_Fleets.Add(only_available_fleet);
        
        // var

        context.SaveChanges();

      };
      
      Console.WriteLine("Hello! Please select what would you like to do:\nPress 1 to look through our cars\nPress 2 to sign in\nPress 3 to create an account");
      
      
      // int input = int.Parse(Console.ReadLine());
      string? input2 = Console.ReadLine(); // Permite input nullabil
    
      if (!int.TryParse(input2, out int input))
      {
        Console.WriteLine("Invalid input. Please enter a valid number.");
      }
      else
      {
        if (input == 1)
        {
        
        }
      }
    }

    public class CarRentalContext: DbContext
    {
      public DbSet<Car> Cars { get; set; }
      public DbSet<Reservation> Reservations { get; set; }
      public DbSet<Car_Fleet> Car_Fleets { get; set; }
      public DbSet<Rental> Rentals { get; set; }
      public DbSet<Client> Clients { get; set; }
      
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
        optionsBuilder.UseInMemoryDatabase("cars");
      }
    }
    
  }
}





// namespace Data_base
// {
//   public class DB_context: DbContext
//   {
//     public DbSet<Car> Cars { get; set; }
//
//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//       optionsBuilder.UseInMemoryDatabase("cars");
//     }
//   }
// }




namespace CarRental
{
  public class Reservation
  {
    public int id { get; set; }
    public DateTime day_1 { get; set; }
    public DateTime day_n { get; set; }

    public Reservation() { }

    public Reservation(DateTime start, DateTime end)
    {
      day_1 = start;
      day_n = end;
    }
  }
  public class Car
  {
    [Key]
    public string? id { get; set; }
    public string? nr_inmatriculare { get; set; }
    
    public string? firma { get; set; }
    public string? model { get; set; }
    public string? culoare { get; set; }
    public int an_fabricatie { get; set; }
    public int pret_zi { get; set; }
    public int km { get; set; }
    // public bool is_available { get; set; }

    public bool is_for_sale { get; set; }
    public int pret_vanzare { get; set; }
    
    public int quality_class { get; set; }
    
    public List<Reservation>? reservations { get; set; } = new List<Reservation>();
    
    public string propulsion { get; set; }

    public Car() { }

    public Car(List<Reservation> rezervari, string id2 = "ABC123", string nr_inmatriculare2 = "B 01 ZZZ", string firma2 = "Porsche",
      string model2 = "911", string culoare2 = "frozenberrymetallic",
      int an2 = 2024, int pret_zi2 = 1000, int km2 = 10, bool valabilitate = true, bool is_for_sale2 = false,
      int pret_vanzare2 = 0, int qualityClass2 = 1, string propulsion = "E")
    {
      id = id2;
      nr_inmatriculare = nr_inmatriculare2;
      firma = firma2;
      model = model2;
      culoare = culoare2;
      an_fabricatie = an2;
      pret_zi = pret_zi2;
      km = km2;
      // is_available = valabilitate;
      is_for_sale = is_for_sale2;
      pret_vanzare = pret_vanzare2;
      quality_class = qualityClass2;
      reservations = rezervari;
    }

    public void update(string id2, string nr_inmatriculare2, string firma2, string model2, string culoare2,
      int an2, int pret_zi2, int km2, bool valabilitate, int calitate, List<Reservation> rezervari)
    {
      id = id2;
      nr_inmatriculare = nr_inmatriculare2;
      firma = firma2;
      model = model2;
      culoare = culoare2;
      an_fabricatie = an2;
      pret_zi = pret_zi2;
      km = km2;
      // is_available = valabilitate;
      quality_class = calitate;
      reservations = rezervari;
    }

    public void show_details()
    {
      Console.WriteLine("Car ID: {0}", id);
      Console.WriteLine("License plate: {0}", nr_inmatriculare);
      Console.WriteLine("Company & type: {0} {1}", firma, model);
      Console.WriteLine("Colour: {0}", culoare);
      Console.WriteLine("Year: {0}", an_fabricatie);
      Console.WriteLine("Rent price/day: {0}", pret_zi);
      Console.WriteLine("Km: {0}", km);
      Console.WriteLine("Quality class: {0}", quality_class);
    }

    private object WriteLine(string carId, string p1)
    {
      throw new NotImplementedException();
    }


    public void selling_details()
    {
      if (is_for_sale)
      {
        Console.WriteLine("Price: {0}", pret_vanzare);
      }
      else
      {
        Console.WriteLine("This car is not for sale");
      }
    }
    
    
    public bool check_availability(DateTime first_day, DateTime last_day)
    {
      if (reservations != null)
      {
        foreach (var reservation in reservations)
        {
          if ((first_day < reservation.day_n) && (last_day > reservation.day_1))
          {
            return false;
          }
        }

        return true;
      }

      return true;
    }

    public bool id_corect(string id)
    {
      if (this.id == id)
      {
        return true;
      }

      return false;
    }
    
  }

  
  
  
  public class Car_Fleet
  {
    // private static readonly Lazy<Car_Fleet> instance = new Lazy<Car_Fleet>(() => new Car_Fleet());
    //
    // public static Car_Fleet Instance => instance.Value;
    [Key] public int id_unic { get; set; } = 1;
    public List<Car> car { get; set; }

    public Car_Fleet()
    {
      car = new List<Car>();
    }

    public void add_Car(Car masina)
    {
      if (masina == null)
      {
        Console.WriteLine("The car is invalid. Please try again");
      }
      else
      {
        car.Add(masina);
      }
    }

    public void modifyCar(Car masinuta)
    {
      var car2 = car.FirstOrDefault(c => c.id == masinuta.id);
      if (car2 != null)
      {
        car2.culoare = masinuta.culoare;
        car2.nr_inmatriculare = masinuta.nr_inmatriculare;
        car2.firma = masinuta.firma;
        car2.model = masinuta.model;
        car2.an_fabricatie = masinuta.an_fabricatie;
        car2.pret_zi = masinuta.pret_zi;
        car2.km = masinuta.km;
        // car2.is_available = masinuta.is_available;
        car2.is_for_sale = masinuta.is_for_sale;
        car2.pret_vanzare = masinuta.pret_vanzare;

        Task.Run(() => SomeMethodAsync()).GetAwaiter().GetResult();
      }
      else
      {
        Console.WriteLine("Failed action. Please try again later");
      }
    }

    public Car find_by_id(string id)
    {
      Car? masina = car.FirstOrDefault(c => c.id == id);
      if (masina != null)
      {
        return masina;
      }

      Reservation rezervare = new Reservation();
      return new Car(); 
    }
    
    public List<Car> available_cars_list(DateTime first_day, DateTime last_day)
    {
      return car.Where(lightning => lightning.check_availability(first_day, last_day)).ToList();
    }

    static async Task DoWorkAsync()
    {
      Console.WriteLine("Your changes are being saved...");
      await Task.Delay(2000); // Simulates a 2-second delay
      Console.WriteLine("Changes saved");
    }
    
    static async Task SomeMethodAsync()
    {
      await DoWorkAsync();
    }
  }
  
  
  
  
  
  public class Rental
  {
    [Key]
    public int idC { get; set; } = 1; //id rezervare
    public Car rented_car { get; set; }
    public Buyers.Client client { get; set; }
    public DateTime first_day { get; set; }
    public DateTime last_day { get; set; }
    
    public int final_price { get; set; }
    
    public Rental(){}
    
    public Rental(Car masina, Buyers.Client cli, DateTime prima_zi, DateTime ultima_zi)
    {
      idC++;
      rented_car = masina;
      client = cli;
      first_day = prima_zi;
      last_day = ultima_zi;
    }

    public void calculate_price()
    {
      int days = (last_day - first_day).Days;
      if (days <= 0)
      {
        Console.WriteLine("A car has to be rented for at least one day");
      }
      else
      {
        if (days <= 3)
        {
          final_price = rented_car.quality_class == 1  ? rented_car.pret_zi * days + rented_car.pret_zi * days / 5 : rented_car.pret_zi * days + rented_car.pret_zi * days * 3 / 20;
        }
        else if (days <=7)
        {
          final_price = rented_car.quality_class == 1  ? rented_car.pret_zi * days + rented_car.pret_zi * days * 3 / 20 : rented_car.pret_zi * days + rented_car.pret_zi * days / 20 ;
        }
        else if (days <= 20)
        {
          final_price = rented_car.quality_class == 1  ? rented_car.pret_zi * days + rented_car.pret_zi * days / 10 : rented_car.pret_zi * days + rented_car.pret_zi * days / 20;
        }
        else if (days <= 31)
        {
          final_price = rented_car.pret_zi * days;
        }
        Console.WriteLine("The final price is: {0}", final_price);
      }
    }

    public Reservation set_date()
    {
      DateTime day1, dayn;
      while (true)
      {
        Console.WriteLine("Choose the date when you would like to pick up your car (YYYY-MM-DD): ");
        string? day1str = Console.ReadLine();
        if (day1str != null)
        {
          Console.WriteLine("Choose the date when you would like to return your car (YYYY-MM-DD): ");
          string? daynstr = Console.ReadLine();
          if (daynstr != null)
          {
            DateTime.TryParse(day1str, out day1);
            DateTime.TryParse(daynstr, out dayn);
        
            if ((dayn - day1).Days <= 0 || dayn <= day1)
            {
              Console.WriteLine("Your input is not correct. Please try again\n");
            }
            else
            {
              break;
            }
          }
        }
      }

      Reservation rezervare = new Reservation(day1, dayn);
      return rezervare;
    }

    public void Rent_aCar()
    {
      while (true)
      {
        Reservation rezervare = set_date();
        
        List<Car>? availableCars = Program.Fleet_global.fleet?.available_cars_list(rezervare.day_1, rezervare.day_n);
        if (availableCars != null && availableCars.Count == 0)
        {
          Console.WriteLine("We are sorry, but there is no car available when you need it. Try another period of time");
        }
        else if (availableCars != null)
        {
          Console.WriteLine("Here are the available options for your chosen dates:\n");
          for (int i = 0; i < availableCars.Count; i++)
          {
            var masina = availableCars[i];
            masina.show_details();
          }
          Console.WriteLine("Choose the number of your desired car: ");
          string? input = Console.ReadLine();
          if (input != null && int.TryParse(input, out int result))
          {
            int bucsa = result - 1;
            if (bucsa >= 0 && bucsa < availableCars.Count)
            {
              var masina_selectata = availableCars[bucsa];
              Console.WriteLine("This is the car that you chose");
              masina_selectata.show_details();
              Console.WriteLine("Would you like to confirm your choice?\nPress 1 for yes\nPress 0 for no");

              string? input3 = Console.ReadLine();
              if (input3 != null && int.TryParse(input3, out int choice))
              {
                if (choice == 1)
                {
                  rented_car = masina_selectata;
                  calculate_price();
                  Console.WriteLine($"The price for your choice is: {final_price}");
                }
                else
                {
                  Console.WriteLine("The process was stopped by the user. Please try again later");
                }
              }

              payment_page();
              break;
            }
          }
          else
          {
            Console.WriteLine("Choose a valid number!");
          }
        }
      }
    }


    void payment_page()
    {
      Console.WriteLine("The only available option is to pay with a credit card. ");
      Task.Run(() => PaymentPage()).GetAwaiter().GetResult();
      ;
      credit_card_payment();
      Console.WriteLine("Thank you for your payment! We are waiting for you to come and pick your car");
    }
    
    void credit_card_payment()
    {
      Console.WriteLine("Credit card number: ");
      string? cc_number = Console.ReadLine();
      Task.Run(() => PaymentCheck()).GetAwaiter().GetResult();

      DateTime expDate;
      Console.WriteLine("Expiry date (YYYY-MM-DD)");
      string? expiry_date = Console.ReadLine();
      DateTime.TryParse(expiry_date, out expDate);
        
      Console.WriteLine("CVV/CVC: ");
      string? input4 = Console.ReadLine();
    
      if (input4 != null && int.TryParse(input4, out int cvv))
      {
        Console.WriteLine("\u2713");
      }      
    }
    
    static async Task PaymentCheck()
    {
      Console.WriteLine("We are identifying your bank...");
      await Task.Delay(2000); // Simulates a 2-second delay
      Console.WriteLine("Visa");
    }
    
    static async Task PaymentPage()
    {
      Console.WriteLine("Wait a second! You are being redirected to the payment page...");
      await Task.Delay(2000); 
      Console.WriteLine("Please introduce your credit card info\n");
    }
    
    public async Task call_payment_page()
    {
      await PaymentPage();
    }
  }
}



namespace Buyers
{
  public class Client
  {
    [Key]
    public string id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string phone_number { get; set; }
    public string email { get; set; }

    public List<Rental> history = new List<Rental>();
    
    public Client(){}

    public Client(string name, string name2, string phone, string email2, string id2)
    {
      first_name = name;
      last_name = name2;
      phone_number = phone;
      email = email2;
      id = id2;
    }
  }
}




