using ChordTone.Domains.Chords.Consts;
using ChordTone.Domains.Chords.Enums;
using ChordTone.Domains.Chords.ValueObjects.ChordValue;
using ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritance;

namespace ChordTone.Services
{
    /// <summary>
    /// パーササービス
    /// </summary>
    /// <remarks>
    /// コードネームを解析するサービスを提供する
    /// </remarks>
    public static class Parser
    {
        /// <summary>
        /// 入力されたコードネーム構文解析し、コード構成を解釈する
        /// </summary>
        /// <param name="chordName">コードネーム文字列</param>
        /// <returns>和音値オブジェクト</returns>
        /// <exception cref="InvalidDataException">不正な音階名が入力された場合の例外</exception>
        /// <exception cref="ArgumentException">#の臨時記号がつけることのできない音階につけられていた場合の例外</exception>
        public static ChordBaseValue Parse(string chordName)
        {
            int ind = 0;
            #region Phase1 ルート音の解析
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
                _ => throw new InvalidDataException($"{chordName[ind..(ind + 1)]}は音階名に存在しません。")
            };
            ind++;
            #endregion
            #region Phase2 臨時記号の解析
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
                    throw new InvalidDataException($"{root}には#の臨時記号をつけることはできません。");
                }

            } else if (chordName.Length >= ind + 1 && chordName[ind..(ind + 1)].Equals("b"))
                {
                // ♭の場合は半音下げる
                if (root != Tone.F && root != Tone.C)
                {
                    root = root.Get(-1);
                    ind++;
                }
                else
                {
                    throw new InvalidDataException($"{root}にはbの臨時記号をつけることはできません。");
                }
            }
            #endregion
            #region Phase3 付加情報の解析
            /// コードの生成規則は、バッカス＝ナウア記法に則ると下記のように表せる。
            /// 
            /// コードネーム文字列を<ChordName>とする。
            /// <ChordName> := <Root><Attributes>
            /// <Root> := C|D|E|F|G|A|B [#|b]
            /// <Attributes> := [m|M|mM|Maj|△|aug|dim|7|b5|-5]
            /// 
            ChordBaseValue chordElement;
            if (chordName.Length < ind + 1)
            {
                chordElement = new MajorTriadValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.MINOR_TRIAD, ind))
            {
                chordElement = new MinorTriadValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.DOMINANT_7TH, ind))
            {
                chordElement = new Dominant7thValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.MINOR_7TH, ind))
            {
                chordElement = new Minor7thValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.MAJOR_7TH, ind))
            {
                chordElement = new Major7thValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.MAJOR_7TH_ALTER1, ind))
            {
                chordElement = new Major7thValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.MAJOR_7TH_ALTER2, ind))
            {
                chordElement = new Major7thValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.MINOR_MAJOR_7TH, ind))
            {
                chordElement = new MinorMajor7thValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.MINOR_7TH_FLATTED_5, ind))
            {
                chordElement = new HalfDiminishValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.MINOR_7TH_FLATTED_5_ALTER1, ind))
            {
                chordElement = new HalfDiminishValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.DIMINISHED, ind))
            {
                chordElement = new DiminishValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.AUGMENTED_CHORD, ind))
            {
                chordElement = new AugmentValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.SUSPENDED_4TH, ind))
            {
                chordElement = new Suspended4thValue(root);
            }
            else
            {
                throw new ArgumentException("不正なコードのため解析できませんでした。");
            }
            #endregion
            return chordElement;
        }

        /// <summary>
        /// 対象の文字列のマッチするか検査します
        /// </summary>
        /// <param name="chordName">入力文字列</param>
        /// <param name="CompareName">検査対象文字列</param>
        /// <param name="index">インデックス</param>
        /// <returns>合致していればTrueしていなければ、False<returns>

        private static bool ChordNameMatcher(string chordName, string CompareName, int index)
        =>
            chordName.Length == index + CompareName.Length && chordName[index..(index + CompareName.Length)].Equals(CompareName);
    }
}
