using System.ComponentModel.DataAnnotations.Schema;

namespace App_fotos.Data.DbModels;

public class Compras
{
    public int id { get; set; }
    
    public DateTime Data { get; set; }
    
    public ICollection<Fotografias> ListaFotos { get; set; }
    
    [ForeignKey(nameof(Comprador))]
    public int CompradorId { get; set; }
    public Utilizadores Comprador { get; set; }
}