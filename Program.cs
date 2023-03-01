namespace OOP{

class Produto{
    public string nome;
    public String autor;
    private float preco;
    public string tipoPagamento;
    public void CalcularDesconto(){}


}

class Program{
    public static void Main(String[]args){
        
        var Livros = new List<Livro>(){
            new Livro(){Id=1, Titulo="O poder do Hábito", Preco = 30, Autor ="Charles Duhigg"},
            new Livro(){Id=2, Titulo="Aprendendo Inteligencia", Preco= 20, Autor="Pierluigi Piazzi"},
            new Livro(){Id=3, Titulo ="Curso de Física Basica 1", Preco = 80, Autor="Moysés Nussenzveig"}
        };
        Console.WriteLine(Livros.Count);

    }


}





class Livro{
    public int Id {get; set;}
    public String Titulo {get; set;}
    public double Preco {get; set;}
    public String Autor {get; set;}

}
}