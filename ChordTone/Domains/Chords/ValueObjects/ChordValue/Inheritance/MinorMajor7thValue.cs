using ChordTone.Domains.Chords.Enums;
using ChordTone.Domains.Chords.ValueObjects.ChordValue;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// マイナーメジャーセブンスコードDTOクラス
    /// </summary>
    public class MinorMajor7thValue : ChordBaseValue
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public MinorMajor7thValue(Tone root) : base(root, Pitch.Minor, Pitch.Perfect, Pitch.Major)
        {
            Root = root;
        }
    }
}
