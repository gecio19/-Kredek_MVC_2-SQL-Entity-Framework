using MichalNajwerLab3.Models;

namespace MichalNajwerLab3.Repositories
{
    public class PizzaRepository: IPizzaRepository
    {
        private DatabaseContext context;

        public PizzaRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public void Edit_des(int id, string des)
        {
            context.Pizzas.FirstOrDefault(x => x.Id == id).Description = des;
            context.SaveChanges();
        }


        public IEnumerable<Pizza> GetAll()
        {
            return context.Pizzas.ToList();
        }

        public Pizza? GetPizza(int id)
        {
            return context.Pizzas.FirstOrDefault(pizza => pizza.Id == id);
        }
    }
}
