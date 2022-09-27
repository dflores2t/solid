namespace cincoDependency;

public class Producto{
  private string? _nombre;
  private int _tipo;
  private double _costo;

  public string? Nombre { get=>_nombre; set=>_nombre=value; }
  public int Tipo { get=> _tipo; set=> _tipo = value; }
  public double Costo { get=> _costo; set=> _costo = value; }
  public Producto(string pNombre, int pTipo, double pCosto)
  {
    Nombre = pNombre;
    Tipo = pTipo;
    Costo = pCosto;
  }

  public override string ToString()
  {
    string strTipo = "";
    if(Tipo ==0){
      strTipo = "ALIMENTO";
    }else if(Tipo==1){
      strTipo = "Medicina";
    }else if(Tipo == 2){
      strTipo = "Ropa";
    }

    return $"{_nombre} {strTipo} {_costo}";
  }
}