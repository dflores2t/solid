namespace cuatroSegregacionRefactory;

public class Fax : IFax
{
  // AHORA SOLO TENEMOS LOS METODOS QUE SON NECESARIOS.

  public void Faxear()
  {
    System.Console.WriteLine("ENVIO UN FAX");
  }

  public void Telefono()
  {
    System.Console.WriteLine("TE MARCO UN TELEFONO");
  }
}