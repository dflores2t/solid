namespace cincoDependency;
//clase de alto nivel
public class Auditor{
  private Almacen _miAlmacen;

  //ESTAN FUERTEMENTE ACOPLADOS, SOLAMENTE PUEDE TRABAJAR CON ALMACEN
  public Auditor(Almacen pAlmacen){
    _miAlmacen = pAlmacen;
  }
  public double totalesAlimentos(){
    double total = 0;
    foreach(Producto p in _miAlmacen.Invetario){
      if(p.Tipo ==0){
        System.Console.WriteLine(p);
        total += p.Costo;
      }
    }
    return total;
  }
}