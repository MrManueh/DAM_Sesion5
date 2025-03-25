namespace Sesion5;
/// <summary>
/// Clase para la funcionalidad del boton de la pagina
/// </summary>
public partial class AnomalocarisPag : ContentPage
{
	public AnomalocarisPag()
	{
		InitializeComponent();
	}
    /// <summary>
    /// El boton abre la p�gina y pasa el la referencia de la imagen y el texto a la pagina de detalles
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DetailButtonAnom(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles { BindingContext = new Details {Ref= "anomgif.gif", Texto = "Anomalocaris (del gr. anomalos \"extra�o\" y caris \"camar�n\" o \"cangrejo\") es un g�nero de animales extintos, perteneciente a la familia de los anomalocar�didos, la cual se relaciona con los artr�podos." +
            " Se estima que los Anomalocaris existieron entre comienzos y mediados del per�odo C�mbrico, desde hace aproximadamente 520 hasta 499 millones de a�os." +
            " Sus primeros f�siles fueron descubiertos en el esquisto de Ogygopsis y m�s tarde en el famoso esquisto de Burgess. En un principio, varias partes del cuerpo (descubiertas separadamente) se cre�an provenientes de distintos animales, hasta que nuevos estudios aclararon la verdadera naturaleza de los f�siles." +
            "\r\n\r\nAnomalocaris expone rasgos muy llamativos como ap�ndices armados con espinas con los que se llevaba la comida a la boca, ojos compuestos, boca en forma de anillo con hileras de dientes, l�bulos laterales que rodeaban todo el cuerpo, entre otros. Se cree que Anomalocaris ocupaba la cima de la cadena tr�fica de los oc�anos del C�mbrico." } });
    }
}