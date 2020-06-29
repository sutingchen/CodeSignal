using Xunit;
using CodeSignal.InterviewPractice;

namespace CodeSignal.Tests
{
    public class ArrayServiceTest
    {
        ArrayService _arrayService;

        public ArrayServiceTest()
        {
            _arrayService = new ArrayService();
        }

        [Theory]
        [InlineData("abacabad", 'c')]
        [InlineData("abacabaabacaba", '_')]
        [InlineData("z", 'z')]
        public void FirstNotRepeatingCharacter_ShouldWork(string input, char expected)
        {
            var actual = _arrayService.FirstNotRepeatingCharacter(input);

            Assert.Equal(expected, actual);
        }
    }
}