namespace Vorti_Oh.Model.Mapper.Interfaces;

public interface IGeneralMapping
    <Type, CreateDto, UpdateDto, ReadDto, ReadDtoWithRelations>
{
    public Type ToModel(CreateDto dto);

    public Type ToUpdateModel(UpdateDto dto, Type type);

    public CreateDto ToCreateDto(UpdateDto dto);

    public ReadDtoWithRelations ToReadDtoCollection(Type type);

    public ICollection<ReadDto> ToReadDtoCollection(ICollection<Type> types);

}
