using ChordTone.Enums;

namespace ChordTone.DTOs
{
    /// <summary>
    /// マイナースケールDTOクラス
    /// </summary>
    public class MinorTriadDto : ChordBaseDto
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public MinorTriadDto(Tone root) : base(root, Pitch.Minor, Pitch.Perfect, Pitch.Omit)
        {
            Root = root;
        }
    }
}
