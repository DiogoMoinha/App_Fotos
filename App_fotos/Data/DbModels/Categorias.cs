namespace App_fotos.Data.DbModels;

public class Categorias
{
    public int Id { get; set; }
    
    public string Categoria { get; set; }
    
    public ICollection<Fotografias> ListaFotos { get; set; }
}