namespace ChordTone
{
    public static class Parser
    {
        public static Instractor Parse(string chordName)
        {
            // 1文字目～2文字目：ルート音
            // TODO: かなりゴリ押しでいくので、あとでスマートな形にリファクタする
            var root = chordName[0..1] switch
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

            // ２文字目に臨時記号がついていた場合の処理
            if (chordName[1..2].Equals("#")) 
            {
                // 半音上げる
                if (root != Tone.E && root != Tone.B)
                {
                    root = root.Get(1);
                }
                else 
                {
                    throw new InvalidDataException("その音階には#の臨時記号をつけることはできません。");
                }
                
            }
            // TODO: ♭の処理

            // TODO: ３度の長短の判定

            // TODO: セブンスコードの判定
            
            return new Instractor(root, Pitch.Major, Pitch.Parfect, Pitch.Omit);
        }
    }
}
