using NUnit.Framework;

namespace Testing
{
    public static class TestHelper
    {
        public static void That(bool condition, string message, params object[] args)
        {
            Assert.That(condition, Is.True, message, args);
        }
    }
}
