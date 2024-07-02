using Product;
namespace Player

{
    public class Player : Bat
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public Player(int Id, string name, string desc) 
        {
            this.id = Id;

            this.name = name;
            this.description = desc;

        }
        public override string ToString()
        {
            return base.ToString()+ " "+id+" "+name+" "+description;
        }

    }
}
