using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue
{
    /// <summary>
    /// 和音基底クラス
    /// </summary>
    public class ChordBaseValue
    {
        /// <summary>
        /// ルート音程
        /// </summary>
        public Tone Root { get; protected set; }

        /// <summary>
        /// ３度音程
        /// </summary>
        public Pitch Third { get; }

        /// <summary>
        /// ５度音程
        /// </summary>
        public Pitch Fifth { get; }

        /// <summary>
        /// ７度音程
        /// </summary>
        public Pitch Seventh { get; }

        /// <summary>
        /// コードトーン
        /// </summary>
        private List<Tone> _tone = [];

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音程</param>
        /// <param name="third">３度音程</param>
        /// <param name="fifth">５度音程</param>
        /// <param name="seventh">７度音程</param>
        public ChordBaseValue(Tone root, Pitch third, Pitch fifth, Pitch seventh)
        {

            Root = root;
            Third = third;
            Fifth = fifth;
            Seventh = seventh;

            // ルート音
            _tone.Add(Root);

            // ３度
            switch (Third)
            {
                case Pitch.Major:
                    _tone.Add(Root.Get(4));
                    break;
                case Pitch.Minor:
                    _tone.Add(Root.Get(3));
                    break;
            }

            // ５度
            switch (Fifth)
            {
                case Pitch.Perfect:
                    _tone.Add(Root.Get(7));
                    break;
                case Pitch.Diminished:
                    _tone.Add(Root.Get(6));
                    break;
                case Pitch.Augmented:
                    _tone.Add(Root.Get(8));
                    break;
            }

            // ７度
            switch (Seventh)
            {
                case Pitch.Major:
                    _tone.Add(Root.Get(11));
                    break;
                case Pitch.Minor:
                    _tone.Add(Root.Get(10));
                    break;
                case Pitch.Diminished:
                    _tone.Add(Root.Get(9));
                    break;
                case Pitch.Omit:
                    break;
            }
        }

        /// <summary>
        /// コードトーンを取得する
        /// </summary>
        /// <returns>コードトーン</returns>
        public List<Tone> CodeTones() => _tone;
    }
}
