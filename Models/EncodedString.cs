namespace SortInputObjectIssue.Models
{
    /// <summary>
    /// This model mimics an external interface, with matching implementation.
    /// </summary>
    public interface IEncodedString
    {
        string GetValue();
    }

    public class EncodedString : IEncodedString
    {
        /// <summary>
        /// Implementation is irrelavent.
        /// </summary>
        private string Value { get; } = string.Empty;
        
        public EncodedString(string value)
            => this.Value = value;

        public string GetValue() => this.Value;
    }
}