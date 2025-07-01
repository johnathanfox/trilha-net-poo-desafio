namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {                                                
        public string Numero { get; set; }                 //implementando propriedades
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        // Construtor da classe base. Ele será chamado pelas classes filhas.
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
             // Atribui os valores recebidos nos parâmetros às propriedades da classe.
            Numero = numero;     
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}