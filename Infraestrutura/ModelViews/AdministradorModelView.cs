using minimal_api.Dominio.Enums;

namespace minimal_api.Infraestrutura.ModelViews
{
    public record AdministradorModelView
    {
        public int Id { get; set; } = default;
        public string Email { get; set; } = default;
        public Perfil? Perfil { get; set; } = default;
    }
}