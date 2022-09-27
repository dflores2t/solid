namespace cuatroSegregacion;

public class Program {
    static void Main(string[] args){

    MultiAvanzado avanzado = new MultiAvanzado();
    System.Console.WriteLine("------AVANZADO------------");
    avanzado.Escanear();
    avanzado.Faxear();
    avanzado.Imprimir();
    avanzado.Telefono();

    System.Console.WriteLine("-----------------------------");
    System.Console.WriteLine("-------mi fax");
    Fax miFax = new Fax();
    miFax.Telefono();
    miFax.Faxear();
    miFax.Imprimir();
    System.Console.WriteLine("--------------------");

    System.Console.WriteLine("----------MULTI SENCILLO-----------");
    MultiSencillo sencilla = new MultiSencillo();
    sencilla.Escanear();
    sencilla.Imprimir();
    sencilla.Telefono(); ///LANZARA LA EXCEPCIO

  }
}