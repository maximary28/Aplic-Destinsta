
using System.ComponentModel.DataAnnotations;
using lp4.Shared.Requests;

namespace LP4.Server.Models;
//Representara la estructura de datos del usuario.( La Tabla en la BD).

public class Usuario
{
    [Key]

    public int Id { get; set; }

     public int UsuarioRolId { get; set; }

     public UsuarioRol UsuarioRol { get; set; } = default!;

    public string Name { get; set; } = null!;

    public string Nickname { get; set; } = null!;

    public string Password { get; set; } = null!;

    public static Usuario Crear (UsuarioRequests requests)
    {    
        return new Usuario()
        { 

            UsuarioRolId = requests.UsuarioRolId,
            Name = requests.Name,
            Nickname= requests.Nickname,
            Password = requests.Password,

         };

    }
    public void Editar(UsuarioRequests requests)
    { 
            UsuarioRolId = requests.UsuarioRolId;
            Name = requests.Name;
            Nickname= requests.Nickname;
            Password = requests.Password;

    }

}
