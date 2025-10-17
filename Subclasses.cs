#nullable disable
//SUBCLASSE CASA
public class Casa : Imovel
{
    private double _valorDiaria = 650;

    public Casa(int id, string endereco, int numero, Proprietario proprietario) :
    base(id, endereco, numero, proprietario)
    { }


    public override double CalcularAluguel(int dias)
    {
        return dias * _valorDiaria;
    }

    public override string ObterStatusAluguel()
    {
        if (_alugado)
        {
            return "A casa está alugada.";
        }
        else
        {
            return "A casa está disponível.";
        }
    }
}
//------------------------------------------------------
//SUBCLASSE APARTAMENTO

public class Apartamento : Imovel
{
    private double _valorDiaria = 1250;
    private double TaxaCondominioCalculada 
    {
        get {return _valorDiaria * 0.25;}
    }

    public Apartamento(int id, string endereco, int numero, Proprietario proprietario)
        : base(id, endereco, numero, proprietario) { }

    public override double CalcularAluguel(int dias)
    {
        double custoTotalDiario = _valorDiaria + TaxaCondominioCalculada;
        return dias * custoTotalDiario;
    }

    public override string ObterStatusAluguel()
    {
        string status;
        if (_alugado)
        {
            status = "alugado"; 
        }
        else
        {
            status = "disponível"; 
        }
        return $"O apartamento n° {_numero} está {status}.";
    }

}    
        
    
