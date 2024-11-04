using ChordTone.Domains.Chords.Enums;
using ChordTone.Domains.Chords.ValueObjects.ChordValue;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// メジャースケールDTOクラス
    /// </summary>
    public class MajorTriadValue : ChordBaseValue
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public MajorTriadValue(Tone root) : base(root, Pitch.Major, Pitch.Perfect, Pitch.Omit)
        {
            Root = root;
        }
    }
}
