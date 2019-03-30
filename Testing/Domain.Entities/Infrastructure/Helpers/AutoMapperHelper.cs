using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Domain.Entities.Infrastructure
{
    public static class AutoMapperHelper
    {
        public static TResult MapperConfiguration<TEntity, TResult>(TEntity entity) {
            var config = new MapperConfiguration(
                   cfg =>
                   {
                       cfg.CreateMap<TEntity, TResult>();
                   });
            IMapper mapper = config.CreateMapper();
            var destination = mapper.Map<TEntity, TResult>(entity);
            return destination;
        }
    }
}
