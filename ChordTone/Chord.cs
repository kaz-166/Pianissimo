using System.ComponentModel;

namespace ChordTone
{
    /// <summary>
    /// 和音クラス
    /// </summary>
    public class Chord
    {
        private Tone _key;

        private Pitch _third;

        private Pitch _fifth;

        private Pitch _seventh;   

        private List<Tone> _tone = [];

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="instractor">コード生成指示</param>
        public Chord(Instractor instractor)
        {
            _key = instractor.Root;
            _third = instractor.Third;
            _fifth = instractor.Fifth;
            _seventh = instractor.Seventh;
        }

        public List<Tone> CodeTones() 
        {
            // 長３和音
            if (_third == Pitch.Major &&
                _fifth == Pitch.Parfect &&
                _seventh == Pitch.Omit)
            {
                var list = MajorTriad();
                Console.WriteLine("構成音は、{0}、{1}、{2}です。", list[0].GetString(), list[1].GetString(), list[2].GetString());
                return list;
            }
            // 短３和音
            else if (_third == Pitch.Minor &&
                     _fifth == Pitch.Parfect &&
                     _seventh == Pitch.Omit)
            {
                var list = MinorTriad();
                Console.WriteLine("構成音は、{0}、{1}、{2}です。", list[0].GetString(), list[1].GetString(), list[2].GetString());
                return list;
            }
            // メジャーセブンス
            else if (_third == Pitch.Major &&
                     _fifth == Pitch.Parfect &&
                     _seventh == Pitch.Major) 
            {
                var list = Major7th();
                Console.WriteLine("構成音は、{0}、{1}、{2}、{3}です。", list[0].GetString(), list[1].GetString(), list[2].GetString(), list[3].GetString());
                return list;
            }
            // ドミナントセブンス
            else if (_third == Pitch.Major &&
                     _fifth == Pitch.Parfect &&
                     _seventh == Pitch.Minor)
            {
                var list = Dominant7th();
                Console.WriteLine("構成音は、{0}、{1}、{2}、{3}です。", list[0].GetString(), list[1].GetString(), list[2].GetString(), list[3].GetString());
                return list;
            }
            // マイナーセブンス
            else if (_third == Pitch.Minor &&
                     _fifth == Pitch.Parfect &&
                     _seventh == Pitch.Minor)
            {
                var list = Minor7th();
                Console.WriteLine("構成音は、{0}、{1}、{2}、{3}です。", list[0].GetString(), list[1].GetString(), list[2].GetString(), list[3].GetString());
                return list;
            }
            // マイナーセブンスフラットファイブ
            else if (_third == Pitch.Minor &&
                     _fifth == Pitch.Diminished &&
                     _seventh == Pitch.Minor)
            {
                var list = HalfDiminish();
                Console.WriteLine("構成音は、{0}、{1}、{2}、{3}です。", list[0].GetString(), list[1].GetString(), list[2].GetString(), list[3].GetString());
                return list;
            }
            // ディミニッシュ
            else if (_third == Pitch.Minor &&
                     _fifth == Pitch.Diminished &&
                     _seventh == Pitch.Diminished)
            {
                var list = Diminish();
                Console.WriteLine("構成音は、{0}、{1}、{2}、{3}です。", list[0].GetString(), list[1].GetString(), list[2].GetString(), list[3].GetString());
                return list;
            }

            return null;
        }

        /// <summary>
        /// 長三和音を返却するメソッド
        /// </summary>
        /// <returns>コードトーン</returns>
        private List<Tone> MajorTriad() 
        { 
            _tone.Clear();

            // ルート音
            _tone.Add(_key);

            // 長３度
            _tone.Add(_key.Get(4));

            // 完全５度
            _tone.Add(_key.Get(7));

            return _tone;
        }

        /// <summary>
        /// 短三和音を返却するメソッド
        /// </summary>
        /// <returns>コードトーン</returns>
        private List<Tone> MinorTriad()
        {
            _tone.Clear();

            // ルート音
            _tone.Add(_key);

            // 短３度
            _tone.Add(_key.Get(3));

            // 完全５度
            _tone.Add(_key.Get(7));

            return _tone;
        }

