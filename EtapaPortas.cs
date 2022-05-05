using System.Text;

namespace Pipeline.Simples
{
    public class EtapaPortas : IEtapa<StringBuilder>
    {
        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Append("[PORTAS]");
            return entrada;
        }
    }
}