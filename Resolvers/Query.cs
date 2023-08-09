namespace SortInputObjectIssue.Models
{
    public class Query
    {
        public IEnumerable<Result> GetResult() =>
            Enumerable.Repeat<Result>(new()
            {
                Value = new EncodedString("value")
            }, 10);
    }
}