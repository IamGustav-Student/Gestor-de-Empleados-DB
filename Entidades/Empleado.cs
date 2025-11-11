namespace GestorEmpleados.Entidades
{
    public partial class Empleado
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Profesion { get; set; }
        public double Sueldo { get; set; }

        public Empleado(int legajo, string nombre, string profesion, double
   sueldo)
        {
            Legajo = legajo;
            Nombre = nombre;
            Profesion = profesion;
            Sueldo = sueldo;
        }
    }               

}