        /// <summary>
        /// 長七和音を返却するメソッド
        /// </summary>
        /// <returns>コードトーン</returns>
        private List<Tone> Major7th()
        {
            _tone.Clear();

            // ルート音
            _tone.Add(_key);

            // 長３度
            _tone.Add(_key.Get(4));

            // 完全５度
            _tone.Add(_key.Get(7));

            // 長７度
            _tone.Add(_key.Get(11));

            return _tone;
        }

        /// <summary>
        /// 属七和音を返却するメソッド
        /// </summary>
        /// <returns>コードトーン</returns>
        private List<Tone> Dominant7th()
        {
            _tone.Clear();

            // ルート音
            _tone.Add(_key);

            // 長３度
            _tone.Add(_key.Get(4));

            // 完全５度
            _tone.Add(_key.Get(7));

            // 短７度
            _tone.Add(_key.Get(10));

            return _tone;
        }

        /// <summary>
        /// 短七和音を返却するメソッド
        /// </summary>
        /// <returns>コードトーン</returns>
        private List<Tone> Minor7th()
        {
            _tone.Clear();

            // ルート音
            _tone.Add(_key);

            // 短３度
            _tone.Add(_key.Get(3));

            // 完全５度
            _tone.Add(_key.Get(7));

            // 短７度
            _tone.Add(_key.Get(10));

            return _tone;
        }

        /// <summary>
        /// 短七減五和音を返却するメソッド
        /// </summary>
        /// <remarks>
        /// マイナーセブンスフラットファイブまたはハーフディミニッシュとも呼称される
        /// </remarks>
        /// <returns>コードトーン</returns>
        private List<Tone> HalfDiminish()
        {
            _tone.Clear();

            // ルート音
            _tone.Add(_key);

            // 短３度
            _tone.Add(_key.Get(3));

            // 減５度
            _tone.Add(_key.Get(6));

            // 短７度
            _tone.Add(_key.Get(10));

            return _tone;
        }

        /// <summary>
        /// 減七減五和音を返却するメソッド
        /// </summary>
        /// <remarks>
        /// ディミニッシュとも呼称される
        /// </remarks>
        /// <returns>コードトーン</returns>
        private List<Tone> Diminish()
        {
            _tone.Clear();

            // ルート音
            _tone.Add(_key);

            // 短３度
            _tone.Add(_key.Get(3));

            // 減５度
            _tone.Add(_key.Get(6));

            // 減７度
            _tone.Add(_key.Get(9));

            return _tone;
        }
    }


    /// <summary>
    /// 音階の列挙型
    /// </summary>
    public enum Tone
    {
        C,
        CSharp,
        D,
        DSharp,
        E,
        F,
        FSharp,
        G,
        GSharp,
        A,
        ASharp,
        B,
        HiC
    }

    /// <summary>
    /// Tone列挙型拡張メソッド用静的クラス
    /// </summary>
    public static class ToneEnum 
    {
        /// <summary>
        /// 指定の度数差の音階を取得する拡張メソッド
        /// </summary>
        /// <param name="tone">this</param>
        /// <param name="interval">度数</param>
        /// <returns>〇度上(または下)の音階</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static Tone Get(this Tone tone, int interval) 
        {
            // いったんは〇度上のみを取得可能にする制限をつける
            // TODO: 負の度数(〇度下)にも対応
            if (interval < 0) throw new ArgumentOutOfRangeException();

            // 1オクターブ内に収まるように調整
            var ret = (tone + interval);
            while (ret > Tone.HiC)
            {
                ret -= Tone.HiC;
            }

            return ret;
        }

        /// <summary>
        /// 列挙型を楽譜記号に変換する拡張メソッド
        /// </summary>
        /// <param name="tone">this</param>
        /// <returns>楽譜記号</returns>
        /// <exception cref="InvalidEnumArgumentException">不正な列挙型の例外</exception>
        public static string GetString(this Tone tone) 
            => tone switch {
                Tone.C => "C",
                Tone.CSharp => "C#",
                Tone.D => "D",
                Tone.DSharp => "D#",
                Tone.E => "E",
                Tone.F => "F",
                Tone.FSharp => "F#",
                Tone.G => "G",
                Tone.GSharp => "G#",
                Tone.A => "A",
                Tone.ASharp => "A#",
                Tone.B => "B",
                Tone.HiC => "HiC",
                _ => throw new InvalidEnumArgumentException()};
        
    }
}
