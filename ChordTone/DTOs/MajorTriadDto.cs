using ChordTone.Enums;

namespace ChordTone.DTOs
{
    /// <summary>
    /// メジャースケールDTOクラス
    /// </summary>
    public class MajorTriadDto : ChordBaseDto
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public MajorTriadDto(Tone root) : base(root, Pitch.Major, Pitch.Perfect, Pitch.Omit)
        {
            Root = root;
        }
    }
}
