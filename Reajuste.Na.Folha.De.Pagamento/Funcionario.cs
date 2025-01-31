namespace Reajuste.Na.Folha.De.Pagamento
{
    public class Funcionario
    {
        public int? Codigo { get; set; }
        public int? Salario { get; set; }
        public int? Porcentual
        {
            get
            {
                if(Salario == null && Codigo == null)
                {
                    return null;
                }
                if (this.Salario < 1000 && this.Salario > 0) return 15;
                else if (this.Salario < 3000 && this.Salario > 0) return 10;
                else return 5;
            }
        }
        public double? NovoSalario
        {
            get
            {
                return (this.Salario * this.Porcentual / 100) + this.Salario;
            }
        }


    }
}