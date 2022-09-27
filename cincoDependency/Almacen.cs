namespace cincoDependency;

public class Almacen{
  private List<Producto> _inventario;

  //NOS VEMOS FORZADOS A CREAR LA PROPIEDAD PARA QUE SE PUEDA CONTAR EL INVENTARIO
  //AL SER UNA PROPIEDAD DE TIPO LIST FORZAMOS AL AUDITOR A TRABAJAR CON LIST

  public List<Producto> Invetario { get => _inventario; set => _inventario = value; }

  public Almacen()
  {
    _inventario = new List<Producto>();
  }

  public void AdicionaProduct(Producto pProducto){
    Invetario.Add(pProducto);
    System.Console.WriteLine("ADICIONAMOS {0}", pProducto.Nombre);
  }
}