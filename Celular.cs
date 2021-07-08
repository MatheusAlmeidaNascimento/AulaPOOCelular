namespace POO_Celular
{
    public class Celular
    {
        public string cor = "Cinza-Metálico";
        public string modelo = "Motorola";
        public string Tamanho = "6.1 Polegadas";
        private bool ligado = false;

        public bool Ligar(){
            ligado = true;
            return(true);
        }
        public bool Desligar(){
            ligado = false;
            return(false);
        }
        public void Ligacao(){

        }
        public void EnviarMensagem(){

        }

    }

}