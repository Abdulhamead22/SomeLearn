public class playercharactar :Charactar
{
    public playercharactar(string name,int health){

    }
    public void Heal(int amount){
            health+=amount;
            Debug.Log("The New Health: "+ health);
        }
}