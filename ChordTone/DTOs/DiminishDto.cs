using ChordTone.Enums;

namespace ChordTone.DTOs
{
    /// <summary>
    /// DiminishコードDTOクラス
    /// </summary>
    public class DiminishDto : ChordBaseDto
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public DiminishDto(Tone root) : base (root, Pitch.Minor, Pitch.Diminished, Pitch.Diminished)
        {
            Root = root;
        }
    }
}
