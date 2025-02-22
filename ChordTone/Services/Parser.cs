using ChordTone.Domains.Chords.Consts;
using ChordTone.Domains.Chords.Enums;
using ChordTone.Domains.Chords.ValueObjects.ChordValue;
using ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritances.Seventh;
using ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritances.Tension;
using ChordTone.Domains.Chords.ValueObjects.ChordValue.Inheritances.Triad;

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
            if (chordName.Length >= ind + 1 && chordName[ind..(ind + 1)].Equals("#"))
            {
                // #の場合は半音上げる
                if (root != Tone.E && root != Tone.B)
                {
                    root = root.Get(1);
                    ind++;
                }
                else
                {
                    /// EとBの音は半音上の音がすでにスケール上に存在するため
                    /// #の臨時記号を付加することができない。
                    throw new InvalidDataException($"{root}には#の臨時記号をつけることはできません。");
                }

            } 
            else if (chordName.Length >= ind + 1 && chordName[ind..(ind + 1)].Equals("b"))
            {
                // ♭の場合は半音下げる
                if (root != Tone.F && root != Tone.C)
                {
                    root = root.Get(-1);
                    ind++;
                }
                else
                {   /// CとFの音は半音下の音がすでにスケール上に存在するため
                    /// bの臨時記号を付加することができない。
                    throw new InvalidDataException($"{root}にはbの臨時記号をつけることはできません。");
                }
            }
            #endregion

            // コードシンボルの解析を行う
            return ParceChordSymbol(ind, chordName, root);
        }

        /// <summary>
        /// コードシンボルを解析します
        /// </summary>
        /// <param name="ind">インデックス</param>
        /// <param name="chordName">コードネームparam>
        /// <param name="root">ルート音</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private static ChordBaseValue ParceChordSymbol(int ind, string chordName, Tone root) 
        {
            /// コードの生成規則は、バッカス＝ナウア記法に則ると下記のように表せる。
            /// 
            /// コードネーム文字列を<ChordName>とする。
            /// <ChordName> := <Root><Attributes>
            /// <Root> := C|D|E|F|G|A|B [#|b]
            /// <Attributes> := [m|m7|7|M7|mM7|maj7|△7|aug|dim|m7-5|m7b5|sus4]
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
            else if (ChordNameMatcher(chordName, ChordAttributes.AUGMENTED, ind))
            {
                chordElement = new AugmentValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.SUSPENDED_4TH, ind))
            {
                chordElement = new Suspended4thValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.DOMINANT_9TH, ind))
            {
                chordElement = new Dominant9thValue(root);
            }
            else if (ChordNameMatcher(chordName, ChordAttributes.DOMINANT_9TH_ALTER1, ind))
            {
                chordElement = new Dominant9thValue(root);
            }
            else
            {
                throw new ArgumentException("不正なコードのため解析できませんでした。");
            }

            return chordElement;
        }

        /// <summary>
        /// 対象の文字列とマッチするか検査します
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