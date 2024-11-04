using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// Sus4和音 値オブジェクト
    /// </summary>
    public class Suspended4thValue : ChordBaseValue
    {
        /// <summary>
        /// Sus4和音 値オブジェクト　コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public Suspended4thValue(Tone root) : base(root, Pitch.Augmented, Pitch.Perfect, Pitch.Omit)
        {
            Root = root;
        }
    }
}
