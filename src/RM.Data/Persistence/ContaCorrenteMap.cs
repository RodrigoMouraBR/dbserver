using MongoDB.Bson.Serialization;
using RM.Domain.Entities;

namespace RM.Data.Persistence
{
    public class ContaCorrenteMap
    {
        public static void Configure()
        {
            BsonClassMap.RegisterClassMap<ContaCorrente>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(x => x.Id);
                map.MapMember(x => x.Saldo).SetIsRequired(true);
                map.MapMember(x => x.Agencia).SetIsRequired(true);
                map.MapMember(x => x.NumeroConta).SetIsRequired(true);
                map.MapMember(x => x.ClienteId).SetIsRequired(true);
            });
        }
    }

}
