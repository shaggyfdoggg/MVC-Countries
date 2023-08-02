using System;
namespace MVC_Country
{
	public class CountryController
	{
		public List<Country> CountryDB = new List<Country>()
		{
			new Country("United States of America", "North America", "red", "white", "blue"),
			new Country("Canada", "North America","red", "white"),
			new Country("Mexico", "North America", "red", "white", "green"),
			new Country("Brazil", "South America", "green", "yellow", "blue"),
            new Country("Italy", "Europe", "red", "white", "green"),
            new Country("Czech Republic", "Europe", "red", "white", "blue"),
            new Country("United Kingdom", "North America", "red", "white", "blue"),
            new Country("Japan", "Asia","red", "white"),
			new Country("Tunisia", "Africa", "red", "white")
        };

		public void CountryAction(Country c)
		{
			CountryView listView = new CountryView(c);
			listView.Display();
		}

		public void WelcomeAction()
		{
			CountryListView listView = new CountryListView(CountryDB);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
            listView.Display();
			//Country input = Country.Parse(Console.ReadLine());
			//CountryAction(input);
			
		}
	}
}

