using NUnit.Framework;
using WEXtesting;

namespace Test
{
    public class Testing
    {
        [Test, Description("should handle the empty string")]
        public void ShouldHandleEmptyString()
        {
            Assert.True(Characters.HasUniqueChars(""));
        }

        [Test, Description("should handle a single letter")]
        public void ShouldHandleSingleLetter()
        {
            Assert.True(Characters.HasUniqueChars("a"));
        }

        [Test, Description("should handle two unique letters")]
        public void ShouldHandleTwoUniqueLetters()
        {
            Assert.True(Characters.HasUniqueChars("ab"));
        }

        [Test, Description("should handle two of the same letter with different cases")]
        public void ShouldHandleTwoUniqueLettersWithCase()
        {
            Assert.True(Characters.HasUniqueChars("aA"));
        }

        [Test, Description("should handle more than two unique characters")]
        public void ShouldHandleMoreThanTwoUniqueCharacters()
        {
            Assert.True(Characters.HasUniqueChars("abcdefg"));
        }

        [Test, Description("should handle two non-unique letters")]
        public void ShouldHandleTwoNonUniqueLetters()
        {
            Assert.False(Characters.HasUniqueChars("aa"));
        }

        [Test, Description("should handle two non-unique characters")]
        public void ShouldHandleTwoNonUniqueCharacters()
        {
            Assert.False(Characters.HasUniqueChars("  "));
        }

        [Test, Description("should handle more than two non-unique characters")]
        public void ShouldHandleMoreThanTwoNonUniqueCharacters()
        {
            Assert.False(Characters.HasUniqueChars("abbcdefg"));
        }
    }
}
