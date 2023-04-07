// See https://aka.ms/new-console-template for more information

namespace Program
{
    //con genericos

    public class GenericService<TEntitty, TDto>
        where TDto : class
        where TEntitty : class
    {
        public delegate TDto Mapper(TEntitty t);
        private readonly Func<TEntitty, TDto> MapperFunc;

        public GenericService(Func<TEntitty,TDto> mapper)
        {
            MapperFunc = mapper;
            
        }

        public Entity CreateEntity()
        {
            return new Entity()
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                Name = "New Entity",
            };
        }

        public TDto toDTO(TEntitty t)
        {
           return  MapperFunc.Invoke(t);
        }
    }
}