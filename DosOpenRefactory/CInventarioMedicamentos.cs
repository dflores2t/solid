namespace DosOpenRefactory;

class CInventarioMedicamentos : CBaseInventario
{

  public CInventarioMedicamentos(CProducto pProducto) : base(pProducto)
  {

  }

  public override double CalcularProducto()
  {
    producto.Precio *= 1.20;
    return producto.Precio;
  }
}