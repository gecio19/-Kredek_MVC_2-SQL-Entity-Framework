using MichalNajwerLab3.Models;

namespace MichalNajwerLab3.Repositories
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> GetAll();

        Pizza? GetPizza(int id);

        void Edit_des(int id, string des);
    }
}
