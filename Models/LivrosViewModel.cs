using BookStockMvc.Models.Enuns;

namespace BookStockMvc.Models
{
    public class LivrosViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Gênero { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public RegistroLivroEnum RegistroLivro { get; set; }
        public int? UsuarioId { get; set; }
        //public Usuario? Usuario { get; set; }
        public byte[]? FotoLivro { get; set; }
    }
}