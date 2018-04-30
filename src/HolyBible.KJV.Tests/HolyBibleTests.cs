using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace HolyBible.KJV.Tests
{
  public class HolyBibleTests
  {
    readonly ITestOutputHelper _output;
    readonly Bible _bible;

    public HolyBibleTests(ITestOutputHelper output)
    {
      _output = output;
      _bible = BibleFactory.GetBible();
    }

    [Fact]
    public void Bible_FindGenesisOneOne_ReturnsCorrectText()
    {
      var actual = _bible.Find(Book.Genesis, 1, 1);
      var expected = "In the beginning God created the heaven and the earth.";
      _output.WriteLine(actual.Text);
      Assert.Equal(expected, actual.Text);
    }

    [Fact]
    public void BibleFindPhraseKingdomOfGod_ReturnsSixtyNineResults()
    {
      var actual = _bible.Find("kingdom of god").Count();
      _output.WriteLine(actual.ToString());
      Assert.Equal(69, actual);
    }

    [Fact]
    public void BibleFindWordRepent_ReturnsOneHundredAndFive()
    {
      var actual = _bible.Find("repent").Count();
      _output.WriteLine(actual.ToString());
      Assert.Equal(105, actual);
    }

    [Fact]
    public void BibleFindPhrase_ReturnsThree()
    {
      var actual = _bible.Find("seventh day is the sabbath");
      var passages = actual.ToList();
      foreach (var passage in passages)
      {
        _output.WriteLine(passage.Book.ToString());
        _output.WriteLine(passage.Chapter.ToString());
        _output.WriteLine(passage.Verse.ToString());
        _output.WriteLine(passage.Text);
      }

      Assert.Equal(3, passages.Count);
    }
  }
}