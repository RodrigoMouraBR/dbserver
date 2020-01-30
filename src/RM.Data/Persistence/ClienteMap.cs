using MongoDB.Bson.Serialization;
using RM.Domain.Entities;

namespace RM.Data.Persistence
{
    public class ClienteMap
    {
        public static void Configure()
        {
            BsonClassMap.RegisterClassMap<Cliente>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(x => x.Id);
                map.MapMember(x => x.Nome).SetIsRequired(true);
                map.MapMember(x => x.CPF).SetIsRequired(true);
             
            });
        }
    }
}
