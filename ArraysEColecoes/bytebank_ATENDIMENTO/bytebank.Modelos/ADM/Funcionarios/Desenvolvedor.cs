namespace bytebank.Modelos.ADM.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.15;
        }

        public override double getBonificacao()
        {
            return this.Salario * 0.1;
        }
    }
}
