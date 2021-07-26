using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Joaum2.Clases;
using Joaum2.Data;

namespace Joaum2.Formularios
{
    public partial class PrendaAgregar : Form
    {
        //************Universal Variable************//
        Conexion conexion;
        List<Image> imagenes= new List<Image>(); 
        Categoria Categoria=new Categoria();
        Tela Tela = new Tela();
        Material material = new Material();
        int indexImg=0;

            //===================================//


        public PrendaAgregar()
        {
            InitializeComponent();
        }


        //****************Editar ***************************//
        public PrendaAgregar(Prenda Prenda)
        {

            InitializeComponent();

        }
        //==================================================//
        private void PrendaEditar_Load(object sender, EventArgs e)
        {
            CargarTbxs();
            CargarStock();
        }

        //-----------------------cargar combo box----------------------------------
         void CargarTbxs()
        {
            //Categorias 
            cbxCategoria.DisplayMember = "Categoria";
            cbxCategoria.ValueMember = "IdCategoria";
            cbxCategoria.DataSource = Categoria.ListarCategorias();
            //Tela
            cbxTela.DisplayMember = "Tela";
            cbxTela.ValueMember = "IdTela";
            cbxTela.DataSource = Tela.ListarTelas();
            //Genero
            conexion = new Conexion();
            cbxGenero.DisplayMember = "Genero";
            cbxGenero.ValueMember = "IdGenero";
            cbxGenero.DataSource = conexion.listarAny("ListarGenero");
            //Material 
            cbxMaterial.DisplayMember = "Material";
            cbxMaterial.ValueMember = "IdMaterial";
            cbxMaterial.DataSource = material.Listar();
            //Unidades
            conexion = new Conexion();
            cbxUnidad.DisplayMember = "NombreUnidad";
            cbxUnidad.ValueMember = "IdUnidad";
            cbxUnidad.DataSource = conexion.listarAny("ListarUnidad");




        }



        //************************Rellenar Stock*********************

        void CargarStock()
        {
            //dgvStock = new DataGridView();
            conexion = new Conexion();
            dgvStock.DataSource = conexion.listarAny("FillDgvStock");
            dgvStock.Columns[0].Visible = false;
            //dgvStock.Columns[1].Width = 30;
            //dgvStock.Columns[2].Width = 50;
            //dgvStock.Columns[3].Width = 30;


        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnImgAgre_Click(object sender, EventArgs e)
        {
            ofdImagenes.Filter = "Imagenes(*.JPEG,*.JPG,*.PNG)|*.JPEG;*.JPG;*.PNG";
            ofdImagenes.Multiselect = true;
            ofdImagenes.Title = "Selecciones las las imagenes";

            if (ofdImagenes.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in ofdImagenes.FileNames)
                {   
                    Image img = Image.FromFile(file);
                    imagenes.Add(img);
                }
     
            }
            picImagenes.Image = imagenes[0];





        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnImgSiguiente_Click(object sender, EventArgs e)
        {
            if(imagenes.Count>0)
            {
                if (indexImg == imagenes.Count - 1)
                {
                    indexImg = 0;
                }
                else
                    indexImg += 1;

                picImagenes.Image = imagenes[indexImg];



            }








        }

        private void btnImgAnterior_Click(object sender, EventArgs e)
        {

            if(imagenes.Count>0)
            if (indexImg==0)
                indexImg = imagenes.Count - 1;
            else
                indexImg -= 1;


            picImagenes.Image = imagenes[indexImg];

   

        }

        private void btnImgDrop_Click(object sender, EventArgs e)
        {
          if (imagenes.Count==1)
            {
                btnImgAnterior.Enabled = false;
                btnImgSiguiente.Enabled = false;
            }
          else if  (imagenes.Count==0)
            {
                picImagenes.Image = null;
                btnImgAnterior.Enabled = true ;
                btnImgSiguiente.Enabled = true;
            }

        }
    }
}
