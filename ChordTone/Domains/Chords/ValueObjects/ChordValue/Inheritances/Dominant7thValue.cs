using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// 属七和音　値オブジェクト
    /// </summary>
    public class Dominant7thValue : ChordBaseValue
    {
        /// <summary>
        /// 属七和音　値オブジェクト　コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        /// <remarks>
        /// ルート・短三度・減五度・減七度
        /// </remarks>
        public Dominant7thValue(Tone root) : base(root, Pitch.Major, Pitch.Perfect, Pitch.Minor)
        {
            Root = root;
        }
    }
}
