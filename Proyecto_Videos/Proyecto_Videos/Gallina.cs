using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace Proyecto_Videos
{
    class Gallina : Ser_vivo
    {
        public Gallina(string nombre, Image image)
            : base(nombre, image)
        {
        }

        public override void accion()
        {
            SoundPlayer s = new SoundPlayer("gallina.wav");
            s.Play();
        }
    }
}
