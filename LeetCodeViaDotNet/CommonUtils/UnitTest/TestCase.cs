namespace CommonUtils.UnitTest
{
    // <summary>
    /// A Reusable Test Model
    /// </summary>
    public class TestCase
    {
        public bool IsValid { get; set; }
        public object[] _parameters { get; set; }

        public TestCase(object[] parameters)
        {
            _parameters = parameters;
        }

        
    }
}