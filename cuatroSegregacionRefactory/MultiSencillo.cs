namespace cuatroSegregacionRefactory;

public class MultiSencillo : IMultiBasico
{
  //SOLO IMPLEMENTA LOS METOSOD QUE SE NECESITAN
  public void Imprimir()
  {
    System.Console.WriteLine("IMPRIMO UN DOCUMENTO");
  }
  public void Escanear()
  {
    System.Console.WriteLine("ESCANEO UNA FOTOGRAFIA");
  }
}