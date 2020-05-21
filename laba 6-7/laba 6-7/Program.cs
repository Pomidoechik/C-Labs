using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6_7
{
  class Program
  {
    

    static void Main(string[] args)
    {
      List<User> getUsersFromTheSCity()
      {
        using (DataStore db = new DataStore())
        {
          return db.Users.Where(user => user.city == "S").ToList();
        }
      }

      void sortByName()
      {

        using (DataStore db = new DataStore())
        {

          List<User> sortedUsers = db.Users.OrderBy(user => user.name).ToList();
        }


      }

      List<User> users = new List<User> { new User("Tom", "099-101-200", "N"), new User("John", "098-103-222", "N"), new User("Bob", "097-200-312", "S"), new User("Jerry", "001-221-332", "L") };
      List<Market> markets = new List<Market> { new Market("QQQ", "N"), new Market("QSQ", "N"), new Market("SGD", "S"), new Market("KLS", "L") };

      using (DataStore db = new DataStore())
      {
        users.ForEach(user =>
        {
          db.Users.Add(user);
        });

        markets.ForEach(market =>
        {
          db.Markets.Add(market);
        });
      }

      User userTom;

      using (DataStore db = new DataStore())
      {
        userTom = db.Users.Where(user => user.name == "Tom").FirstOrDefault();
      }

      var groupedStudents = users.GroupBy(user => user.city);

      using (DataStore db = new DataStore())
      {
        var result = db.Users.Join(db.Markets, user => user.city, market => market.city,
          (user, market) => new { city = market.city, usersName = user.name, marketsName = market.name }
        );
      }


      List<User> newUsers = new List<User> { new User("Tom", "099-101-200", "N"), new User("John", "098-103-222", "N"), new User("Sara", "032-112-221", "S"), new User("Harry", "021-121-532", "N") };

      var exceptResult = users.Except(newUsers); // різниця
      var intersectResult = users.Intersect(newUsers); // перетин
      var unionResult = users.Union(newUsers).Distinct(); ; //об'єднання з видаленням дублікатів

      var userFromSCity = getUsersFromTheSCity();

      string superLongName= users.Aggregate(string.Empty, (res, user) =>
       res + user.name
      );

      Console.WriteLine(superLongName);

      int numberMarketInSCity = markets.Count(market => market.city == "S");

      int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

      int numbersSum = numbers.Sum();

      int numbersMin = numbers.Min();
      int numbersMax = numbers.Max();
      double numbersAverage = numbers.Average();



      Console.Read();

    }
  }
}
