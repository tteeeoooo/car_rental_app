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
using MainP;
using Car_Fleet = CarRental.Car_Fleet;
// using Console. = System.Diagnostics.Debug;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CarRental
{
  public class Reservation
  {
    [Key] public static int id { get; set; } = 1;
    public DateTime day_1 { get; set; }
    public DateTime day_n { get; set; }

    public Reservation(DateTime start, DateTime end)
    {
      day_1 = start;
      day_n = end;
    }
  }
  public class Car
  {
    [Key]
    public string id { get; set; }
    public string nr_inmatriculare { get; set; }

    public string firma { get; set; }
    public string model { get; set; }
    public string culoare { get; set; }
    public int an_fabricatie { get; set; }
    public int pret_zi { get; set; }
    public int km { get; set; }
    // public bool is_available { get; set; }

    public bool is_for_sale { get; set; }
    public int pret_vanzare { get; set; }
    
    public int quality_class { get; set; }
    
    public List<Reservation> reservations { get; set; }

    public Car(string id2 = "ABC123", string nr_inmatriculare2 = "B 01 ZZZ", string firma2 = "Porsche",
      string model2 = "911", string culoare2 = "frozenberrymetallic",
      int an2 = 2024, int pret_zi2 = 1000, int km2 = 10, bool valabilitate = true, bool is_for_sale2 = false,
      int pret_vanzare2 = 0, int qualityClass2 = 1, List<Reservation> rezervari = null)
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
      foreach (var reservation in reservations)
      {
        if ((first_day < reservation.day_n) && (last_day > reservation.day_1))
        {
          return false;
        }
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

    public List<Car> car { get; set; }
    
    private Car_Fleet()
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

        DoWorkAsync();
      }
      else
      {
        Console.WriteLine("Failed action. Please try again later");
      }
    }

    public Car find_by_id(string id)
    {
      return car.FirstOrDefault(c => c.id == id);
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
  }
  
  
  
  
  
  public class Rental
  {
    [Key]
    private int idC = 1; //id rezervare
    public Car rented_car { get; set; }
    public Buyers.Client client { get; set; }
    public DateTime first_day { get; set; }
    public DateTime last_day { get; set; }
    
    public int final_price { get; set; }

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
        string day1str = Console.ReadLine();
        Console.WriteLine("Choose the date when you would like to return your car (YYYY-MM-DD): ");
        string daynstr = Console.ReadLine();
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

      Reservation rezervare = new Reservation(day1, dayn);
      return rezervare;
    }

    public void Rent_aCar()
    {
      while (true)
      {
        Reservation rezervare = set_date();
        var availableCars = Program.Fleet_global.fleet.available_cars_list(rezervare.day_1, rezervare.day_n);
        if (availableCars.Count == 0)
        {
          Console.WriteLine("We are sorry, but there is no car available when you need it. Try another period of time");
        }
        else
        {
          Console.WriteLine("Here are the available options for your chosen dates:\n");
          for (int i = 0; i < availableCars.Count; i++)
          {
            var masina = availableCars[i];
            masina.show_details();
          }
          Console.WriteLine("Choose the number of your desired car: ");
          int bucsa = int.Parse(Console.ReadLine()) - 1;
          
          if (bucsa >= 0 && bucsa < availableCars.Count)
          {
            var masina_selectata = availableCars[bucsa];
            Console.WriteLine("This is the car that you chose");
            masina_selectata.show_details();
            Console.WriteLine("Would you like to confirm your choice?\nPress 1 for yes\nPress 0 for no");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
              rented_car = masina_selectata;
              calculate_price();
              Console.WriteLine($"The price for your choice is: {final_price}");
            }

            payment_page();
            break;
          }
          else
          {
            Console.WriteLine("Selecție invalidă.");
          }
        }
      }
    }


    void payment_page()
    {
      Console.WriteLine("The only available option is to pay with a credit card. ");
      PaymentPage();
      credit_card_payment();
      Console.WriteLine("Thank you for your payment! We are waiting for you to come and pick your car");
    }
    
    void credit_card_payment()
    {
      Console.WriteLine("Credit card number: ");
      string cc_number = Console.ReadLine();
      PaymentCheck();

      DateTime expDate;
      Console.WriteLine("Expiry date (YYYY-MM-DD)");
      string expiry_date = Console.ReadLine();
      DateTime.TryParse(expiry_date, out expDate);
        
      Console.WriteLine("CVV/CVC: ");
      int cvv = int.Parse(Console.ReadLine());
    }
    
    static async Task PaymentCheck()
    {
      Console.WriteLine("We are identifying your bak...");
      await Task.Delay(2000); // Simulates a 2-second delay
      Console.WriteLine("Visa");
    }
    
    static async Task PaymentPage()
    {
      Console.WriteLine("Wait a second! You are being redirected to the payment page...");
      await Task.Delay(2000); 
      Console.WriteLine("Please introduce your credit card info\n");
    }
  }
}

namespace Buyers
{
  public class Client
  {
    [Key] public static int client;
    public string first_name;
    public string last_name;
    public string phone_number;
    public string email;
    public string id;

    public List<CarRental.Rental> history = new List<Rental>();

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


namespace MainP
{
  class Program
  {
    public static class Fleet_global
    {
      public static Car_Fleet fleet { get; set; }
    }
    static void Main()
    {
      Console.WriteLine("Hello! Please select what would you like to do:\nPress 1 to look through our cars\nPress 2 to sign in\nPress 3 to create an account");
      int input = int.Parse(Console.ReadLine());

      if (input == 1)
      {
        
      }
    }
  }
}

