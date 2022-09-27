namespace liskovRefactory;

public class Noticiero : Principal
{
  protected string mensaje;

  public Noticiero(string pMensaje) : base(pMensaje)
  {
  
  }
  public override void Muestra()
  {
    System.Console.WriteLine("DESDE EL NOTICIERO: {0} ", mensaje);
  }

}