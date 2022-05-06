using System;
using System.Text;
using Pipeline.Simples;

namespace Pipeline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pipeline Simples para Montagem de Veículos");
            var montagemVeiculo = new Pipeline<StringBuilder>();
            montagemVeiculo.AdicionarEtapa(new EtapaChassi());
            montagemVeiculo.AdicionarEtapa(new EtapaMotor());
            montagemVeiculo.AdicionarEtapa(new EtapaBancos());
            montagemVeiculo.AdicionarEtapa(new EtapaCarroceria());
            montagemVeiculo.AdicionarEtapa(new EtapaPortas());
            montagemVeiculo.AdicionarEtapa(new EtapaPintura());

            for (var i = 0; i < 10; i++)
            {
                var veiculo = montagemVeiculo.Processar(new StringBuilder());
                Console.WriteLine($"Veículo {i + 1:D2}: {veiculo.ToString()}");
            }
        }
    }
}
