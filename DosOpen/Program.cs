namespace DosOpen;

class Program
{
  static void Main(string[] args)
  {
    //version si uso del principio
    List<CProducto> misProductos = new List<CProducto>{
      new CProducto("Papas",1,12.5),
      new CProducto("Analgesico",2,23.40),
      new CProducto("Tomate",1,30),
      new CProducto("Manzana",1,25),
      new CProducto("Antibiotico",2,89),
      new CProducto("Antiacido",2,43),
    };
    
    CTienda miTienda = new CTienda(misProductos);
    miTienda.calcularInventario();

    //cambio en los requerimientos 
    // es que los alimentos tineen un duescuento 20% y las medicinas un aumento 20%
    // esto lleva a que debemos modificar mi clase
  }
}
