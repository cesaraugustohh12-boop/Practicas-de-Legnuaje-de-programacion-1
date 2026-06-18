using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Serpiente
{
    public partial class Form1 : Form
    {

        List<Point> serpiente = new List<Point>();

        Point comida;

        int direccionX = 1;
        int direccionY = 0;

        int tamañoBloque = 20;

        System.Windows.Forms.Timer juego = new System.Windows.Forms.Timer();

        Random aleatorio = new Random();

        int puntuacion = 0;



        public Form1()
        {
            InitializeComponent();


            this.Width = 450;
            this.Height = 450;
            this.Text = "Juego de la Serpiente";

            this.BackColor = Color.White;

            // evita parpadeos al dibujar
            this.DoubleBuffered = true;


            IniciarJuego();

            // permite recibir teclas
            this.Focus();
        }



        void IniciarJuego()
        {

            serpiente.Clear();


            // cuerpo inicial
            serpiente.Add(new Point(5, 5));
            serpiente.Add(new Point(4, 5));
            serpiente.Add(new Point(3, 5));


            CrearComida();



            juego.Interval = 120;

            juego.Tick += MoverSerpiente;

            juego.Start();



            this.KeyDown += CambiarDireccion;

        }




        void CrearComida()
        {

            comida = new Point(
                aleatorio.Next(0, 20),
                aleatorio.Next(0, 20)
            );

        }




        void MoverSerpiente(object? sender, EventArgs e)
        {


            Point cabeza = serpiente[0];


            Point nuevaCabeza = new Point(
                cabeza.X + direccionX,
                cabeza.Y + direccionY
            );



            // choque con paredes

            if(
                nuevaCabeza.X < 0 ||
                nuevaCabeza.Y < 0 ||
                nuevaCabeza.X >= 20 ||
                nuevaCabeza.Y >= 20
            )
            {
                Perder();
                return;
            }




            serpiente.Insert(0, nuevaCabeza);




            // comer comida

            if(nuevaCabeza == comida)
            {

                puntuacion++;

                CrearComida();

            }
            else
            {

                serpiente.RemoveAt(serpiente.Count - 1);

            }



            // actualizar pantalla

            Invalidate();

        }




        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);


            Graphics dibujo = e.Graphics;



            // dibujar serpiente

            foreach(Point parte in serpiente)
            {

                dibujo.FillRectangle(
                    Brushes.Green,
                    parte.X * tamañoBloque,
                    parte.Y * tamañoBloque,
                    tamañoBloque,
                    tamañoBloque
                );

            }




            // dibujar comida

            dibujo.FillRectangle(
                Brushes.Red,
                comida.X * tamañoBloque,
                comida.Y * tamañoBloque,
                tamañoBloque,
                tamañoBloque
            );




            // mostrar puntos

            dibujo.DrawString(
                "Puntos: " + puntuacion,
                new Font("Arial",14),
                Brushes.Black,
                10,
                10
            );

        }





        void CambiarDireccion(object? sender, KeyEventArgs e)
        {

            switch(e.KeyCode)
            {


                case Keys.Up:

                    if(direccionY != 1)
                    {
                        direccionX = 0;
                        direccionY = -1;
                    }

                    break;



                case Keys.Down:

                    if(direccionY != -1)
                    {
                        direccionX = 0;
                        direccionY = 1;
                    }

                    break;



                case Keys.Left:

                    if(direccionX != 1)
                    {
                        direccionX = -1;
                        direccionY = 0;
                    }

                    break;



                case Keys.Right:

                    if(direccionX != -1)
                    {
                        direccionX = 1;
                        direccionY = 0;
                    }

                    break;

            }

        }





        void Perder()
        {

            juego.Stop();


            MessageBox.Show(
                "Juego terminado\nPuntuación: " + puntuacion
            );


            puntuacion = 0;


            juego.Start();


            IniciarJuego();

        }

    }
}