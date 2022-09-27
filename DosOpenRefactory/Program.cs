namespace DosOpenRefactory;

public class Program
{
  static void Main(string[] args)
  {
    //aplicando el principio de abierto cerrado haciendo uso de polimorfismo.
    List<CBaseInventario> productos = new List<CBaseInventario>{
      new CInventarioAlimento(new CProducto("PAPAS",1,12.5)),
      new CInventarioMedicamentos(new CProducto("ANALGESICO",2,23.40)),
      new CInventarioAlimento(new CProducto("TOMATE",1,30)),
      new CInventarioAlimento(new CProducto("MANZANA",1,25)),
      new CInventarioMedicamentos(new CProducto("ANTIBIOTICO",2,89)),
      new CInventarioMedicamentos(new CProducto("ANTIACIDO",2,43)),
    };
    CTienda miTienda = new CTienda(productos);

    miTienda.calcularInventario();
  }
}

/*
si deseo agregar productos nuevos solo basta con agregar la nueva clase sin modificar la tienda
si deseo agregar nuevo requerimiento basa con sobreescribir el metodo de calculo de esa clase para tener ese nuevo requerimiento.
de esa manera la clase tienda quedo cerrada para los cambios y abierta para extensiones.

*/