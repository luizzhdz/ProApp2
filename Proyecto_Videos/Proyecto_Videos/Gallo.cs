using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace Proyecto_Videos
{
    class Gallo : Ser_vivo
    {
        public Gallo(string nombre, Image image)
            : base(nombre, image)
        {
        }

        public override void accion()
        {
            SoundPlayer s = new SoundPlayer("gallo.wav");
            s.Play();
        }
    }
}
