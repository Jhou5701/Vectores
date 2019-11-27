using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores
{
    public partial class Form1 : Form
    {
        private int cont = 0;
        private const int MAX = 100;
        private double[] vector = new double[MAX];
        private void llenarlista()
        { }
        public Form1()
        {
            InitializeComponent();
        }

        public void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cont<MAX)
                {
                    vector[cont] = int.Parse(this.txtingreso.Text);
                }
                cont++;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }            
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            //AGREGAR ELEMENTOS AL LISTBOX
            for(int i=0; i<cont;i++)
            {
                this.Lista_Numeros.Items.Add(vector[i]);
            }
            this.txtsuma.Text = sum().ToString();
            this.txtpromedio.Text = division().ToString();
        }
        private double sum()
        {
            double suma = 0;
            for (int i = 0; i < cont; i++)
            {
                suma = suma + vector[i];
            }
            return suma;
        }
        private double division()
        {
            return (sum() / cont);
        }
    }
}
