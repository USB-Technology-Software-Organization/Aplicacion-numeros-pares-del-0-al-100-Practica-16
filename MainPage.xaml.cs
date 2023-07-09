namespace Aplicación_números_pares_del_0_al_100;

public partial class MainPage : ContentPage

{

    /// <summary>
    /// <Createdate>7/7/2023</Createdate>
    /// <Company>USB Technology</Company>
    /// <Lastmodificationdate>7/7/2023</Lastmodificationdate>
    /// <Lastmodificationdescription>Se agrego un DisplayAlert que imprime los numeros pares</Lastmodificationdescription>
    /// <Lastmodificationautor>Lorena Vazquez,Nery Méndez</Lastmodificationautor>
    /// </summary>

    /// <summary>Constructor de la clase</summary>
    
    public MainPage()

	{

		InitializeComponent();

	}

    /// <summary>En el evento del boton se encarga de determinar que numeros son pares y cuales no</summary>

    private void Mostrar_Clicked(object sender, EventArgs e)

    {

    // Declaramos las variables correspondientes y realizamos la operación //

        int x = 0;

        while (x < 100)

        {

            x++;

            x = x + 1;

            DisplayAlert("Los numeros pares son:", x.ToString(), "Aceptar");

        }

    }

}

