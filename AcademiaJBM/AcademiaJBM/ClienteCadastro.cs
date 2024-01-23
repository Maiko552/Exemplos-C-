public class ClienteCadastro
{
    //Atributos 
    private string nomeCompleto;
    private string CPF;
    private string RG;
    private string dataNascimento;
    private string email;
    private string celular;
    private string objetivo;
    private string rua;
    private string numeroCasa;
    private string cidade;

    //Construtor
    public  ClienteCadastro()
    {
        this.nomeCompleto = "";
        this.CPF = "";
        this.RG = "";
        this.dataNascimento = "";
        this.email = "";
        this.celular = "";
        this.objetivo = "";
        this.rua = "";
        this.numeroCasa = "";
        this.cidade = "";
    }

    //Métodos SET/ GET
    public void setNomeCompleto(string par_nomeCompleto)
    {
        this.nomeCompleto = par_nomeCompleto;
    }
    public string getNomeCompleto()
    {
        return this.nomeCompleto;
    }

    public void setCPF(string par_CPF)
    {
        this.CPF = par_CPF;
    }
    public string getCPF()
    {
        return this.CPF;
    }

    public void setRG(string par_RG)
    {
        this.RG = par_RG;
    }
    public string getRG()
    {
        return this.RG;
    }

    public void setNascimento(string par_Nascimento)
    {
        this.dataNascimento = par_Nascimento;
    }
    public string getNascimento()
    {
        return this.dataNascimento;
    }

    public void setEmail(string par_Email)
    {
        this.email = par_Email;
    }
    public string getEmail()
    {
        return this.email;
    }

    public void setCelular(string par_Celular)
    {
        this.celular = par_Celular;
    }
    public string getCelular()
    {
        return this.celular;
    }

    public void setObjetivo(string par_Objetivo)
    {
        this.objetivo = par_Objetivo;
    }
    public string getObjetivo()
    {
        return this.objetivo;
    }

    public void setRua(string par_Rua)
    {
        this.rua = par_Rua;
    }
    public string getRua()
    {
        return this.rua;
    }

    public void setNumeroCasa(string par_NumeroCasa)
    {
        this.numeroCasa = par_NumeroCasa;
    }
    public string getNumeroCasa()
    {
        return this.numeroCasa;
    }


    public void setCidade(string par_Cidade)
    {
        this.cidade = par_Cidade;
    }
    public string getCidade()
    {
        return this.cidade;
    }
}
  
