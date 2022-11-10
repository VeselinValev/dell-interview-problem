
string str1 = "dusty";
string str2 = "study";

string str3 = "taste";
string str4 = "state";

string str5 = "enjoyalgorithms";
string str6 = "enjoymathematics";

Console.WriteLine(CheckAnagram(str1, str2));
Console.WriteLine(CheckAnagram(str3, str4));
Console.WriteLine(CheckAnagram(str5, str6));

static bool CheckAnagram(string inputStr1, string inputStr2)
{
  string sortedString1 = SortString(inputStr1);
  string sortedString2 = SortString(inputStr2);

  return sortedString1.Equals(sortedString2);
}

static string SortString(string str)
{
  var strArr = str.ToArray();
  Array.Sort(strArr);

  return new string(strArr);
}