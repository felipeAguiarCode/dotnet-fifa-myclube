namespace fifa_my_club.Models
{
    public class Player
    {

        public Player(){}

        public Player(
                        int id,
                        string name, 
                        int pace, 
                        int shooting, 
                        int passing, 
                        int dribbling, 
                        int defending, 
                        int physical) 
        {
                this.Id = id;
                this.Name = name;
                this.Pace = pace;
                this.Shooting = shooting;
                this.Passing = passing;
                this.Dribbling = dribbling;
                this.Defending = defending;
                this.Physical = physical;
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pace { get; set; }
        public int Shooting { get; set; }
        public int Passing { get; set; }
        public int Dribbling { get; set; }
        public int Defending { get; set; }
        public int Physical { get; set; }

        public int Average { get; set; }


    }
}