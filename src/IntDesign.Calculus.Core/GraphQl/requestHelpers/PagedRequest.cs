namespace Calculus.Core.GraphQl.requestHelpers
{
    public class PagedRequest
    {
        public int Take { get; set; } = 100;

        public int Offset { get; set; }
    }
}