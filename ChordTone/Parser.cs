namespace ChordTone
{
    public static class Parser
    {
        public static Instractor Parse(string chordName)
        {
            int ind = 0;
            // 1文字目～2文字目：ルート音
            // TODO: かなりゴリ押しでいくので、あとでスマートな形にリファクタする
            var root = chordName[ind..(ind + 1)] switch
            {
                "C" => Tone.C,
                "D" => Tone.D,
                "E" => Tone.E,
                "F" => Tone.F,
                "G" => Tone.G,
                "A" => Tone.A,
                "B" => Tone.B,
                _ => throw new InvalidDataException("不正な音階名が指定されています。")
            };
            ind++;

            // ２文字目に臨時記号がついていた場合の処理
            if (chordName.Length >= ind + 1 && chordName[ind..(ind + 1)].Equals("#")) 
            {
                // 半音上げる
                if (root != Tone.E && root != Tone.B)
                {
                    root = root.Get(1);
                    ind++;
                }
                else 
                {
                    throw new InvalidDataException("その音階には#の臨時記号をつけることはできません。");
                }
                
            }
            // TODO: ♭の処理

            
            Instractor instractor;
            if (chordName.Length < ind + 1) 
            {
                instractor = new Instractor(root, Pitch.Major, Pitch.Parfect, Pitch.Omit);
            }
            else if (chordName.Length == ind + 1 && chordName[ind..(ind + 1)].Equals("m"))
            {
                instractor = new Instractor(root, Pitch.Minor, Pitch.Parfect, Pitch.Omit);
            }
            else if (chordName.Length == ind + 1 && chordName[ind..(ind + 1)].Equals("7"))
            {
                instractor = new Instractor(root, Pitch.Major, Pitch.Parfect, Pitch.Minor);
            }
            else if (chordName.Length == ind + 2 && chordName[ind..(ind + 2)].Equals("m7"))
            {
                instractor = new Instractor(root, Pitch.Minor, Pitch.Parfect, Pitch.Minor);
            }
            else if (chordName.Length == ind + 2 && chordName[ind..(ind + 2)].Equals("M7"))
            {
                instractor = new Instractor(root, Pitch.Major, Pitch.Parfect, Pitch.Major);
            }
            else if (chordName.Length == ind + 4 && chordName[ind..(ind + 4)].Equals("Maj7"))
            {
                instractor = new Instractor(root, Pitch.Major, Pitch.Parfect, Pitch.Major);
            }
            else if (chordName.Length == ind + 3 && chordName[ind..(ind + 3)].Equals("mM7"))
            {
                instractor = new Instractor(root, Pitch.Minor, Pitch.Parfect, Pitch.Major);
            }
            else if (chordName.Length == ind + 4 && chordName[ind..(ind + 4)].Equals("m7-5"))
            {
                instractor = new Instractor(root, Pitch.Minor, Pitch.Diminished, Pitch.Minor);
            }
            else if (chordName.Length == ind + 4 && chordName[ind..(ind + 4)].Equals("m7b5"))
            {
                instractor = new Instractor(root, Pitch.Minor, Pitch.Diminished, Pitch.Minor);
            }
            else if (chordName.Length == ind + 3 && chordName[ind..(ind + 3)].Equals("dim"))
            {
                instractor = new Instractor(root, Pitch.Minor, Pitch.Diminished, Pitch.Diminished);
            }
            else
            {
                throw new ArgumentException("構文エラーです。");
            }

            return instractor;
        }
    }
}
