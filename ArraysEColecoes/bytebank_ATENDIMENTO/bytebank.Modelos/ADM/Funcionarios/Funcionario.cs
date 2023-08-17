
namespace bytebank.Modelos.ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            this.CPF = cpf;
            this.Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

        public abstract double getBonificacao();
    }
}
