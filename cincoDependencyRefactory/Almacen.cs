namespace cincoDependencyRefactory;

public class Almacen :IAuditable{
  private List<Producto> _inventario;

  public Almacen()
  {
    _inventario = new List<Producto>();
  }

  public void AdicionaProduct(Producto pProducto){
    _inventario.Add(pProducto);
    System.Console.WriteLine("ADICIONAMOS {0}", pProducto.Nombre);
  }

  //IMPLEMENTACION DE LA INTERFAZ , HACEMOS LA BUSQUEDA FLEXIBLE.
  public IEnumerable<Producto> ObtenerProductos(int pTipo){
    List<Producto> encontrados = new List<Producto>();
    foreach(Producto p in _inventario){
      if(p.Tipo ==pTipo){
        encontrados.Add(p);
      }
    }
    return encontrados;
  }

}