using System;
using System.ComponentModel.DataAnnotations;

namespace Play.Catalog.Service.Dtos
{
    public record ItemDto(Guid Id, string name, string Description, decimal Price, DateTimeOffset CreateDate);

    public record CreateItemDto([Required(ErrorMessage = "O campo Nome é obrigatório.")] string Name, string Description, [Range(0, 1000, ErrorMessage = "O campo preço deve ter o valor entre 0 e 1000.")] decimal Price);

    public record UpdateItemDto([Required(ErrorMessage = "O campo Nome é obrigatório.")] string Name, string Description, [Range(0, 1000, ErrorMessage = "O campo preço deve ter o valor entre 0 e 1000.")] decimal Price);
}