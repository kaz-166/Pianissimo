using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// 導七和音　値オブジェクト
    /// </summary>
    public class HalfDiminishValue : ChordBaseValue
    {
        /// <summary>
        /// 導七和音　値オブジェクト　コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        /// <remarks>
        /// ルート・短三度・減五度・短七度
        /// </remarks>
        public HalfDiminishValue(Tone root) : base(root, Pitch.Minor, Pitch.Diminished, Pitch.Minor)
        {
            Root = root;
        }
    }
}
