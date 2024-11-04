namespace ChordTone.Domains.Chords.Enums
{
    /// <summary>
    /// 音程の長短増減指示 列挙型
    /// </summary>
    public enum Pitch
    {
        Omit,       // 除外
        Major,      // 長音程
        Minor,      // 短音程
        Perfect,    // 完全音程
        Diminished, // 減音程
        Augmented   // 増音程       
    }
}
