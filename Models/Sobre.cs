public class Sobre
{
    Jugador[] paquete = new Jugador[6];


    public void AbrirSobre(){
        Random random = new Random();
        for(int i = 0; i<7; i++){
            int id = random.Next(1,961);
            paquete[i] = dicJugador[id];
        }

        return 
    }
    
}