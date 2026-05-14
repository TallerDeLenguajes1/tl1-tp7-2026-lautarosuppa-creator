public class Calculadora
{
    private double memoria;
    public double Memoria {get => memoria;}
    public void Sumar(double termino){
        memoria += termino;
    }
    public void Restar(double termino){
        memoria -= termino;
    }
    public void Multiplicar(double termino){}
    public void Dividir(double termino){}
    public void Limpiar(){
        memoria = 0;
    }
}