using ChordTone.Domains.Chords.Enums;
using ChordTone.Domains.Chords.ValueObjects.ChordValue;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// マイナーセブンスフラットファイブDTOクラス
    /// </summary>
    public class HalfDiminishValue : ChordBaseValue
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public HalfDiminishValue(Tone root) : base(root, Pitch.Minor, Pitch.Diminished, Pitch.Minor)
        {
            Root = root;
        }
    }
}
