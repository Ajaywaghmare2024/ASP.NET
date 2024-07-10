using CricketWebMVC.Models;

namespace CricketWebMVC.Services
{
    public interface ICricketerService
    {
        List<Cricketer> GetAllCricketer();

        Cricketer GetById(int id);

        void AddCricketer(Cricketer cricketer);

        void UpdateCricketer(Cricketer cricketer);

        void DeleteCricketer(int id);

        List<Cricketer> SearchByRole(string role);

        List<Cricketer> SortByRole();


    }
}
