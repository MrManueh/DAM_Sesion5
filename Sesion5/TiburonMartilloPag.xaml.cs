namespace Sesion5;
/// <summary>
/// Clase para la funcionalidad del boton de la pagina
/// </summary>
public partial class TiburonMartilloPag : ContentPage
{
	public TiburonMartilloPag()
	{
		InitializeComponent();
	}
    /// <summary>
    /// El boton abre la p�gina y pasa el la referencia de la imagen y el texto a la pagina de detalles
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DetailButtonTib(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles { BindingContext = new Details { Ref= "tirgif.gif", Texto = "El tibur�n martillo gigante (Sphyrna mokarran) es una especie de elasmobranquio carcarriniforme de la familia Sphyrnidae. Posee una longitud media de 4,6 m y una longitud m�xima de 6,1 m. Se encuentra en aguas tropicales y templadas c�lidas de todo el mundo. Habita zonas costeras y la plataforma continental. El tibur�n martillo gigante se puede distinguir de otros tiburones martillo por la forma de su cabeza en forma de martillo (de ah� su nombre), que es ancha con un margen frontal casi recto, y por su primera aleta dorsal alta y en forma de hoz. Es un superdepredador, solitario y nadador, que se alimenta de una amplia variedad de presas que van desde crust�ceos y cefal�podos hasta peces �seos y tiburones m�s peque�os." } });
    }
}