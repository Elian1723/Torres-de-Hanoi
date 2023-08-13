using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Torres_de_Hanoi
{
    partial class Form1
    {
        private void Subir(Button disco)
        {
            disco.BackColor = Color.Green;
            disco.Location = new Point(disco.Location.X, disco.Location.Y - 30);
        }

        private void Bajar(Button disco)
        {
            disco.BackColor = Color.Blue;
            disco.Location = new Point(disco.Location.X, disco.Location.Y + 30);
        }

        private void CrearDiscos(int numeroDeDiscos)
        {
            Button inicial = new Button();
            inicial.Name = "Inicial";
            inicial.Enabled = false;
            inicial.Width = groupBoxTorre1.Width + 1;
            torre1.Push(inicial);
            torre2.Push(inicial);
            torre3.Push(inicial);

            for (int i = 0; i < numeroDeDiscos; i++)
            {
                Button disco = new Button();
                disco.Name = $"disco{numeroDeDiscos - i}";
                disco.BackColor = Color.Blue;
                disco.Cursor = Cursors.Hand;

                int alto = ((numeroDeDiscos - 400) * -1) / numeroDeDiscos;
                int ancho = 375 - (i * (375 - alto)) / (numeroDeDiscos - 1);
                disco.Size = new Size(ancho, alto);

                int centroEnX = groupBoxTorre1.Width / 2 - disco.Width / 2;
                int baseEnY = groupBoxTorre1.Height - alto - 40 - i * alto;
                disco.Location = new Point(centroEnX, baseEnY);

                disco.Click += new EventHandler(Seleccionar);

                groupBoxTorre1.Controls.Add(disco);

                torre1.Push(disco);
            }
        }
    }
}
