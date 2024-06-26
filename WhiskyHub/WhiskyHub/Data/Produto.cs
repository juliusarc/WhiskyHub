using System.ComponentModel.DataAnnotations;

namespace WhiskyHub.Data
{
    public class Produto
    {
          public int Id { get; set; }

            [Required]
            [StringLength(255)]
          public string Nome { get; set; } = string.Empty;

        [Required]
        public string Descricao { get; set; } = string.Empty;

        [Required]
            [StringLength(255)]
            public string Marca { get; set; } = string.Empty;

        [Required]
            [StringLength(255)]
            public string Tipo { get; set; } = string.Empty; // Ex: single malt, blended, bourbon

        [Required]
            [Range(0, int.MaxValue, ErrorMessage = "Por favor, insira um número inteiro válido para Idade.")]
            public int Idade { get; set; }  
            [Required]
            [Range(0, int.MaxValue, ErrorMessage = "Por favor, insira um número inteiro válido para Idade.")]
            public int Volume { get; set; }  // Em ml

            [Required]
            [Range(0, 100, ErrorMessage = "Por favor, insira um número decimal válido para Preço.")]
            public decimal TeorAlcoolico { get; set; }  

            [Required]
            [Range(0, 9999999999.99, ErrorMessage = "Por favor, insira um número decimal válido para Preço.")]
            public decimal Preco { get; set; }  

            [Required]
            [Range(0, int.MaxValue, ErrorMessage = "Por favor, insira um número inteiro válido para Quantidade em Estoque.")]
            public int QuantidadeEmEstoque { get; set; }
        }
    }

