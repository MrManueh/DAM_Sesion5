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
    /// El boton abre la página y pasa el la referencia de la imagen y el texto a la pagina de detalles
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DetailButtonAnom(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles { BindingContext = new Details {Ref= "anomgif.gif", Texto = "Anomalocaris (del gr. anomalos \"extraño\" y caris \"camarón\" o \"cangrejo\") es un género de animales extintos, perteneciente a la familia de los anomalocarídidos, la cual se relaciona con los artrópodos." +
            " Se estima que los Anomalocaris existieron entre comienzos y mediados del período Cámbrico, desde hace aproximadamente 520 hasta 499 millones de años." +
            " Sus primeros fósiles fueron descubiertos en el esquisto de Ogygopsis y más tarde en el famoso esquisto de Burgess. En un principio, varias partes del cuerpo (descubiertas separadamente) se creían provenientes de distintos animales, hasta que nuevos estudios aclararon la verdadera naturaleza de los fósiles." +
            "\r\n\r\nAnomalocaris expone rasgos muy llamativos como apéndices armados con espinas con los que se llevaba la comida a la boca, ojos compuestos, boca en forma de anillo con hileras de dientes, lóbulos laterales que rodeaban todo el cuerpo, entre otros. Se cree que Anomalocaris ocupaba la cima de la cadena trófica de los océanos del Cámbrico." } });
    }
}