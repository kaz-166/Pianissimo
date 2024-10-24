namespace ChordTone
{
    /// <summary>
    /// 和音クラス
    /// </summary>
    public class Chord
    {
        private Tone _key;

        private List<Tone> _tone = [];

        public Chord(Instractor instractor)
        {
            _key = instractor.Root;
        }

        /// <summary>
        /// 長三和音を返却するメソッド
        /// </summary>
        /// <returns>コードトーン</returns>
        public List<Tone> MajorTriad() 
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
        public List<Tone> MinorTriad()
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
        public List<Tone> Major7th()
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
        public List<Tone> Dominant7th()
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
        public List<Tone> Minor7th()
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
        public List<Tone> HalfDiminish()
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
        public List<Tone> Diminish()
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
            while (tone + interval > Tone.HiC)
            {
                ret -= Tone.HiC;
            }

            return ret;
        }
    }
}
