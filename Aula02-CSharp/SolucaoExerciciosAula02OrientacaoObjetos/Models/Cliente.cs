namespace SolucaoExerciciosAula02OrientacaoObjetos.Models
{
    public class Cliente
    {
        
        public int id { get; set; } 
        public  string nome { get; set; }

        public Cliente(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }


    }
}