using Bycoders.Lib.Bycoders.Lib.Domain.Models;

namespace Bycoders.Domain.Infrastructure.Data.Model
{
    public class TypeTransaction : Entity
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public KindTransaction Kind { get; set; }
    }

    public enum KindTransaction
    {
        Input,
        Output
    }
}
