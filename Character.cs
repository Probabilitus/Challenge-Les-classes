namespace Les_classes
{
    public class Character
    {
        public string Name { get; set; }
        public int PointsOfView { get; set; }
        public int AttackForce { get; set; }
        public int DefenseForce { get; set; }

        public Character(int pointsOFView)
        {
            PointsOfView = pointsOFView;
        }

        public bool IsAlive()
        {
            Console.WriteLine(" Is view");
            return true;
        }
        
         public void Attack(Character otherCharacter) 
         { 
            PointsOfView = (PointsOfView) - (otherCharacter.AttackForce - DefenseForce);
            if (PointsOfView <= 0 || otherCharacter.PointsOfView <= 0)
            {
                Console.WriteLine($"{Name} is died");
            }
            else
            {
                Console.WriteLine($"{Name} is view, pointsOFView number : {PointsOfView}");
            }
            
         }
    }
}
