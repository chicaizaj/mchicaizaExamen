namespace mchicaizaExamen.Views;

public partial class vista2 : ContentPage
{
    const double precioUPS = 300;  
    const double porcentajeInicial = 0.15;  
    const double porcentajeInteres = 0.05;
    public vista2(String usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "USUARIO CONECTADO " + usuario;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
       
        if (!double.TryParse(entryMontoInicial.Text, out double montoInicialIngresado))
        {
            await DisplayAlert("Error", "Ingrese un monto inicial válido", "OK");
            return;  
        }

        double montoRestante = precioUPS - montoInicialIngresado;
        double cuotaBase = montoRestante / 3.0;
        double cuotaMensual = cuotaBase * (1 + porcentajeInteres);

  
        entryCuotaMensual.Text = cuotaMensual.ToString("F2");

     
    }
    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        string usuario = lblUsuario.Text.Replace("USUARIO CONECTADO ", "");  
        string nombre = txtNombre.Text;  
        string apellido = txtcontrasena.Text; 
        string montoInicial = entryMontoInicial.Text; 
        string cuotaMensual = entryCuotaMensual.Text;
        await Navigation.PushAsync(new vista3(usuario,nombre,apellido,montoInicial,cuotaMensual));
    }
}