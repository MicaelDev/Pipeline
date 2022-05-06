using System.Text;

namespace Pipeline.Duplo
{
    public class EtapaDuplaPortas : IEtapaDupla<StringBuilder>
    {
        public IEtapaDupla<StringBuilder> ProximaEtapa { get; set; }

        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Insert(0, "[PORTA]", 2);
            entrada.Insert(entrada.Length, "[PORTA]", 2);
            entrada = ProximaEtapa?.Processar(entrada) ?? entrada;
            return entrada;
        }
    }
}