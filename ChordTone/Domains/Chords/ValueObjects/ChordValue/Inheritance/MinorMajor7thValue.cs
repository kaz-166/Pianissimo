using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
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
        public MinorMajor7thValue(Tone root) : base(root, Pitch.Minor, Pitch.Perfect, Pitch.Major)
        {
            Root = root;
        }
    }
}
