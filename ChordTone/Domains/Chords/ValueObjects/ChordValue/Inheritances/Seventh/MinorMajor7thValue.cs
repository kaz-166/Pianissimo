using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritances.Seventh
{
    /// <summary>
    /// 短長七和音　値オブジェクト
    /// </summary>
    public class MinorMajor7thValue : ChordBaseValue
    {
        /// <summary>
        /// 短長七和音　値オブジェクト　コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        /// /// <remarks>
        /// ルート・短三度・完全五度・長七度
        /// </remarks>
        public MinorMajor7thValue(Tone root) : base(root, Pitch.Minor, Pitch.Perfect, Pitch.Major)
        {
            Root = root;
        }
    }
}
