public class Figurita{
    public int figu = {get;set;}
    private int contadorRepe = 0;

    public int ObtenerFigu(){
        Random random = new Random();
        int numero = random.Next(1,30);
        this.figu = numero;
        contadorRepe = contadorRepe + 1;
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

    public void PegarFigu(){
        
    }
    
}