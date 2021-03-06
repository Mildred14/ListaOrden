﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasOrdenadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista l = new Lista();
        int codigo;
        int delete;
        string nombre;
        int cantidad;
        int precio;
        Nodo n1;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AGREGAR_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(textBox1.Text);
            nombre = textBox2.Text;
            cantidad = Convert.ToInt32(textBox3.Text);
            precio = Convert.ToInt32(textBox4.Text);
            n1 = new Nodo(codigo, nombre, cantidad, precio);
            l.agregar(n1);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void ELIMINAR_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(textBox1.Text);
            l.eliminar(codigo);
        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {

            Nodo n1;
            int b = Convert.ToInt32(textBox6.Text);
            n1 = l.buscar(b);
            if (n1 != null)
            {
                textBox5.Text = n1.ToString();
            }
        }

        private void REPORTE_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox5.Text += l.lista();
        }
    }
}

