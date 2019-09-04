using System;

namespace Calculus.Core.Models.GraphQl.filters
{
    public interface IIdentifier
    {
        Guid Id { get; set; }
    }
}