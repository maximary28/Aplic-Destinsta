namespace lp4.Shared.Requests;
//Representara la estructura de datos del usuario.( La Tabla en la BD).

public class UsuarioRequests
{
   

    public int Id { get; set; }

     public int UsuarioRolId { get; set; }

    public string Name { get; set; } = null!;

    public string Nickname { get; set; } = null!;

    public string Password { get; set; } = null!;

}
