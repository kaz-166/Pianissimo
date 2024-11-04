namespace ChordTone.Domains.Chords.Enums
{
    /// <summary>
    /// 音程の長短増減指示 列挙型
    /// </summary>
    public enum Pitch
    {
        /// <summary>
        /// 除外
        /// </summary>
        Omit,

        /// <summary>
        /// 長音程
        /// </summary>
        Major,

        /// <summary>
        /// 短音程
        /// </summary>
        Minor,

        /// <summary>
        /// 完全音程
        /// </summary>
        Perfect,

        /// <summary>
        /// 減音程
        /// </summary>
        Diminished,

        /// <summary>
        /// 増音程
        /// </summary>
        Augmented      
    }
}
