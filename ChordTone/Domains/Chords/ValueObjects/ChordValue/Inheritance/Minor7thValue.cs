using ChordTone.Domains.Chords.Enums;
using ChordTone.Domains.Chords.ValueObjects.ChordValue;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// マイナーセブンスDTOクラス
    /// </summary>
    public class Minor7thValue : ChordBaseValue
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public Minor7thValue(Tone root) : base(root, Pitch.Minor, Pitch.Perfect, Pitch.Minor)
        {
            Root = root;
        }
    }
}
