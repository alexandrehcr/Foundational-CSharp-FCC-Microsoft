// https://learn.microsoft.com/en-us/training/modules/csharp-modify-content/5-exercise-challenge-extract-replace-remove-data

// Expected output:
// Quantity: 5000
// Output: <h2>Widgets &reg;</h2><span>5000</span>

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string openSpan = "<span>";
const string closeSpan = "</span>";
int quantityStart = input.IndexOf(openSpan) + openSpan.Length;
int quantityLength = input.IndexOf(closeSpan) - quantityStart;
quantity = "Quantity: " + input.Substring(quantityStart, quantityLength);

const string openDiv = "<div>";
const string closeDiv = "</div>";
int divContentStart = input.IndexOf(openDiv) + openDiv.Length;
int divContentLength = input.IndexOf(closeDiv) - divContentStart;
output = "Output: " + input.Substring(divContentStart, divContentLength);

const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = output.Replace(tradeSymbol, regSymbol);

Console.WriteLine(quantity);
Console.WriteLine(output);
