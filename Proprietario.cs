public  class Proprietario {

    //atributos com getters e setters 
    public string Nome {get; set; };
    public string CPF {get; set; };
    public string Telefone{get; set; };

    //montando o construtor
    public Proprietario(string nome, string cpf, string telefone) 
    {
        this.Nome = nome;
        this.CPF = cpf;
        this.Telefone = telefone;
    }

    //montando os métodos 
    public string ContatoProprietario()
    {
        return $"Nome: {Nome}, Telefone: {Telefone}";
    }
}





