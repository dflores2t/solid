namespace cuatroSegregacionRefactory;

public class MultiAvanzado : IMultiCompleto
{
  public void Imprimir()
  {
    System.Console.WriteLine("IMPRIMO TU REPORTE");
  }
  public void Escanear()
  {
    System.Console.WriteLine("ESTOY ESCANEANDO UN DOCUMENTO");
  }
  public void Telefono()
  {
    System.Console.WriteLine("TE MARCO A UN TELEFON");
  }
  public void Faxear()
  {
    System.Console.WriteLine("ENVIO UN FAX");
  }
}