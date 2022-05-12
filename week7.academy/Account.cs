using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7.academy
{
    public class Account
    {
          public int id { get; set; }
            public string Name { get; set; }
            public string Gender{ get; set; }
            public decimal Amount { get; set; }
            public string Yearofspecification { get; set; }

            public static List<Account> GetAccounts()
            {
                return new List<Account>
                {
                    new Account { id = 2, Name = "Amar", Gender = "F", Amount = 400000, Yearofspecification = "2 years"},
                    new Account { id = 6, Name = "Joe", Gender = "M", Amount = 40000, Yearofspecification = "2 months"},
                    new Account { id = 8, Name = "Tola", Gender = "F", Amount = 800000, Yearofspecification = "5 days"},
                    new Account { id = 10, Name = "Jude", Gender = "M", Amount = 500000, Yearofspecification = "6 years"},
                    new Account { id = 12, Name = "Amir", Gender = "F", Amount = 1000000, Yearofspecification = "1 years"},
                    new Account { id = 14, Name = "Sam", Gender = "F", Amount = 600000, Yearofspecification = "1 years"},
                    new Account { id = 16, Name = "Joy", Gender = "F", Amount = 100000, Yearofspecification = "3 years"},
                    new Account { id = 18, Name = "Ola", Gender = "M", Amount = 20000, Yearofspecification = "4 months"}
                };

            }

    }
        public class week
        {
        public string Days { get; set; }

             public static List<week> GetWeeks()
             {
               return new List<week>
               {
                    new week {Days = "SUNDAY"},
                    new week {Days = "MONDAY"},
                    new week {Days = "TUESDAY"},
                    new week {Days = "WEDNESDAY"},
                    new week {Days = "THURSDAY"},
                    new week {Days = "FRIDAY"},
                    new week {Days = "SATURDAY"}
               };
             }
        }
    public class year
    {
        public string Months { get; set; }

        public static List<year> GetYears()
        {
            return new List<year>
            {
                new year {Months = "JANUARY"},
                new year {Months = "FEB"},
                new year {Months = "MARCH"},
                new year {Months = "APRIL"},
                new year {Months = "MAY"},
                new year {Months = "JUNE"},
                new year {Months = "JULY"},
                new year {Months = "AUGUST"},
                new year {Months = "SEPTEMBER"},
                new year {Months = "OCTOBER"},
                new year {Months = "NOVEMBER"},
                new year {Months = "DECEMBER"},

            };
        }
    }
}
