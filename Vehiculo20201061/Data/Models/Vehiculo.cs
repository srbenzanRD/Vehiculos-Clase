 //El namesspace deve corresponder con la ubicacion del archivo
//namespace Vehiculo20201061; ANTERIOR
namespace Vehiculo20201061.Data.Models;

public class Vehiculo
{
    public int VehiculoID { get; set; }
    public string Marca { get; set; } = null!;
    public string  Modelo { get; set; } = null!;
    public int Año { get; set; }
    public string Color { get; set; } = null!;
    //IT'S OK
}