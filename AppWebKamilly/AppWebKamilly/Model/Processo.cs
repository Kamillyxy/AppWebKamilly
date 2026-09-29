namespace AppWebKamilly.Model
{
 public class Processo
 {
 public int Id { get; set; }
 public string Numero { get; set; } = string.Empty;
 public DateTime? Data { get; set; }
 public string Interessado { get; set; } = string.Em
pty;
 public string Assunto { get; set; } = string.Empty;
 public string Descricao { get; set; } = string.Empt
y;
 public string Situacao { get; set; } = string.Empt
y;
 }
}
