namespace mchicaizaExamen.Views;

public partial class vista3 : ContentPage
{
	public vista3(string usuario, string nombre, string apellido, string montoInicial, string cuotaMensual)
	{
		InitializeComponent();

        lblUsuario.Text = "Usuario: " + usuario;
        lblNombre.Text = "Nombre: " + nombre;
        lblApellido.Text = "Apellido: " + apellido;
        lblMontoInicial.Text = "Monto Inicial: " + montoInicial;
        lblCuotaMensual.Text = "Cuota Mensual: " + cuotaMensual;
    }
}