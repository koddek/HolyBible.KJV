using System;
using System.Collections.Generic;

namespace HolyBible.KJV
{
  public class Bible
  {
    public string Name => "King James Version (KJV)";
    public int Version => 1769;

    public List<Passage> Passages { get; } = new List<Passage>();

    /// <summary>
    /// Find all passages of a book of the bible.
    /// </summary>
    /// <param name="book">The book.</param>
    /// <returns></returns>
    public IEnumerable<Passage> Find(Book book) =>
      Passages.FindAll(p => p.Book == book);

    /// <summary>
    /// Find all passages of a chapter of a book of the bible.
    /// </summary>
    /// <param name="book">The book.</param>
    /// <param name="chapter">The chapter.</param>
    /// <returns></returns>
    public IEnumerable<Passage> Find(Book book, int chapter) =>
      Passages.FindAll(p => p.Book == book && p.Chapter == chapter);

    /// <summary>
    /// Find a <see cref="Passage"/> of scripture.
    /// </summary>
    /// <param name="book">The book of the bible.</param>
    /// <param name="chapter">The chapter.</param>
    /// <param name="verse">The verse</param>
    /// <returns></returns>
    public Passage Find(Book book, int chapter, int verse) =>
      Passages.Find(p => p.Book == book && p.Chapter == chapter && p.Verse == verse);

    /// <summary>
    /// Find all passages in the bible that contains a word or phrase, case sensitive or not. 
    /// </summary>
    /// <param name="filter">The word or phrase</param>
    /// <param name="ignoreCase">Ignore the case or not?</param>
    /// <returns></returns>
    public IEnumerable<Passage> Find(string filter, bool ignoreCase = true)
    {
      foreach (var passage in Passages)
        if (ignoreCase && passage.Text.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
          yield return passage;
        else if (passage.Text.Contains(filter))
          yield return passage;
    }
  }
}