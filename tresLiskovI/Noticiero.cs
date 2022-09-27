namespace liskov;

public class Noticiero
{
  protected string mensaje;

  public Noticiero(string pMensaje)
  {
    mensaje = pMensaje;
  }
  //PARA PRIMERA PRUEBA
  // public void Muestra(){
  //   System.Console.WriteLine("DESDE EL NOTICIERO:{0}", mensaje);
  // }

  //SEGUNDA PRUEBA / COMENTAR PRIMER METODO 
  public virtual void Muestra()
  {
    System.Console.WriteLine("DESDE EL NOTICIERO: {0} ", mensaje);
  }

}