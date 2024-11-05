using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// 短三和音 値オブジェクト
    /// </summary>
    public class MinorTriadValue : ChordBaseValue
    {
        /// <summary>
        /// 短三和音　値オブジェクト　コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        /// /// <remarks>
        /// ルート・短三度・完全五度
        /// </remarks>
        public MinorTriadValue(Tone root) : base(root, Pitch.Minor, Pitch.Perfect, Pitch.Omit)
        {
            Root = root;
        }
    }
}
