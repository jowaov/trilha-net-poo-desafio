namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // implementado as propriedades que estavam faltando de acordo com o diagrama
        public virtual string Numero { get; set; }
        public virtual long Imei { get; set; }
        public virtual string Modelo { get; set; }
        public virtual int Memoria { get; set; }
        public Smartphone(string numero, string modelo, long imei, int memoria)
        {
            // implementado o encapsulamento das propriedades externas
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando com o {Modelo}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação com o {Modelo}...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}