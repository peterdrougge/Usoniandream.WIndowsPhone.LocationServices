using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace Usoniandream.WindowsPhone.LocationServices.Models.JSON.Nokia.Place
{
    public class AlternativeName
    {
        public string name { get; set; }
        public string language { get; set; }
    }

    public class Address
    {
        public string text { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string postalCode { get; set; }
    }

    public class Location
    {
        public List<double> position { get; set; }
        public Address address { get; set; }
        public List<double> bbox { get; set; }
    }

    public class Supplier
    {
        public string id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string href { get; set; }
    }

    public class Phone
    {
        public string value { get; set; }
        public string label { get; set; }
    }

    public class Website
    {
        public string value { get; set; }
        public string label { get; set; }
    }

    public class Contacts
    {
        public List<Phone> phone { get; set; }
        public List<Website> website { get; set; }
    }

    public class Category
    {
        public string title { get; set; }
        public string href { get; set; }
        public string type { get; set; }
    }

    public class Ratings
    {
        public double average { get; set; }
        public int count { get; set; }
    }

    public class Create
    {
        public string title { get; set; }
        public string href { get; set; }
        public string type { get; set; }
        public string method { get; set; }
    }

    public class Dimensions
    {
        public string Width { get; set; }
        public string Height { get; set; }
    }

    public class Supplier2
    {
        public string title { get; set; }
        public string href { get; set; }
        public string type { get; set; }
        public string icon { get; set; }
    }

    public class Item
    {
        public string src { get; set; }
        public Dimensions dimensions { get; set; }
        public string attribution { get; set; }
        public Supplier2 supplier { get; set; }
    }

    public class Images
    {
        public int available { get; set; }
        public string next { get; set; }
        public Create create { get; set; }
        public List<Item> items { get; set; }
    }

    public class Supplier3
    {
        public string title { get; set; }
        public string href { get; set; }
        public string type { get; set; }
    }

    public class Item2
    {
        public string description { get; set; }
        public string attribution { get; set; }
        public string language { get; set; }
        public Supplier3 supplier { get; set; }
    }

    public class Editorials
    {
        public int available { get; set; }
        public List<Item2> items { get; set; }
    }

    public class Create2
    {
        public string title { get; set; }
        public string href { get; set; }
        public string type { get; set; }
        public string method { get; set; }
    }

    public class User
    {
        public string name { get; set; }
    }

    public class Supplier4
    {
        public string title { get; set; }
        public string href { get; set; }
        public string type { get; set; }
        public string icon { get; set; }
    }

    public class Via
    {
        public string href { get; set; }
        public string type { get; set; }
    }

    public class Item3
    {
        public string id { get; set; }
        public string date { get; set; }
        public string title { get; set; }
        public int rating { get; set; }
        public string description { get; set; }
        public User user { get; set; }
        public string attribution { get; set; }
        public string language { get; set; }
        public Supplier4 supplier { get; set; }
        public Via via { get; set; }
    }

    public class Reviews
    {
        public int available { get; set; }
        public string next { get; set; }
        public Create2 create { get; set; }
        public List<Item3> items { get; set; }
    }

    public class Media
    {
        public Images images { get; set; }
        public Editorials editorials { get; set; }
        public Reviews reviews { get; set; }
    }

    public class Payment
    {
        public string text { get; set; }
        public string label { get; set; }
    }

    public class OpeningHours
    {
        public string text { get; set; }
        public string label { get; set; }
    }

    public class Extended
    {
        public Payment payment { get; set; }
        public OpeningHours openingHours { get; set; }
    }

    public class Recommended
    {
        public string title { get; set; }
        public string href { get; set; }
        public string type { get; set; }
    }

    public class Related
    {
        public Recommended recommended { get; set; }
    }

    public class RootObject
    {
        public string name { get; set; }
        public string placeId { get; set; }
        public string view { get; set; }
        public List<AlternativeName> alternativeNames { get; set; }
        public Location location { get; set; }
        public string attribution { get; set; }
        public Supplier supplier { get; set; }
        public Contacts contacts { get; set; }
        public List<Category> categories { get; set; }
        public string icon { get; set; }
        public Ratings ratings { get; set; }
        public Media media { get; set; }
        public Extended extended { get; set; }
        public Related related { get; set; }
        public bool? sponsored { get; set; }
    }
}