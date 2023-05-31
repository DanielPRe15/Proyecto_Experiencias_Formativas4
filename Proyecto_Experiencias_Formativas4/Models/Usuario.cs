using System;
using System.Collections.Generic;

namespace Proyecto_Experiencias_Formativas4.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nombre { get; set; }

    public string? Clave { get; set; }
}
