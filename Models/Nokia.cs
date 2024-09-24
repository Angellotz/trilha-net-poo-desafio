using System.Runtime.CompilerServices;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //DONE
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, string memoria) : base(numero)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        //DONE
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("instalando o "+ nomeApp);
        }
    }
}