
using ChordTone;
while (true) 
{
    Console.WriteLine("コードネームを入力してください。");
    var input = Console.ReadLine();

    var chord = new Chord(Parser.Parse(input));

    chord.CodeTones();
}


