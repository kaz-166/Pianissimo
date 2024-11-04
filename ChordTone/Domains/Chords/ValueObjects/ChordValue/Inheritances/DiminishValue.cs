using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// 減七和音　値オブジェクト
    /// </summary>
    public class DiminishValue : ChordBaseValue
    {
        /// <summary>
        /// 減七和音　値オブジェクト　コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public DiminishValue(Tone root) : base(root, Pitch.Minor, Pitch.Diminished, Pitch.Diminished)
        {
            Root = root;
        }
    }
}
