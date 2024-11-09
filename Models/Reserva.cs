namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (ObterQuantidadeHospedes() <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade da suíte é menor que o número de hóspedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
             if (Hospedes.Count == 0)
             {
                throw new Exception("Não há hospedes cadastrados");
             }
            else
            {
            return Hospedes.Count;
            }
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = (DiasReservados * Suite.ValorDiaria);

            if (DiasReservados >= 10)
            {
                valor = valor - ((valor * 10)/100);
            }

            return valor;
        }
    }
}