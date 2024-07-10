using CricketWebApp.Entitties;
using CricketWebApp.Repositories;

namespace CricketWebApp.Services
{
    public class CricketerService : ICricketerService

    {     private readonly DbCricketerContext _context=new DbCricketerContext();
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
                var crick = context.cricketers.Find(id);
                if (crick != null)
                {
                    context.cricketers.Remove(crick);
                    context.SaveChanges();
                }
            }



        }

        public List<Cricketer> GetAll()
        {
           return _context.cricketers.ToList();

        }

        public Cricketer GetById(int id)
        {
            using (var context = new DbCricketerContext())
            {
                var cricketer=context.cricketers.Find(id);
                return cricketer;
            }
        }

        public List<Cricketer> SearchByRole(string role)
        {
            using (var context = new DbCricketerContext())
            {
                var crickter=context.cricketers.Where(c=>c.Role==role).ToList();
                return crickter;
            }
        }

        public List<Cricketer> SortByRole()
        {
            using (var context = new DbCricketerContext())
            {
                var cricketer=context.cricketers.OrderBy(c=>c.Role=="Batsman"?0:1).ToList();
                return cricketer.ToList();
            }


        }

        public void UpdateCricketer(UpdateModel cricketer)
        {
            using (var context = new DbCricketerContext())
            {
                var crick=context.cricketers.Find(cricketer.Id);
                if (crick != null)
                {
                    crick.Id = cricketer.Id;

                    crick.Age = cricketer.Age;

                    crick.Role = cricketer.Role;    

                    context.cricketers.Update(crick);

                    context.SaveChanges();


                }
            }
        }
    }
}
