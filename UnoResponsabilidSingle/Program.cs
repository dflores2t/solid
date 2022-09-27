using static System.Console;
namespace SingleResponsability;


class Program{
  static void Main(string[] args){
    // CEmpleado empleado = new CEmpleado("Ivonne","programador",23,18000);
    // WriteLine(empleado);
    // empleado.PagarImpuesto();

    //APLICANDO SINGLE
    CEmpleado empleado = new CEmpleado("DANIEL", "PROGRAMADOR", 23, 18000);
    WriteLine(empleado);
    WriteLine(CHacienda.CalcularImpuesto(empleado));
    CHacienda.PagarImpuesto(empleado); //recordar metodo statico, se utiliza si instanciar un nuevo objeto.
  }
}