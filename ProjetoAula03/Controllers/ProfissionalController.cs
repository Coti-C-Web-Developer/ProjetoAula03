using ProjetoAula03.Entities;
using ProjetoAula03.Repositories;

namespace ProjetoAula03.Controllers
{
    public class ProfissionalController
    {
        public void CadastrarProfissional()
        {
            try
            {
                Console.WriteLine("\nCADASTRO DE PROFISSIONAL\n");

                var profissional = new Profissional();
                profissional.Id = Guid.NewGuid();

                profissional.Empresa = new Empresa();
                profissional.Empresa.Id = Guid.NewGuid();

                Console.Write("INFORME O NOME.....................: ");
                profissional.Nome = Console.ReadLine();

                Console.Write("INFORME O CPF......................: ");
                profissional.Cpf = Console.ReadLine();

                Console.Write("INFORME O NUMº DE REGISTRO.........: ");
                profissional.NumRegistro = Console.ReadLine();

                Console.Write("INFORME O SALÁRIO..................: ");
                profissional.Salario = decimal.Parse(Console.ReadLine());

                Console.Write("INFORME O NOME FANTASIA DA EMPRESA.: ");
                profissional.Empresa.NomeFantasia = Console.ReadLine();

                Console.Write("INFORME A RAZÃO SOCIAL DA EMPRESA..: ");
                profissional.Empresa.RazaoSocial = Console.ReadLine();

                Console.Write("INFORME O CNPJ DA EMPRESA..........: ");
                profissional.Empresa.Cnpj = Console.ReadLine();

                //Gerando os dados em XML
                var profissionalRepositoryXml = new ProfissionalRepositoryXml();
                profissionalRepositoryXml.Exportar(profissional);

                //Gerando os dados em JSON
                var profissionalRepositoryJson = new ProfissionalRepositoryJson();
                profissionalRepositoryJson.Exportar(profissional);

                Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO.");
            }
            catch(Exception e)
            {
                Console.WriteLine("\nFALHA AO CADASTRAR O PROFISSIONAL.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
