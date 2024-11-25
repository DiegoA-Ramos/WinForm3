using System.Data;
using WinForm3.Informacion;
using WinForm3.Modelo;

namespace WinForm3
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario dato = new Usuario();

        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consultar();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Edad");
            grilla.DataSource = tabla;
        }
        private void Guardar()
        {
            UsuarioModel modelo = new UsuarioModel()
            {
                Nombre = txtnombre.Text,
                Edad = int.Parse(txtedad.Text)
            };
            dato.Guardar(modelo);
        }
        private void Consultar()
        {
            foreach( var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Edad"] = item.Edad;
                tabla.Rows.Add(fila);
            }
        }
        private void Limpiar()
        {
            txtnombre.Text = "";
            txtedad.Text = "";
        }
    }
}
