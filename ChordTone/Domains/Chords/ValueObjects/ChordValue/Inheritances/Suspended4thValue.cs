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
        /// /// <remarks>
        /// ルート・完全四度・完全五度
        /// 和音の定義上は上記ですが、実装上の都合から完全四度を増三度とみなし、
        /// ルート・増三度・完全五度としています。
        /// </remarks>
        public Suspended4thValue(Tone root) : base(root, Pitch.Augmented, Pitch.Perfect, Pitch.Omit)
        {
            Root = root;
        }
    }
}
