namespace liskov;

class Program{
  static void Main(string [] args){
    //PRIMERA PRUEBA CON NEW

    Noticiero miNoticiero = new Noticiero("HOLA A TODOS");
    miNoticiero.Muestra();

    Radio miRadio = new Radio("COMO ESTAN?");
    miRadio.Muestra();

    System.Console.WriteLine("-------");

    //SUSTITUIMOS LA CLASE HIJA Y VEMOS COMO SE COMPROTAN
    Noticiero sustitucion = new Radio("ESTAMOS PROBANDO");
    sustitucion.Muestra();

    
  }
}
