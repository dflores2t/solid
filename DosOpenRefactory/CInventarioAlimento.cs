namespace DosOpenRefactory;

class CInventarioAlimento : CBaseInventario
{

  public CInventarioAlimento(CProducto pProducto) : base(pProducto)
  {

  }

  public override double CalcularProducto()
  {
    producto.Precio *= 0.80;
    return producto.Precio;
  }
}