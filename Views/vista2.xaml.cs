namespace mchicaizaExamen.Views;

public partial class vista2 : ContentPage
{
    const double precioUPS = 300;  // Precio fijo del UPS
    const double porcentajeInicial = 0.15;  
    const double porcentajeInteres = 0.05;
    public vista2(String usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "USUARIO CONECTADO " + usuario;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        double montoInicial = precioUPS * porcentajeInicial;
        entryMontoInicial.Text = montoInicial.ToString("C");
        double montoRestante = precioUPS - montoInicial;
        double cuotaBase = montoRestante / 3;
        double cuotaConInteres = cuotaBase * (1 + porcentajeInteres);

        entryCuotaMensual.Text = cuotaConInteres.ToString("C");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtcontrasena.Text;
        string voltaje = "No seleccionado";
        if (pickerCiudad.SelectedIndex >= 0)
            voltaje = pickerCiudad.SelectedItem.ToString();

        string fecha = datePicker.Date.ToString("dd/MM/yyyy");
        string ciudad = "No seleccionada";
        if (pickerCiudad.SelectedIndex >= 0)
            ciudad = pickerCiudad.SelectedItem.ToString();

        string montoInicial = entryMontoInicial.Text ?? "No calculado";
        string cuotaMensual = entryCuotaMensual.Text ?? "No calculada";

        // Crear el mensaje del resumen
        string mensaje = $"Nombre: {nombre}\n" +
                         $"Apellido: {apellido}\n" +
                         $"Voltaje: {voltaje}\n" +
                         $"Fecha: {fecha}\n" +
                         $"Ciudad: {ciudad}\n" +
                         $"Monto Inicial: {montoInicial}\n" +
                         $"Cuota Mensual: {cuotaMensual}";

        // Mostrar el DisplayAlert
        await DisplayAlert("Resumen de Datos", mensaje, "Aceptar");
    }
}