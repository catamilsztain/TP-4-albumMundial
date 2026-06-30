public class Figurita{
    public int num {get;set;}

    public void GetJugadorRnd(){
        Random random = new Random();
        int numero = random.Next(1,30);
        num = numero;
    }

    
}