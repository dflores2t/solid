namespace liskov;

public class Radio : Noticiero
{
  public Radio(string pMensaje) : base(pMensaje)
  {

  }
  //PARA LA PRIMERA PRUEBA / CREANDO UNA NUEVA VERSION DEL METODO MUESTRA DE LA CLASE PADRE
  // public new void Muestra(){
  //   System.Console.WriteLine("DESDE EL RADIO: {0}",mensaje);
  // }

  ///PROBAMOS EL MISMO CODIGO CON LA SEGUNDA VERSION VIRTUAL Y OVERRIDE

  //PARA SEGUNDA PRUEBA / COMENTAR PRIMER METODO
  public override void Muestra()
  {
      System.Console.WriteLine("DESDE EL RADIO: {0} ", mensaje);
  }
  //se pierde totalment la funcionalidad de la clase padre........al usar override.
}