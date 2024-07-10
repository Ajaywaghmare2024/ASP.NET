using CricketWebApp.Entitties;

namespace CricketWebApp.Services
{
    public interface ICricketerService
    {
        List<Cricketer> GetAll();

        Cricketer GetById(int id);

        void AddCricketer(Cricketer cricketer);

        void UpdateCricketer(UpdateModel cricketer);

        void DeleteCricketer(int id);

        List<Cricketer> SortByRole();

        List<Cricketer> SearchByRole(string role);  
    }
}
