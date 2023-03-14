using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject
{
    public class DataViewModel
    {
        public List<TabModel> Data { get; set; }
        public DataViewModel() {
            Data = new List<TabModel>()
            {
                new TabModel() {Name = "India", Description = "India, officially the Republic of India, is a country in South Asia. It is the seventh-largest country by area, the second-most populous country, and the most populous democracy in the world."},
                new TabModel() { Name ="Germany",Description = "Germany officially the Federal Republic of Germany is a country in Central Europe. It is the second-most populous country in Europe after Russia, and the most populous member state of the European Union."},
                new TabModel() { Name = "France",Description = "France officially the French Republic (French: Republique francaise is a country located primarily in Western Europe. It also includes overseas regions and territories in the Americas and the Atlantic, Pacific and Indian Oceans, giving it one of the largest discontiguous exclusive economic zones in the world."},
                new TabModel() { Name = "Australia", Description = "Australia, officially the Commonwealth of Australia, is a sovereign country comprising the mainland of the Australian continent, the island of Tasmania, and numerous smaller islands. With an area of 7,617,930 square kilometres (2,941,300 sq mi), Australia is the largest country by area in Oceania and the world's sixth-largest country."},
            };
        }
    }
}
