using System.Text.Json.Serialization;

namespace bootstrap_cons_api.Models
{
 public class ListaRateioPremio
    {
        [JsonPropertyName("faixa")]
        public int Faixa { get; set; }

        [JsonPropertyName("numeroDeGanhadores")]
        public int NumeroDeGanhadores { get; set; }

        [JsonPropertyName("valorPremio")]
        public double ValorPremio { get; set; }

        [JsonPropertyName("descricaoFaixa")]
        public string DescricaoFaixa { get; set; }
    }
}