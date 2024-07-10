using CricketWebMVC.Models;
using CricketWebMVC.Repositories;

namespace CricketWebMVC.Services
{
    public class CricketerService : ICricketerService
    {    private readonly DbCricketerContext _cricketerContext =new DbCricketerContext();
        public void AddCricketer(Cricketer cricketer)
        {
            using (var context = new DbCricketerContext())
            {
                context.cricketers.Add(cricketer);
                context.SaveChanges();  
            }


        }

        public void DeleteCricketer(int id)
        {
            using (var context = new DbCricketerContext())
            {
                var crickter=context.cricketers.Find(id);
                if (crickter != null)
                {
                    context.cricketers.Remove(crickter);
                    context.SaveChanges();
                }
            }
        }

        public List<Cricketer> GetAllCricketer()
        {
            return _cricketerContext.cricketers.ToList();
        }

        public Cricketer GetById(int id)
        {
            using (var context=new DbCricketerContext())
            {
                var cricks=context.cricketers.Find(id);
                return cricks;
            }
          
        }

        public List<Cricketer> SearchByRole(string role)
        {
            using (var context = new DbCricketerContext())
            {
                var cricket=context.cricketers.Where(c=>c.Role==role).ToList();
                return cricket.ToList();
            }
        }

        public List<Cricketer> SortByRole()
        {
            using (var context=new DbCricketerContext())
            {
                var crick = context.cricketers.OrderBy(c => c.Role == "Batsman" ? 0 : 1).ToList();
                return crick;
            }
        }

        public void UpdateCricketer(Cricketer cricketer)
        {
            using (var context = new DbCricketerContext())
            {
                var criks = context.cricketers.Find(cricketer.Id);
                if(criks != null)
                {
                 criks.Id = cricketer.Id;
                    criks.Ranker = cricketer.Ranker;
                   
                    criks.Age = cricketer.Age;



                    context.cricketers.Update(criks);
                    context.SaveChanges();
                }


              
            }
        }
    }
}
