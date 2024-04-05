namespace DesafioPOO.Models
{
    // implementado a herança da classe Smartphone + Construtor
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, long imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // implementado o override de instalação de aplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no {Modelo}");
        }
    }
}