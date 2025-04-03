using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazadaS
{
    class Locomotora
    {
        Vagon Primero { get; set; }

        public void AgregaPrimero(int valor)
        {
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null) //caso1
            {
                this.Primero = nuevo;
            }
            else //caso2
            {
                Vagon primVag = this.Primero;

                nuevo.sig = this.Primero;

                this.Primero = nuevo;
            }
        }

        public void AgregaFinal(int valor)
        {
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null) //caso1
            {
                this.Primero = nuevo;
            }
            else //caso2
            {
                Vagon tmp = this.Primero;
                while (tmp.sig != null)
                {
                    tmp = tmp.sig;
                }
                tmp.sig = nuevo;
            }
        }
        public string VerVagones ()
        {
            string listaVag = "";
            Vagon tmp = this.Primero;
            while (tmp != null)
            {
                listaVag += tmp.Dato + ", ";
                tmp = tmp.sig;
            }

            return listaVag;
        }
        public void EliminarUltimo()
        {
            if(this.Primero == null) //Caso1: La lista estam vacia
            {
                return;
            }
            if(this.Primero.sig == null)//Caso2: Solo hay un vagón
            {
                this.Primero = null;
                return;
            }

            Vagon tmp = this.Primero;
            while (tmp != null)
            {
                tmp = tmp.sig;
            }
            tmp.sig = null;
        }
    }
}
