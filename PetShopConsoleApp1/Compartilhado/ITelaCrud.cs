namespace PetShopConsoleApp1.Compartilhado;

public interface ITelaCrud
{
    char ApresentarMenu();
    void CadastrarRegistro();
    void EditarRegistro();
    void ExcluirRegistro();
    void VisualizarRegistros(bool v);
}