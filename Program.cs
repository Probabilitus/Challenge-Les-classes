namespace Les_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character(4);
            character1.Name = "toto";
            character1.AttackForce = 3;
            character1.DefenseForce = 2;
            
            Character character2 = new Character(6);
            character2.Name = "lulu";
            character2.AttackForce = 5;
            character2.DefenseForce = 3;

            character1.Attack(character2);
            character2.Attack(character1);
            character1.Attack(character2);
        }
    }
}
