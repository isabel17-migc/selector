using System.Drawing.Text;

namespace selector
{
    public partial class Form1 : Form
    {
        //ruta donde se encuentran las imagenes
        private readonly string rutaRecursos =
            Path.Combine(Application.StartupPath, "resources");

        public Form1()
        {
            InitializeComponent();
            //cargar las distribucioes al iniciar
            cargaDistribuciones();

            //configurar el picture box
            piclogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //=============================================
        // CARGA LSA DISTRIBUCIONES EN EL COMBOBOX
        //=============================================
        private void cargaDistribuciones()
        {
            combodistro.Items.Clear();

            combodistro.Items.Add("puppy linux");
            combodistro.Items.Add("slax");
            combodistro.Items.Add("Antix");
            combodistro.Items.Add("Debian");
            combodistro.Items.Add("Tiny core linux");
            //no seleccionar ningun item al iniciar

            combodistro.SelectedIndex = -1;
        }

        private void combodistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //revisar el combobox tenga informacion
            if (combodistro.SelectedIndex == -1)
            {
                return;
            }
            string distroSelecionda =
                combodistro.SelectedItem.ToString();
            switch (distroSelecionda)
            {
                case "puppy Linux":

                    MostrarDistro(
                         
                        "puppy linux",
                        "puppy linux es una distribucion ligera" +
                        " diseñada para funcionar correctamente en" +
                        " equipos de pocos recursos\r\n\r\n" +
                        " requisitos aproximados: \r\n" +
                        "· procesador x86_ o compatible\r\n" +
                        "· 512 Mega de Ram o mas\r\n" +
                        "· espacio reducido en diso",
                        "puppy. png",
                        "https://puppylinux-woof-ce.github.io/"
                        );
                    break;


                case "slax":

                    MostrarDistro(

                        "slax",
                        "slax es una distribucion pequeña y" +
                        " portable que puede ejecutarse desde una " +
                        " memoria USB\r\n\r\n" +
                        " requisitos aproximados: \r\n" +

                        "· procesador x86_64 o compatible\r\n" +
                        "· 512 Mega de Ram o mas\r\n" +
                        "· espacio reducido en diso",
                        "slax.png",
                        "https://www.slax.org/"
                        );
                    break;

                case "Antix":
                    MostrarDistro(
                        "Antix",
                        "Antix es una distribucion ligera " +
                        " basada en debian y orientada especialmente" +
                        "a equipos antiguos\r\n\r\n" +
                        " requisitos aproximados: \r\n" +
                        "· procesador x86_64 o compatible\r\n" +
                        "· 512 Mega de Ram o mas\r\n" +
                        "· espacio reducido en diso",
                        "antix.png",
                        "https://antixlinux.com/"
                        );
                    break;
                case "Debian":
                    MostrarDistro(
                        "Debian",
                        "Debian es una distribucion estable y" +
                        " confiable que se utiliza como base para" +
                        " muchas otras distribuciones\r\n\r\n" +
                        " requisitos aproximados: \r\n" +
                        "· procesador x86_64 o compatible\r\n" +
                        "· 512 MB de Ram o mas\r\n" +
                        "· espacio reducido en diso",
                        "debian.png",
                        "https://www.debian.org/"
                        );
                    break;
                case "Tiny core linux":
                    MostrarDistro(
                        "Tiny core linux",
                        "Tiny core linux es una distribucion" +
                        " minimalista y ligera que se centra en la" +
                        " simplicidad y eficiencia\r\n\r\n" +
                        " requisitos aproximados: \r\n" +
                        "· procesador x86_64 o compatible\r\n" +
                        "· 128 MB de Ram o mas\r\n" +
                        "· espacio reducido en diso",
                        "tinycore.png",
                        "http://tinycorelinux.net/"
                        );
                    break;
            }
        }
        //===========================================
        // METODO PARA MOSTRAR LA DISTRIBUCION SELECCIONADA
        //=============================================
        private void MostrarDistro(
        string nombre,
        string descripcion,
        string nombreimagen,
        string url)

        {
            //MOSTRAR LA DESCRIPCION
            lbldescripcion.Text =
               nombre + "\r\n\r\n" + descripcion;
            //DIRECCION DE DESCARGA
            linkdescarga.Tag = url;

            //MOSTRAMOS EL ENLACE
            linkdescarga.Text = nombreimagen;

            try
            {
                string rutaImagen =
                    Path.Combine(rutaRecursos, nombreimagen);
                if (File.Exists(rutaImagen))
                {
                    //liberar imagen anterior
                    if (piclogo.Image != null)
                    {
                        piclogo.Image.Dispose();
                        piclogo.Image = null;
                    }
                    piclogo.Image = Image.FromFile(rutaImagen);
                }
                else
                {
                    piclogo.Image = null;
                    MessageBox.Show("No se encontro la imagen: " + rutaImagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se encontro la imagen : " + ex.Message);
            }


        }

        private void linkdescarga_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}





















