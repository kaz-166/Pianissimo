using ChordTone.Enums;

namespace ChordTone.DTOs
{
    /// <summary>
    /// 構成音の長短増減情報を格納するData Transfer Object基底クラス
    /// </summary>
    /// <param name="root">ルート音</param>
    /// <param name="third">三度音程</param>
    /// <param name="fifth">五度音程</param>
    /// <param name="seventh">七度音程</param>
    public class ChordBaseDto(Tone root, Pitch third, Pitch fifth, Pitch seventh)
    {
        /// <summary>
        /// ルート音
        /// </summary>
        public Tone Root { get; protected set; } = root;

        /// <summary>
        /// ３度音程
        /// </summary>
        public Pitch Third { get; protected set; } = third;

        /// <summary>
        /// ５度音程
        /// </summary>
        public Pitch Fifth { get; protected set; } = fifth;

        /// <summary>
        /// ７度音程
        /// </summary>
        public Pitch Seventh { get; protected set; } = seventh;
    }
}
