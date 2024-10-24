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
        /// ３度
        /// </summary>
        public Pitch Third { get; }

        /// <summary>
        /// ５度
        /// </summary>
        public Pitch Fifth { get; }

        /// <summary>
        /// ７度
        /// </summary>
        public  Pitch Seventh { get; }

        public Instractor(Tone root, Pitch third, Pitch fifth, Pitch seventh)
        {
            Root = root;
            Third = third;
            Fifth = fifth;
            Seventh = seventh;
        }
    }

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
