public class Reptil : Animal
{
    public Reptil(string nome, int idade) : base(nome, idade) { }
}
public class Cobra : Reptil
{
    public double Comprimento { get; set; }
    public  Cobra (string nome, int idade, double comprimento ) : base (nome, idade )
    {
        Comprimento = comprimento;
        EmitirSom();
    }
}
