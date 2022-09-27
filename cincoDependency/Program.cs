namespace cincoDependency;

public class Program
{
  static void Main(string[] arsg)
  {
    Almacen miAlmacen = new Almacen();

    double total = 0;

    //0alimento , 1 medicina , 2 ropa
    miAlmacen.AdicionaProduct(new Producto("Tomate", 0, 15.50));
    miAlmacen.AdicionaProduct(new Producto("Banana", 0, 30));
    miAlmacen.AdicionaProduct(new Producto("Analgesico", 1, 23.80));
    miAlmacen.AdicionaProduct(new Producto("Jeans", 2, 450.99));
    miAlmacen.AdicionaProduct(new Producto("Manzana", 0, 12.38));
    miAlmacen.AdicionaProduct(new Producto("Antiacido", 1, 38.50));
    miAlmacen.AdicionaProduct(new Producto("Blusa", 2, 200.88));

    System.Console.WriteLine("----------------------------------");
    Auditor miAuditor = new Auditor(miAlmacen);
    total = miAuditor.totalesAlimentos();
    System.Console.WriteLine("EL TOTAL DE ALIMENOS ES {0} ", total);
  }
}