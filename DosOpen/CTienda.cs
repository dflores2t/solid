using static System.Console;
using System.Collections;
namespace DosOpen;

public class CTienda
{

  private List<CProducto> productos;
  public CTienda(List<CProducto> pProductos)
  {
    productos = pProductos;
  }

  public void calcularInventario()
  {
    double total = 0;
    // foreach (CProducto producto in productos)
    // {
    //   WriteLine(producto);
    //   total += producto.Precio;
    // }
    //cambio en el requerimiento tomando en cuenta el aumento del 20% en medicina y 20% descuento en alimento
    foreach (CProducto producto in productos)
    {
      if (producto.Categoria == 1)
      {
        ForegroundColor = ConsoleColor.Green;
        producto.Precio *= 0.8;
        WriteLine(producto);
        total += producto.Precio;
      }
      if (producto.Categoria == 2)
      {
        ForegroundColor = ConsoleColor.Yellow;
        producto.Precio *= 1.2;
        WriteLine(producto);
        total += producto.Precio;
      }
    }
    WriteLine("EL TOTAL EN INVENTARIO ES {0} ", total);
  }

}