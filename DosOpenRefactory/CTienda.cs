using static System.Console;
using System.Collections;
namespace DosOpenRefactory;

public class CTienda
{

  private List<CBaseInventario> productos; // para obtener cualquier objeto que implemente el invetario alimento o medicina
 
  public CTienda(List<CBaseInventario> pProductos)
  {
    productos = pProductos;
  }

  public void calcularInventario()
  {
    double total = 0;
    foreach (var producto in productos)
    {
      producto.CalcularProducto();
      WriteLine(producto);
      total += producto.Producto.Precio;
    }
    
    
    WriteLine("EL TOTAL EN INVENTARIO ES {0} ", total);
  }

}