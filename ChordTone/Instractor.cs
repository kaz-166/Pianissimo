namespace ChordTone
{
    /// <summary>
    /// コード生成指示クラス
    /// </summary>
    public class Instractor
    {
        /// <summary>
        /// ルート音
        /// </summary>
        public Tone Root { get; }

        /// <summary>
        /// ３度音程
        /// </summary>
        public Pitch Third { get; }

        /// <summary>
        /// ５度音程
        /// </summary>
        public Pitch Fifth { get; }

        /// <summary>
        /// ７度音程
        /// </summary>
        public  Pitch Seventh { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="root">ルート音</param>
        /// <param name="third">三度音程</param>
        /// <param name="fifth">五度音程</param>
        /// <param name="seventh">七度音程</param>
        public Instractor(Tone root, Pitch third, Pitch fifth, Pitch seventh)
        {
            Root = root;
            Third = third;
            Fifth = fifth;
            Seventh = seventh;
        }
    }

    /// <summary>
    /// 音程
    /// </summary>
    public enum Pitch 
    {
        Omit,       // 除外
        Major,      // 長音程
        Minor,      // 短音程
        Parfect,    // 完全音程
        Diminished, // 減音程
        Augmented   // 増音程
    }
}
