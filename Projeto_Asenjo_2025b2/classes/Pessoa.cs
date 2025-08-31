using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Asenjo_2025b2.classes
{
    internal class Pessoa
    {
        private static string nome;
        private static string email;
        private static string telefone;
        private static string cep;
        private static string estado;
        private static string cidade;
        private static string bairro;
        private static string rua;
        private static string numero;
        private static string complemento;
        private static int id;

        public static void setNome(string _nome) { nome = _nome; }
        public static void setEmail(string _email) { email = _email; }
        public static void setTelefone(string _telefone) { telefone = _telefone; }
        public static void setCep(string _cep) { cep = _cep; }
        public static void setEstado(string _estado) { estado = _estado; }
        public static void setCidade(string _cidade) { cidade = _cidade; }
        public static void setBairro(string _bairro) { bairro = _bairro; }
        public static void setRua(string _rua) { rua = _rua; }
        public static void setNumero(string _numero) { numero = _numero; }
        public static void setComplemento(string _complemento) { complemento = _complemento; }
        public static void setId(int _id) { id = _id; }


        public static string getNome() { return nome; }
        public static string getEmail() { return email; }
        public static string getTelefone() { return telefone; }
        public static string getCep() { return cep; }
        public static string getEstado() { return estado; }
        public static string getCidade() { return cidade; }
        public static string getBairro() { return bairro; }
        public static string getRua() { return rua; }
        public static string getNumero() { return numero; }
        public static string getComplemento() { return complemento; }
        public static int getId() { return id; }


    }
}
