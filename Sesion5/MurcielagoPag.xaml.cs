namespace Sesion5;
/// <summary>
/// Clase para la funcionalidad del boton de la pagina
/// </summary>
public partial class MurcielagoPag : ContentPage
{
	public MurcielagoPag()
	{
		InitializeComponent();
	}
    /// <summary>
    /// El boton abre la página y pasa el la referencia de la imagen y el texto a la pagina de detalles
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DetailButtonBat(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles { BindingContext = new Details { Ref= "batgif.gif", Texto = "Los quirópteros (Chiroptera, del griego ???? cheir, 'mano' y ????? pteron, 'ala'), conocidos comúnmente como murciélagos,? son un orden de mamíferos placentarios cuyas extremidades superiores se desarrollaron como alas. Con unas mil cuatrocientas especies actuales, representan aproximadamente un 20 % de todas las especies de mamíferos,? lo que los convierte, tras los roedores, en el segundo orden más diverso de esta clase. Están presentes en todos los continentes, excepto en la Antártida.? La disciplina correspondiente es la quiropterología.\r\n\r\nSon los únicos mamíferos capaces de volar,? se han extendido por casi todo el mundo y han ocupado una gran variedad de nichos ecológicos diferentes. Desempeñan un papel ecológico vital como polinizadores, como controladores de plagas de insectos y pequeños vertebrados y también desarrollan un importante papel en la dispersión de semillas; muchas plantas tropicales dependen por completo de los murciélagos.? Tienen las patas anteriores transformadas en alas y más de la mitad de especies conocidas se orientan y cazan por medio de la ecolocalización.? Cerca de un 70 % de las especies son insectívoras y la mayor parte del resto frugívoras; algunas se alimentan de pequeños vertebrados como ranas, roedores, aves, peces, otros murciélagos o, como en el caso de los vampiros (subfamilia Desmodontinae), de sangre." } });
    }
}