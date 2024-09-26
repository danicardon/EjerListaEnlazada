using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recup2_ED_CS;

namespace EjerListaEnlazada
{
    public partial class Form1 : Form
    {
        private CLista listaCorredores;

        public Form1()
        {
            InitializeComponent();
            listaCorredores = new CLista();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            grCorredores.Rows.Clear();
            List<Nodo> corredores = listaCorredores.Listar();

            foreach (var corredor in corredores)
            {
                grCorredores.Rows.Add(corredor.NroCorredor, corredor.Nombre, corredor.Carreras, corredor.Ganadas);
            }
        }

        private void btnListarGanadores_Click(object sender, EventArgs e)
        {
            grGanadores.Rows.Clear();
            List<Nodo> ganadores = listaCorredores.ListarGanadores();

            foreach (var ganador in ganadores)
            {
                grGanadores.Rows.Add(ganador.NroCorredor, ganador.Nombre, ganador.Carreras, ganador.Ganadas);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int totalCorredores = listaCorredores.ObtenerCorredores();
            MessageBox.Show("Total de corredores registrados: " + totalCorredores.ToString());
        }

        private void LlenarCorredoresAleatorios(int cantidad)
        {
            Random random = new Random();
            grCorredores.Rows.Clear();

            for (int i = 0; i < cantidad; i++)
            {
                int nroCorredor = i + 1;
                string nombre = "Corredor " + nroCorredor;
                int carrerasGanadas = random.Next(0, 10);
                int participaciones = random.Next(1, 15);

                Nodo corredor = new Nodo
                {
                    NroCorredor = nroCorredor,
                    Nombre = nombre,
                    Ganadas = carrerasGanadas,
                    Carreras = participaciones
                };

                listaCorredores.Insertar(corredor);
                //grCorredores.Rows.Add(corredor.NroCorredor, corredor.Nombre, corredor.Carreras, corredor.Ganadas);
            }
        }

        private void RANDOM_Click(object sender, EventArgs e)
        {
            LlenarCorredoresAleatorios(2);
        }
    }
}
