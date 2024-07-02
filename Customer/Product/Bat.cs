

namespace Product
{
    public class Bat
    { 
        public int Id { get; set; }
        public string Name { get; set; }

        public Bat(int id, string Name)
        {
            this.Id = id;
            this.Name = Name;
                
        }
        public int getId() { return this.Id; }
        public string getName() { return this.Name; }

        public void setId(int id) { this.Id = id; }
        public void setName(string Name) { this.Name = Name; }

        public override string ToString()
        {
            return Id + ":" + Name;
        }


    }
}
