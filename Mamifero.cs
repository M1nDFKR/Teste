public class Mamifero : Animal
{
    public Mamifero(string nome, int idade) : base(nome, idade) { }
    
}
public class Leao : Mamifero 
{
    public int TamanhoDoGrupo { get; set; }
    public Leao(string nome, int idade, int tamanhoDoGrupo) : base(nome, idade)
    {
        TamanhoDoGrupo = tamanhoDoGrupo;
        EmitirSom();
    }
}
