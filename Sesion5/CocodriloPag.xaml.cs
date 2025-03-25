namespace Sesion5;
/// <summary>
/// Clase para la funcionalidad del boton de la pagina
/// </summary>
public partial class CocodriloPag : ContentPage
{
	public CocodriloPag()
	{
		InitializeComponent();

		
	}
    /// <summary>
    /// El boton abre la p�gina y pasa el la referencia de la imagen y el texto a la pagina de detalles
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DetailButtonCroc(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Detalles { BindingContext = new Details {Ref= "crocgif.gif", Texto = "Crocodylidae (castellanizado como crocod�lidos? o cocodr�lidos?) es una familia de saur�psidos, arcosaurios com�nmente conocidos como cocodrilos (aunque poco usada, el DLE tambi�n acepta la graf�a crocodilo).? Incluye a catorce especies actuales.? Se trata de grandes reptiles semiacu�ticos que viven en las regiones tropicales de �frica, Asia, Am�rica y Australia. Aparecieron por primera vez durante el Eoceno, hace unos cincuenta y cinco millones de a�os.\r\n\r\nEn sentido estricto, un cocodrilo es cualquier especie que pertenece a la familia Crocodylidae (a veces clasificada como la subfamilia Crocodylinae). No obstante, el t�rmino tambi�n se puede usar de manera m�s flexible para incluir todos los miembros existentes de la orden Crocodilia, es decir, los verdaderos cocodrilos, los aligatores y caimanes (familia Alligatoridae) y los gaviales (familia Gavialidae), as� como los Crocodylomorpha, que incluye parientes y antepasados extintos de los cocodrilos actuales.\r\n\r\nLos cocodrilos tienden a congregarse en h�bitats de agua dulce como r�os, lagos, humedales y algunas veces en agua salobre. Se alimentan principalmente de vertebrados (peces, reptiles y mam�feros), y algunas veces de invertebrados (moluscos y crust�ceos), seg�n la especie." } });
	}
}