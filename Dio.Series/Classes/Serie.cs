namespace DIO.Series
{
    public class Serie : EntidadeBase
    {   
        // Atributos
        private Genero Genero {get; set;}
        private string  Titulo { get; set; }

        private string Descricao {get; set;}

        private int Ano {get;set;}

        private bool Excluido {get;set;}
        // Métodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano){
            this.Id = id;
            this.Genero = genero;
            this.Titulo = descricao;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;

        }

        public override string ToString()
        {
            string retorno = "";
            retorno+= "Gênero: " + this.Genero + Environment.NewLine; //Newline para nova linha
            retorno+= "Título: " + this.Titulo + Environment.NewLine;
            retorno+= "Descrição: " + this.Descricao + Environment.NewLine;
            retorno+= "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno+= "Excluído " + this.Excluido;
            return retorno;
        }

        // Encapsulamento

        public string retornaTitulo(){
            return this.Titulo;
        }

        public bool retornaExcluido(){
            return this.Excluido;

        }

        public int retornaId(){
            return this.Id;

        }

        public void Excluir(){
            this.Excluido = true;
        }
    }
}