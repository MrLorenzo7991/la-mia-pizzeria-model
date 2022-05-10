namespace la_mia_pizzeria.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Ingredienti { get; set; } 

        public Pizza()
        {

        }

        public Pizza(int id, string name, string desctiption, List<string> ingredienti)
        {
            this.Id=id;
            this.Name=name;
            this.Description=desctiption;
            this.Ingredienti = ingredienti;
        }
    }
}
