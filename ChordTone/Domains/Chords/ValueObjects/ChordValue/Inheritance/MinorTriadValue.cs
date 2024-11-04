using ChordTone.Domains.Chords.Enums;
using ChordTone.Domains.Chords.ValueObjects.ChordValue;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// マイナースケールDTOクラス
    /// </summary>
    public class MinorTriadValue : ChordBaseValue
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public MinorTriadValue(Tone root) : base(root, Pitch.Minor, Pitch.Perfect, Pitch.Omit)
        {
            Root = root;
        }
    }
}
