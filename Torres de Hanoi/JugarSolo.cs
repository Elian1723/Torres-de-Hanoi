using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Torres_de_Hanoi
{
    partial class Form1
    {
        bool par = false;

        private void buttonResolver_Click(object sender, EventArgs e)
        {
            par = trackBarDiscos.Value % 2 == 0 ? true : false;
            Resolver(ref groupBoxTorre1, ref groupBoxTorre2, ref groupBoxTorre3);
            //MessageBox.Show($"{torre1.Count}");

            //GroupBox origen = groupBoxTorre1;
            //GroupBox auxiliar = groupBoxTorre2;
            //GroupBox destino = groupBoxTorre3;

            //int i = 0;
            //while (true)
            //{
            //    if (destino.Controls.Count != trackBarDiscos.Value)
            //    {

            //    }
            //}
        }

        private void Resolver(ref GroupBox origen, ref GroupBox auxiliar, ref GroupBox destino)
        {
            if (torre3.Count != trackBarDiscos.Value + 1)
            {
                Button disco = null;

                if (!par)
                {
                    for (int i = 0; i < trackBarDiscos.Value; i++)
                    {
                        disco = BuscarDisco(ref origen);
                    }

                    //disco = BuscarDisco(ref origen);
                    //torre1.Pop();
                    //AgregarDisco(ref destino, ref disco); // O -> D

                    //disco = BuscarDisco(ref origen);
                    //torre1.Pop();
                    //AgregarDisco(ref auxiliar, ref disco); // O -> A

                    //disco = BuscarDisco(ref destino);
                    //torre2.Pop();
                    //AgregarDisco(ref auxiliar, ref disco); // D -> A

                    //if (origen.Controls.Count == 1 && destino.Controls.Count == 0)
                    //{
                    //    disco = BuscarDisco(ref origen);
                    //    torre1.Pop();
                    //    AgregarDisco(ref destino, ref disco); // O -> D
                    //    par = true;
                    //    Resolver(ref groupBoxTorre2, ref groupBoxTorre1, ref groupBoxTorre3);
                    //}

                }
                else
                {
                    disco = BuscarDisco(ref origen);
                    torre1.Pop();
                    AgregarDisco(ref auxiliar, ref disco); // O -> A

                    disco = BuscarDisco(ref origen);
                    torre1.Pop();
                    AgregarDisco(ref destino, ref disco); // O -> D

                    disco = BuscarDisco(ref auxiliar);
                    torre2.Pop();
                    AgregarDisco(ref destino, ref disco); // A -> D
                }
            }
            ComprobarVictoria();
        }

        private Button BuscarDisco(ref GroupBox torre)
        {
            int ultimoDisco = torre.Controls.Count - 1;

            Button disco = null;
            if (torre.Name == "groupBoxTorre1")
            {
                disco = (Button)groupBoxTorre1.Controls[ultimoDisco];
            }
            else if (torre.Name == "groupBoxTorre2")
            {
                disco = (Button)groupBoxTorre2.Controls[ultimoDisco];
            }
            else if (torre.Name == "groupBoxTorre3")
            {
                disco = (Button)groupBoxTorre3.Controls[ultimoDisco];
            }
            return disco;
        }
    }
}
