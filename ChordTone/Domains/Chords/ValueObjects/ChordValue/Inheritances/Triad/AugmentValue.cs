using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritances.Triad
{
    /// <summary>
    /// 増五和音　値オブジェクト
    /// </summary>
    public class AugmentValue : ChordBaseValue
    {
        /// <summary>
        /// 増五和音 値オブジェクト　コンストラクタ
        /// </summary>
        /// <param name="root"></param>
        /// <remarks>
        /// ルート・長三度・増五度
        /// </remarks>
        public AugmentValue(Tone root) : base(root, Pitch.Major, Pitch.Augmented, Pitch.Omit)
        {
            Root = root;
        }
    }
}
