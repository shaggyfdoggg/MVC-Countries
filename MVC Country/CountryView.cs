using System;
namespace MVC_Country
{
	public class CountryView
	{
		//Property
		public Country DisplayCountry { get; set; }
		//Constructor
		public CountryView(Country _country)
		{
			DisplayCountry = _country;
		}

		public void Display()
		{
			Console.WriteLine($"Name: {DisplayCountry.Name} ${DisplayCountry.Continent} Flag Colors: ");
			DisplayCountry.Colors.ForEach(c => Console.Write(DisplayCountry.Colors));
		}
	}
}

