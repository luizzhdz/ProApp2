using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;

namespace Proyecto_Videos
{
    class Superheroe : Ser_vivo
    {
        private string video;
        private Form formulario;

        public Superheroe(string nombre, Image image, string vid)
            : base(nombre, image)
        {
            this.video = vid;
        }
        
        public override void accion()
        {
            ejecutarvideo();
        }

        private void ejecutarvideo()
        {
            try
            {
                Process nuevo = new Process();
                nuevo.StartInfo.FileName = video;
                nuevo.Start();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}
