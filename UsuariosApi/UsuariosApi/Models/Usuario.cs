using Microsoft.AspNetCore.Identity;

namespace UsuariosApi.Models;

public class Usuario: IdentityUser
{
	// Herda todas as propriedades do IdentityUser
	public DateTime DataNascimento { get; set; }

	public Usuario() : base()
	{

	}
}
