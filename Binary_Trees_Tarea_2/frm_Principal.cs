using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Importar el proyecto con las clases
using Capa_Logica;


namespace Binary_Trees_Tarea_2
{
    public partial class frm_Principal : Form
    {
        // Objetos e instancia de clase (solo se 
        // puede utilizar dentro de esta clase)
        Reglas_del_Juego reglas_juego = new Reglas_del_Juego();
        // Variables globales estaticas de la clase
        int longitud = Reglas_del_Juego.longitud;
        int longitudPixel = Reglas_del_Juego.longitudPixel;
        int[,] celulas = Reglas_del_Juego.celulas; // Matriz

        public frm_Principal()
        {
            InitializeComponent();
        }

        #region Metodos

        private void PintarMatriz()
        {
            Bitmap bmp = new Bitmap(ptb_matriz.Width, ptb_matriz.Height);
            for (int x = 0; x < longitud; x++)
            {
                for (int y = 0; y < longitud; y++)
                {
                    if (celulas[x, y] == 0)
                        PintarPixel(bmp, x, y, Color.Red);
                    else
                        PintarPixel(bmp, x, y, Color.White);
                }
            }

            ptb_matriz.Image = bmp;
        }

        private void PintarPixel(Bitmap bmp, int x, int y, Color color)
        {
            for (int i = 0; i < longitudPixel; i++)
                for (int j = 0; j < longitudPixel; j++)
                    bmp.SetPixel(i + (x * longitudPixel), j + (y * longitudPixel), color);
        }

        private void tmr_1_Tick(object sender, EventArgs e)
        {
            reglas_juego.JuegoDeLaVida();
            PintarMatriz();
        }

        #endregion

        #region Eventos del form
        private void bnt_random_Click(object sender, EventArgs e)
        {
            // Reinicio
            for (int i = 0; i < longitud; i++)
                for (int j = 0; j < longitud; j++)
                    celulas[i, j] = 0;

            Random r = new Random();

            // Llenado de random
            for (int i = 0; i < longitud; i++)
                for (int j = 0; j < longitud; j++)
                    celulas[i, j] = r.Next(0, 2);

            PintarMatriz();
        }

        private void btn_pausa_Click(object sender, EventArgs e)
        {
            tmr_1.Enabled = false;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            tmr_1.Enabled = true;
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            // Al cargar el form principal cargara el metodo automaticamente
            PintarMatriz();
        }

        #endregion

    }
}
