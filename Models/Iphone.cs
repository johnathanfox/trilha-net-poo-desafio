namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {

        // adicionando um construtor para a classe Iphone que chama o construtor de smartphone
  
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        //Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Iphone pela App Store.");
        }
    }
}