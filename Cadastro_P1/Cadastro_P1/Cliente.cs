using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_P1
{
    public class Cliente
    {
        //Atributos
        private string nome, sobrenome;
        private string data_Nascimento;
        private string email, telefone;
        private string senha, confirmar_Senha;
        private Endereco endereco;



        //métodos
        public Cliente(string par_Nome, string par_Sobrenome, string par_Nascimento, string par_CEP, string par_Email,
                          string par_Senha, string par_ConfirmeSenha, string par_tel)
        {

            /*this.setNome(par_Nome);
            this.setSobrenome(par_Sobrenome);
            this.setNascimento(par_Nascimento);
            this.setCEP(par_CEP);
            this.setEmail(par_Email);
            this.setSenha(par_Senha);
            this.setConfirmeSenha(par_ConfirmeSenha);
            endereco = new Endereco();
            */
        }

        public Cliente()
        {
            this.nome = "";
            this.sobrenome = "";
            this.email = "";
            this.senha = "";
            this.confirmar_Senha = "";
            this.data_Nascimento = "";
            this.telefone = "";
            endereco = new Endereco();
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string par_Nome)
        {
            this.nome = par_Nome;
        }
        public string getSobrenome()
        {
            return this.sobrenome;
        }
        public void setSobrenome(string par_Sobrenome)
        {
            this.sobrenome = par_Sobrenome;
        }

        public string getNascimento()
        {
            return this.data_Nascimento;
        }
        public void setNascimento(string par_Nascimento)
        {

            this.data_Nascimento = par_Nascimento;
        }
        public string getCEP()
        {
            return this.endereco.cep;
        }
        public void setCEP(string par_CEP)
        {
            this.endereco.cep = par_CEP;
        }
        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string par_Email)
        {
            this.email = par_Email;
        }
        public string getSenha()
        {
            return this.senha;
        }
        public void setSenha(string par_Senha)
        {
            this.senha = par_Senha;
        }
        public string getConfirmeSenha()
        {
            return this.confirmar_Senha;
        }
        public void setConfirmeSenha(string par_ConfirmeSenha)
        {
            this.confirmar_Senha = par_ConfirmeSenha;
        }
        public string getRua()
        {
            return this.endereco.rua;
        }
        public void setRua(string par_Rua)
        {
            this.endereco.rua = par_Rua;
        }
        public string getBairro()
        {
            return this.endereco.bairro;
        }
        public void setBairro(string par_Bairro)
        {
            this.endereco.bairro = par_Bairro;
        }
        public string getTelefone()
        {
            return this.telefone;
        }
        public void setTelefone(string par_tel)
        {
            this.telefone = par_tel;
        }
    }

}




