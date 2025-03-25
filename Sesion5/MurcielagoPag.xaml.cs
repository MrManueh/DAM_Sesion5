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
    /// El boton abre la p�gina y pasa el la referencia de la imagen y el texto a la pagina de detalles
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DetailButtonBat(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles { BindingContext = new Details { Ref= "batgif.gif", Texto = "Los quir�pteros (Chiroptera, del griego ???? cheir, 'mano' y ????? pteron, 'ala'), conocidos com�nmente como murci�lagos,? son un orden de mam�feros placentarios cuyas extremidades superiores se desarrollaron como alas. Con unas mil cuatrocientas especies actuales, representan aproximadamente un 20 % de todas las especies de mam�feros,? lo que los convierte, tras los roedores, en el segundo orden m�s diverso de esta clase. Est�n presentes en todos los continentes, excepto en la Ant�rtida.? La disciplina correspondiente es la quiropterolog�a.\r\n\r\nSon los �nicos mam�feros capaces de volar,? se han extendido por casi todo el mundo y han ocupado una gran variedad de nichos ecol�gicos diferentes. Desempe�an un papel ecol�gico vital como polinizadores, como controladores de plagas de insectos y peque�os vertebrados y tambi�n desarrollan un importante papel en la dispersi�n de semillas; muchas plantas tropicales dependen por completo de los murci�lagos.? Tienen las patas anteriores transformadas en alas y m�s de la mitad de especies conocidas se orientan y cazan por medio de la ecolocalizaci�n.? Cerca de un 70 % de las especies son insect�voras y la mayor parte del resto frug�voras; algunas se alimentan de peque�os vertebrados como ranas, roedores, aves, peces, otros murci�lagos o, como en el caso de los vampiros (subfamilia Desmodontinae), de sangre." } });
    }
}