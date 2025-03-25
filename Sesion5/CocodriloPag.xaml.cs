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
    /// El boton abre la página y pasa el la referencia de la imagen y el texto a la pagina de detalles
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DetailButtonCroc(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Detalles { BindingContext = new Details {Ref= "crocgif.gif", Texto = "Crocodylidae (castellanizado como crocodílidos? o cocodrílidos?) es una familia de saurópsidos, arcosaurios comúnmente conocidos como cocodrilos (aunque poco usada, el DLE también acepta la grafía crocodilo).? Incluye a catorce especies actuales.? Se trata de grandes reptiles semiacuáticos que viven en las regiones tropicales de África, Asia, América y Australia. Aparecieron por primera vez durante el Eoceno, hace unos cincuenta y cinco millones de años.\r\n\r\nEn sentido estricto, un cocodrilo es cualquier especie que pertenece a la familia Crocodylidae (a veces clasificada como la subfamilia Crocodylinae). No obstante, el término también se puede usar de manera más flexible para incluir todos los miembros existentes de la orden Crocodilia, es decir, los verdaderos cocodrilos, los aligatores y caimanes (familia Alligatoridae) y los gaviales (familia Gavialidae), así como los Crocodylomorpha, que incluye parientes y antepasados extintos de los cocodrilos actuales.\r\n\r\nLos cocodrilos tienden a congregarse en hábitats de agua dulce como ríos, lagos, humedales y algunas veces en agua salobre. Se alimentan principalmente de vertebrados (peces, reptiles y mamíferos), y algunas veces de invertebrados (moluscos y crustáceos), según la especie." } });
	}
}