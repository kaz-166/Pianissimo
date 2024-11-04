using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// 増五和音　値オブジェクト
    /// </summary>
    public class AugmentValue : ChordBaseValue
    {
        // 増五和音 値オブジェクト　コンストラクタ
        public AugmentValue(Tone root) : base(root, Pitch.Major, Pitch.Augmented, Pitch.Omit)
        {
            Root = root;
        }
    }
}
