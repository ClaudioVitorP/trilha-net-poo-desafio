namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; private set;}
        public string IMEI { get; private set; }
        public int Memoraria { get; private set; }

        public Smartphone(string numero, string modelo, string imei, int memoraria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoraria = memoraria;
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