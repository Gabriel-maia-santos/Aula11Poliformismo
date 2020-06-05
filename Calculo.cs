namespace Aula11
{
    public class Calculo
    {
        public string Calcular(){
            return "Não hove nenhum calculo a ser aplicado";
        }


        public string Calcular(int vida){
            return "A vida do jogador está com "+vida;
        }

        public string Calcular(int vida, int escudo){
            return "A vida do jogardor escudo é "+ (vida+escudo);
        }

        public string Calcular(string nome, string sobrenome){
            return $"O nome completo do jogador é {nome} {sobrenome} ";
        }



    }
}