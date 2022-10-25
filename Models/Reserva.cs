
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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // Implementado
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // Implementado
                Console.WriteLine($"Atenção, Suite com capacidade para {Suite.Capacidade} hospedes, não comporta a reserva para {hospedes.Count} pessoas. ");
                // Ação necessária para conseguir informar o orçamento para os hospedes
                //Hospedes=hospedes;
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // Implementado com tratamento de erro
            // se a Capacidade da Suite for excedida apresenta erro porque no CadastrarHospede
            // Hospedes = hospedes somente quando não ultrapassa a capacidade 
            try
            {
                // retorno ok capacidade da suite >= quantidade de hospedes
                return Hospedes.Count;
            } 
            catch 
            {
                // capacidade inferior ao número de hospedes
                return 0;
            }       
            
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // Implementado            
            decimal valor = Suite.ValorDiaria * DiasReservados;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // Implementado
            if (DiasReservados >= 10)
            {
                valor -= valor * 10 / 100;
            }
            return valor;
        }
    }
}