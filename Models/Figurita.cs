public class Figurita{
    public int figu {get;set;}
    public int contadorRepe {get;set;}

    public int ObtenerFigu(){
        Random random = new Random();
        int numero = random.Next(1,21);
        this.figu = numero;
        BD.Pegar(numero);
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