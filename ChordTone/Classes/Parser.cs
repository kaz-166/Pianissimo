using ChordTone.DTOs;
using ChordTone.Enums;

namespace ChordTone.Classes
{
    /// <summary>
    /// パーサクラス
    /// </summary>
    /// <remarks>
    /// コードネームを解析し、各構成音に対して長短増減の情報を付加したものを返す
    /// </remarks>
    public static class Parser
    {
        /// <summary>
        /// 入力されたコードネーム構文解析し、コード構成を解釈するメソッド
        /// </summary>
        /// <param name="chordName">コードネーム文字列</param>
        /// <returns>コード構成DTO</returns>
        /// <exception cref="InvalidDataException">不正な音階名が入力された場合の例外</exception>
        /// <exception cref="ArgumentException">#の臨時記号がつけることのできない音階につけられていた場合の例外</exception>
        public static ChordElementDto Parse(string chordName)
        {
            int ind = 0;

            // 1文字目：ルート音
            var root = chordName[ind..(ind + 1)] switch
            {
                "C" => Tone.C,
                "D" => Tone.D,
                "E" => Tone.E,
                "F" => Tone.F,
                "G" => Tone.G,
                "A" => Tone.A,
                "B" => Tone.B,
                _ => throw new InvalidDataException("不正な音階名が指定されています。")
            };
            ind++;

            // ２文字目：臨時記号
            if (chordName.Length >= ind + 1 && chordName[ind..(ind + 1)].Equals("#"))
            {
                // シャープの場合は半音上げる
                if (root != Tone.E && root != Tone.B)
                {
                    root = root.Get(1);
                    ind++;
                }
                else
                {
                    throw new InvalidDataException("その音階には#の臨時記号をつけることはできません。");
                }

            }
            // TODO: ♭の処理

            ChordElementDto chordElement;
            if (chordName.Length < ind + 1)
            {
                chordElement = new ChordElementDto(root, Pitch.Major, Pitch.Perfect, Pitch.Omit);
            }
            else if (ChordNameMatcher(chordName, "m", ind))
            {
                chordElement = new ChordElementDto(root, Pitch.Minor, Pitch.Perfect, Pitch.Omit);
            }
            else if (ChordNameMatcher(chordName, "7", ind))
            {
                chordElement = new ChordElementDto(root, Pitch.Major, Pitch.Perfect, Pitch.Minor);
            }
            else if (ChordNameMatcher(chordName, "m7", ind))
            {
                chordElement = new ChordElementDto(root, Pitch.Minor, Pitch.Perfect, Pitch.Minor);
            }
            else if (ChordNameMatcher(chordName, "M7", ind))
            {
                chordElement = new ChordElementDto(root, Pitch.Major, Pitch.Perfect, Pitch.Major);
            }
            else if (ChordNameMatcher(chordName, "Maj7", ind))
            {
                chordElement = new ChordElementDto(root, Pitch.Major, Pitch.Perfect, Pitch.Major);
            }
            else if (ChordNameMatcher(chordName, "△7", ind))
            {
                chordElement = new ChordElementDto(root, Pitch.Major, Pitch.Perfect, Pitch.Major);
            }
            else if (ChordNameMatcher(chordName, "mM7", ind))
            {
                chordElement = new ChordElementDto(root, Pitch.Minor, Pitch.Perfect, Pitch.Major);
            }
            else if (ChordNameMatcher(chordName, "m5-7", ind))
            {
                chordElement = new ChordElementDto(root, Pitch.Minor, Pitch.Diminished, Pitch.Minor);
            }
            else if (ChordNameMatcher(chordName, "m5b7", ind))
            {
                chordElement = new ChordElementDto(root, Pitch.Minor, Pitch.Diminished, Pitch.Minor);
            }
            else if (ChordNameMatcher(chordName, "dim", ind))
            {
                chordElement = new ChordElementDto(root, Pitch.Minor, Pitch.Diminished, Pitch.Diminished);
            }
            else
            {
                throw new ArgumentException("構文エラーです。");
            }

            return chordElement;
        }

        /// <summary>
        /// 対象の文字列のマッチするか検査します
        /// </summary>
        /// <param name="chordName">入力文字列</param>
        /// <param name="CompareName">検査対象文字列</param>
        /// <param name="index">インデックスう</param>
        /// <returns>合致していればTrueしていなければ、False<returns>

        private static bool ChordNameMatcher(string chordName, string CompareName, int index)
        =>
            chordName.Length == index + CompareName.Length && chordName[index..(index + CompareName.Length)].Equals(CompareName);
    }
}
