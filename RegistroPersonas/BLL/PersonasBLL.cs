using RegistroPersonas.DAL;
using RegistroPersonas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPersonas.BLL
{
    public class PersonasBLL
    {
        public static bool Guardar(Persona persona)
        {
            if (!Existe(persona.IdPersona))
                return Insertar(persona);
            else
                return Modificar(persona);

        }
        private static bool Insertar(Persona persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Persona.Add(persona);
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Persona persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(persona).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var persona = contexto.Persona.Find(id);
                if (persona != null)
                {
                    contexto.Persona.Remove(persona);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }
        public static Persona Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Persona persona;
            try
            {
                persona = contexto.Persona.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return persona;
        }
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Persona.Any(e => e.IdPersona == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }
    }
}
