using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código do Cliente é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage ="Código do cliente deve conter apenas valores númericos.")]
            [StringLength(6, MinimumLength = 6, ErrorMessage ="Código do cliente deve conter 6 dígitos.")]
            public string Id { get; set; }

            [Required(ErrorMessage = "Nome do cliente é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome do cliente deve conter no máximo 50 caracteres.")]
            public string Nome { get; set; }

            [StringLength(50, ErrorMessage = "Nome do pai deve conter no máximo 50 caracteres.")]
            public string NomePai { get; set; }

            [Required(ErrorMessage = "Nome da mãe é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome da mãe deve conter no máximo 50 caracteres.")]
            public string NomeMae { get; set; }
            public bool NaoTemPai { get; set; }

            [Required(ErrorMessage = "O campo CPF deve ser preenchido.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CPF deve conter apenas valores númericos.")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve conter 11 dígitos.")]
            public string Cpf { get; set; }

            [Required(ErrorMessage ="É necessário selecionar o campo Gênero.")]
            public int Genero { get; set;}

            [Required(ErrorMessage ="É necessário preencher o campo Cep.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Cep deve conter apenas valores númericos.")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "Cep deve conter 8 dígitos.")]
            public string Cep { get; set; }

            [Required(ErrorMessage ="É necessário preencher o campo Logradouro.")]
            [StringLength(100, ErrorMessage = "Logradouro deve conter no máximo 100 caracteres.")]
            public string Logradouro { get; set; }

            [Required(ErrorMessage = "É necessário preencher o campo Complemento.")]
            [StringLength(100, ErrorMessage = "Complemento deve conter no máximo 100 caracteres.")]
            public string Complemento { get; set; }

            [Required(ErrorMessage = "É necessário preencher o campo Bairro.")]
            [StringLength(50, ErrorMessage = "Bairro deve conter no máximo 50 caracteres.")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "É necessário preencher o campo Cidade.")]
            [StringLength(50, ErrorMessage = "Cidade deve conter no máximo 50 caracteres.")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "É necessário selecionar o campo Estado.")]
            [StringLength(50, ErrorMessage = "Estado deve conter no máximo 50 caracteres.")]
            public string Estado { get; set; }
            [Required(ErrorMessage = "É necessário preencher o campo Telefone.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Telefone deve conter apenas valores númericos.")]
            public string Telefone { get; set; }
            public string Profissão { get; set; }

            [Required(ErrorMessage ="É necessário preencher o campo Renda Familiar.")]
            [Range(0, Double.MaxValue, ErrorMessage ="Renda familiar deve ser um valor positivo.")]
            public Double RendaFamiliar { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if(isValid == false)
                {
                    StringBuilder abrErrors = new StringBuilder();
                    foreach (var ValidationResult in results)
                    {
                        abrErrors.AppendLine(ValidationResult.ErrorMessage);
                    }
                    throw new ValidationException(abrErrors.ToString());
                }
            }
            public void ValidaComplemento()
            {
                if(this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome do Pai e da Mãe não podem ser iguais.");
                }
                if(this.NaoTemPai == false)
                {
                    if(this.NomePai == "")
                    {
                        throw new Exception("Nome do Pai não pode estar vazio quando a propriedade Pai Desconhecido não estiver selecionada.");
                    }
                }
                bool validaCpf = Cls_Uteis.Valida(this.Cpf);
                if(validaCpf == false)
                {
                    throw new Exception("CPF inválido.");
                }
            }
        }


        public class  List
        {
            public List<Unit> ListUnit {  get; set; }
        }

    }
}
