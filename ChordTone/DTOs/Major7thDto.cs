using ChordTone.Enums;

namespace ChordTone.DTOs
{
    /// <summary>
    /// メジャーセブンスDTOクラス
    /// </summary>
    public class Major7thDto : ChordBaseDto
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public Major7thDto(Tone root) : base (root, Pitch.Major, Pitch.Perfect, Pitch.Major)
        {
            Root = root;   
        }
    }
}
