using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// 長三和音　値オブジェクト
    /// </summary>
    public class MajorTriadValue : ChordBaseValue
    {
        /// <summary>
        /// 長三和音　値オブジェクト　コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        /// <remarks>
        /// ルート・長三度・完全五度
        /// </remarks>
        public MajorTriadValue(Tone root) : base(root, Pitch.Major, Pitch.Perfect, Pitch.Omit)
        {
            Root = root;
        }
    }
}
