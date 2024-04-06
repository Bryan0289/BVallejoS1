namespace BVallejoS1.Vistas;

public partial class Saludo : ContentPage
{
	public Saludo()
	{
		InitializeComponent();
	}
    private void OnSaludar(object sender, EventArgs e)
    {
        var nombre = txtNombre.Text;
        var anio = int.Parse(txtAnio.Text);
        string saludo = $"Bienvenido: {nombre}\nSu edad es: {CalcularEdad(anio)}";

        DisplayAlert("Saludo", saludo, "OK");


    }
    private int CalcularEdad(int anio)
    {
        int currentYear = DateTime.Now.Year;

        return currentYear - anio;

    }
}