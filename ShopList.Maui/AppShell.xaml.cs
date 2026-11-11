using ShopList.Maui.Views;
namespace ShopList.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Registrar las rutas de navegacion de las paginas de la aplicacion 
            Routing.RegisterRoute(
                nameof(EditShopListItemPage),
                typeof(EditShopListItemPage));
        }
    }
}
