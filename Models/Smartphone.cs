namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; protected set; }
        public string IMEI { get; private set; }
        public int Memoria { get; private set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"Smartphone {Modelo} com número {Numero} está ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Você esta recebendo uma ligação do número {Numero}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        
        public override string ToString()
        {
            return $"Modelo: {Modelo}, Número: {Numero}, IMEI: {IMEI}, Memória: {Memoria}GB";
        }
    }
}