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
                        "puppy linux" +
                        "puppy linux es una distribucion ligera" +
                        " diseñada para funcionar correctamente en" +
                        " equipos de pocos recursos\r\n\r\n" +
                        " requisitos aproximados: \r\n" +

                        "· procesador x86_ o compatible\r\n" +
                        "· 512 Mega de Ram o mas\r\n" +
                        "· espacio reducido en diso",
                        "puppy. png",
                        "https://puppylinux.com/");
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
                        "https://www.slax.org/");
                    break;
            
            }

        }
    }
}



