using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// 短七和音　値オブジェクト
    /// </summary>
    public class Minor7thValue : ChordBaseValue
    {
        /// <summary>
        /// 短七和音　値オブジェクト　コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        /// <remarks>
        /// ルート・短三度・完全五度・短七度
        /// </remarks>
        public Minor7thValue(Tone root) : base(root, Pitch.Minor, Pitch.Perfect, Pitch.Minor)
        {
            Root = root;
        }
    }
}
