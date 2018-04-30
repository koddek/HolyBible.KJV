using System;
using System.Collections.Generic;

namespace HolyBible.KJV
{
  public class Bible
  {
    public string Name => "King James Version (KJV)";
    public int Version => 1769;

    public List<Passage> Passages { get; } = new List<Passage>();

    public Passage Find(Book book, int chapter, int verse) =>
      Passages.Find(p => p.Book == book && p.Chapter == chapter && p.Verse == verse);

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