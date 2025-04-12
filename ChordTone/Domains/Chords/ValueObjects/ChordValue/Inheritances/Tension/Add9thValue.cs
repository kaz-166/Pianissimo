using ChordTone.Domains.Chords.Enums;

namespace ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritances.Tension
{
    public class Add9thValue : ChordBaseValue
    {
        /// <summary>
        /// アドナインスコード 値オブジェクト コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        /// /// <remarks>
        /// ルート・長三度・完全五度・長九度
        /// </remarks>
        public Add9thValue(Tone root) : base(root, Pitch.Major, Pitch.Perfect, Pitch.Omit)
        {
            Root = root;

            // 長九度を追加する
            _tone.Add(Root.Get(14));
        }
    }
}
