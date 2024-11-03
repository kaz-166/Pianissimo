using ChordTone.Enums;

namespace ChordTone.DTOs
{
    /// <summary>
    /// ドミナント7thコードDTOクラス
    /// </summary>
    public class Dominant7thDto : ChordBaseDto
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        public Dominant7thDto(Tone root) : base(root, Pitch.Major, Pitch.Perfect, Pitch.Minor)
        {
            Root = root;
        }
    }
}
