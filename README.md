# HolyBible.KJV

![GitHub license](https://img.shields.io/github/license/codedek/HolyBible.KJV.svg)
![GitHub release](https://img.shields.io/github/release/codedek/HolyBible.KJV.svg)
![GitHub All Releases](https://img.shields.io/github/downloads/codedek/holybible.kjv/total.svg)



---------------------------------------
# Description
This is the complete searchable Holy Bible James Version (KJV) written in C# as a library for use in any .net project. The KJV bible database used was taken from http://biblehub.com.

See the [change log](CHANGELOG.md) for changes and road map.

## Features

- Find a Passage of scripture.
  ```csharp
  Bible bible = BibleFactory.GetBible();
  var passage bible.Find(Book.Genesis, 1, 1);
  passage.Book.Dump();
  // Genesis
  passage.Chapter.Dump();
  // 1
  passage.Verse.Dump();
  // 1
  passage.Text.Dump();
  // In the beginning God created the heaven and the earth.
  ```
- Find any bible verse that contains a word or phrase.
  ```csharp
  Bible bible = BibleFactory.GetBible();
  var passages bible.Find("sons of god");
  passages.Count().Dump();
  // 11

  var passages bible.Find("god created man");
  passages.Count().Dump();
  // 3

  var passages bible.Find("the seventh day is the sabbath");
  passages.Count().Dump();
  // 3

  var passages bible.Find("repent");
  passages.Count().Dump();
  // 105
  ```

## License
[MIT](LICENSE)
