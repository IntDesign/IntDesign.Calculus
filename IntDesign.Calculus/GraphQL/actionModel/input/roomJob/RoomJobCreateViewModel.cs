using Calculus.Core.Models.GraphQl.enums;
using Calculus.Core.Models.MainModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.roomJob
{
    public class RoomJobCreateViewModel : InputObjectGraphType<RoomJob>
    {
        public RoomJobCreateViewModel()
        {
            Field(t => t.StartDate, true, typeof(DateTimeGraphType))
                .Description("The date this job will start");
            Field(t => t.FinishDate, true, typeof(DateTimeGraphType))
                .Description("The date this job will be finished");
            Field(t => t.Type, false, typeof(NonNullGraphType<JobRequestTypeEnum>))
                .Description("The type of the job that will ne applied on the room");
            Field(t => t.RoomId, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("The room id of the room that contains this job");
        }
    }
}