using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.Collections;

namespace Proyecto_Videos
{
    public partial class Form1 : Form
    {
        ArrayList lista = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ser_vivo pollito = new Pollo("pollo", Image.FromFile("pollo.jpg"));
            lista.Add(pollito);
            Ser_vivo gallina = new Gallina("gallina", Image.FromFile("gallina.jpg"));
            lista.Add(gallina);
            Ser_vivo gallo = new Gallo("gallo", Image.FromFile("gallo.jpg"));
            lista.Add(gallo);
            Ser_vivo super = new Superheroe("iron man", Image.FromFile("ironman.jpg"), "ironman.mp4");
            lista.Add(super);
            Ser_vivo super2 = new Superheroe("capitan america", Image.FromFile("capitan.jpg"), "capitan.mp4");
            lista.Add(super2);

            int i = 0;
            foreach (Ser_vivo item in lista)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = item.imagen;
                dataGridView1[1, i].Value = item.nombre;
                dataGridView1[2, i].Value = "Da click";
                i++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Ser_vivo objser= (Ser_vivo)lista[e.RowIndex];
                objser.accion();
            }
        }
    }
}
