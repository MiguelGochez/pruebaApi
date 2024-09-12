using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EjemploWebApi.Models;

public partial class Producto
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Fecha { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Precio { get; set; }
}
