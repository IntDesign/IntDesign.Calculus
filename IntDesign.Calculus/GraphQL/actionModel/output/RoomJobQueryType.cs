using Calculus.Core.Models.MainModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.output
{
    public class RoomJobQueryType : ObjectGraphType<RoomJob>
    {
        public RoomJobQueryType()
        {
            Field(t => t.Id, false, typeof(StringGraphType)).Description("RoomJob ID");
            Field(t => t.Type, false, typeof(StringGraphType)).Description("RoomJob type");
            Field(t => t.StartDate, false, typeof(StringGraphType)).Description("RoomJob Start Date");
            Field(t => t.FinishDate, false, typeof(StringGraphType)).Description("RoomJob Finish Date");
            Field(t => t.RoomId, false, typeof(StringGraphType)).Description("RoomJob Room Id");
        }
    }
}