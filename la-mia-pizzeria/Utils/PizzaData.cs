using la_mia_pizzeria.Models;

namespace la_mia_pizzeria.Utils
{
    public static class PizzaData
    {
        private static List<Pizza> ListaPizze;
        public static List<Pizza> GetPizze()
        {
            if (ListaPizze != null)
            {
                return ListaPizze;
            }
        }
    }
}
