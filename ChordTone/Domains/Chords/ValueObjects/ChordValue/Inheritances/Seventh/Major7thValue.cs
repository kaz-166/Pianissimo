using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritances.Seventh
{
    /// <summary>
    /// 長七和音　値オブジェクト
    /// </summary>
    public class Major7thValue : ChordBaseValue
    {
        /// <summary>
        /// 長七和音　値オブジェクト　コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        /// <remarks>
        /// ルート・長三度・完全五度・長七度
        /// </remarks>
        public Major7thValue(Tone root) : base(root, Pitch.Major, Pitch.Perfect, Pitch.Major)
        {
            Root = root;
        }
    }
}
