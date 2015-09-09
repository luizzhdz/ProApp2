using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace Proyecto_Videos
{
    class Pollo : Ser_vivo
    {
        public Pollo(string nombre, Image image)
            : base(nombre, image)
        {
        }

        public override void accion()
        {
            SoundPlayer s = new SoundPlayer("pollo.wav");
            s.Play();
        }
    }
}
