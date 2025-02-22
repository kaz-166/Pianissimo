using ChordTone.Domains.Chords.Enums;
using ChordTone.Services;

while (true) 
{
    List<Tone>? chordTones;
    var _ = new List<Tone>();

    Console.WriteLine("コードネームを入力してください。");
    try
    {
        chordTones = Parser.Parse(Console.ReadLine()).CodeTones();
    }
    catch
    {
        break;
    }
   
    // 三和音
    if (chordTones.Count == 3)
    {
        Console.WriteLine("構成音は、{0}、{1}、{2}です。", 
            chordTones[0].GetString(), 
            chordTones[1].GetString(),
            chordTones[2].GetString());
    } 
    // 四和音
    else if (chordTones.Count == 4)
    {
        Console.WriteLine("構成音は、{0}、{1}、{2}、{3}です。",
            chordTones[0].GetString(), 
            chordTones[1].GetString(), 
            chordTones[2].GetString(),
            chordTones[3].GetString());
    }
    // テンションコード
    else if (chordTones.Count == 5)
    {
        Console.WriteLine("構成音は、{0}、{1}、{2}、{3}、{4}です。",
            chordTones[0].GetString(),
            chordTones[1].GetString(),
            chordTones[2].GetString(),
            chordTones[3].GetString(),
            chordTones[4].GetString());
    }
}


