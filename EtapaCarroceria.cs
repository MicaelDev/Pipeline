using System.Text;

namespace Pipeline.Simples
{
    public class EtapaCarroceria : IEtapa<StringBuilder>
    {
        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Append("[CARROCERIA]");
            return entrada;
        }
    }
}