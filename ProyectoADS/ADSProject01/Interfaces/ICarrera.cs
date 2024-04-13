using ADSProject01.Models;

namespace ADSProject01.Interfaces
{
    public interface ICarrera
    {
        public int AgregarCarrera(Carrera carrera);

        public int ActualizarCarrera(int idCarrera, Carrera carrera);

        public bool EliminarCarrera(int idCarrera);

        public List<Carrera> ObtenerTodasLasCarreras();

        public Carrera ObtenerCarreraPorId(int idCarrera);
    }
}
