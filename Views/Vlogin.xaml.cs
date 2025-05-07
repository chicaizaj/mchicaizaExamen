namespace mchicaizaExamen.Views;

public partial class Vlogin : ContentPage
{
    public Vlogin()
    {
        InitializeComponent();
    }
    string usuariof = "uisrael";
    string contrasenaf = "2025"; 
    public Vlogin(string usuario, string contrasena)
    {
        InitializeComponent();
        this.usuariof = usuario;
        this.contrasenaf = contrasena;
    }

    private void btniniciar_Clicked(object sender, EventArgs e)
    {
        if (txtusuario.Text == usuariof && txtcontrasena.Text == contrasenaf)
        {
            Navigation.PushAsync(new Views.vista2(usuariof));
        }
        else
        {
            DisplayAlert("Alerta", "USUARIO INCORRECTO", "OK");
        }
    }

    private async void btnregistro_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Acerca De", "Esta aplicación fue desarrollada por Chicaiza Jonnathan Mauricio en 8VO A.", "OK");
    }
}