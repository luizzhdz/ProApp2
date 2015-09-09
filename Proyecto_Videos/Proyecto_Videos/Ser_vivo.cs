using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;
using System.ComponentModel;
namespace Proyecto_Videos
{
    abstract class Ser_vivo
    {
        public string nombre { set; get; }
        public Image imagen { set; get; }

        public Ser_vivo(string nom, Image image)
        {
            nombre = nom;
            imagen = image;
            
        }

        abstract public void accion();
        
    }
}
