using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
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
        public Major7thValue(Tone root) : base(root, Pitch.Major, Pitch.Perfect, Pitch.Major)
        {
            Root = root;
        }
    }
}
