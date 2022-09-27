namespace cincoDependencyRefactory;
//clase de alto nivel
public class Auditor{

  private IAuditable _miAlmacen;

  //AHORA EL AUDITOR YA NO ESTA FUERTEMENTE ACOPLADO CON EL ALMACEN.
  public Auditor(IAuditable pAlmacen){
    _miAlmacen = pAlmacen;
  }
  public double totalesAlimentos(){
    double total = 0;
    IEnumerable<Producto> listado = _miAlmacen.ObtenerProductos(0);

    foreach(Producto p in listado){
      if(p.Tipo ==0){
        System.Console.WriteLine(p);
        total += p.Costo;
      }
    }
    return total;
  }
}