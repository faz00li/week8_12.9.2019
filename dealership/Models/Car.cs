


using System;

namespace Models
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;

    // public string MakeModel
    // {
    //   get
    //   {
    //     return _makeModel;
    //   }
    //   get
    //   {
    //     return "That's a big secret. You'll have to visit Lonny's to find out about our special deals!";
    //   }
    //   set
    //   {
    //     _makeModel = value;
    //   }
    // }
    //*****implemented w/ public properties*****

    public string MakeModel {get; set;}
    public int Price {get; set;}
    public int Miles {get; set;}

    public Car()
    {

    }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
        Price = price;
        Miles = miles;
    }

    // public Car(string makeModel, int price, int miles)
    // {
    //   _makeModel = makeModel;
    //   _price = price;
    //   _miles = miles;
    // }

    // public static string MakeSound(string sound)
    // {
    //   return "Our cars sound like " + sound;
    // }
    //
    // //setters
    // public string GetMakeModel()
    // {
    //   return _makeModel;
    // }
    // public int GetPrice()
    // {
    //   return _price;
    // }
    // public int GetMiles()
    // {
    //   return _miles;
    // }
    //
    // //getters
    // public void SetPrice(int price)
    // {
    //   _price = price;
    // }
    //
    // public bool WorthBuying(int maxPrice)
    // {
    //   return (_price < maxPrice);
    // }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    //setters
    public string GetMakeModel()
    {
      return MakeModel;
    }
    public int GetPrice()
    {
      return Price;
    }
    public int GetMiles()
    {
      return Miles;
    }

    //getters
    public void SetPrice(int price)
    {
      Price = price;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }
  }
}
