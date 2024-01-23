public class SuplementoCadastro
{
    //Atributos
    private string id;
    private string nome;
    private string descricao;
    private string sabor;
    private string preco;
    private string pesoKg;
    private string marca;
    private string dataCadastro;
    private string qtd_estoque;
    private string validade;

    //Método construtor 
    public SuplementoCadastro()
    {
        setID("");
        setNome("");
        setDescricao("");
        setSabor("");
        setPreco("");
        setPesoKg("");
        setMarca("");
        setDataCadastro("");
        setQtd_Estoque("");
        setValidade("");
    }

    //Métodos get and set
    public string getId()
    {
        return id;
    }
    public void setID(string p_Id)
    {
        this.id = p_Id;
    }
    public string getNome()
    {
        return nome;
    }
    public void setNome(string p_Nome)
    {
        this.nome = p_Nome;
    }
    public string getDescricao()
    {
        return descricao;
    }
    public void setDescricao(string p_descricao)
    {
        this.descricao = p_descricao;
    }
    public string getSabor()
    {
        return sabor;
    }
    public void setSabor(string p_Sabor)
    {
        this.sabor = p_Sabor;
    }
    public string getPreco()
    {
        return preco;
    }
    public void setPreco(string p_Preco)
    {
        this.preco = p_Preco;
    }
    public string getPesoKg()
    {
        return pesoKg;
    }
    public void setPesoKg(string p_PesoKG)
    {
        this.pesoKg = p_PesoKG;
    }
    public string getMarca()
    {
        return marca;
    }
    public void setMarca(string p_Marca)
    {
        this.marca = p_Marca;
    }
    public string getDataCadastro()
    {
        return dataCadastro;
    }
    public void setDataCadastro(string p_DataCadastro)
    {
        this.dataCadastro = p_DataCadastro;
    }
    public string getQtd_Estoque()
    {
        return qtd_estoque;
    }
    public void setQtd_Estoque(string p_Estoque)
    {
        this.qtd_estoque = p_Estoque;
    }
    public string getValidade()
    {
        return validade;
    }
    public void setValidade(string p_Valide)
    {
        this.validade = p_Valide;
    }
}
