using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using SmartHint.Emuns;

namespace SmartHint.Models
{
    public class Comprador
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("NomeRazaoSocial")]
        public string NomeRazaoSocial { get; set; } = string.Empty;
        [BsonElement("Email")]
        public string Email { get; set; } = string.Empty;
        [BsonElement("Telefone")]
        public string Telefone { get; set; } = string.Empty;
        [BsonElement("DataCadastro")]
        public DateTime DataCadastro { get; set; }
        [BsonElement("CpfCnpj")]
        public string CpfCnpj { get; set; } = string.Empty;
        [BsonElement("Bloqueado")]
        public EBloqueado Bloqueado { get; set; } = EBloqueado.NaoBloqueado;
        [BsonElement("TipoPessoa")]
        public ETipoPessoa TipoPesoa { get; set; } = ETipoPessoa.Fisica;
        [BsonElement("InscriçãoEstadual")]
        public string? InscricaoEstadual { get; set; }
        [BsonElement("Genero")]
        public int Genero { get; set; }
        [BsonElement("DataNascimento")]
        public DateTime DataNascismento { get; set; }
    }
}

