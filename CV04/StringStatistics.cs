using System.Text.RegularExpressions;
public class StringStatistics
{
  string text;
  string ClearText;
  public StringStatistics(string text)
  {
    this.text = text;
    ClearText = text.Replace(".", "").Replace(",", "")
      .Replace("?", "").Replace("!", "")
      .Replace("\n", " ").Replace("(", "").Replace(")", "");
  }

  public int CountOfWords()
  {
    var count = ClearText.Split(' ').Length;

    return count;
  }

  public int CountOfLines()
  {
    var count = text.Split('\n').Length;

    return count;
  }

  public int CountOfSentences()
  {
    var st = text.Replace("\n", " ").Replace(",", "").Replace("\n", " ").Replace("(", "").Replace(")", "");
    string[] splitSentences = Regex.Split(st, @"(?<=['""A-Za-z0-9][\.\!\?])\s+(?=[A-Z])"); // <-- Analyza string, aby program zjistil, kde probehne Split. ASCII Table

    return splitSentences.Length;
  }

  public List<string> LongestWords()
  {
    string[] stringOfWords = ClearText.Split(' ');

    var ordered = stringOfWords.OrderBy(x => x.Length).ToList<string>();
    ordered.Reverse();
    var finalList = new List<string>();
    var length = 0;
    foreach (var word in ordered)
    {
      if (word.Length >= length)
      {
        length = word.Length;
        finalList.Add(word);
      }
    }

    return finalList;
  }

  public List<string> ShortestWords()
  {
    string[] stringOfWords = ClearText.Split(' ');

    var ordered = stringOfWords.OrderBy(x => x.Length).ToList();

    var finalList = new List<string>();
    var length = 10000;
    foreach (var word in ordered)
    {
      if (word.Length <= length)
      {
        length = word.Length;
        finalList.Add(word);
      }
    }

    return finalList;
  }

  public string[] OftenWords()
  {
    string[] stringOfWords = ClearText.Split(' ');
    var GroupName = stringOfWords.GroupBy(x => x);
    var maxCount = GroupName.Max(g => g.Count());
    var mostCommons = GroupName.Where(x => x.Count() == maxCount).Select(x => x.Key).ToArray();

    return mostCommons;
  }

  public List<string> Alphabet()
  {
    string[] stringOfWords = ClearText.Split(' ');

    var list = new List<string>();
    foreach (var word in stringOfWords)
    {
      list.Add(word);
    }
    list.Sort();
    return list;
  }
}