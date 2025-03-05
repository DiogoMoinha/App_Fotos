using System.ComponentModel.DataAnnotations.Schema;

namespace App_fotos.Data.DbModels;

public class Fotografias
{
    public int Id { get; set; }
    
    public string Titulo { get; set; }
    
    public string Descricao { get; set; }
    
    public string Ficheiro { get; set; }
    
    public DateTime DataFotografia { get; set; }
    
    public decimal Preco { get; set; }
    
    //FK para Utilizador
    [ForeignKey(nameof(Utilizador))]
    public int UtilizadorId { get; set; }
    public Utilizadores Utilizador { get; set; }
    
    // FK para Categoria 
    [ForeignKey(nameof(Categoria))]
    public int CategoriaId { get; set; }
    public Categorias Categoria { get; set; }
    
    // many to many -> Gostos
    public ICollection<Gostos> ListaGostos { get; set; }
    
    // many to many -> Compras
    public ICollection<Compras> ListaCompras { get; set; }
}