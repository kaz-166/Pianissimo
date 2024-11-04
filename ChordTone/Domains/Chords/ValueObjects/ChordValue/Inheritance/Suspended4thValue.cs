using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    // Sus4和音 値オブジェクト
    public class Suspended4thValue : ChordBaseValue
    {
        // Sus4和音 値オブジェクト　コンストラクタ
        public Suspended4thValue(Tone root) : base(root, Pitch.Augmented, Pitch.Perfect, Pitch.Omit)
        {
            Root = root;
        }
    }
}
