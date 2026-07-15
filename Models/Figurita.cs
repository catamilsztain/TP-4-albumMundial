public class Figurita{
    public Jugadores jugador {get;set;}
    public int contadorRepe {get;set;}

    public int ObtenerFigu(){
        Random random = new Random();
        int numero = random.Next(1,21);
        this.figu = numero;
        BD.BuscarJugador(numero);
        return this.figu;
    }

    

    public bool esPegada(){
        if(contadorRepe > 0){
            return true;
        }
        else{
            return false;
        }
    }

    
}