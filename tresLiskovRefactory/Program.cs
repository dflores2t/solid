namespace liskovRefactory;
 class Program{
  static void Main(){
    Principal miNoticiero = new Noticiero("Hola a todos");
    miNoticiero.Muestra();

    Principal miRadio = new Radio("Como Estan?");
    miRadio.Muestra();
  }
 }