using ChordTone.Enums;

namespace ChordTone.DTOs
{
    /// <summary>
    /// マイナーセブンスDTOクラス
    /// </summary>
    public class Minor7thDto : ChordBaseDto
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public Minor7thDto(Tone root) : base(root, Pitch.Minor, Pitch.Perfect, Pitch.Minor)
        {
            Root = root;
        }
    }
}
