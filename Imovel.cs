#nullable disable
using System;

public abstract class Imovel {

    //atributos
    protected int _id;
    protected string _endereco;
    protected int _numero;
    protected bool _alugado;
    protected Proprietario _proprietario;
    
    //montando os getters e setters
    public int Id { get => _id; set => _id = value; }
    public string Endereco { get => _endereco; set => _endereco = value; }
    public int Numero { get => _numero; set => _numero = value; }
    public Proprietario Proprietario { get => _proprietario; set => _proprietario = value; }
    public bool Alugado { get => _alugado; }

    //montando o construtor
    public Imovel(int Id, string Endereco, int Numero, Proprietario proprietario)
    {
        this._id = Id;
        this._endereco = Endereco;
        this._numero = Numero;
        this._alugado = false;
        this._proprietario = proprietario;
    }

    //métodos

    public abstract double CalcularAluguel(int dias);
    public virtual string ObterStatusAluguel()
    {
        if(_alugado)
        {
            return "O imóvel está alugado.";
        }
        else 
        {
            return "O imóvel está disponível.";
        }
    }

    public void Alugar()
    {
        if (_alugado)
        {
            Console.WriteLine("Esse imóvel está alugado! Verifique outro com a imobiliária.");
        }
        else 
        {
            _alugado = true;
            Console.WriteLine("Imóvel alugado com sucesso");
        }
    }
    public void Disponibilizar()
    {
        if(!_alugado){
            Console.WriteLine("Este imóvel já está disponível.");
        }
        else
        {
            _alugado = false;
            Console.WriteLine("Imóvel disponível para alugar!");
        }
    }
    
}