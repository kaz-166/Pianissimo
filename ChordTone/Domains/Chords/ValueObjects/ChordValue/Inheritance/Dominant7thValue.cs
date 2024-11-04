using ChordTone.Domains.Chords.Enums;
using ChordTone.Domains.Chords.ValueObjects.ChordValue;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance
{
    /// <summary>
    /// ドミナント7thコードDTOクラス
    /// </summary>
    public class Dominant7thValue : ChordBaseValue
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public Dominant7thValue(Tone root) : base(root, Pitch.Major, Pitch.Perfect, Pitch.Minor)
        {
            Root = root;
        }
    }
}
