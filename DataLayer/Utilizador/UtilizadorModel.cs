namespace DataLayer.Utilizador;

public record UtilizadorModel
{
    public string? _Id { get; set; }
    public int Id { get; }
    public string username { get; set; } = "";
    public string password { get; set; } = "";
    public float avaliacaoMedia { get; set; } = 0;
    public int numeroDeLeiloesFeitos { get; set; }
    public byte[] Imagem { get; set; }
    public string dataDeRegisto { get; set; } = "";
}