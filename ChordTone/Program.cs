using ChordTone.Domains.Chords.Enums;
using ChordTone.Services;

while (true) 
{
    Console.WriteLine("コードネームを入力してください。");
    var chord = Parser.Parse(Console.ReadLine());

    var chordTones = chord.CodeTones();

    if (chordTones.Count == 3)
    {
        Console.WriteLine("構成音は、{0}、{1}、{2}です。", chordTones[0].GetString(), chordTones[1].GetString(), chordTones[2].GetString());
    } 
    else if (chordTones.Count == 4)
    {
        Console.WriteLine("構成音は、{0}、{1}、{2}、{3}です。", chordTones[0].GetString(), chordTones[1].GetString(), chordTones[2].GetString(), chordTones[3].GetString());
    }
}


