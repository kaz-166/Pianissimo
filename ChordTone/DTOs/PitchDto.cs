using ChordTone.Classes;
using ChordTone.Enums;

namespace ChordTone.DTOs
{
    /// <summary>
    /// 構成音の長短増減指示情報を格納するData Transfer Object
    /// </summary>
    /// <param name="root">ルート音</param>
    /// <param name="third">三度音程</param>
    /// <param name="fifth">五度音程</param>
    /// <param name="seventh">七度音程</param>
    public class PitchDto(Tone root, Pitch third, Pitch fifth, Pitch seventh)
    {
        /// <summary>
        /// ルート音
        /// </summary>
        public Tone Root { get; } = root;

        /// <summary>
        /// ３度音程
        /// </summary>
        public Pitch Third { get; } = third;

        /// <summary>
        /// ５度音程
        /// </summary>
        public Pitch Fifth { get; } = fifth;

        /// <summary>
        /// ７度音程
        /// </summary>
        public Pitch Seventh { get; } = seventh;
    }
}
