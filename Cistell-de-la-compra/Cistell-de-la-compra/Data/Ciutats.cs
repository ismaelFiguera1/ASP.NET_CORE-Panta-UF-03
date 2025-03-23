using Cistell_de_la_compra.Models;

namespace Cistell_de_la_compra.Data
{
    public class Ciutats
    {
        public static List<Ciutat> LlistaCiutats { get; } = new List<Ciutat>
        {
            new Ciutat { id=1, name="Vigo", countrycode="ESP", district="Galicia", population=2052 }
        };
    }
}
