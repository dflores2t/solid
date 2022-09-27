namespace SingleResponsability;
using static System.Console;
public class CEmpleado
{
  private string nombre = "";
  private string puesto = "";
  private int edad = 0;
  private double sueldo = 0.0;

  public CEmpleado(string pNombre, string pPuesto, int pEdad, double pSueldo)
  {
    nombre = pNombre;
    puesto = pPuesto;
    edad = pEdad;
    sueldo = pSueldo;
  }

  public string Nombre { get => nombre; set => nombre = value; }
  public double Suelddo { get => sueldo; set => sueldo = value; }


  public override string ToString()
  {
    return string.Format("{0},{1},{2},{3} ", nombre, puesto, edad, sueldo);
  }

  //aqui van otros metodos propios de emplead
  //asignar horario
  // proyecto actual

  /*
  AHORA COLOCAMOS ALGO QUE NO ES RESPONSABILIDA DEL EMPLEAO
  TENOMOS DOS RAZONES PARA CAMBIAR LA CLASE
  CUANDO CAMBIA ALGO DEL EMPLEADO EN SUS POLITICAS
  CUANDO CAMBIA ALGO RELACIONADO CON LOS IMPUESTOS EN SUS POLITICAS.

  */
  public double CalcularImpuesto()
  {
    return sueldo * 0.15;
  }

  public void PagarImpuesto()
  {
    double imp = CalcularImpuesto();
    WriteLine("Se pago {0} en impuestos por parte de {1} ", imp, nombre);
  }
  //LO MEJOR ES LLEVAR ESTOS DOS METODOS A UNA CLASE APARTE LLAMADA HACIENDA

}