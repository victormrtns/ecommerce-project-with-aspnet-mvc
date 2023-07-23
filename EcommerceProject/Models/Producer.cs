using System.ComponentModel.DataAnnotations;

namespace EcommerceProject.Models
{
    //Aqui eu coloco todas as minhas propriedades, nesse caso:
    //Cada propriedade nesse caso, é uma coluna na minha database
    // Foto de perfil, nome completo e biografia
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

    }
}
