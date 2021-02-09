using Parcial1_ap1_20180240.Dal;
using Parcial1_ap1_20180240.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_ap1_20180240.BLL
{
    class CiudadBLL
    {
        public static bool Guardar(Ciudades ciudades)
        {
            if (!Existe(ciudades.CiudadId))
                return Insertar(ciudades);
            else
                return Modificar(ciudades);
        }
        public static bool Insertar(Ciudades ciudades)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Ciudades.Add(ciudades);
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
        public static bool Modificar(Ciudades ciudades)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(contexto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
        public static bool Eliminar(int CiudadId)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var ciudades = contexto.Ciudades.Find(CiudadId);

                if (ciudades != null)
                {
                    contexto.Ciudades.Remove(ciudades);
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
        public static Contexto Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ciudades ciudade;
            try
            {
                ciudade = contexto.Ciudades.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ciudade;
        }
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Ciudades.Any(e => e.CiudadId == id);
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
        private static List<Ciudades> GetList(Expression<Func<Ciudades, bool>> criterio)
        {
            List<Ciudades> lista = new List<Ciudades>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Ciudades.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }





    }
}
