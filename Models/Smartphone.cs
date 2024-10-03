namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades sugeridas baseadas no contexto de um smartphone
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        // Construtor corrigido para receber os parâmetros e inicializar as propriedades
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos existentes
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato para ser implementado nas classes derivadas
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
