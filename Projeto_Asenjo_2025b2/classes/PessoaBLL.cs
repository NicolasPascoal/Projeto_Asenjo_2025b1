using Projeto_Asenjo_2025b2.classes;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Projeto_Asenjo_2025b2
{
    public static class PessoaBLL
    {
        public static void validaDados()
        {
            Erro.setErro(false);

            if (string.IsNullOrWhiteSpace(Pessoa.getNome()))
            {
                Erro.setMsg("O nome é de preenchimento obrigatório!");
                return;
            }
            if (string.IsNullOrWhiteSpace(Pessoa.getEmail()))
            {
                Erro.setMsg("O e-mail é de preenchimento obrigatório!");
                return;
            }
            if (string.IsNullOrWhiteSpace(Pessoa.getTelefone()))
            {
                Erro.setMsg("O telefone é de preenchimento obrigatório!");
                return;
            }
            if (string.IsNullOrWhiteSpace(Pessoa.getCep()))
            {
                Erro.setMsg("O CEP é de preenchimento obrigatório!");
                return;
            }
            if (string.IsNullOrWhiteSpace(Pessoa.getEstado()))
            {
                Erro.setMsg("O estado é de preenchimento obrigatório!");
                return;
            }
            if (string.IsNullOrWhiteSpace(Pessoa.getCidade()))
            {
                Erro.setMsg("A cidade é de preenchimento obrigatório!");
                return;
            }
            if (string.IsNullOrWhiteSpace(Pessoa.getBairro()))
            {
                Erro.setMsg("O bairro é de preenchimento obrigatório!");
                return;
            }
            if (string.IsNullOrWhiteSpace(Pessoa.getRua()))
            {
                Erro.setMsg("A rua é de preenchimento obrigatório!");
                return;
            }
            if (string.IsNullOrWhiteSpace(Pessoa.getNumero()))
            {
                Erro.setMsg("O número é de preenchimento obrigatório!");
                return;
            }

            // Regex
            string regexEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string regexTelefone = @"^\(?\d{2}\)?\s?\d{4,5}-?\d{4}$";
            string regexCep = @"^\d{8}$"; // apenas números (sem hífen)

            string cep = Pessoa.getCep().Replace("-", "").Trim();

            if (!Regex.IsMatch(Pessoa.getEmail(), regexEmail))
            {
                Erro.setMsg("Formato de e-mail inválido!");
                return;
            }

            if (!Regex.IsMatch(Pessoa.getTelefone(), regexTelefone))
            {
                Erro.setMsg("Formato de telefone inválido!");
                return;
            }

            if (!Regex.IsMatch(cep, regexCep))
            {
                Erro.setMsg("Formato de CEP inválido!");
                return;
            }
        }

        public static async Task PreencherPessoaPorCep(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";

                try
                {
                    var response = await client.GetStringAsync(url);

                    var pessoaDto = JsonConvert.DeserializeObject<PessoaDTO>(response);

                    if (pessoaDto != null && !pessoaDto.Erro) // agora reconhece corretamente
                    {
                        Pessoa.setRua(pessoaDto.Logradouro);
                        Pessoa.setBairro(pessoaDto.Bairro);
                        Pessoa.setCidade(pessoaDto.Localidade);
                        Pessoa.setEstado(pessoaDto.Uf);
                        Pessoa.setComplemento(pessoaDto.Complemento);
                    }
                    else
                    {
                        Erro.setMsg("CEP não encontrado!");
                    }
                }
                catch (Exception ex)
                {
                    Erro.setMsg("Erro ao consultar o CEP! Detalhes: " + ex.Message);
                }
            }
        }
    }
}
