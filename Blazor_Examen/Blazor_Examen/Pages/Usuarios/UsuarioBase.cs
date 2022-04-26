namespace Blazor.Pages.Usuario
{
    internal class UsuarioBase
    {

        protected override async Task OnInitializedAsync()
        {
            usuariosLista = await _usuarioServicio.GetLista();
        }
    }
}