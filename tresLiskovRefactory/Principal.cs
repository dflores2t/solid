namespace liskovRefactory;
/// <summary>
/// se crea esta clase con su metodo abstracto para que pueda ser implementado en las demas clases.
/// </summary>
public abstract class Principal
{
  protected string mensaje;

  public Principal(string pMensaje)
  {
    mensaje = pMensaje;
  }

  //LO CREAMOS COMO METODO ABSTRACTO PARA QUE CADA VERSION LO IMPLEMENTE
  public abstract void Muestra();
}