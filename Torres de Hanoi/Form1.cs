using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace Torres_de_Hanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack<Button> torre1 = new Stack<Button>();
        Stack<Button> torre2 = new Stack<Button>();
        Stack<Button> torre3 = new Stack<Button>();

        int movimientos = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonReiniciar.PerformClick();
            
            groupBoxTorre1.Click += new EventHandler(MoverDisco);
            groupBoxTorre2.Click += new EventHandler(MoverDisco);
            groupBoxTorre3.Click += new EventHandler(MoverDisco);
        }

        bool discoSeleccionado = false;
        string idDiscoSeleccionado = "";
        string botonSeleccionado = "";
        string nombreTorreOrigen = "torre1";
        string nombreTorreDestino = "";

        private void Seleccionar(object sender, EventArgs e)
        {
            Button disco = (Button)sender;

            if (!discoSeleccionado && (disco.Name == torre1.Peek().Name || disco.Name == torre2.Peek().Name || disco.Name == torre3.Peek().Name))
            {
                discoSeleccionado = true;
                idDiscoSeleccionado = disco.Name;
                Subir(disco);
                botonSeleccionado = disco.Name;
            }
            else
            {
                if (idDiscoSeleccionado == disco.Name)
                {
                    idDiscoSeleccionado = "";
                    discoSeleccionado = false;
                    Bajar(disco);
                    botonSeleccionado = "";
                }
            }
        }

        private void trackBarDiscos_Scroll(object sender, EventArgs e)
        {
            movimientos = 0;
            groupBoxTorre1.Controls.Clear();
            groupBoxTorre2.Controls.Clear();
            groupBoxTorre3.Controls.Clear();

            groupBoxTorre1.Enabled = true;
            groupBoxTorre2.Enabled = true;
            groupBoxTorre3.Enabled = true;

            torre1.Clear();
            torre2.Clear();
            torre3.Clear();

            labelNumeroDeDiscos.Text = trackBarDiscos.Value.ToString();
            labelMejor.Text = $"Mejor: {Math.Pow(2, trackBarDiscos.Value) - 1}";
            labelMovimientos.Text = $"Movimientos: {movimientos}";
            labelGanador.Text = "";

            CrearDiscos(trackBarDiscos.Value);
            idDiscoSeleccionado = "";
            botonSeleccionado = "";
            discoSeleccionado = false;
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            movimientos = 0;
            par = false;

            groupBoxTorre1.Controls.Clear();
            groupBoxTorre2.Controls.Clear();
            groupBoxTorre3.Controls.Clear();

            groupBoxTorre1.Enabled = true;
            groupBoxTorre2.Enabled = true;
            groupBoxTorre3.Enabled = true;

            torre1.Clear();
            torre2.Clear();
            torre3.Clear();

            trackBarDiscos.Value = Convert.ToInt32(labelNumeroDeDiscos.Text);

            labelNumeroDeDiscos.Text = trackBarDiscos.Value.ToString();
            labelMejor.Text = $"Mejor: {Math.Pow(2, trackBarDiscos.Value) - 1}";
            labelMovimientos.Text = $"Movimientos: {movimientos}";
            labelGanador.Text = "";
            
            CrearDiscos(trackBarDiscos.Value);
            idDiscoSeleccionado = "";
            botonSeleccionado = "";
            discoSeleccionado = false;
        }

        private string BuscarTorreOrigen()
        {
            if (discoSeleccionado)
            {
                foreach (Control control in groupBoxTorre1.Controls)
                {
                    if (idDiscoSeleccionado == control.Name)
                        return "groupBoxTorre1";
                }
                foreach (Control control in groupBoxTorre2.Controls)
                {
                    if (idDiscoSeleccionado == control.Name)
                        return "groupBoxTorre2";
                }
                foreach (Control control in groupBoxTorre3.Controls)
                {
                    if (idDiscoSeleccionado == control.Name)
                        return "groupBoxTorre3";
                }
            }
            return "";
        }

        private bool ComprobarDiscoMenor(Button disco, GroupBox torreDestino)
        {
            if (torreDestino.Name == "groupBoxTorre1")
            {
                if (disco.Width > torre1.Peek().Width)
                    return false;
            }
            else if (torreDestino.Name == "groupBoxTorre2")
            {
                if (disco.Width > torre2.Peek().Width)
                    return false;
            }
            else if (torreDestino.Name == "groupBoxTorre3")
            {
                if (disco.Width > torre3.Peek().Width)
                    return false;
            }
            return true;
        }

        private void AgregarDisco(ref GroupBox torreDestino, ref Button disco)
        {
            int centroEnX = groupBoxTorre1.Width / 2 - disco.Width / 2;
            int alto = ((trackBarDiscos.Value - 400) * -1) / trackBarDiscos.Value;

            if (torreDestino.Name == "groupBoxTorre1")
            {
                groupBoxTorre1.Controls.Add(disco);
                int baseEnY = groupBoxTorre1.Height - 70 - (groupBoxTorre1.Controls.Count * alto);
                disco.Location = new Point(centroEnX, baseEnY);
                torre1.Push(disco);
                Bajar(disco);
            }
            else if (torreDestino.Name == "groupBoxTorre2")
            {
                groupBoxTorre2.Controls.Add(disco);
                int baseEnY = groupBoxTorre2.Height - 70 - (groupBoxTorre2.Controls.Count * alto);
                disco.Location = new Point(centroEnX, baseEnY);
                torre2.Push(disco);
                Bajar(disco);
            }
            else if (torreDestino.Name == "groupBoxTorre3")
            {
                groupBoxTorre3.Controls.Add(disco);
                int baseEnY = groupBoxTorre3.Height - 70 - (groupBoxTorre3.Controls.Count * alto);
                disco.Location = new Point(centroEnX, baseEnY);
                torre3.Push(disco);
                Bajar(disco);
            }
        }

        private void MoverDisco(object sender, EventArgs e)
        {
            GroupBox torreDestino = (GroupBox)sender;
            nombreTorreOrigen = BuscarTorreOrigen();

            if (nombreTorreOrigen == "groupBoxTorre1" && discoSeleccionado == true)
            {
                for (int i = 0; i < groupBoxTorre1.Controls.Count; i++)
                {
                    if (i == groupBoxTorre1.Controls.Count - 1)
                    {
                        Button disco = (Button)groupBoxTorre1.Controls[i];
                        bool discoMenor = ComprobarDiscoMenor(disco, torreDestino);
                        if (discoMenor)
                        {
                            torre1.Pop();
                            AgregarDisco(ref torreDestino, ref disco);
                            discoSeleccionado = false;

                            movimientos += torreDestino.Name == nombreTorreOrigen ? 0 : 1;
                        }
                        else
                            MessageBox.Show("No se puede colocar un disco más grande que el de abajo", "Posicionamiento incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (nombreTorreOrigen == "groupBoxTorre2" && discoSeleccionado == true)
            {
                for (int i = 0; i < groupBoxTorre2.Controls.Count; i++)
                {
                    if (i == groupBoxTorre2.Controls.Count - 1)
                    {
                        Button disco = (Button)groupBoxTorre2.Controls[i];
                        bool discoMenor = ComprobarDiscoMenor(disco, torreDestino);
                        if (discoMenor)
                        {
                            torre2.Pop();
                            AgregarDisco(ref torreDestino, ref disco);
                            discoSeleccionado = false;
                            movimientos++;
                        }
                        else
                            MessageBox.Show("No se puede colocar un disco más grande que el de abajo", "Posicionamiento incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (nombreTorreOrigen == "groupBoxTorre3" && discoSeleccionado == true)
            {
                for (int i = 0; i < groupBoxTorre3.Controls.Count; i++)
                {
                    if (i == groupBoxTorre3.Controls.Count - 1)
                    {
                        Button disco = (Button)groupBoxTorre3.Controls[i];
                        bool discoMenor = ComprobarDiscoMenor(disco, torreDestino);
                        if (discoMenor)
                        {
                            torre3.Pop();
                            AgregarDisco(ref torreDestino, ref disco);
                            discoSeleccionado = false;
                            movimientos++;
                        }
                        else
                            MessageBox.Show("No se puede colocar un disco más grande que el de abajo", "Posicionamiento incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            ComprobarVictoria();
            labelMovimientos.Text = $"Movimientos: {movimientos}";
        }

        private void ComprobarVictoria()
        {
            if (torre3.Count - 1 == trackBarDiscos.Value)
            {
                labelGanador.Text = "¡Ganaste, felicidades!";
                groupBoxTorre1.Enabled = false;
                groupBoxTorre2.Enabled = false;
                groupBoxTorre3.Enabled = false;
                buttonReiniciar.Focus();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter file = new StreamWriter(@"../../Files/sesion.txt"))
            {
                //string line = $"{trackBarDiscos.Value};{};{torre2.Count};{torre3.Count}";
                //file.WriteLine(line);
            }
            Application.Exit();
        }
    }
}