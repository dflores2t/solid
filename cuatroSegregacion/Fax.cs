namespace cuatroSegregacion;

public class Fax : IMultifuncional
{
  //nos vemos forzados a implementar estos metodos
  public void Imprimir()
  {
    System.Console.WriteLine("NO TENGO ESTE SERVICIO");
  }
  public void Escanear()
  {
    System.Console.WriteLine("NO TENGO ESTE SERVICIO");
  }

  // ESTOS METODOS SI LOS NECESITAMOS

  public void Faxear()
  {
    System.Console.WriteLine("ENVIO UN FAX");
  }

  public void Telefono()
  {
    System.Console.WriteLine("TE MARCO UN TELEFONO");
  }
}