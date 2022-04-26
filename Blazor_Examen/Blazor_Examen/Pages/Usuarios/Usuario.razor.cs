using Blazor_Examen.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelo;

namespace Blazor.Pages.Usuario;

partial class Usuario
{
    [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

   private IEnumerable<Usuarios> usuariosLista { get; set; }

    protected override async Task OnInitializedAsync()
    {
        usuariosLista = await _usuarioServicio.GetLista();
    }

}