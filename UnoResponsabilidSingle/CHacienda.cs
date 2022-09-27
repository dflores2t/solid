using static System.Console;
namespace SingleResponsability;

public class CHacienda{
  //CREAMOS UNA CLASE ESPECIALIZADO PARA LA OTRA RESPONSABILIDAD
  //AHORA CADA CLASE TIENE SOLO UNA RESPONSABILIDAD.

  public static double CalcularImpuesto(CEmpleado pEmpleado){
    return pEmpleado.Suelddo * 0.35;
  }

  public static void PagarImpuesto(CEmpleado pEmpleado){
    double imp = CalcularImpuesto(pEmpleado);
    WriteLine("Se Pago {0} en impuestos por parte de {1} ", imp,pEmpleado.Nombre);
  }
}