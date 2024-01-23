public class TreinoCadastro
{
    //Atributos
    private string treino;
    private string genero;
    private string series;
    private string intensidade;
    private string selecao_Exercicios;
    private string repeticao;
    private string frequencia;
    private string horario_Treino;
    private string dataTreino;
    private string quantHoras;

    //Métodos Construtor
    public TreinoCadastro()
    {
        setTreino("");
        setGenero("");
        setSeries("");
        setIntensidade("");
        setSelecao_Exercicios("");
        SetRepeticao("");
        SetFrequencia("");
        setHorario_Treino("");
        setDataTreino("");
        setQuantHoras("");
    }
    //Método get e set
    public string getTreino()
    {
        return treino;
    }
    public void setTreino(string p_Treino)
    {
        this.treino = p_Treino;
    }
    public string getGenero()
    {
        return genero;
    }
    public void setGenero(string p_Genero)
    {
        this.genero = p_Genero;
    }
    public string getSeries()
    {
        return series;
    }
    public void setSeries(string p_Series)
    {
        this.series = p_Series;
    }
    public string getIntensidade()
    {
        return intensidade;
    }
    public void setIntensidade(string p_Intensidade)
    {
        this.intensidade = p_Intensidade;
    }
    public string getSelecaoExercicios()
    {
        return selecao_Exercicios;
    }
    public void setSelecao_Exercicios(string p_Selecao_Exercicios)
    {
        this.selecao_Exercicios = p_Selecao_Exercicios;
    }
    public string getRepeticao()
    {
        return repeticao;
    }
    public void SetRepeticao(string p_Repeticao)
    {
        this.repeticao = p_Repeticao;
    }
    public string getFrequencia()
    {
        return frequencia;
    }
    public void SetFrequencia(string p_Frequencia)
    {
        this.frequencia = p_Frequencia;
    }
    public string getHorario_Treino()
    {
        return horario_Treino;
    }
    public void setHorario_Treino(string p_Horario_Treino)
    {
        this.horario_Treino = p_Horario_Treino;
    }
    public string getDataTreino()
    {
        return dataTreino;
    }
    public void setDataTreino(string p_DataTreino)
    {
        this.dataTreino = p_DataTreino;
    }
    public string getQuantHoras()
    {
        return quantHoras;
    }
    public void setQuantHoras(string p_QuantHoras)
    {
        this.quantHoras = p_QuantHoras;
    }
}
