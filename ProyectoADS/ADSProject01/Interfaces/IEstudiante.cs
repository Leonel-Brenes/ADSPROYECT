﻿using ADSProject01.Models;
namespace ADSProject01.Interfaces
{
    public interface IEstudiante
    {
        public int AgregarEstudiante(Estudiante estudiante);

        public int ActualizarEstudiante(int idEstudiante, Estudiante estudiante);

        public bool EliminarEstudiante(int idEstudiante);

        public List<Estudiante> ObtenerTodosLosEstudiantes();

        public Estudiante ObtenerEstudiantePorId(int  idEstudiante);


    }
}