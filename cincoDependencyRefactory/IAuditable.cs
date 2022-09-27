namespace cincoDependencyRefactory;

public interface IAuditable{
  IEnumerable<Producto> ObtenerProductos(int pTipo);
}