using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasOrdenadas
{
    class Lista
    {
        public Nodo primero = null;
        Nodo raiz;

        public Lista()
        {

        }
        //AGREGAR ORDENADO
        public void agregar(Nodo nodo)
        {
            Nodo raiz = primero;
            if (primero == null)
            {
                primero = nodo;


            }
            else
            {
                if (nodo.Codigo <= primero.Codigo)
                {
                    nodo.siguiente = primero;
                    primero = nodo;
                }


                else
                {
                    while (raiz.siguiente != null)
                    {
                        if (nodo.Codigo <= raiz.siguiente.Codigo)
                            break;
                        raiz = raiz.siguiente;
                    }
                    nodo.siguiente = raiz.siguiente;
                    raiz.siguiente = nodo;
                }
            }
        }

        
        //BUSQUEDA
        public Nodo buscar(int codigo)
        {
            Nodo search = primero;
            while (search != null)
            {
                if (search.Codigo == codigo)
                {
                    return search;
                }
                else
                {
                    search = search.siguiente;
                }
            }
            return null;
        }
        //ELIMINAR
        public void eliminar(int codigo)
        {
            if (primero.Codigo == codigo)
            {
                primero = primero.siguiente;

            }
            else
            {
                Nodo temporal = primero;

                while (temporal.siguiente != null)
                {
                    if (temporal.siguiente.Codigo == codigo)
                    {
                        temporal.siguiente = temporal.siguiente.siguiente;

                        break;
                    }
                    else
                    {
                        temporal = temporal.siguiente;
                    }
                }
            }


        }
        //LISTA
        public string lista()
        {
            string show = ToString() + Environment.NewLine;
            Nodo temporal = primero;
            while (temporal != null)
            {
                show += " " + Environment.NewLine;
                show += temporal.ToString();
                temporal = temporal.siguiente;
            }
            return show;
        }

    }
}

