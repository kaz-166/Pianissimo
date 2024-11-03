using ChordTone.Enums;

namespace ChordTone.DTOs
{
    /// <summary>
    /// マイナーメジャーセブンスコードDTOクラス
    /// </summary>
    public class MinorMajor7thDto : ChordBaseDto
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public MinorMajor7thDto(Tone root) : base (root, Pitch.Minor, Pitch.Perfect, Pitch.Major) 
        {
            Root = root;
        }
    }
}
