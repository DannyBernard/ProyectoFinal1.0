﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class RepositorioBase <T> :IDisposable, IRepository<T> where T: class 
    {
        internal Contexto _contexto;

        public RepositorioBase()
        {
            _contexto = new Contexto();
        }

        public bool Guardar (T enetity)
        {
            bool paso = false;
            try
            {
             if(_contexto.Set<T>().Add(enetity) != null)
                {
                    _contexto.SaveChanges(); //guarda cambios
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public bool Modificar(T entity)
        {
            bool paso = false;
            try
            {
                _contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                if(_contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;
            try
            {
                T entity = _contexto.Set<T>().Find(id);
                _contexto.Set<T>().Remove(entity);

                if (_contexto.SaveChanges() > 0)
                {
                    paso = true;
                    _contexto.Dispose();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public virtual T Buscar(int id)
        {
            T entity;
            try
            {
                entity = _contexto.Set<T>().Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return entity;
        }

        public List<T> GeList(Expression<Func<T, bool>> expression)
        {
            List<T> lista = new List<T>();
            try
            {
                lista = _contexto.Set<T>().Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

        public List<T> GetList(Expression<Func<T,bool>> expression)
        {
            List<T> lista = new List<T>();
            try
            {
                lista = _contexto.Set<T>().Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
