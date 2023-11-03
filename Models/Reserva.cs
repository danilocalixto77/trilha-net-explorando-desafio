namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;

        }


        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*

            // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
            // *IMPLEMENTE AQUI*
            try
            {
                if (Suite.Capacidade >= hospedes.Count)
                {
                    Hospedes = hospedes;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"OCORREU UMA EXCEÇÃO: {ex.Message}");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            var totalHospede = Hospedes.Count;
            return totalHospede;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*

            decimal valor = DiasReservados * Suite.ValorDiaria;
            decimal desconto = 10;


            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados < 10)
            {
                return valor;
            }
            else
            {
                return (valor * (1 - (desconto / 100)));
            }


        }
    }
}