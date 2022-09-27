namespace cuatroSegregacion;

public class MultiSencillo : IMultifuncional
{
  //NECESITAMOS ESTOS METODOS
  public void Imprimir()
  {
    System.Console.WriteLine("IMPRIMO UN DOCUMENTO");
  }
  public void Escanear()
  {
    System.Console.WriteLine("ESCANEO UNA FOTOGRAFIA");
  }

  //ESTOS METODO NO LO NECESITAMOS
  //SI NO COLOCAMOS LA IMPLEMENTACION HAY QUE PONER EXCEPION.
  public void Faxear()
  {
    throw new NotImplementedException();
  }


  public void Telefono()
  {
    throw new NotImplementedException();
  }
}