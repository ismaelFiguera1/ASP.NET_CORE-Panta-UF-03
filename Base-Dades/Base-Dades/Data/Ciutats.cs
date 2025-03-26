using Base_Dades.Models;

namespace Base_Dades.Data
{
    public class Ciutats
    {
        public static List<Ciutat> LlistaCiutats { get; } = new List<Ciutat>
        {
            new Ciutat { id=1, name="Vigo", countrycode="ESP", district="Galicia", population=283670 },
            new Ciutat { id=2, name="Sydney", countrycode="AUS", district="New South Wales", population=3276207 },
            new Ciutat { id=3, name="Cairo", countrycode="EGY", district="Kairo", population=6789479 },
            new Ciutat { id=4, name="Angeles", countrycode="PHL", district="Central Luzon", population=263971 },
            new Ciutat { id=5, name="Danao", countrycode="PHL", district="Central Visayas", population=98781 },
            new Ciutat { id=6, name="São Vicente", countrycode="BRA", district="São Paulo", population=286848 }
        };
    }
}
