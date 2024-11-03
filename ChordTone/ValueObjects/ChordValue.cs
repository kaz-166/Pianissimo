using ChordTone.DTOs;
using ChordTone.Enums;

namespace ChordTone.ValueObjects
{
    /// <summary>
    /// 和音値オブジェクト
    /// </summary>
    /// <param name="instractor">コード構成</param>
    public class ChordValue
    {
        private Tone _key;

        private Pitch _third;

        private Pitch _fifth;

        private Pitch _seventh;

        private List<Tone> _tone = [];

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="elem">コード構成音</param>
        public ChordValue(ChordElementDto elem)
        {
            _key = elem.Root;
            _third = elem.Third;
            _fifth = elem.Fifth;
            _seventh = elem.Seventh;

            // ルート音
            _tone.Add(_key);

            // ３度
            switch (_third)
            {
                case Pitch.Major:
                    _tone.Add(_key.Get(4));
                    break;
                case Pitch.Minor:
                    _tone.Add(_key.Get(3));
                    break;
                    ;
            }

            // ５度
            switch (_fifth)
            {
                case Pitch.Perfect:
                    _tone.Add(_key.Get(7));
                    break;
                case Pitch.Diminished:
                    _tone.Add(_key.Get(6));
                    break;
                case Pitch.Augmented:
                    _tone.Add(_key.Get(8));
                    break;
            }

            // ７度
            switch (_seventh)
            {
                case Pitch.Major:
                    _tone.Add(_key.Get(11));
                    break;
                case Pitch.Minor:
                    _tone.Add(_key.Get(10));
                    break;
                case Pitch.Diminished:
                    _tone.Add(_key.Get(9));
                    break;
                case Pitch.Omit:
                    break;
            }

        }

        /// <summary>
        /// コードトーンを取得するメソッド
        /// </summary>
        /// <returns>コードトーン</returns>
        public List<Tone> CodeTones() => _tone;

    }
}
