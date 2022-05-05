using System.Text;

namespace Pipeline.Simples
{
    public class EtapaBancos : IEtapa<StringBuilder>
    {
        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Append("[BANCOS]");
            return entrada;
        }
    }
}