using MongoDB.Bson.Serialization;
using RM.Domain.Entities;

namespace RM.Data.Persistence
{

    public class TransacaoMap
    {
        public static void Configure()
        {
            BsonClassMap.RegisterClassMap<Transacao>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(x => x.Id);
                map.MapMember(x => x.CPFOrigem).SetIsRequired(true);
                map.MapMember(x => x.CPFDestino).SetIsRequired(true);
                map.MapMember(x => x.Data).SetIsRequired(true);
            });
        }
    }


}
