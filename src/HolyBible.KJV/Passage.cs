namespace HolyBible.KJV
{
  /// <summary>
  /// Represents a passage of scripture.
  /// </summary>
  public class Passage
  {
    /// <summary>
    /// Represents a book of the bible.
    /// </summary>
    public Book Book { get; set; }
    /// <summary>
    /// Represents a chapter of a book of the bible.
    /// </summary>
    public int Chapter { get; set; }
    /// <summary>
    /// Represents a verse of a chapter of a book of the bible.
    /// </summary>
    public int Verse { get; set; }
    /// <summary>
    /// Represents the text of a verse of a chapter of a book of the bible.
    /// </summary>
    public string Text { get; set; } = string.Empty;
  }
}