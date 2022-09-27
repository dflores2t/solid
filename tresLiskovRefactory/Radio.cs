namespace liskovRefactory;

public class Radio : Principal
{
  public Radio(string pMensaje) : base(pMensaje)
  {

  }
  public override void Muestra()
  {
    System.Console.WriteLine("DESDE EL RADIO: {0} ", mensaje);
  }
}