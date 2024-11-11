public class Enemy : Character
{
    public Enemy(string name, int health) 
    {
        
    }

    public void Attack(Character character, int attacks)
    {
        character.Health -= attacks;
        Debug.Log("The New Health: "+ character.Health);
    }
}
