using Newtonsoft.Json;

namespace Projeto_Asenjo_2025b2.classes
{
    public class PessoaDTO
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("localidade")]
        public string Localidade { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("erro")]
        public bool Erro { get; set; }   // agora funciona!
    }
}
