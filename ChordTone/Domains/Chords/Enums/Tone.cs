﻿using System.ComponentModel;

namespace ChordTone.Domains.Chords.Enums
{
    /// <summary>
    /// 音階の列挙型
    /// </summary>
    public enum Tone
    {
        C,
        CSharp,
        D,
        DSharp,
        E,
        F,
        FSharp,
        G,
        GSharp,
        A,
        ASharp,
        B,
        HiC
    }

    /// <summary>
    /// Tone列挙型拡張メソッド用静的クラス
    /// </summary>
    public static class ToneEnum
    {
        /// <summary>
        /// 指定の度数差の音階を取得する拡張メソッド
        /// </summary>
        /// <param name="tone">this</param>
        /// <param name="interval">度数</param>
        /// <returns>指定された度数上(または下)の音階</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <summary>
        /// 指定の度数差の音階を取得する拡張メソッド
        /// </summary>
        /// <param name="tone">基準となる音階</param>
        /// <param name="interval">度数</param>
        /// <returns>指定された度数上(または下)の音階</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static Tone Get(this Tone tone, int interval)
        {
            var min = Tone.C + 1;
            var max = Tone.HiC;

            var ret = tone + interval;

            // 1オクターブ内で循環させる
            var octaveRange = max - min + 1;
            ret = ((ret - min) % octaveRange + octaveRange) % octaveRange + min;

            return ret;
        }

        /// <summary>
        /// 列挙型を楽譜記号に変換する拡張メソッド
        /// </summary>
        /// <param name="tone">this</param>
        /// <returns>楽譜記号</returns>
        /// <exception cref="InvalidEnumArgumentException">不正な列挙型の例外</exception>
        public static string GetString(this Tone tone)
            => tone switch
            {
                Tone.C => "C",
                Tone.CSharp => "C#",
                Tone.D => "D",
                Tone.DSharp => "D#",
                Tone.E => "E",
                Tone.F => "F",
                Tone.FSharp => "F#",
                Tone.G => "G",
                Tone.GSharp => "G#",
                Tone.A => "A",
                Tone.ASharp => "A#",
                Tone.B => "B",
                Tone.HiC => "C",
                _ => throw new InvalidEnumArgumentException()
            };
    }
}
