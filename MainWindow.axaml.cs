using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Mipresentacion;

public partial class MainWindow : Window
{
    private bool saludoAlternativo = false;

    public MainWindow()
    {
        InitializeComponent();
    }

    // BOTON PRESENTARME
    private void Presentarme_Click(object? sender, RoutedEventArgs e)
    {
        saludoAlternativo = false;
        MostrarPresentacion();
    }

    // VALIDAR Y MOSTRAR LA PRESENTACION
    private void MostrarPresentacion()
    {
        string nombre = NombreTextBox.Text?.Trim() ?? "";
        string apellido = ApellidoTextBox.Text?.Trim() ?? "";
        string edadTexto = EdadTextBox.Text?.Trim() ?? "";

        // Validar nombre
        if (string.IsNullOrWhiteSpace(nombre))
        {
            ResultadoTextBlock.Text = "Advertencia: escribe tu nombre.";
            return;
        }

        // Validar apellido
        if (string.IsNullOrWhiteSpace(apellido))
        {
            ResultadoTextBlock.Text = "Advertencia: escribe tu apellido.";
            return;
        }

        // Validar que la edad sea un numero entero
        if (!int.TryParse(edadTexto, out int edad))
        {
            ResultadoTextBlock.Text = "Advertencia: escribe una edad numerica.";
            return;
        }

        // Validar que la edad sea positiva
        if (edad <= 0)
        {
            ResultadoTextBlock.Text = "Advertencia: la edad debe ser mayor que cero.";
            return;
        }

        // Mostrar saludo principal o alternativo
        if (saludoAlternativo == false)
        {
            ResultadoTextBlock.Text =
                $"¡Hola! Mi nombre es {nombre} {apellido}, " +
                $"tengo {edad} años y estoy aprendiendo " +
                "a desarrollar interfaces gráficas con C#.";
        }
        else
        {
            ResultadoTextBlock.Text =
                $"¡Mucho gusto! Soy {nombre} {apellido}, " +
                $"tengo {edad} años y estoy dando mis primeros pasos " +
                "en el mundo de la programación. ¡Vamos a aprender!";
        }
    }

    // BOTON LIMPIAR
    private void Limpiar_Click(object? sender, RoutedEventArgs e)
    {
        NombreTextBox.Text = "";
        ApellidoTextBox.Text = "";
        EdadTextBox.Text = "";

        saludoAlternativo = false;

        ResultadoTextBlock.Text =
            "Aquí aparecerá tu presentación.";

        NombreTextBox.Focus();
    }

    // BOTON CAMBIAR SALUDO
    private void CambiarSaludo_Click(object? sender, RoutedEventArgs e)
    {
        saludoAlternativo = !saludoAlternativo;

        MostrarPresentacion();
    }
}