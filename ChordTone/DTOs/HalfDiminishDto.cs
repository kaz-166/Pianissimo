using ChordTone.Enums;

namespace ChordTone.DTOs
{
    /// <summary>
    /// マイナーセブンスフラットファイブDTOクラス
    /// </summary>
    public class HalfDiminishDto : ChordBaseDto
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public HalfDiminishDto(Tone root) : base(root, Pitch.Minor, Pitch.Diminished, Pitch.Minor)
        {
            Root = root;
        }
    }
}
