using System.ComponentModel.DataAnnotations;

namespace EcommerceProject.Models
{

    //Aqui eu coloco todas as minhas propriedades, nesse caso:
    //Cada propriedade nesse caso, é uma coluna na minha database
    // Logo, nome completo e descricao
    public class Cinema
    {

        [Key]
        public int Id { get; set; }
        public string Logo{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
