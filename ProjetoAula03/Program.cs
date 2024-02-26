using ProjetoAula03.Controllers;

class Program
{
    static int Main(string[] args)
    {
        ProfissionalController controller = new ProfissionalController();
        controller.CadastrarProfissional();
        return 0;
    }
}
