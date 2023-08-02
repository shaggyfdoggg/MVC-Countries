using System;
namespace MVC_Country
{
	public class CountryListView
	{
		//Property
		public List<Country> Countries { get; set; }
		//Constructor
		public CountryListView(List<Country> _countries)
		{
			Countries = _countries;
		}
		//methods
		public void Display()
		{
			for (int i = 0; i < Countries.Count; i++)
			{
				Console.WriteLine($"{i}. {Countries[i].Name}");
			}
		}
	}
}

