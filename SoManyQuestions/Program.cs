
var questions = new Question[] { 
    new StringQuestion("Hva heter du"),
    new IntQuestion("I hvilket år er du født"),
    new SelectQuestion("Hvor fornøyd er du på en skala fra 1 til 6"),
    new MultipleChoiceQuestion(),
};


// question 1
var question1 = "Hva heter du? ";
Console.Write(question1);
var answer1 = Console.ReadLine();
var isValid1 = answer1.Length >= 0;

// question 2
var question2 = "I hvilket år er du født? ";
Console.Write(question2);
var answer2Str = Console.ReadLine();
var isValid2 = int.TryParse(answer2Str, out int answer2) && answer2 > 1900;

// question 3
var question3 = "Hvor fornøyd er du på en skala fra 1 til 6? ";
Console.Write(question3);
var answer3Str = Console.ReadLine();
var isValid3 = int.TryParse(answer2Str, out int answer3) && answer3 >= 1 && answer3 <= 6;

// question 4
var options4 = new[] { "Ekstra bacon", "Ekstra ost", "Glutenfritt brød" };
var question4 = "Vi du ha noe ekstra (eks: 1,2)? \n"
    + string.Join("\n", options4.Select((t, i) => $"{i + 1}: {t}"));
Console.Write(question4);
var answer4Str = Console.ReadLine();
var partsStr4 = answer4Str.Split(',');
var partsInt4 = partsStr4.Select(s => Convert.ToInt32(s)).ToArray();
var isValid4 = partsInt4.All(n => n >= 1 && n <= options4.Length);

// question 5
var options5 = new[] { "Rød", "Grønn", "Blå" };
var question5 = "Vi du ha noe ekstra (eks: 1,2)? \n"
    + string.Join("\n", options5.Select((t, i) => $"{i + 1}: {t}"));
Console.Write(question4);
var answer5Str = Console.ReadLine();
var isValid5 = int.TryParse(answer5Str, out int answer5) && answer5 >= 1 && answer5 <= options5.Length;
