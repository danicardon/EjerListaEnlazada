using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recup2_ED_CS
{
    public class CLista
    {
        // propiedades
        public Nodo Primero { get; set; }
        public Nodo Ultimo { get; set; }

        // constructor
        public CLista()
        {
            Primero = null;
            Ultimo = null;
        }

        // metodos publicos
        public void Crear(Nodo nuevo)
        {
            if (Primero == null && Ultimo == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Insertar(nuevo);
            }
        }

        // el INSERTAR mantiene ordenada la lista por el campo "Numero" de manor a mayor
        public void Insertar(Nodo nuevo)
        {
            if (Primero == null || nuevo.NroCorredor < Primero.NroCorredor)
            {
                nuevo.Siguiente = Primero;
                Primero = nuevo;
                if (Ultimo == null)
                {
                    Ultimo = nuevo;
                }
                return;
            }

            Nodo actual = Primero;
            while (actual.Siguiente != null && actual.Siguiente.NroCorredor < nuevo.NroCorredor)
            {
                actual = actual.Siguiente;
            }

            nuevo.Siguiente = actual.Siguiente;
            actual.Siguiente = nuevo;

            if (nuevo.Siguiente == null)
            {
                Ultimo = nuevo;
            }
        }


        public List<Nodo> Listar()
        {
            List<Nodo> nodos = new List<Nodo>();
            Nodo actual = Primero;

            while (actual != null)
            {
                nodos.Add(actual);
                actual = actual.Siguiente;
            }

            return nodos;
        }

        public List<Nodo> ListarGanadores()
        {
            List<Nodo> ganadores = new List<Nodo>();
            Nodo actual = Primero;

            while (actual != null)
            {
                if (actual.Ganadas > 2 && actual.Carreras >= 5)
                {
                    ganadores.Add(actual);
                }
                actual = actual.Siguiente;
            }

            return ganadores;
        }

        public int ObtenerCorredores()
        {
            int cantidad = 0;
            Nodo actual = Primero;

            while (actual != null)
            {
                cantidad++;
                actual = actual.Siguiente;
            }

            return cantidad;
        }

        public Nodo Buscar(int nro)
        {
            Nodo nodo = null;

            return nodo;
        }


    }
}
