namespace Subnetting.Pages
{
    public partial class Index
    {
        private int cont;
        /*Eliminamos input al restar contador el for recorre uno menos y se ve uno menos*/
        private void Eliminar()
        {
            cont--;
        }
        /*A�adimos input al sumar contador el for recorre uno m�s y se ve uno m�s*/
        private void Contar()
        {
            cont++;
        }
    }
}