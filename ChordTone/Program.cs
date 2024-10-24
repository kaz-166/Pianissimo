// See https://aka.ms/new-console-template for more information
using ChordTone;

var input = "E";

var param = Parser.Parse(input);

var chord = new Chord(Parser.Parse(input));

// TODO: このロジックはChordクラスに閉じ込める
if (param.Third == Pitch.Major && 
    param.Fifth == Pitch.Parfect &&
    param.Seventh == Pitch.Omit) 
{
    var list = chord.MajorTriad();
    Console.WriteLine("構成音は、{0}、{1}、{2}です。", list[0], list[1], list[2]);
}

