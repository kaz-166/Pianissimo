using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// メジャーセブンスDTOクラス
    /// </summary>
    public class Major7thValue : ChordBaseValue
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public Major7thValue(Tone root) : base(root, Pitch.Major, Pitch.Perfect, Pitch.Major)
        {
            Root = root;
        }
    }
}
