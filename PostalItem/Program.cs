using System;

public class PostalItem
{
    public int PostalCode { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Building { get; set; }
    public string Apartment { get; set; }
    public string Message { get; set; }

    public PostalItem(int postalCode, string city, string street, string house, string building, string apartment, string message)
    {
        PostalCode = postalCode;
        City = city;
        Street = street;
        House = house;
        Building = building;
        Apartment = apartment;
        Message = message;
    }

    public string GetAddress()
    {
        return $"Индекс: {PostalCode}, Город: {City}, Улица: {Street}, Дом: {House}, Корпус: {Building}, Квартира: {Apartment}";
    }

    public override string ToString()
    {
        return $"Адрес: {GetAddress()}, Сообщение: {Message}";
    }

    public static void Main(string[] args)
    {
        PostalItem letter = new PostalItem(123456, "Москва", "Тверская", "10", "1", "25", "Привет, это письмо!");
        Console.WriteLine(letter.GetAddress());
        Console.WriteLine(letter);
    }
}