using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritances
{
    /// <summary>
    /// テンションコード(9)　値オブジェクト
    /// </summary>
    public class Dominant9thValue : ChordBaseValue
    {
        /// <summary>
        /// テンションコード(9)　値オブジェクト　コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        /// /// <remarks>
        /// ルート・長三度・完全五度・短七度・長九度
        /// </remarks>
        public Dominant9thValue(Tone root) : base(root, Pitch.Major, Pitch.Perfect, Pitch.Minor)
        {
            Root = root;

            // 長九度を追加する
            _tone.Add(Root.Get(14));
        }
    }
}
