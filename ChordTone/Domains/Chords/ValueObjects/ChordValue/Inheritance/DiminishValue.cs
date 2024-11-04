using ChordTone.Domains.Chords.Enums;
using ChordTone.Domains.Chords.ValueObjects.ChordValue;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// DiminishコードDTOクラス
    /// </summary>
    public class DiminishValue : ChordBaseValue
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public DiminishValue(Tone root) : base(root, Pitch.Minor, Pitch.Diminished, Pitch.Diminished)
        {
            Root = root;
        }
    }
}
